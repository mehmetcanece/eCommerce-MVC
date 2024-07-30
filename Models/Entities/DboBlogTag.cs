using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboBlogTag
{
    public sbyte? Id { get; set; }

    public string? Title { get; set; }

    public sbyte? IsConfirm { get; set; }

    public sbyte? RowNumber { get; set; }

    public sbyte? BlogId { get; set; }
}
