using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class RoomInformation
{
    public RoomInformation() { }

    public RoomInformation(int roomId, string roomNumber, string description, int maxCapacity, decimal price, int roomTypeId, int status)
    {
        this.RoomId = roomId;
        this.RoomNumber = roomNumber;
        this.RoomDetailDescription = description;
        this.RoomMaxCapacity = maxCapacity;
        this.RoomPricePerDay = price;
        this.RoomTypeId = roomTypeId;
        this.RoomStatus = status;
    }
    public int RoomId { get; set; }

    public string RoomNumber { get; set; } = null!;

    public string RoomDetailDescription { get; set; }

    public int RoomMaxCapacity { get; set; }

    public int RoomTypeId { get; set; }

    public int RoomStatus { get; set; }

    public decimal RoomPricePerDay { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();

    public virtual RoomType RoomType { get; set; } = null!;
}
