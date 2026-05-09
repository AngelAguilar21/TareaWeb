using System;
using System.Collections.Generic;

namespace ESAN.LOGISTICA.API.Data;

public partial class Categories
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    // Relación inversa
    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}