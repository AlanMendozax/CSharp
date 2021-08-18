namespace Proyecto_Tienda
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStripOpciones = new System.Windows.Forms.MenuStrip();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verApartadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPersonal = new System.Windows.Forms.Button();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.buttonVenta = new System.Windows.Forms.Button();
            this.dataGridViewTablas = new System.Windows.Forms.DataGridView();
            this.buttonApartados = new System.Windows.Forms.Button();
            this.labelVenta = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.labelApartados = new System.Windows.Forms.Label();
            this.labelPersonal = new System.Windows.Forms.Label();
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.labelVentanaVenta = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelTotalDeLaVenta = new System.Windows.Forms.Label();
            this.labelSumaVenta = new System.Windows.Forms.Label();
            this.labelTablaActual = new System.Windows.Forms.Label();
            this.labelRealizarB = new System.Windows.Forms.Label();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.labelEmpleadoSel = new System.Windows.Forms.Label();
            this.menuStripOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripOpciones
            // 
            this.menuStripOpciones.BackColor = System.Drawing.Color.DarkGray;
            this.menuStripOpciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStripOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuStripOpciones.Name = "menuStripOpciones";
            this.menuStripOpciones.Size = new System.Drawing.Size(884, 24);
            this.menuStripOpciones.TabIndex = 0;
            this.menuStripOpciones.Text = "menuStripOpciones";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.reporteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verHistorialToolStripMenuItem});
            this.registrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            this.registrosToolStripMenuItem.Click += new System.EventHandler(this.registrosToolStripMenuItem_Click);
            // 
            // verHistorialToolStripMenuItem
            // 
            this.verHistorialToolStripMenuItem.Name = "verHistorialToolStripMenuItem";
            this.verHistorialToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.verHistorialToolStripMenuItem.Text = "Ver Historial";
            this.verHistorialToolStripMenuItem.Click += new System.EventHandler(this.verHistorialToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarProductosToolStripMenuItem,
            this.verApartadosToolStripMenuItem,
            this.historialDeVentaToolStripMenuItem1});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.inventarioToolStripMenuItem.Text = "Datos";
            // 
            // administrarProductosToolStripMenuItem
            // 
            this.administrarProductosToolStripMenuItem.Name = "administrarProductosToolStripMenuItem";
            this.administrarProductosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.administrarProductosToolStripMenuItem.Text = "Productos";
            this.administrarProductosToolStripMenuItem.Click += new System.EventHandler(this.administrarProductosToolStripMenuItem_Click);
            // 
            // verApartadosToolStripMenuItem
            // 
            this.verApartadosToolStripMenuItem.Name = "verApartadosToolStripMenuItem";
            this.verApartadosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.verApartadosToolStripMenuItem.Text = "Apartados";
            this.verApartadosToolStripMenuItem.Click += new System.EventHandler(this.verApartadosToolStripMenuItem_Click);
            // 
            // historialDeVentaToolStripMenuItem1
            // 
            this.historialDeVentaToolStripMenuItem1.Name = "historialDeVentaToolStripMenuItem1";
            this.historialDeVentaToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.historialDeVentaToolStripMenuItem1.Text = "Historial de Venta";
            this.historialDeVentaToolStripMenuItem1.Click += new System.EventHandler(this.historialDeVentaToolStripMenuItem1_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualTablaToolStripMenuItem});
            this.exportarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // actualTablaToolStripMenuItem
            // 
            this.actualTablaToolStripMenuItem.Name = "actualTablaToolStripMenuItem";
            this.actualTablaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.actualTablaToolStripMenuItem.Text = "Actual Tabla";
            this.actualTablaToolStripMenuItem.Click += new System.EventHandler(this.actualTablaToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPersonalToolStripMenuItem});
            this.seguridadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // administrarPersonalToolStripMenuItem
            // 
            this.administrarPersonalToolStripMenuItem.Name = "administrarPersonalToolStripMenuItem";
            this.administrarPersonalToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.administrarPersonalToolStripMenuItem.Text = "Administrar Personal";
            this.administrarPersonalToolStripMenuItem.Click += new System.EventHandler(this.administrarPersonalToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.BackColor = System.Drawing.Color.Transparent;
            this.buttonPersonal.BackgroundImage = global::Proyecto_Tienda.Properties.Resources._029_clerk;
            this.buttonPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPersonal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPersonal.Location = new System.Drawing.Point(13, 383);
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Size = new System.Drawing.Size(98, 98);
            this.buttonPersonal.TabIndex = 5;
            this.buttonPersonal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonPersonal.UseVisualStyleBackColor = false;
            this.buttonPersonal.Click += new System.EventHandler(this.buttonPersonal_Click);
            // 
            // buttonProductos
            // 
            this.buttonProductos.BackColor = System.Drawing.Color.Transparent;
            this.buttonProductos.BackgroundImage = global::Proyecto_Tienda.Properties.Resources._025_package;
            this.buttonProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonProductos.Location = new System.Drawing.Point(12, 144);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(98, 98);
            this.buttonProductos.TabIndex = 2;
            this.buttonProductos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonProductos.UseVisualStyleBackColor = false;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // buttonVenta
            // 
            this.buttonVenta.BackColor = System.Drawing.Color.Transparent;
            this.buttonVenta.BackgroundImage = global::Proyecto_Tienda.Properties.Resources._022_money;
            this.buttonVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVenta.Location = new System.Drawing.Point(12, 27);
            this.buttonVenta.Name = "buttonVenta";
            this.buttonVenta.Size = new System.Drawing.Size(98, 98);
            this.buttonVenta.TabIndex = 1;
            this.buttonVenta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonVenta.UseVisualStyleBackColor = false;
            this.buttonVenta.Click += new System.EventHandler(this.buttonVenta_Click);
            // 
            // dataGridViewTablas
            // 
            this.dataGridViewTablas.AllowUserToAddRows = false;
            this.dataGridViewTablas.AllowUserToDeleteRows = false;
            this.dataGridViewTablas.AllowUserToResizeRows = false;
            this.dataGridViewTablas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTablas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTablas.Location = new System.Drawing.Point(116, 68);
            this.dataGridViewTablas.Name = "dataGridViewTablas";
            this.dataGridViewTablas.ReadOnly = true;
            this.dataGridViewTablas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTablas.Size = new System.Drawing.Size(756, 233);
            this.dataGridViewTablas.TabIndex = 6;
            this.dataGridViewTablas.DataSourceChanged += new System.EventHandler(this.dataGridViewTablas_DataSourceChanged);
            this.dataGridViewTablas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTablas_CellContentClick);
            this.dataGridViewTablas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTablas_CellDoubleClick);
            this.dataGridViewTablas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTablas_CellMouseClick);
            this.dataGridViewTablas.DoubleClick += new System.EventHandler(this.dataGridViewTablas_DoubleClick);
            // 
            // buttonApartados
            // 
            this.buttonApartados.BackColor = System.Drawing.Color.Transparent;
            this.buttonApartados.BackgroundImage = global::Proyecto_Tienda.Properties.Resources._008_phone_call;
            this.buttonApartados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApartados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApartados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonApartados.Location = new System.Drawing.Point(15, 266);
            this.buttonApartados.Name = "buttonApartados";
            this.buttonApartados.Size = new System.Drawing.Size(98, 98);
            this.buttonApartados.TabIndex = 4;
            this.buttonApartados.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonApartados.UseVisualStyleBackColor = false;
            this.buttonApartados.Click += new System.EventHandler(this.buttonApartados_Click);
            // 
            // labelVenta
            // 
            this.labelVenta.AutoSize = true;
            this.labelVenta.BackColor = System.Drawing.Color.Transparent;
            this.labelVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVenta.Location = new System.Drawing.Point(24, 128);
            this.labelVenta.Name = "labelVenta";
            this.labelVenta.Size = new System.Drawing.Size(76, 13);
            this.labelVenta.TabIndex = 7;
            this.labelVenta.Text = "Realizar Venta";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.BackColor = System.Drawing.Color.Transparent;
            this.labelProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProductos.Location = new System.Drawing.Point(36, 245);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(55, 13);
            this.labelProductos.TabIndex = 9;
            this.labelProductos.Text = "Productos";
            // 
            // labelApartados
            // 
            this.labelApartados.AutoSize = true;
            this.labelApartados.BackColor = System.Drawing.Color.Transparent;
            this.labelApartados.ForeColor = System.Drawing.SystemColors.Control;
            this.labelApartados.Location = new System.Drawing.Point(36, 367);
            this.labelApartados.Name = "labelApartados";
            this.labelApartados.Size = new System.Drawing.Size(55, 13);
            this.labelApartados.TabIndex = 10;
            this.labelApartados.Text = "Apartados";
            // 
            // labelPersonal
            // 
            this.labelPersonal.AutoSize = true;
            this.labelPersonal.BackColor = System.Drawing.Color.Transparent;
            this.labelPersonal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPersonal.Location = new System.Drawing.Point(36, 484);
            this.labelPersonal.Name = "labelPersonal";
            this.labelPersonal.Size = new System.Drawing.Size(48, 13);
            this.labelPersonal.TabIndex = 11;
            this.labelPersonal.Text = "Personal";
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(221, 28);
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(227, 20);
            this.textBoxEntrada.TabIndex = 14;
            this.textBoxEntrada.TextChanged += new System.EventHandler(this.textBoxEntrada_TextChanged);
            this.textBoxEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEntrada_KeyPress);
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.AllowUserToAddRows = false;
            this.dataGridViewVenta.AllowUserToDeleteRows = false;
            this.dataGridViewVenta.AllowUserToResizeRows = false;
            this.dataGridViewVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVenta.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewVenta.Location = new System.Drawing.Point(116, 320);
            this.dataGridViewVenta.MultiSelect = false;
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.ReadOnly = true;
            this.dataGridViewVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVenta.Size = new System.Drawing.Size(756, 161);
            this.dataGridViewVenta.TabIndex = 17;
            this.dataGridViewVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVenta_CellClick);
            this.dataGridViewVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVenta_CellContentClick);
            this.dataGridViewVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVenta_CellDoubleClick);
            this.dataGridViewVenta.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewVenta_RowsAdded);
            // 
            // labelVentanaVenta
            // 
            this.labelVentanaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVentanaVenta.AutoSize = true;
            this.labelVentanaVenta.BackColor = System.Drawing.Color.Transparent;
            this.labelVentanaVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVentanaVenta.Location = new System.Drawing.Point(119, 304);
            this.labelVentanaVenta.Name = "labelVentanaVenta";
            this.labelVentanaVenta.Size = new System.Drawing.Size(93, 13);
            this.labelVentanaVenta.TabIndex = 18;
            this.labelVentanaVenta.Text = "Ventana de Venta";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelTotalDeLaVenta
            // 
            this.labelTotalDeLaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalDeLaVenta.AutoSize = true;
            this.labelTotalDeLaVenta.BackColor = System.Drawing.Color.DimGray;
            this.labelTotalDeLaVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalDeLaVenta.Location = new System.Drawing.Point(117, 484);
            this.labelTotalDeLaVenta.Name = "labelTotalDeLaVenta";
            this.labelTotalDeLaVenta.Size = new System.Drawing.Size(118, 13);
            this.labelTotalDeLaVenta.TabIndex = 19;
            this.labelTotalDeLaVenta.Text = "TOTAL DE LA VENTA:";
            // 
            // labelSumaVenta
            // 
            this.labelSumaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSumaVenta.AutoSize = true;
            this.labelSumaVenta.BackColor = System.Drawing.Color.DimGray;
            this.labelSumaVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSumaVenta.Location = new System.Drawing.Point(241, 484);
            this.labelSumaVenta.Name = "labelSumaVenta";
            this.labelSumaVenta.Size = new System.Drawing.Size(33, 13);
            this.labelSumaVenta.TabIndex = 20;
            this.labelSumaVenta.Text = "Nada";
            // 
            // labelTablaActual
            // 
            this.labelTablaActual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTablaActual.AutoSize = true;
            this.labelTablaActual.BackColor = System.Drawing.Color.Transparent;
            this.labelTablaActual.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTablaActual.Location = new System.Drawing.Point(117, 52);
            this.labelTablaActual.Name = "labelTablaActual";
            this.labelTablaActual.Size = new System.Drawing.Size(113, 13);
            this.labelTablaActual.TabIndex = 21;
            this.labelTablaActual.Text = "Tabla Actual: Ninguna";
            // 
            // labelRealizarB
            // 
            this.labelRealizarB.AutoSize = true;
            this.labelRealizarB.BackColor = System.Drawing.Color.Transparent;
            this.labelRealizarB.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRealizarB.Location = new System.Drawing.Point(119, 31);
            this.labelRealizarB.Name = "labelRealizarB";
            this.labelRealizarB.Size = new System.Drawing.Size(96, 13);
            this.labelRealizarB.TabIndex = 22;
            this.labelRealizarB.Text = "Realizar Búsqueda";
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(770, 28);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(102, 21);
            this.comboBoxEmpleados.TabIndex = 23;
            // 
            // labelEmpleadoSel
            // 
            this.labelEmpleadoSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmpleadoSel.AutoSize = true;
            this.labelEmpleadoSel.BackColor = System.Drawing.Color.Transparent;
            this.labelEmpleadoSel.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEmpleadoSel.Location = new System.Drawing.Point(710, 31);
            this.labelEmpleadoSel.Name = "labelEmpleadoSel";
            this.labelEmpleadoSel.Size = new System.Drawing.Size(54, 13);
            this.labelEmpleadoSel.TabIndex = 24;
            this.labelEmpleadoSel.Text = "Empleado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.labelEmpleadoSel);
            this.Controls.Add(this.comboBoxEmpleados);
            this.Controls.Add(this.labelRealizarB);
            this.Controls.Add(this.labelTablaActual);
            this.Controls.Add(this.labelSumaVenta);
            this.Controls.Add(this.labelTotalDeLaVenta);
            this.Controls.Add(this.labelVentanaVenta);
            this.Controls.Add(this.textBoxEntrada);
            this.Controls.Add(this.labelPersonal);
            this.Controls.Add(this.labelApartados);
            this.Controls.Add(this.labelProductos);
            this.Controls.Add(this.labelVenta);
            this.Controls.Add(this.buttonApartados);
            this.Controls.Add(this.buttonVenta);
            this.Controls.Add(this.buttonProductos);
            this.Controls.Add(this.buttonPersonal);
            this.Controls.Add(this.menuStripOpciones);
            this.Controls.Add(this.dataGridViewTablas);
            this.Controls.Add(this.dataGridViewVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripOpciones;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novedades German";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripOpciones.ResumeLayout(false);
            this.menuStripOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripOpciones;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button buttonPersonal;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Button buttonVenta;
        private System.Windows.Forms.DataGridView dataGridViewTablas;
        private System.Windows.Forms.Button buttonApartados;
        private System.Windows.Forms.Label labelVenta;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Label labelApartados;
        private System.Windows.Forms.Label labelPersonal;
        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.Label labelVentanaVenta;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualTablaToolStripMenuItem;
        private System.Windows.Forms.Label labelSumaVenta;
        private System.Windows.Forms.Label labelTotalDeLaVenta;
        private System.Windows.Forms.Label labelTablaActual;
        private System.Windows.Forms.Label labelRealizarB;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verApartadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verHistorialToolStripMenuItem;
        private System.Windows.Forms.Label labelEmpleadoSel;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
    }
}

