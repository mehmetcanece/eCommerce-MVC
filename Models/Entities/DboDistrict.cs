using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboDistrict
{
    public short? Id { get; set; }

    public string? Name { get; set; }

    public short? Code { get; set; }

    public sbyte? CityId { get; set; }
}
