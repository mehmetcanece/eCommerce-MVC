using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboComment
{
    public string? Id { get; set; }

    public string? IsConfirm { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Subject { get; set; }

    public string? Comment { get; set; }

    public string? Date { get; set; }

    public string? Type { get; set; }

    public string? TypeId { get; set; }

    public string? Rate { get; set; }

    public string? IsRead { get; set; }
}
