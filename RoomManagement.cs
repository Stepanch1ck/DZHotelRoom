using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZHotelRoom
{
    internal class RoomManagement
    {
        private readonly HotelRoomContext _context;

        public RoomManagement(HotelRoomContext context)
        {
            _context = context;
        }

        public void FillRooms()
        {
            // Get today's date
            string todayString = DateTime.Today.ToString("yyyy-MM-dd");

            // Find available rooms (not occupied)
            var availableRooms = _context.Rooms.Where(r => r.Person == null);

            // Get people arriving today with their arrival and release dates
            var arrivingPeople = _context.People
                .Where(p => p.ArrivalDate.ToString("yyyy-MM-dd") == todayString) // Compare date strings
                .Select(p => new { p.IdPerson, p.ArrivalDate, p.ReleaseDate });


            // Assign people to available rooms
            foreach (var person in arrivingPeople)
            {
                var availableRoom = availableRooms.FirstOrDefault();
                if (availableRoom != null)
                {
                    availableRoom.Person = person.IdPerson;
                    
                }
                else
                {
                    // Handle situation when there are no available rooms
                    Console.WriteLine($"No available room for person with ID {person.IdPerson}");
                }
            }

            // Save changes to the database
            _context.SaveChanges();
        }

    }
}
