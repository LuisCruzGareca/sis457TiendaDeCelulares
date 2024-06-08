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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'labTiendaCelularesDataSet2.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.labTiendaCelularesDataSet2.categorias);

        }
    }
}
