using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboSysdiagram
{
    public string? Name { get; set; }

    public sbyte? PrincipalId { get; set; }

    public sbyte? DiagramId { get; set; }

    public sbyte? Version { get; set; }

    public string? Definition { get; set; }
}
