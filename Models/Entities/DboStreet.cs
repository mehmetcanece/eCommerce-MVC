using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboStreet
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public int? NeighborhoodId { get; set; }
}
