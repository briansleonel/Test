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
    public partial class FrmGestionClientes : Form
    {
        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            load_clientes();
            HabilitarAcciones(false);
        }

        private void load_clientes()
        {
            dgwClientes.DataSource = TrabajarCliente.list_clientes();
        }

        private void HabilitarAcciones(bool b)
        {
            btnAgregar.Enabled = !b;
            btnGuardar.Enabled = b;
            btnEliminar.Enabled = b;
            txtDNI.Enabled = !b;
            cambiarColor(btnAgregar);
            cambiarColor(btnGuardar);
            cambiarColor(btnEliminar);
        }

        private void cambiarColor(Button btn)
        {

            if (btn.Enabled==false)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);

            if (!bErrorFound)
            {
                DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea agregar este elemento?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogoResult == DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Cli_Nombre = txtNombre.Text;
                    oCliente.Cli_Apellido = txtApellido.Text;
                    oCliente.Cli_DNI = txtDNI.Text;
                    oCliente.Cli_Direccion = txtDireccion.Text;
                    oCliente.Os_CUIT = txtCUIT.Text;
                    oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                    TrabajarCliente.insert_cliente(oCliente);

                    ClearTextBoxs();
                    load_clientes();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearTextBoxs();
            HabilitarAcciones(false);
            HideErrorLabels();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);

            if (!bErrorFound)
            {
                DialogResult dialogoResult = MessageBox.Show("¿Esta seguro de que desea guardar los cambios?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogoResult == DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Cli_DNI = txtDNI.Text;
                    oCliente.Cli_Nombre = txtNombre.Text;
                    oCliente.Cli_Apellido = txtApellido.Text;
                    oCliente.Cli_Direccion = txtDireccion.Text;
                    oCliente.Os_CUIT = txtCUIT.Text;
                    oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                    TrabajarCliente.update_cliente(oCliente);

                    load_clientes();
                    HabilitarAcciones(false);
                    ClearTextBoxs();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogoResult = MessageBox.Show("¿Esta seguro de que desea eliminar este elemento?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogoResult == DialogResult.Yes)
            {
                TrabajarCliente.delete_cliente(txtDNI.Text);

                load_clientes();
                HabilitarAcciones(false);
                ClearTextBoxs();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string szApellido = txtBusquedaApellido.Text;
            string szDireccion = txtBusquedaDireccion.Text;

            if (szApellido != String.Empty && szDireccion != String.Empty)
            {
                dgwClientes.DataSource = TrabajarCliente.search_clientes(szApellido, szDireccion);
            }
            else
            {
                load_clientes();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            load_clientes();
            txtBusquedaApellido.Clear();
            txtBusquedaDireccion.Clear();
        }

        private void dgwClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwClientes.CurrentRow != null)
            {
                txtNombre.Text = dgwClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgwClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDNI.Text = dgwClientes.CurrentRow.Cells["DNI"].Value.ToString();
                txtDireccion.Text = dgwClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtCUIT.Text = dgwClientes.CurrentRow.Cells["CUIT"].Value.ToString();
                txtNroCarnet.Text = dgwClientes.CurrentRow.Cells["Nro de Carnet"].Value.ToString();

                HabilitarAcciones(true);
            }
        }

        public void HideErrorLabels()
        {
            lblValidDNI.Hide();
            lblValidApellido.Hide();
            lblValidNombre.Hide();
            lblValidDireccion.Hide();
            lblValidCUIT.Hide();
            lblValidNroCarnet.Hide();
        }

        private void ClearTextBoxs()
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCUIT.Clear();
            txtNroCarnet.Clear();
        }

        private void ValidateTextBoxs(ref bool bErrorFound)
        {
            if (txtDNI.Text.Length != 8)
            {
                lblValidDNI.Show();
                bErrorFound = true;
            }
            if (txtApellido.Text.Length < 3)
            {
                lblValidApellido.Show();
                bErrorFound = true;
            }
            if (txtNombre.Text.Length < 3)
            {
                lblValidNombre.Show();
                bErrorFound = true;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                lblValidDireccion.Show();
                bErrorFound = true;
            }
            if (!txtCUIT.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtCUIT.Text))
            {
                lblValidCUIT.Show();
                bErrorFound = true;
            }
            if (!txtNroCarnet.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtNroCarnet.Text))
            {
                lblValidNroCarnet.Show();
                bErrorFound = true;
            }
        }

    }
}
