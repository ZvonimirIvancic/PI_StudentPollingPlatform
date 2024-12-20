﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Poll
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Tekst { get; set; } = null!;

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
