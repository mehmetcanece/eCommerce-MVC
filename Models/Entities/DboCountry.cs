using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboCountry
{
    public short? Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Language { get; set; }

    public string? PhoneCode { get; set; }
}
