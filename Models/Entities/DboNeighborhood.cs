using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboNeighborhood
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public int? Code { get; set; }

    public int? DistrictId { get; set; }
}
