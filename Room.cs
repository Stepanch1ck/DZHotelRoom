using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DZHotelRoom;

[Table("Rooms")]
public partial class Room
{
    public int IdRoom { get; set; }

    public string Status { get; set; } = null!;

    public int? Person { get; set; }

    public virtual Person? PersonNavigation { get; set; }
}
