using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboCity
{
    public sbyte? Id { get; set; }

    public string? Name { get; set; }

    public sbyte? Code { get; set; }

    public short? CountryId { get; set; }
}
