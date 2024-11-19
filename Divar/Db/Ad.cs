using System;
using System.Collections.Generic;

namespace Divar.Db;

public partial class Ad
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public string? Discription { get; set; }

    public int CityId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual City City { get; set; } = null!;
}
