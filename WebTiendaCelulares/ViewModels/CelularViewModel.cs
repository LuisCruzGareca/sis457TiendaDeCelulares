﻿namespace WebTiendaCelulares.ViewModels
{
    public class CelularViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        //public int Stock { get; set; }
        public string NombreCategoria { get; set; }
        public string NombreColor { get; set; }
        public int Stock { get; set; }
    }

}
