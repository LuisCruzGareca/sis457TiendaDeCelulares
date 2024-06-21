﻿using System;
using System.Collections.Generic;

namespace WebTiendaCelulares.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Nombre { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
