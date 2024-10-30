using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class RoomType
{
    public RoomType() { }

    public RoomType(int roomTypeId, string roomTypeName, string description, string note)
    {
        this.RoomTypeId = roomTypeId;
        this.RoomTypeName = roomTypeName;
        this.TypeDescription = description;
        this.TypeNote = note;
    }
    public int RoomTypeId { get; set; }

    public string RoomTypeName { get; set; } = null!;

    public string? TypeDescription { get; set; }

    public string? TypeNote { get; set; }

    public virtual ICollection<RoomInformation> RoomInformations { get; set; } = new List<RoomInformation>();
}
