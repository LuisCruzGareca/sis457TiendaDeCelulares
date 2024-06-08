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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CpTiendaCelulares
{
    public partial class frmNuevoCelular : Form
    {
        private frmCelulares frmCelulares;
        public frmNuevoCelular(frmCelulares frmCelulares)
        {
            InitializeComponent();
            this.frmCelulares = frmCelulares;
        }

        private void frmNuevoCelular_Load(object sender, EventArgs e)

        {
            

            // TODO: esta línea de código carga datos en la tabla 'labTiendaCelularesDataSet2.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.labTiendaCelularesDataSet2.categorias);
            // TODO: esta línea de código carga datos en la tabla 'labTiendaCelularesDataSet1.colores' Puede moverla o quitarla según sea necesario.
            this.coloresTableAdapter.Fill(this.labTiendaCelularesDataSet1.colores);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txNombre.Text;
            string descripcion = txDescripcion.Text;
            string marca = txMarca.Text;
            string modelo= txModelo.Text;
            string precio = txPrecio.Text;
            DataRowView drvColor = (DataRowView)cmbColores.SelectedItem;
            int colorId = Convert.ToInt32(drvColor["id"].ToString());
            DataRowView drvCategoria = (DataRowView)cmbCategorias.SelectedItem;
            int categoriaId = Convert.ToInt32(drvCategoria["id"].ToString());
            bool esValido = true;

            
            errorNombre.SetError(txNombre, "");
            errorDescripcion.SetError(txDescripcion, "");
            errorMarca.SetError(txMarca, "");
            errorModelo.SetError(txModelo, "");
            errorPrecio.SetError(txPrecio, "");

            if (string.IsNullOrWhiteSpace(nombre))       
            {
                errorNombre.SetError(txNombre, "El campo nombre no puede estar vacio");
                esValido = false;

            }

            if (string.IsNullOrWhiteSpace(descripcion)) {
                errorDescripcion.SetError(txDescripcion, "El campo descripcion  no puede estar vacio");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(marca))
            {
                errorMarca.SetError(txMarca, "El campo marca no puede estar vacio");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(modelo))
            {
                errorModelo.SetError(txModelo, "El campo modelo no puede estar vacio");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(precio))
            {
                errorPrecio.SetError(txPrecio, "El campo precio no puede estar vacio");
                esValido = false;
            }

            decimal precioDecimal;
            if (!decimal.TryParse(precio, out precioDecimal))
            {
                esValido = false;
                errorPrecio.SetError(txPrecio, "El campo precio ha de ser un numero");

            }

            if (esValido) {
                //se crea el objeto celular con todos los campos validados
                var celular = new celulares();
                celular.nombre = nombre;
                celular.descripcion = descripcion;
                celular.marca = marca;
                celular.modelo  = modelo;
                celular.precio = precioDecimal;
                celular.idColor = colorId;
                celular.idCategoria = categoriaId;

                //se inserta el celular en la base de datos
                CelularCln.insertar(celular);

                //actualizo el data grid view del formulario de celulares
                this.frmCelulares.actuializarLista();

                //cierro el formulario de creacion de celulares
                this.Close();
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
