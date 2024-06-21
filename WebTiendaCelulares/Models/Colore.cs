using System;
using System.Collections.Generic;

namespace WebTiendaCelulares.Models;

public partial class Colore
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Celulare> Celulares { get; set; } = new List<Celulare>();
}
