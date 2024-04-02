using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZHotelRoom
{
    public partial class ViewForm : Form
    {
        HotelRoomContext db = new HotelRoomContext();
        public int? idroom = null;
        public ViewForm(int? idroom)
        {
            InitializeComponent();
            this.idroom = idroom;
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            db.Database.EnsureCreated();
            var selectedRoom = db.Rooms.Include(r => r.PersonNavigation).FirstOrDefault(r => r.IdRoom == idroom);
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

        private void QuantityNumberDayPlusButton_Click(object sender, EventArgs e)
        {
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
