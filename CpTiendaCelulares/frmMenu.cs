using CadTiendaCelulares;
using FontAwesome.Sharp;
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
    public partial class frmMenu : Form
    {
        private static usuarios usuario;
        private Form currentChildForm;
        private int usuarioId;
        private frmLogin frmLogin;
        public frmMenu(frmLogin frmLogin,int usuarioId)
        {

            InitializeComponent();
            this.usuarioId = usuarioId;
            this.frmLogin = frmLogin;
        }

        private void Inicio_load(object sender ,EventArgs e)
        {
            
        }

        private void AbriFormulario(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();  // Close the current child form
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbriFormulario(new Form1());
        }

        private void iconMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            AbriFormulario(new frmCompras());
        }

        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
            AbriFormulario(new frmColor());
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            AbriFormulario(new frmCelulares(this.usuarioId));
        }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.frmLogin.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem5_Click_1(object sender, EventArgs e)
        {
            AbriFormulario(new frmCategoria());
        }
    }
}
