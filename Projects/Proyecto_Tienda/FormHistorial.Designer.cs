namespace Proyecto_Tienda
{
    partial class FormHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorial));
            this.labelRealizarBHistorial = new System.Windows.Forms.Label();
            this.textBoxEntradaHistorial = new System.Windows.Forms.TextBox();
            this.dataGridViewHistorial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIdVenta = new System.Windows.Forms.TextBox();
            this.textBoxIdEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxNombre_Producto = new System.Windows.Forms.TextBox();
            this.textBoxCosto_Producto = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.buttonActualFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRealizarBHistorial
            // 
            this.labelRealizarBHistorial.AutoSize = true;
            this.labelRealizarBHistorial.BackColor = System.Drawing.Color.Transparent;
            this.labelRealizarBHistorial.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRealizarBHistorial.Location = new System.Drawing.Point(12, 14);
            this.labelRealizarBHistorial.Name = "labelRealizarBHistorial";
            this.labelRealizarBHistorial.Size = new System.Drawing.Size(96, 13);
            this.labelRealizarBHistorial.TabIndex = 24;
            this.labelRealizarBHistorial.Text = "Realizar Búsqueda";
            // 
            // textBoxEntradaHistorial
            // 
            this.textBoxEntradaHistorial.Location = new System.Drawing.Point(114, 11);
            this.textBoxEntradaHistorial.Name = "textBoxEntradaHistorial";
            this.textBoxEntradaHistorial.Size = new System.Drawing.Size(227, 20);
            this.textBoxEntradaHistorial.TabIndex = 26;
            this.textBoxEntradaHistorial.TextChanged += new System.EventHandler(this.textBoxEntradaHistorial_TextChanged);
            // 
            // dataGridViewHistorial
            // 
            this.dataGridViewHistorial.AllowUserToAddRows = false;
            this.dataGridViewHistorial.AllowUserToDeleteRows = false;
            this.dataGridViewHistorial.AllowUserToResizeRows = false;
            this.dataGridViewHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistorial.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewHistorial.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewHistorial.Name = "dataGridViewHistorial";
            this.dataGridViewHistorial.ReadOnly = true;
            this.dataGridViewHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistorial.Size = new System.Drawing.Size(760, 239);
            this.dataGridViewHistorial.TabIndex = 27;
            this.dataGridViewHistorial.Click += new System.EventHandler(this.dataGridViewHistorial_Click);
            this.dataGridViewHistorial.DoubleClick += new System.EventHandler(this.dataGridViewHistorial_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(87, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "idVenta";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(68, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "idEmpleado";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(72, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "idProducto";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(81, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(23, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nombre del Producto";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(93, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(33, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Costo del Producto";
            // 
            // textBoxIdVenta
            // 
            this.textBoxIdVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxIdVenta.Location = new System.Drawing.Point(136, 282);
            this.textBoxIdVenta.Name = "textBoxIdVenta";
            this.textBoxIdVenta.Size = new System.Drawing.Size(227, 20);
            this.textBoxIdVenta.TabIndex = 35;
            this.textBoxIdVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdVenta_KeyPress);
            // 
            // textBoxIdEmpleado
            // 
            this.textBoxIdEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxIdEmpleado.Location = new System.Drawing.Point(136, 308);
            this.textBoxIdEmpleado.Name = "textBoxIdEmpleado";
            this.textBoxIdEmpleado.Size = new System.Drawing.Size(227, 20);
            this.textBoxIdEmpleado.TabIndex = 36;
            this.textBoxIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdEmpleado_KeyPress);
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxIdProducto.Location = new System.Drawing.Point(136, 334);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.Size = new System.Drawing.Size(227, 20);
            this.textBoxIdProducto.TabIndex = 37;
            this.textBoxIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdProducto_KeyPress);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCantidad.Location = new System.Drawing.Point(136, 360);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(227, 20);
            this.textBoxCantidad.TabIndex = 38;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // textBoxNombre_Producto
            // 
            this.textBoxNombre_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNombre_Producto.Location = new System.Drawing.Point(136, 386);
            this.textBoxNombre_Producto.Name = "textBoxNombre_Producto";
            this.textBoxNombre_Producto.Size = new System.Drawing.Size(227, 20);
            this.textBoxNombre_Producto.TabIndex = 39;
            this.textBoxNombre_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_Producto_KeyPress);
            // 
            // textBoxCosto_Producto
            // 
            this.textBoxCosto_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCosto_Producto.Location = new System.Drawing.Point(136, 438);
            this.textBoxCosto_Producto.Name = "textBoxCosto_Producto";
            this.textBoxCosto_Producto.Size = new System.Drawing.Size(227, 20);
            this.textBoxCosto_Producto.TabIndex = 41;
            this.textBoxCosto_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCosto_Producto_KeyPress);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAgregar.BackColor = System.Drawing.Color.Gold;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgregar.Location = new System.Drawing.Point(12, 526);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(166, 23);
            this.buttonAgregar.TabIndex = 42;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminar.Location = new System.Drawing.Point(356, 526);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(166, 23);
            this.buttonEliminar.TabIndex = 43;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModificar.BackColor = System.Drawing.Color.Cyan;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModificar.Location = new System.Drawing.Point(184, 526);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(166, 23);
            this.buttonModificar.TabIndex = 44;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(136, 412);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(227, 20);
            this.dateTimePickerFecha.TabIndex = 45;
            // 
            // buttonActualFecha
            // 
            this.buttonActualFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonActualFecha.BackColor = System.Drawing.SystemColors.Control;
            this.buttonActualFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonActualFecha.Location = new System.Drawing.Point(369, 410);
            this.buttonActualFecha.Name = "buttonActualFecha";
            this.buttonActualFecha.Size = new System.Drawing.Size(80, 23);
            this.buttonActualFecha.TabIndex = 46;
            this.buttonActualFecha.Text = "Fecha Actual";
            this.buttonActualFecha.UseVisualStyleBackColor = false;
            this.buttonActualFecha.Click += new System.EventHandler(this.buttonActualFecha_Click);
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonActualFecha);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxCosto_Producto);
            this.Controls.Add(this.textBoxNombre_Producto);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxIdProducto);
            this.Controls.Add(this.textBoxIdEmpleado);
            this.Controls.Add(this.textBoxIdVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHistorial);
            this.Controls.Add(this.textBoxEntradaHistorial);
            this.Controls.Add(this.labelRealizarBHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHistorial_FormClosing);
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRealizarBHistorial;
        private System.Windows.Forms.TextBox textBoxEntradaHistorial;
        private System.Windows.Forms.DataGridView dataGridViewHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIdVenta;
        private System.Windows.Forms.TextBox textBoxIdEmpleado;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxNombre_Producto;
        private System.Windows.Forms.TextBox textBoxCosto_Producto;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button buttonActualFecha;
    }
}