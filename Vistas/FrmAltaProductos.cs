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
    public partial class FrmAltaProductos : Form
    {
        public FrmAltaProductos()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);

            if (!bErrorFound)
            {
                string szCodigo = txtCodigo.Text;
                string szCategoria = txtCategoria.Text;
                string szDescripcion = txtDescripcion.Text;
                string szPrecio = txtPrecio.Text;

                DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea guardar este registro?",
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogoResult == DialogResult.Yes)
                {
                    Producto oProducto = new Producto(szCodigo, szCategoria, szDescripcion, Convert.ToDecimal(szPrecio));
                    MessageBox.Show("Datos del Producto: " +
                                    "\n\n Código : " + oProducto.Prod_Codigo +
                                    "\n Categoría : " + oProducto.Prod_Categoria +
                                    "\n Descripción : " + oProducto.Prod_Descripcion +
                                    "\n Precio : " + oProducto.Prod_Precio, "Producto agregado");
                    ClearTextBoxs();
                }
            }

        }

        public void HideErrorLabels()
        {
            lblValidCategoria.Hide();
            lblValidCodigo.Hide();
            lblValidDescripcion.Hide();
            lblValidPrecio.Hide();
        }

        private void ClearTextBoxs()
        {
            txtCategoria.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void ValidateTextBoxs(ref bool bErrorFound)
        {
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                lblValidCategoria.Show();
                bErrorFound = true;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                lblValidDescripcion.Show();
                bErrorFound = true;
            }
            if (!txtCodigo.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtCodigo.Text))
            {
                lblValidCodigo.Show();
                bErrorFound = true;
            }
            if (!txtPrecio.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtPrecio.Text))            
            {
                lblValidPrecio.Show();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
