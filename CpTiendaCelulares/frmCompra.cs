using CadTiendaCelulares;
using ClnTiendaCelulares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpTiendaCelulares
{
    public partial class frmCompra : Form
    {
        private frmCelulares frmCelulares;
        private int id;
        private string precio;
        private int usuarioId;
        public frmCompra(
            frmCelulares frmCelulares,
            int id,
            string nombre,
            string precio,
            int usuarioId
        )
        {
            InitializeComponent();
            lbCelular.Text = nombre;
            lbTotal.Text = precio.ToString() + " bs";
            this.frmCelulares = frmCelulares;
            this.id = id;
            this.precio = precio.ToString();
            this.usuarioId = usuarioId;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string direccion = txDireccion.Text;
            
            errorDireccion.SetError(txDireccion, "");

            if (string.IsNullOrWhiteSpace(direccion))
            {
                errorDireccion.SetError(txDireccion, "El campo direccion no puede estar vacio");
            }
            else {
                decimal total;
                decimal.TryParse(this.precio, out total);
                var compra = new compras();
                compra.total = total;
                compra.direccion_envio = direccion;
                compra.id_usuario = this.usuarioId;
                compra.idCelular = this.id;

                CompraCln.insertar(compra);
                this.Close();
            }
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
