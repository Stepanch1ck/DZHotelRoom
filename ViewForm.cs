using DZHotelRoom.DBconnect;
using Microsoft.EntityFrameworkCore;
using NLog;
using System.Globalization;

namespace DZHotelRoom
{
    public partial class ViewForm : Form
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();
        HotelRoomContext db = new HotelRoomContext();
        public int? idroom = null;
        public ViewForm(int? idroom)
        {
            InitializeComponent();
            this.idroom = idroom;
            Logger.Info("ViewForm constructor called with room ID: {0}", idroom);
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            Logger.Debug("ViewForm_Load событие вызвано.");
            db.Database.EnsureCreated();
            try
            {
                var selectedRoom = db.Rooms.Include(r => r.PersonNavigation).FirstOrDefault(r => r.IdRoom == idroom);

                if (selectedRoom == null)
                {
                    Logger.Error("Комната с Id {0} не найдена.", idroom);
                    MessageBox.Show("Комната не найдена.");
                    this.Close();
                    Logger.Debug("Выбрана свободная комната. ViewForm закрыта.");
                }
                
                if (selectedRoom.PersonNavigation == null)
                {
                    MessageBox.Show("Выбрана пустая комната");
                    this.Close();
                }
                else {
                    string fullName = $"{selectedRoom.PersonNavigation?.LastName} {selectedRoom.PersonNavigation?.FirstName} {selectedRoom.PersonNavigation?.Surname}";
                    FIOPersonLabelData.Text = fullName;
                    BirthdayLabelData.Text = selectedRoom.PersonNavigation?.Birthday.ToString("yyyy-MM-dd");
                    PaymentMetodComboBox.Text = selectedRoom.PersonNavigation?.PaymentMetod;

                    DateTime arrivalDate = DateTime.ParseExact(selectedRoom.PersonNavigation.ArrivalDate.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    DateTime releaseDate = DateTime.ParseExact(selectedRoom.PersonNavigation.ReleaseDate.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    TimeSpan stayDuration = releaseDate - arrivalDate;
                    QuantityNumberDayLabel.Text = stayDuration.Days.ToString();
                    AnimalCheckBox.Checked = selectedRoom.PersonNavigation.Animal;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Произошла ошибка при загрузке сведений.");
                MessageBox.Show("Призошла ошибка при загрузке данных.");
            }
        }

        private void QuantityNumberDayPlusButton_Click(object sender, EventArgs e)
        {
            Logger.Debug("QuantityNumberDayPlusButton нажата.");
            var selectedRoom = db.Rooms.Include(r => r.PersonNavigation).FirstOrDefault(r => r.IdRoom == idroom);

            DateTime releaseDate = DateTime.ParseExact(selectedRoom.PersonNavigation.ReleaseDate.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            
            releaseDate = releaseDate.AddDays(1);
            selectedRoom.PersonNavigation.ReleaseDate = DateOnly.FromDateTime(releaseDate);
            db.SaveChanges();
            DateTime arrivalDate = DateTime.ParseExact(selectedRoom.PersonNavigation.ArrivalDate.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            TimeSpan stayDuration = releaseDate - arrivalDate;
            QuantityNumberDayLabel.Text = stayDuration.Days.ToString();
        }

        private void QuantityNumberDayMinusButton_Click(object sender, EventArgs e)
        {
            Logger.Debug("QuantityNumberDayMinusButton нажата.");
            var selectedRoom = db.Rooms.Include(r => r.PersonNavigation).FirstOrDefault(r => r.IdRoom == idroom);

            DateTime releaseDate = DateTime.ParseExact(selectedRoom.PersonNavigation.ReleaseDate.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);

            releaseDate = releaseDate.AddDays(-1);
            selectedRoom.PersonNavigation.ReleaseDate = DateOnly.FromDateTime(releaseDate);
            db.SaveChanges();
            DateTime arrivalDate = DateTime.ParseExact(selectedRoom.PersonNavigation.ArrivalDate.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            TimeSpan stayDuration = releaseDate - arrivalDate;
            
            QuantityNumberDayLabel.Text = stayDuration.Days.ToString();
        }
    }
}
