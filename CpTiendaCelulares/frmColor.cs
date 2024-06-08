using System;
using ClnTiendaCelulares;
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
    public partial class frmColor : Form

    {
        private bool esNuevo = false;
        public frmColor()
        {
            InitializeComponent();
        }

        private void frmColor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'labTiendaCelularesDataSet3.colores' Puede moverla o quitarla según sea necesario.
            this.coloresTableAdapter1.Fill(this.labTiendaCelularesDataSet3.colores);
            // TODO: esta línea de código carga datos en la tabla 'labTiendaCelularesDataSet2.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.labTiendaCelularesDataSet2.categorias);
            this.actuializarLista();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoUsuario = new frmNuevoUsuario(this);

            frmNuevoUsuario.ShowDialog();
        }

        public void actuializarLista()
        {
            //dataGridView1.DataSource = Colores.listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
