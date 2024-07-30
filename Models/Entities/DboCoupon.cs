using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboCoupon
{
    public sbyte? Id { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? Code { get; set; }

    public sbyte? IsConfirm { get; set; }

    public string? Type { get; set; }

    public sbyte? CustomerId { get; set; }

    public sbyte? Amount { get; set; }
}
