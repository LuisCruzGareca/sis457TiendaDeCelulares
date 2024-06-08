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
    public partial class frmEditarCelular : Form
    {
        private frmCelulares frmCelulares;
        private int celularId;

        public frmEditarCelular(
            frmCelulares frmCelulares,
            int celularId
           )
        {
            InitializeComponent();
            this.rellenearCombos();
            this.frmCelulares = frmCelulares;
            this.celularId = celularId;
            var celular = CelularCln.obtenerUno(celularId);
            txNombre.Text = celular.nombre;
            txDescripcion.Text = celular.descripcion;
            txMarca.Text = celular.marca;  
            txModelo.Text = celular.modelo;
            txPrecio.Text = celular.precio.ToString();
            cmbColores.SelectedValue = celular.idColor;
            cmbCategorias.SelectedValue = celular.idCategoria;
            
        }

        private void rellenearCombos() {
            // TODO: esta línea de código carga datos en la tabla 'labTiendaCelularesDataSet4.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.labTiendaCelularesDataSet4.categorias);
            // TODO: esta línea de código carga datos en la tabla 'labTiendaCelularesDataSet3.colores' Puede moverla o quitarla según sea necesario.
            this.coloresTableAdapter.Fill(this.labTiendaCelularesDataSet3.colores);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txNombre.Text;
            string descripcion = txDescripcion.Text;
            string marca = txMarca.Text;
            string modelo = txModelo.Text;
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

            if (string.IsNullOrWhiteSpace(descripcion))
            {
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

            if (esValido)
            {
                //se crea el objeto celular con todos los campos validados
                var celular = new celulares();
                celular.id = this.celularId;
                celular.nombre = nombre;
                celular.descripcion = descripcion;
                celular.marca = marca;
                celular.modelo = modelo;
                celular.precio = precioDecimal;
                celular.idColor = colorId;
                celular.idCategoria = categoriaId;

                //se inserta el celular en la base de datos
                CelularCln.actualizar(celular);

                //actualizo el data grid view del formulario de celulares
                this.frmCelulares.actuializarLista();

                //cierro el formulario de creacion de celulares
                this.Close();
            }
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
