using System;
using System.Collections.Generic;

namespace ToDoApi;

public partial class Item
{
    public int Id { get; set; }

    public string? Namw { get; set; }

    public bool? IsComplete { get; set; }
}
