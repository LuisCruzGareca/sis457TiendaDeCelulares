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

namespace CpTiendaCelulares
{
    public partial class frmNuevoUsuario : Form
    {
        private Form1 frmPrincipal;
        
        public frmNuevoUsuario(Form1 frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
            InitializeComponent();
        }

        public frmNuevoUsuario(frmColor frmColor)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txEmail.Text;
            string password = txPassword.Text;
            string nombre = txNombre.Text;
            bool esValido = true;
            errorEmail.SetError(txEmail, "");
            errorNombre.SetError(txNombre, "");
            errorPassword.SetError(txPassword, "");

            if (!EsEmailValido(email))
            {
                errorEmail.SetError(txEmail, "Email incorrecto");
                esValido = false;
            }

            if (!EsPasswordValido(password))
            {
                errorPassword.SetError(txPassword, "Password ha de ser mayor a 5 caracteres");
                esValido = false;
            }

            if (!EsNombreValido(nombre))
            {
                errorNombre.SetError(txNombre, "El nombre ha de contener solo letras");
                esValido = false;
            }

            if (esValido)
            {
                var usuario = new usuarios();
                usuario.email = email;
                usuario.password = password;
                usuario.nombre = nombre;

                UsuarioCln.insertar(usuario);
                this.frmPrincipal.UpdateDataGridView();
                this.Close();

            }
        }

        private bool EsEmailValido(string email)
        {
            string patronEmail = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            return Regex.IsMatch(email, patronEmail);
        }

        public bool EsPasswordValido(string password)
        {
            return password.Length >= 5;
        }

        public bool EsNombreValido(string nombre)
        {
            foreach (char c in nombre)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
