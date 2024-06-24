using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTiendaCelulares.Models;

public partial class Celulare
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;


    public DateTime FechaCreacion { get; set; }

    
    public DateTime FechaModificacion { get; set; }

    [Required(ErrorMessage = "El campo descripcion es obligatorio.")]
    public string Descripcion { get; set; } = null!;

    [Required(ErrorMessage = "El campo marca es obligatorio.")]
    public string Marca { get; set; } = null!;

    [Required(ErrorMessage = "El campo modelo es obligatorio.")]
    public string Modelo { get; set; } = null!;
   

    [Required(ErrorMessage = "El campo Precio es obligatorio.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Precio { get; set; }

    [Required(ErrorMessage = "deve elegir un color es obligatorio.")]
    public int? IdColor { get; set; }
    [Required(ErrorMessage = "deve elegir una categoria es obligatorio.")]
    public int? IdCategoria { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Colore? IdColorNavigation { get; set; }
}
