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
    public partial class FrmListadoVentas : Form
    {
        public FrmListadoVentas()
        {
            InitializeComponent();
        }

        private void FrmListadoVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = TrabajarVenta.getAllVentas();
            CargarComboClientes();
        }

        private void CargarComboClientes()
        {
            DataTable dt = TrabajarCliente.list_clientes();
            dt.Columns.Add("NombreCompleto", typeof(string), "Apellido + ', '+ Nombre");

            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "DNI";
            cmbClientes.DataSource = dt;
        }

        private void btnListarVentasPorCliente_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = TrabajarVenta.getVentasByCliente(cmbClientes.SelectedValue.ToString());
        }

        private void btnListarVentasPorFechas_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = TrabajarVenta.getVentasByFechas(dtpFechaInicio.Value.Date, dtpFechaFin.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
        }

    }
}
