using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebTiendaCelulares.Models;

public partial class Categoria
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo descripcion es obligatorio.")]
    public string Descripcion { get; set; } = null!;
    [Required(ErrorMessage = "El campo nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;

    public virtual ICollection<Celulare> Celulares { get; set; } = new List<Celulare>();
}
