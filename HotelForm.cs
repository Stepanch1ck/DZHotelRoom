using Microsoft.EntityFrameworkCore;
using System.Data;
using NLog;
using DZHotelRoom.DBconnect;

namespace DZHotelRoom
{
    public partial class HotelForm : Form
    {
        HotelRoomContext db = new HotelRoomContext();
        public int? idRoom = null;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public HotelForm()
        {
            InitializeComponent();
            LoadAllRoomsIntoDataGridView();
            Logger.Info("HotelForm конструктор вызван.");
        }
        public HotelForm(HotelRoomContext context)
        {
            db = context;
            InitializeComponent();
            LoadAllRoomsIntoDataGridView();
            Logger.Info("HotelForm конструктор вызван.");
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            Logger.Trace("Timer_Tick событие сработало.");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchBox.Text = string.Empty;
            Logger.Debug("Search button была нажата.");
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            string searchName = SearchBox.Text.Trim();
            Logger.Debug("SearchButton_Click событие сработало.");

            if (!string.IsNullOrEmpty(searchName))
            {
                string[] nameParts = searchName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var filteredRooms = db.Rooms
                    .Where(r => r.PersonNavigation != null &&
                                 (
                                     r.PersonNavigation.FirstName.Contains(nameParts[0]) ||
                                     r.PersonNavigation.LastName.Contains(nameParts[0]) ||
                                     r.PersonNavigation.Surname.Contains(nameParts[0])
                                )
                             );
                for (int i = 2; i < nameParts.Length; i++)
                {
                    filteredRooms = filteredRooms.Where(r =>
                        r.PersonNavigation.FirstName.Contains(nameParts[i]) ||
                        r.PersonNavigation.LastName.Contains(nameParts[i]) ||
                        r.PersonNavigation.Surname.Contains(nameParts[i]));
                }

                MainDataGridView.DataSource = filteredRooms.ToList();
                MainDataGridView.Refresh();
            }
            else
            {
                LoadAllRoomsIntoDataGridView();
            }
        }

        private void FilterAndDisplayRooms(string status)
        {
            var filteredRooms = db.Rooms.Where(r => r.Status == status).ToList();
            MainDataGridView.DataSource = filteredRooms;
            MainDataGridView.Refresh();
            Logger.Debug($"Отфильтрованы и выведены в таблицу комнаты со статусом: {status}");
            if (filteredRooms.Count == 0)
            {
                Logger.Warn($"Не найдено комнат со статусом: '{status}'.");
            }

        }
        private void LoadRoomsIntoDataGridView()
        {
            Logger.Debug("Загрузка комнат в DataGridView.");
            var rooms = db.Rooms.ToList();
                         
            MainDataGridView.DataSource = rooms;
            Logger.Trace("Получение данных о комнате из базы данных.");
            MainDataGridView.Refresh();
            

        }
        private void LoadAllRoomsIntoDataGridView()
        {

            var allRooms = db.Rooms.ToList();

            MainDataGridView.DataSource = allRooms;
            MainDataGridView.Refresh();
            Logger.Debug("Загрузка всех комнат в DataGridView.");

        }

