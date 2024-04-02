using System;
using System.Collections.Generic;

namespace DZHotelRoom;

public partial class Person
{
    public int IdPerson { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? Surname { get; set; }

    public byte[]? Avatar { get; set; }

    public DateOnly ArrivalDate { get; set; }

    public DateOnly ReleaseDate { get; set; }

    public bool Animal { get; set; }

    public DateOnly Birthday { get; set; }

    public string PaymentMetod { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}