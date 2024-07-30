using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboMessage
{
    public sbyte? Id { get; set; }

    public string? Message { get; set; }

    public string? Date { get; set; }

    public sbyte? SenderId { get; set; }

    public sbyte? IsRead { get; set; }

    public sbyte? RecipientId { get; set; }

    public sbyte? IsLike { get; set; }
}
