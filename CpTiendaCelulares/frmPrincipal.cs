using CadTiendaCelulares;
using ClnTiendaCelulares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CpTiendaCelulares
{
    public partial class Form1 : Form
    {
        private bool esNuevo = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'labTiendaCelularesDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.labTiendaCelularesDataSet.usuarios);

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoUsuario = new frmNuevoUsuario(this);

            frmNuevoUsuario.ShowDialog();
         
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateDataGridView()
        {
            var usuarios = UsuarioCln.listar();
            dataGridView1.DataSource = usuarios;
                
        }

    

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;

            var frmEditarUsuario = new frmEditarUsuario(
                this,
                Convert.ToInt32(row.Cells[0].Value),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString()
                );

            frmEditarUsuario.ShowDialog();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            UsuarioCln.eliminar(id);
            this.UpdateDataGridView();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            var frmNuevoUsuario = new frmNuevoUsuario(this);

            frmNuevoUsuario.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
