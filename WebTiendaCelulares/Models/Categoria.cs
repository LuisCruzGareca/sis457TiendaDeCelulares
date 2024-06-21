using System;
using System.Collections.Generic;

namespace WebTiendaCelulares.Models;

public partial class Categoria
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Celulare> Celulares { get; set; } = new List<Celulare>();
}
