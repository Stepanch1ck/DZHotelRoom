using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace DZHotelRoom
{
    public partial class HotelForm : Form
    {
        HotelRoomContext db = new HotelRoomContext();

        public HotelForm()
        {
            InitializeComponent();
            LoadAllRoomsIntoDataGridView();


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchBox.Text = string.Empty;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchName = SearchBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchName))
            {
                string[] nameParts = searchName.Split(' ');
                string firstName = nameParts.Length > 0 ? nameParts[0] : null;
                string lastName = nameParts.Length > 1 ? nameParts[1] : null;
                string middleName = nameParts.Length > 2 ? nameParts[2] : null;

                // Filter rooms based on the search criteria
                var filteredRooms = db.Rooms
                    .Where(r => r.PersonNavigation != null &&
                                (r.PersonNavigation.FirstName == firstName ||
                                 r.PersonNavigation.LastName == lastName ||
                                 (middleName != null && r.PersonNavigation.Surname == middleName)))
                    .ToList();

                MainDataGridView.DataSource = filteredRooms;

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

        }
        private void LoadRoomsIntoDataGridView()
        {

            var rooms = db.Rooms.ToList();

            MainDataGridView.DataSource = rooms;

        }
        private void LoadAllRoomsIntoDataGridView()
        {

            var allRooms = db.Rooms.ToList();

            MainDataGridView.DataSource = allRooms;

        }

        private void FillRooms()
        {
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
            db.SaveChanges();
            MainDataGridView.Refresh();
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {
            db.Database.EnsureCreated();
            FillRooms();
            LoadRoomsIntoDataGridView();
            Timer.Start();
        }

        private void ReservedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ReservedRadioButton.Checked)
            {
                FilterAndDisplayRooms("зарезервировано");
            }
        }

        private void FreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FreeRadioButton.Checked)
            {
                FilterAndDisplayRooms("свободно");
            }
        }

        private void OccupiedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OccupiedRadioButton.Checked)
            {
                FilterAndDisplayRooms("занято");
            }
        }

        private void CheckoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckoutRadioButton.Checked)
            {
                FilterAndDisplayRooms("выписываются");
            }
        }

        private void MainDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int roomId = (int)MainDataGridView.Rows[e.RowIndex].Cells["IdRoom"].Value;
                var selectedRoom = db.Rooms.Include(r => r.PersonNavigation).FirstOrDefault(r => r.IdRoom == roomId);

                if (selectedRoom != null)
                {
                    NumberLabel.Text = roomId.ToString();
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
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
