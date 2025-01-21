using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public partial class Log
{
    [Key]
    public int Id { get; set; }

    public DateTime Timestamp { get; set; }

    public string? Level { get; set; }

    public string? Message { get; set; }
}
