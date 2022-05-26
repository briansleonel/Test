namespace Vistas
{
    partial class FrmGestionClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGestionClientes = new System.Windows.Forms.Label();
            this.dgwClientes = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtNroCarnet = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblNroCarnet = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblValidNombre = new System.Windows.Forms.Label();
            this.lblValidApellido = new System.Windows.Forms.Label();
            this.lblValidDNI = new System.Windows.Forms.Label();
            this.lblValidDireccion = new System.Windows.Forms.Label();
            this.lblValidCUIT = new System.Windows.Forms.Label();
            this.lblValidNroCarnet = new System.Windows.Forms.Label();
            this.txtBusquedaApellido = new System.Windows.Forms.TextBox();
            this.txtBusquedaDireccion = new System.Windows.Forms.TextBox();
            this.lblBusquedaApellido = new System.Windows.Forms.Label();
            this.lblBusquedaDireccion = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlDatosCliente = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlConsultas = new System.Windows.Forms.Panel();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).BeginInit();
            this.pnlDatosCliente.SuspendLayout();
            this.pnlConsultas.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestionClientes
            // 
            this.lblGestionClientes.AutoSize = true;
            this.lblGestionClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClientes.Location = new System.Drawing.Point(252, 14);
            this.lblGestionClientes.Name = "lblGestionClientes";
            this.lblGestionClientes.Size = new System.Drawing.Size(173, 24);
            this.lblGestionClientes.TabIndex = 2;
            this.lblGestionClientes.Text = "Gestión de Clientes";
            // 
            // dgwClientes
            // 
            this.dgwClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgwClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClientes.Location = new System.Drawing.Point(5, 198);
            this.dgwClientes.Name = "dgwClientes";
            this.dgwClientes.Size = new System.Drawing.Size(371, 260);
            this.dgwClientes.TabIndex = 0;
            this.dgwClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwClientes_CellClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(115, 91);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(115, 136);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(150, 20);
            this.txtDNI.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(115, 181);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(150, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(115, 226);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(150, 20);
            this.txtCUIT.TabIndex = 4;
            // 
            // txtNroCarnet
            // 
            this.txtNroCarnet.Location = new System.Drawing.Point(115, 271);
            this.txtNroCarnet.Name = "txtNroCarnet";
            this.txtNroCarnet.Size = new System.Drawing.Size(150, 20);
            this.txtNroCarnet.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(62, 94);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(80, 139);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(54, 184);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(74, 229);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(35, 13);
            this.lblCUIT.TabIndex = 10;
            this.lblCUIT.Text = "CUIT:";
            // 
            // lblNroCarnet
            // 
            this.lblNroCarnet.AutoSize = true;
            this.lblNroCarnet.Location = new System.Drawing.Point(33, 274);
            this.lblNroCarnet.Name = "lblNroCarnet";
            this.lblNroCarnet.Size = new System.Drawing.Size(76, 13);
            this.lblNroCarnet.TabIndex = 11;
            this.lblNroCarnet.Text = "Nro de Carnet:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(51, 325);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancelar.Location = new System.Drawing.Point(177, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnGuardar.Location = new System.Drawing.Point(51, 362);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnEliminar.Location = new System.Drawing.Point(177, 362);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblValidNombre
            // 
            this.lblValidNombre.AutoSize = true;
            this.lblValidNombre.ForeColor = System.Drawing.Color.Red;
            this.lblValidNombre.Location = new System.Drawing.Point(112, 69);
            this.lblValidNombre.Name = "lblValidNombre";
            this.lblValidNombre.Size = new System.Drawing.Size(155, 13);
            this.lblValidNombre.TabIndex = 16;
            this.lblValidNombre.Text = "Debe ingresar al menos 3 letras";
            this.lblValidNombre.Visible = false;
            // 
            // lblValidApellido
            // 
            this.lblValidApellido.AutoSize = true;
            this.lblValidApellido.ForeColor = System.Drawing.Color.Red;
            this.lblValidApellido.Location = new System.Drawing.Point(112, 114);
            this.lblValidApellido.Name = "lblValidApellido";
            this.lblValidApellido.Size = new System.Drawing.Size(155, 13);
            this.lblValidApellido.TabIndex = 17;
            this.lblValidApellido.Text = "Debe ingresar al menos 3 letras";
            this.lblValidApellido.Visible = false;
            // 
            // lblValidDNI
            // 
            this.lblValidDNI.AutoSize = true;
            this.lblValidDNI.ForeColor = System.Drawing.Color.Red;
            this.lblValidDNI.Location = new System.Drawing.Point(112, 159);
            this.lblValidDNI.Name = "lblValidDNI";
            this.lblValidDNI.Size = new System.Drawing.Size(130, 13);
            this.lblValidDNI.TabIndex = 18;
            this.lblValidDNI.Text = "Debe contener 8 números";
            this.lblValidDNI.Visible = false;
            // 
            // lblValidDireccion
            // 
            this.lblValidDireccion.AutoSize = true;
            this.lblValidDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblValidDireccion.Location = new System.Drawing.Point(112, 204);
            this.lblValidDireccion.Name = "lblValidDireccion";
            this.lblValidDireccion.Size = new System.Drawing.Size(131, 13);
            this.lblValidDireccion.TabIndex = 19;
            this.lblValidDireccion.Text = "Proporcione una dirección";
            this.lblValidDireccion.Visible = false;
            // 
            // lblValidCUIT
            // 
            this.lblValidCUIT.AutoSize = true;
            this.lblValidCUIT.ForeColor = System.Drawing.Color.Red;
            this.lblValidCUIT.Location = new System.Drawing.Point(112, 249);
            this.lblValidCUIT.Name = "lblValidCUIT";
            this.lblValidCUIT.Size = new System.Drawing.Size(123, 13);
            this.lblValidCUIT.TabIndex = 20;
            this.lblValidCUIT.Text = "Este campo es numérico";
            this.lblValidCUIT.Visible = false;
            // 
            // lblValidNroCarnet
            // 
            this.lblValidNroCarnet.AutoSize = true;
            this.lblValidNroCarnet.ForeColor = System.Drawing.Color.Red;
            this.lblValidNroCarnet.Location = new System.Drawing.Point(112, 294);
            this.lblValidNroCarnet.Name = "lblValidNroCarnet";
            this.lblValidNroCarnet.Size = new System.Drawing.Size(123, 13);
            this.lblValidNroCarnet.TabIndex = 21;
            this.lblValidNroCarnet.Text = "Este campo es numérico";
            this.lblValidNroCarnet.Visible = false;
            // 
            // txtBusquedaApellido
            // 
            this.txtBusquedaApellido.Location = new System.Drawing.Point(115, 42);
            this.txtBusquedaApellido.Name = "txtBusquedaApellido";
            this.txtBusquedaApellido.Size = new System.Drawing.Size(200, 20);
            this.txtBusquedaApellido.TabIndex = 5;
            // 
            // txtBusquedaDireccion
            // 
            this.txtBusquedaDireccion.Location = new System.Drawing.Point(115, 77);
            this.txtBusquedaDireccion.Name = "txtBusquedaDireccion";
            this.txtBusquedaDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtBusquedaDireccion.TabIndex = 6;
            // 
            // lblBusquedaApellido
            // 
            this.lblBusquedaApellido.AutoSize = true;
            this.lblBusquedaApellido.Location = new System.Drawing.Point(62, 45);
            this.lblBusquedaApellido.Name = "lblBusquedaApellido";
            this.lblBusquedaApellido.Size = new System.Drawing.Size(47, 13);
            this.lblBusquedaApellido.TabIndex = 7;
            this.lblBusquedaApellido.Text = "Apellido:";
            // 
            // lblBusquedaDireccion
            // 
            this.lblBusquedaDireccion.AutoSize = true;
            this.lblBusquedaDireccion.Location = new System.Drawing.Point(54, 80);
            this.lblBusquedaDireccion.Name = "lblBusquedaDireccion";
            this.lblBusquedaDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblBusquedaDireccion.TabIndex = 8;
            this.lblBusquedaDireccion.Text = "Dirección:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnBuscar.Location = new System.Drawing.Point(159, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Location = new System.Drawing.Point(240, 106);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pnlDatosCliente
            // 
            this.pnlDatosCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDatosCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosCliente.Controls.Add(this.label1);
            this.pnlDatosCliente.Controls.Add(this.lblValidNroCarnet);
            this.pnlDatosCliente.Controls.Add(this.txtNombre);
            this.pnlDatosCliente.Controls.Add(this.lblValidCUIT);
            this.pnlDatosCliente.Controls.Add(this.txtApellido);
            this.pnlDatosCliente.Controls.Add(this.lblValidDireccion);
            this.pnlDatosCliente.Controls.Add(this.txtDNI);
            this.pnlDatosCliente.Controls.Add(this.lblValidDNI);
            this.pnlDatosCliente.Controls.Add(this.txtDireccion);
            this.pnlDatosCliente.Controls.Add(this.lblValidApellido);
            this.pnlDatosCliente.Controls.Add(this.txtCUIT);
            this.pnlDatosCliente.Controls.Add(this.lblValidNombre);
            this.pnlDatosCliente.Controls.Add(this.txtNroCarnet);
            this.pnlDatosCliente.Controls.Add(this.btnEliminar);
            this.pnlDatosCliente.Controls.Add(this.lblNombre);
            this.pnlDatosCliente.Controls.Add(this.btnGuardar);
            this.pnlDatosCliente.Controls.Add(this.lblApellido);
            this.pnlDatosCliente.Controls.Add(this.btnCancelar);
            this.pnlDatosCliente.Controls.Add(this.lblDNI);
            this.pnlDatosCliente.Controls.Add(this.btnAgregar);
            this.pnlDatosCliente.Controls.Add(this.lblDireccion);
            this.pnlDatosCliente.Controls.Add(this.lblNroCarnet);
            this.pnlDatosCliente.Controls.Add(this.lblCUIT);
            this.pnlDatosCliente.Location = new System.Drawing.Point(382, 58);
            this.pnlDatosCliente.Name = "pnlDatosCliente";
            this.pnlDatosCliente.Size = new System.Drawing.Size(300, 400);
            this.pnlDatosCliente.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Datos del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Consultas";
            // 
            // pnlConsultas
            // 
            this.pnlConsultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlConsultas.BackColor = System.Drawing.Color.Transparent;
            this.pnlConsultas.Controls.Add(this.txtBusquedaApellido);
            this.pnlConsultas.Controls.Add(this.label2);
            this.pnlConsultas.Controls.Add(this.txtBusquedaDireccion);
            this.pnlConsultas.Controls.Add(this.lblBusquedaApellido);
            this.pnlConsultas.Controls.Add(this.lblBusquedaDireccion);
            this.pnlConsultas.Controls.Add(this.btnLimpiar);
            this.pnlConsultas.Controls.Add(this.btnBuscar);
            this.pnlConsultas.Location = new System.Drawing.Point(5, 58);
            this.pnlConsultas.Name = "pnlConsultas";
            this.pnlConsultas.Size = new System.Drawing.Size(371, 134);
            this.pnlConsultas.TabIndex = 23;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.pnlCabecera.Controls.Add(this.lblGestionClientes);
            this.pnlCabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlCabecera.Location = new System.Drawing.Point(5, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(677, 52);
            this.pnlCabecera.TabIndex = 24;
            // 
            // FrmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlConsultas);
            this.Controls.Add(this.pnlDatosCliente);
            this.Controls.Add(this.dgwClientes);
            this.Name = "FrmGestionClientes";
            this.Text = "FrmGestionClientes";
            this.Load += new System.EventHandler(this.FrmGestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).EndInit();
            this.pnlDatosCliente.ResumeLayout(false);
            this.pnlDatosCliente.PerformLayout();
            this.pnlConsultas.ResumeLayout(false);
            this.pnlConsultas.PerformLayout();
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGestionClientes;
        private System.Windows.Forms.DataGridView dgwClientes;
        private System.Windows.Forms.Label lblValidNroCarnet;
        private System.Windows.Forms.Label lblValidCUIT;
        private System.Windows.Forms.Label lblValidDireccion;
        private System.Windows.Forms.Label lblValidDNI;
        private System.Windows.Forms.Label lblValidApellido;
        private System.Windows.Forms.Label lblValidNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNroCarnet;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNroCarnet;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBusquedaApellido;
        private System.Windows.Forms.TextBox txtBusquedaDireccion;
        private System.Windows.Forms.Label lblBusquedaApellido;
        private System.Windows.Forms.Label lblBusquedaDireccion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlDatosCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlConsultas;
        private System.Windows.Forms.Panel pnlCabecera;


    }
}