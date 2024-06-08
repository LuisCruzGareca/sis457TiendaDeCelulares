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
    public partial class frmCelulares : Form
    {
        int usuarioId;
        public frmCelulares(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
        }

        private void frmCelulares_Load(object sender, EventArgs e)
        {
            this.actuializarLista();

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevo = new frmNuevoCelular(this);
            frmNuevo.ShowDialog();
        }


        public void actuializarLista() {
            dataGridView1.DataSource = CelularCln.listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;

            var frmEditarUsuario = new frmEditarCelular(
                this,
                Convert.ToInt32(row.Cells[0].Value)
                );

            frmEditarUsuario.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            CelularCln.eliminar(id);
            this.actuializarLista();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            string nombre = row.Cells[1].Value.ToString();
            string precio = row.Cells[5].Value.ToString();

            var frmCompra = new frmCompra(
                this,
                id,
                nombre,
                precio,
                this.usuarioId
            );

            frmCompra.ShowDialog();
        }
    }
}
