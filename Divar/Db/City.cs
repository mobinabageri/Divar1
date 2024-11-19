using System;
using System.Collections.Generic;

namespace Divar.Db;

public partial class City
{
    public int Id { get; set; }

    public string CityName { get; set; } = null!;

    public int? CityCode { get; set; }

    public virtual ICollection<Ad> Ads { get; set; } = new List<Ad>();
}
