namespace Proyecto_Tienda
{
    partial class FormProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.labelRealizarBProducto = new System.Windows.Forms.Label();
            this.textBoxEntradaProductos = new System.Windows.Forms.TextBox();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.textBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.textBoxCostoVenta = new System.Windows.Forms.TextBox();
            this.textBoxExistencias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            this.dataGridViewProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(760, 239);
            this.dataGridViewProductos.TabIndex = 8;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            this.dataGridViewProductos.Click += new System.EventHandler(this.dataGridViewProductos_Click);
            this.dataGridViewProductos.DoubleClick += new System.EventHandler(this.dataGridViewProductos_DoubleClick);
            // 
            // labelRealizarBProducto
            // 
            this.labelRealizarBProducto.AutoSize = true;
            this.labelRealizarBProducto.BackColor = System.Drawing.Color.Transparent;
            this.labelRealizarBProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRealizarBProducto.Location = new System.Drawing.Point(12, 15);
            this.labelRealizarBProducto.Name = "labelRealizarBProducto";
            this.labelRealizarBProducto.Size = new System.Drawing.Size(96, 13);
            this.labelRealizarBProducto.TabIndex = 24;
            this.labelRealizarBProducto.Text = "Realizar Búsqueda";
            // 
            // textBoxEntradaProductos
            // 
            this.textBoxEntradaProductos.Location = new System.Drawing.Point(114, 12);
            this.textBoxEntradaProductos.Name = "textBoxEntradaProductos";
            this.textBoxEntradaProductos.Size = new System.Drawing.Size(227, 20);
            this.textBoxEntradaProductos.TabIndex = 27;
            this.textBoxEntradaProductos.TextChanged += new System.EventHandler(this.textBoxEntradaProductos_TextChanged);
            this.textBoxEntradaProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEntradaProductos_KeyPress);
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxIdProducto.Location = new System.Drawing.Point(136, 284);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.Size = new System.Drawing.Size(227, 20);
            this.textBoxIdProducto.TabIndex = 38;
            this.textBoxIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdProducto_KeyPress);
            // 
            // textBoxNombreProducto
            // 
            this.textBoxNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNombreProducto.Location = new System.Drawing.Point(136, 310);
            this.textBoxNombreProducto.Name = "textBoxNombreProducto";
            this.textBoxNombreProducto.Size = new System.Drawing.Size(227, 20);
            this.textBoxNombreProducto.TabIndex = 39;
            // 
            // textBoxCostoVenta
            // 
            this.textBoxCostoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCostoVenta.Location = new System.Drawing.Point(136, 336);
            this.textBoxCostoVenta.Name = "textBoxCostoVenta";
            this.textBoxCostoVenta.Size = new System.Drawing.Size(227, 20);
            this.textBoxCostoVenta.TabIndex = 40;
            this.textBoxCostoVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCostoVenta_KeyPress);
            // 
            // textBoxExistencias
            // 
            this.textBoxExistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxExistencias.Location = new System.Drawing.Point(136, 362);
            this.textBoxExistencias.Name = "textBoxExistencias";
            this.textBoxExistencias.Size = new System.Drawing.Size(227, 20);
            this.textBoxExistencias.TabIndex = 41;
            this.textBoxExistencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExistencias_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(33, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Costo del Producto";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(72, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "idProducto";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(23, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nombre del Producto";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(70, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Existencias";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAgregar.BackColor = System.Drawing.Color.Gold;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgregar.Location = new System.Drawing.Point(15, 526);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(166, 23);
            this.buttonAgregar.TabIndex = 55;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModificar.BackColor = System.Drawing.Color.Cyan;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModificar.Location = new System.Drawing.Point(187, 526);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(166, 23);
            this.buttonModificar.TabIndex = 56;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminar.Location = new System.Drawing.Point(359, 526);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(166, 23);
            this.buttonEliminar.TabIndex = 57;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxExistencias);
            this.Controls.Add(this.textBoxCostoVenta);
            this.Controls.Add(this.textBoxNombreProducto);
            this.Controls.Add(this.textBoxIdProducto);
            this.Controls.Add(this.textBoxEntradaProductos);
            this.Controls.Add(this.labelRealizarBProducto);
            this.Controls.Add(this.dataGridViewProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label labelRealizarBProducto;
        private System.Windows.Forms.TextBox textBoxEntradaProductos;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.TextBox textBoxNombreProducto;
        private System.Windows.Forms.TextBox textBoxCostoVenta;
        private System.Windows.Forms.TextBox textBoxExistencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}