        private void FillRooms()
        {
            Logger.Debug("Заполнение комнат по дате прибытия и выезда.");
            var availableRooms = db.Rooms.Where(r => r.Person == null).ToList();
            var arrivingPeople = db.People.AsEnumerable()
    .Where(p => p.ArrivalDate.ToDateTime(TimeOnly.MinValue) <= DateTime.Today)
    .Select(p => new { p.IdPerson, p.ArrivalDate, p.ReleaseDate }).ToList();
            foreach (var person in arrivingPeople)
            {
                if (db.Rooms.Any(r => r.Person == person.IdPerson))
                {
                    continue;
                }
                var availableRoom = availableRooms.FirstOrDefault();
                if (availableRoom != null)
                {
                    availableRoom.Person = person.IdPerson;
                    if (person.ArrivalDate.ToDateTime(TimeOnly.MinValue) == DateTime.Today)
                    {
                        availableRoom.Status = "зарезервировано";
                    }
                    else if (person.ArrivalDate.ToDateTime(TimeOnly.MinValue) < DateTime.Today &&
                             person.ReleaseDate.ToDateTime(TimeOnly.MinValue) > DateTime.Today)
                    {
                        availableRoom.Status = "занято";
                    }
                    else if (person.ReleaseDate.ToDateTime(TimeOnly.MinValue) == DateTime.Today)
                    {
                        availableRoom.Status = "выписываются";
                    }
                    else
                    {
                        availableRoom.Status = "свободно";
                    }

                }
                else
                {
                    continue;
                }
                availableRooms.Remove(availableRoom);
            }
            var filledRoomsCount = db.Rooms.Count(r => r.Person != null);
            Logger.Info($"Заполнено {filledRoomsCount} комнат прибывшими гостями.");
            db.SaveChanges();
            MainDataGridView.Refresh();
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {
            db.Database.EnsureCreated();
            FillRooms();
            LoadRoomsIntoDataGridView();
            Timer.Start();
            Logger.Info("HotelForm_Load событие вызвано.");
            if (!db.Database.CanConnect())
            {
                Logger.Warn("Не удалось установить соединения с базой данных.");
            }
            if (!System.IO.File.Exists("HotelRoom.db"))
            {
                Logger.Fatal("Файл базы данных не найден. Приложение будет закрыто.");
                
            }
        }

        private void ReservedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ReservedRadioButton.Checked)
            {
                Logger.Debug("ReservedRadioButton нажата. Отфильтровано по зарезервированным комнатам.");
                FilterAndDisplayRooms("зарезервировано");
            }
        }

        private void FreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FreeRadioButton.Checked)
            {
                Logger.Debug("FreeRadioButton нажата. Отфильтровано по свободным комнатам.");
                FilterAndDisplayRooms("свободно");
            }
        }

        private void OccupiedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OccupiedRadioButton.Checked)
            {
                Logger.Debug("OccupiedRadioButton нажата. Отфильтровано по занятым комнатам.");
                FilterAndDisplayRooms("занято");
            }
        }

        private void CheckoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckoutRadioButton.Checked)
            {
                Logger.Debug("CheckoutRadioButton нажата. Отфильтровано по освобождающимся комнатам.");
                FilterAndDisplayRooms("выписываются");
            }
        }

        private void MainDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Logger.Debug("По DataGridView выполнено двойное нажатие. Получение информации о комнате.");
                idRoom = (int)MainDataGridView.Rows[e.RowIndex].Cells["IdRoom"].Value;
                var selectedRoom = db.Rooms.Include(r => r.PersonNavigation).FirstOrDefault(r => r.IdRoom == idRoom);
                if (idRoom == null)
                {
                    Logger.Error("Нет ID комнаты. Невозможно отправить информацию.");
                }
                if (selectedRoom != null)
                {
                    Logger.Trace($"Выбрана комната под ID: {idRoom}");
                    NumberLabel.Text = idRoom.ToString();
                    string fullName = $"{selectedRoom.PersonNavigation?.LastName} {selectedRoom.PersonNavigation?.FirstName} {selectedRoom.PersonNavigation?.Surname}";
                    StatusPersonLabel.Text = selectedRoom.Status;
                    FIOPersonLabel.Text = fullName;
                    if (selectedRoom.PersonNavigation?.Avatar != null)
                    {
                        using (var ms = new MemoryStream(selectedRoom.PersonNavigation.Avatar))
                        {
                            PhotoBox.Image = Image.FromStream(ms);
                        }
                    }

                    ArrivalPersonLabel.Text = selectedRoom.PersonNavigation?.ArrivalDate.ToString("yyyy-MM-dd");
                    ReleasePersonLabel.Text = selectedRoom.PersonNavigation?.ReleaseDate.ToString("yyyy-MM-dd");
                }
            }
        }

        private void HotelForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            var rooms = db.Rooms.ToList();
            foreach (var room in rooms)
            {
                room.Status = "свободно";
                room.Person = null;
            }
            db.SaveChanges();
            Logger.Info("HotelForm закрывается.");
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Logger.Info("ViewButton нажата.");
            if (idRoom== null)
            {
                MessageBox.Show("Выберите комнату и повторите попытку");
                Logger.Debug("ViewForm не открыта.");
            }
            else
            {
                var viewform = new ViewForm(idRoom);
                viewform.Show();
                Logger.Debug("ViewForm открыта.");
            }
            
        }
    }
}
