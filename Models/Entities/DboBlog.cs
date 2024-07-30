using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboBlog
{
    public short? Id { get; set; }

    public string? Title { get; set; }

    public string? Detail { get; set; }

    public sbyte? IsConfirm { get; set; }

    public string? Image { get; set; }

    public string? Extension { get; set; }

    public string? Headline { get; set; }

    public sbyte? RowNumber { get; set; }

    public short? CatId { get; set; }

    public string? Width { get; set; }

    public string? Height { get; set; }

    public sbyte? EditorId { get; set; }

    public string? Date { get; set; }

    public sbyte? Views { get; set; }

    public sbyte? Likes { get; set; }
}
