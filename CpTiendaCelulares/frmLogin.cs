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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txEmail.Text;
            string password = txPassword.Text;
            lbError.Text = "";

            if (validar())
            {
                var usuario = UsuarioCln.validar(email, password);
                if (usuario != null)
                {
                    var frmMenu = new frmMenu(this,usuario.id);
                    frmMenu.ShowDialog();
                }
                else {
                    lbError.Text = "El Usuario no existe";
                }
            }
        }

        private bool validar()
        {
            bool esValido = true;
            errorEmail.SetError(txEmail, "");
            errorPassword.SetError(txPassword, "");
            if (string.IsNullOrEmpty(txEmail.Text))
            {
                esValido = false;
                errorEmail.SetError(txEmail, "El campo usuario es obligatorio");
            }
            if (string.IsNullOrEmpty(txPassword.Text))
            {
                esValido = false;
                errorPassword.SetError(txPassword, "El campo contraseña es obligatorio");
            }
            return esValido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
