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
    public partial class FrmAltaObrasSociales : Form
    {
        public FrmAltaObrasSociales()
        {
            InitializeComponent();
        }

        private void btnAgregarObraSocial_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);
            
            if (!bErrorFound)
            {
                string szCuit = txtCUIT.Text;
                string szRazonSocial = txtRazonSocial.Text;
                string szDireccion = txtDireccion.Text;
                string szTelefono = txtTelefono.Text;

                 DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea guardar este registro?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogoResult == DialogResult.Yes)
                {
                    ObraSocial oObraSocial = new ObraSocial(szCuit, szRazonSocial, szDireccion, szTelefono);
                    MessageBox.Show("Datos de la Obra Social: " +
                                    "\n\n CUIT : " + oObraSocial.Os_CUIT +
                                    "\n Razon Social : " + oObraSocial.Os_RazonSocial +
                                    "\n Dirección : " + oObraSocial.Os_Direccion +
                                    "\n Telefono : " + oObraSocial.Os_Telefono, "Obra Social agregada");
                    ClearTextBoxs();
                }
            }
        }

        public void HideErrorLabels()
        {
            lblValidRazonSocial.Hide();
            lblValidDireccion.Hide();
            lblValidCUIT.Hide();
            lblValidTelefono.Hide();
        }

        private void ClearTextBoxs()
        {
            txtRazonSocial.Clear();
            txtDireccion.Clear();
            txtCUIT.Clear();
            txtTelefono.Clear();
        }

        private void ValidateTextBoxs(ref bool bErrorFound)
        {
            if (string.IsNullOrEmpty(txtRazonSocial.Text))
            {
                lblValidRazonSocial.Show();
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
            if (!txtTelefono.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                lblValidTelefono.Show();
                bErrorFound = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("#575B58");
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("#1B998B");

        }
    }
}
