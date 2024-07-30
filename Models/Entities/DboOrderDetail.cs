using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboOrderDetail
{
    public string? Id { get; set; }

    public string? OrderId { get; set; }

    public string? ProductId { get; set; }

    public string? RowNumber { get; set; }

    public string? Price { get; set; }

    public string? Quantity { get; set; }

    public string? Discount { get; set; }

    public string? Total { get; set; }

    public string? SizeId { get; set; }

    public string? ColorId { get; set; }
}
