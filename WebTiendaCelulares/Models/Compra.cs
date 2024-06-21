using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTiendaCelulares.Models;

public partial class Compra
{
    public int Id { get; set; }

    public string DireccionEnvio { get; set; } = "-";

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Total { get; set; }

    public DateTime FechaVenta { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdCelular { get; set; }

    public virtual Celulare? IdCelularNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
