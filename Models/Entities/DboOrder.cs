using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboOrder
{
    public string? Id { get; set; }

    public string? CustomerId { get; set; }

    public string? PaymentId { get; set; }

    public string? ShipperId { get; set; }

    public string? OrderDate { get; set; }

    public string? IsPaid { get; set; }

    public string? IsComplated { get; set; }

    public string? AdressId { get; set; }
}
