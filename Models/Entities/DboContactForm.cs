using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboContactForm
{
    public string? Id { get; set; }

    public string? IsConfirm { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public string? Date { get; set; }
}
