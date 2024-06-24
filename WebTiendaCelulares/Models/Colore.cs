using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebTiendaCelulares.Models;

public partial class Colore
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;

    public virtual ICollection<Celulare> Celulares { get; set; } = new List<Celulare>();
}
