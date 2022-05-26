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
    public partial class FrmGestionUsuarios : Form
    {
        Usuario usuarioTmp;
        public FrmGestionUsuarios()
        {
            InitializeComponent();
            this.cargarUsuarios();
            this.esconder();
            dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {   
            Usuario ouser = new Usuario();

                var dialogoConfirmacion = MessageBox.Show("Desea Agregar a este usuario?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogoConfirmacion == DialogResult.No)
                {
                    MessageBox.Show("Usuario no agregado");
                    return;
                }
                try
                {
                    if (this.comprobarAltaModificarUsuario() && !this.comprobarUsuarioExistente(txtUsuario.Text))
                    {
                       this.setUsuario(ouser);
                       TrabajarUsuario.agregarUsuario(ouser);
                       this.cargarUsuarios();
                       this.esconder();
                       this.limpiarCampos();
                       this.HabilitarAcciones(false);
                    }
                   

                }
                catch (Exception efe)
                {
                    MessageBox.Show("Ha fallado - " + efe.Message);
                }
        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {   
            try
            {
                var dialogoConfirmacion = MessageBox.Show("Desea eliminar a " + dgvListaUsuarios.CurrentRow.Cells[1].Value+"?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogoConfirmacion == DialogResult.No)
                {
                    MessageBox.Show("Usuario no eliminado");
                    return;
                }

                TrabajarUsuario.baja_usuarios((int)dgvListaUsuarios.CurrentRow.Cells[0].Value);
                dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
                MessageBox.Show("Usuario eliminado correctamente");
                limpiarCampos();
                this.HabilitarAcciones(false);
            }
            catch(Exception efe)
            {
                MessageBox.Show("Problemas al eliminar usuario " + efe);
            }
               
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (txtNombreUsuario.TextLength >= 2)
            {
                dgvListaUsuarios.DataSource = TrabajarUsuario.buscar_usuario(txtNombreUsuario.Text);
            }
            else
                dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }


        private void setUsuario(Usuario ouser)
        {
            int numRol = ouser.Rol_Codigo;
            switch (cmbRol.Text)
            {
                case "Administrador":
                    numRol = 0;
                    break;
                case "Auditor":
                    numRol = 1;
                    break;
                case "Operador":
                    numRol = 2;
                    break;
            }
            ouser.Usu_Contrasenia = txtContrasenia.Text;
            ouser.Usu_ApellidoNombre = txtNombreCompleto.Text;
            ouser.Usu_NombreUsuario = txtUsuario.Text;
            ouser.Rol_Codigo = numRol;
        }


        private bool comprobarAltaModificarUsuario()
        {
            bool bandera=true;
            try
            {
                if (txtUsuario.TextLength < 3)
                {
                    lblValidUsuario.Show();
                    bandera = false;
                }
                else
                    lblValidUsuario.Hide();
                
                if (txtContrasenia.TextLength < 3)
                {                  
                    lblValidContrasenia.Show();
                    bandera = false;
                }
                else
                    lblValidContrasenia.Hide();

                if (txtNombreCompleto.TextLength < 3)
                {
                    lblValidNombreCompleto.Show();
                    bandera = false;
                }
                else
                    lblValidNombreCompleto.Hide();

            }
            catch (Exception efe)
            {
                    lblValidUsuario.Show();
                    lblValidContrasenia.Show();
                    lblValidNombreCompleto.Show();
                    bandera = false;
            }

            return bandera;
        }
        private void cargarUsuarios()
        {
            dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmUsuario = new FrmGestionUsuarios();
            frmUsuario.Show();
            this.Close();
        }

        private void esconder()
        {
            lblValidUsuario.Hide();
            lblValidContrasenia.Hide();
            lblValidNombreCompleto.Hide();
        }


        private void limpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
            txtNombreCompleto.Clear();

        }


        private bool comprobarUsuarioExistenteModificar(string nombreUsuario)
        {
            if (!TrabajarUsuario.comprobar_NombreUsuarioExistente(nombreUsuario))
            {
                return false;
            }
            else
            {
                if (TrabajarUsuario.buscar_por_nombre_usuario(nombreUsuario).Usu_Id == this.usuarioTmp.Usu_Id)
                    return false;
                else
                {
                    MessageBox.Show("El usuario ya existe en el sistema");
                    return true;
                }
            }
        }

        private bool comprobarUsuarioExistente(string nombreUsuario)
        {
            if (TrabajarUsuario.comprobar_NombreUsuarioExistente(nombreUsuario))
            {
                MessageBox.Show("El usuario ya existe en el sistema");
                return true;
            }
            else
            {
                return false;
            }            
        }

        private void dgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaUsuarios.CurrentRow != null)
            {
                int valor = (int)dgvListaUsuarios.CurrentRow.Cells[0].Value;
                this.usuarioTmp = TrabajarUsuario.buscar_usuario(valor);
                switch (this.usuarioTmp.Rol_Codigo)
                {
                    case 0:
                        cmbRol.Text = "Administrador";
                        break;
                    case 1:
                        cmbRol.Text = "Auditor";
                        break;
                    case 2:
                        cmbRol.Text = "Operador";
                        break;
                }
                txtUsuario.Text = this.usuarioTmp.Usu_NombreUsuario;
                txtContrasenia.Text = this.usuarioTmp.Usu_Contrasenia;
                txtNombreCompleto.Text = this.usuarioTmp.Usu_ApellidoNombre;
                this.HabilitarAcciones(true);
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.comprobarAltaModificarUsuario() && !this.comprobarUsuarioExistenteModificar(txtNombreUsuario.Text))
                {
                    var dialogoConfirmacion = MessageBox.Show("Desea modificar a este usuario?", "Confirmar", MessageBoxButtons.YesNo);
                    if (dialogoConfirmacion == DialogResult.No)
                    {
                        MessageBox.Show("Usuario no modificado");
                        return;
                    }
                    this.setUsuario(this.usuarioTmp);
                    TrabajarUsuario.modificar_usuario(this.usuarioTmp);
                    MessageBox.Show("Usuario modificado correctamente");
                    this.cargarUsuarios();
                    this.esconder();
                    this.HabilitarAcciones(false);
                }

            }
            catch (Exception efe)
            {
                MessageBox.Show("No se ha podido modificar el usuario " + efe);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.usuarioTmp = null;
            this.limpiarCampos();
            this.esconder();
            this.HabilitarAcciones(false);
        }

        private void HabilitarAcciones(bool b)
        {
            btnAgregar.Enabled = !b;
            btnModificarUsuario.Enabled = b;
            btnEliminarUsuario.Enabled = b;
            cambiarColor(btnAgregar);
            cambiarColor(btnModificarUsuario);
            cambiarColor(btnEliminarUsuario);
        }

        private void cambiarColor(Button btn)
        {

            if (btn.Enabled == false)
            {
                btn.BackColor = ColorTranslator.FromHtml("#575B58");
            }
            else
            {
                if (!(btn.Text == "Eliminar"))
                {
                    btn.BackColor = ColorTranslator.FromHtml("#1B998B");
                }
                else
                {
                    btn.BackColor = Color.Crimson;
                }
            }
        }
    }
}
