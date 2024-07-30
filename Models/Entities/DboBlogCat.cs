﻿using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboBlogCat
{
    public short? Id { get; set; }

    public string? Title { get; set; }

    public string? Detail { get; set; }

    public sbyte? IsConfirm { get; set; }

    public string? Image { get; set; }

    public string? Extension { get; set; }

    public string? Headline { get; set; }

    public sbyte? RowNumber { get; set; }

    public sbyte? CatId { get; set; }

    public sbyte? Width { get; set; }

    public sbyte? Height { get; set; }
}