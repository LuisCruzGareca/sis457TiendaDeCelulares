//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadTiendaCelulares
{
    using System;
    using System.Collections.Generic;
    
    public partial class celulares
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public celulares()
        {
            this.compras = new HashSet<compras>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public System.DateTime fecha_modificacion { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public decimal precio { get; set; }
        public Nullable<int> idColor { get; set; }
        public Nullable<int> idCategoria { get; set; }
    
        public virtual categorias categorias { get; set; }
        public virtual colores colores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compras> compras { get; set; }
        public int Stock { get; set; }
    }
}
