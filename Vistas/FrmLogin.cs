using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    { 
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string szUsuario = txtUsuario.Text;
            string szPassword = txtPassword.Text;

            if (szUsuario != String.Empty && szPassword != String.Empty)
            {
                int iRolCodigo = TrabajarUsuario.validate_login(szUsuario, szPassword);

                if (iRolCodigo != 0)
                {
                    //MessageBox.Show("Bienvenido " + szUsuario + "!");
                    
                    FrmMain frmMain = new FrmMain();
                    frmMain.lblUsuarioActual.Text = szUsuario;
                    frmMain.lblRolActual.Text = TrabajarUsuario.get_rol(iRolCodigo);
                    
                    this.Hide();
                    frmMain.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos de acceso incorrectos", "Fallo de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                    txtUsuario.Select();
                }
            }
            else
            {
                MessageBox.Show("Faltan llenar campos", "Fallo de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.DarkSeaGreen;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.SeaGreen;
        }

        

    }
}