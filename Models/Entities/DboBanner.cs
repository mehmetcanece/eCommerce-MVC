using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboBanner
{
    public sbyte? Id { get; set; }

    public string? Title { get; set; }

    public string? Detail { get; set; }

    public sbyte? IsConfirm { get; set; }

    public string? Image { get; set; }

    public string? Extension { get; set; }

    public string? Headline { get; set; }

    public string? Url { get; set; }

    public sbyte? RowNumber { get; set; }

    public string? Target { get; set; }

    public string? Width { get; set; }

    public string? Height { get; set; }
}
