using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Customer
{
    public Customer() { }

    public Customer(int id, string name, string phone, string email, DateOnly birthday, byte status, string password) {
        this.CustomerId = id;
        this.CustomerFullName = name;
        this.Telephone = phone;
        this.EmailAddress = email;
        this.CustomerBirthday = birthday;
        this.CustomerStatus = status;
        this.Password = password;
    }
    public int CustomerId { get; set; }

    public string CustomerFullName { get; set; }

    public string Telephone { get; set; }

    public string EmailAddress { get; set; } = null!;

    public DateOnly CustomerBirthday { get; set; }

    public byte CustomerStatus { get; set; }

    public string Password { get; set; }

    public virtual ICollection<BookingReservation> BookingReservations { get; set; } = new List<BookingReservation>();
}
