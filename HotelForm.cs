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
            Logger.Info("HotelForm ����������� ������.");
        }
        public HotelForm(HotelRoomContext context)
        {
            db = context;
            InitializeComponent();
            LoadAllRoomsIntoDataGridView();
            Logger.Info("HotelForm ����������� ������.");
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            Logger.Trace("Timer_Tick ������� ���������.");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchBox.Text = string.Empty;
            Logger.Debug("Search button ���� ������.");
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            string searchName = SearchBox.Text.Trim();
            Logger.Debug("SearchButton_Click ������� ���������.");

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
            Logger.Debug($"������������� � �������� � ������� ������� �� ��������: {status}");
            if (filteredRooms.Count == 0)
            {
                Logger.Warn($"�� ������� ������ �� ��������: '{status}'.");
            }

        }
        private void LoadRoomsIntoDataGridView()
        {
            Logger.Debug("�������� ������ � DataGridView.");
            var rooms = db.Rooms.ToList();
                         
            MainDataGridView.DataSource = rooms;
            Logger.Trace("��������� ������ � ������� �� ���� ������.");
            MainDataGridView.Refresh();
            

        }
        private void LoadAllRoomsIntoDataGridView()
        {

            var allRooms = db.Rooms.ToList();

            MainDataGridView.DataSource = allRooms;
            MainDataGridView.Refresh();
            Logger.Debug("�������� ���� ������ � DataGridView.");

        }

        private void FillRooms()
        {
            Logger.Debug("���������� ������ �� ���� �������� � ������.");
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
                        availableRoom.Status = "���������������";
                    }
                    else if (person.ArrivalDate.ToDateTime(TimeOnly.MinValue) < DateTime.Today &&
                             person.ReleaseDate.ToDateTime(TimeOnly.MinValue) > DateTime.Today)
                    {
                        availableRoom.Status = "������";
                    }
                    else if (person.ReleaseDate.ToDateTime(TimeOnly.MinValue) == DateTime.Today)
                    {
                        availableRoom.Status = "������������";
                    }
                    else
                    {
                        availableRoom.Status = "��������";
                    }

                }
                else
                {
                    continue;
                }
                availableRooms.Remove(availableRoom);
            }
            var filledRoomsCount = db.Rooms.Count(r => r.Person != null);
            Logger.Info($"��������� {filledRoomsCount} ������ ���������� �������.");
            db.SaveChanges();
            MainDataGridView.Refresh();
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {
            db.Database.EnsureCreated();
            FillRooms();
            LoadRoomsIntoDataGridView();
            Timer.Start();
            Logger.Info("HotelForm_Load ������� �������.");
            if (!db.Database.CanConnect())
            {
                Logger.Warn("�� ������� ���������� ���������� � ����� ������.");
            }
            if (!System.IO.File.Exists("HotelRoom.db"))
            {
                Logger.Fatal("���� ���� ������ �� ������. ���������� ����� �������.");
                
            }
        }

        private void ReservedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ReservedRadioButton.Checked)
            {
                Logger.Debug("ReservedRadioButton ������. ������������� �� ����������������� ��������.");
                FilterAndDisplayRooms("���������������");
            }
        }

        private void FreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FreeRadioButton.Checked)
            {
                Logger.Debug("FreeRadioButton ������. ������������� �� ��������� ��������.");
                FilterAndDisplayRooms("��������");
            }
        }

        private void OccupiedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OccupiedRadioButton.Checked)
            {
                Logger.Debug("OccupiedRadioButton ������. ������������� �� ������� ��������.");
                FilterAndDisplayRooms("������");
            }
        }

        private void CheckoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckoutRadioButton.Checked)
            {
                Logger.Debug("CheckoutRadioButton ������. ������������� �� ��������������� ��������.");
                FilterAndDisplayRooms("������������");
            }
        }

        private void MainDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Logger.Debug("�� DataGridView ��������� ������� �������. ��������� ���������� � �������.");
                idRoom = (int)MainDataGridView.Rows[e.RowIndex].Cells["IdRoom"].Value;
                var selectedRoom = db.Rooms.Include(r => r.PersonNavigation).FirstOrDefault(r => r.IdRoom == idRoom);
                if (idRoom == null)
                {
                    Logger.Error("��� ID �������. ���������� ��������� ����������.");
                }
                if (selectedRoom != null)
                {
                    Logger.Trace($"������� ������� ��� ID: {idRoom}");
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
                room.Status = "��������";
                room.Person = null;
            }
            db.SaveChanges();
            Logger.Info("HotelForm �����������.");
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Logger.Info("ViewButton ������.");
            if (idRoom== null)
            {
                MessageBox.Show("�������� ������� � ��������� �������");
                Logger.Debug("ViewForm �� �������.");
            }
            else
            {
                var viewform = new ViewForm(idRoom);
                viewform.Show();
                Logger.Debug("ViewForm �������.");
            }
            
        }
    }
}
