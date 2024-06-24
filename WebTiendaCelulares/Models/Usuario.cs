using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebTiendaCelulares.Models;

public partial class Usuario
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo email es obligatorio.")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "El campo password es obligatorio.")]
    public string Password { get; set; } = null!;

    [Required(ErrorMessage = "El campo nombre es obligatorio.")]
    public string? Nombre { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
