using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboAddress
{
    public string? Id { get; set; }

    public string? CustomerId { get; set; }

    public string? CountryId { get; set; }

    public string? CityId { get; set; }

    public string? DistrictId { get; set; }

    public string? Adress { get; set; }

    public string? Name { get; set; }

    public string? NeighborhoodId { get; set; }

    public string? StreetId { get; set; }
}
