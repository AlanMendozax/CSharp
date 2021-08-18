namespace Proyecto_Tienda
{
    partial class FormApartados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApartados));
            this.dataGridViewApartados = new System.Windows.Forms.DataGridView();
            this.labelRealizarBApartados = new System.Windows.Forms.Label();
            this.textBoxEntradaApartados = new System.Windows.Forms.TextBox();
            this.textBoxIdApartado = new System.Windows.Forms.TextBox();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.textBoxNombre_Cliente = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxAbono_1 = new System.Windows.Forms.TextBox();
            this.textBoxAbono_2 = new System.Windows.Forms.TextBox();
            this.textBoxAbono_3 = new System.Windows.Forms.TextBox();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.textBoxResta = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApartados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewApartados
            // 
            this.dataGridViewApartados.AllowUserToAddRows = false;
            this.dataGridViewApartados.AllowUserToDeleteRows = false;
            this.dataGridViewApartados.AllowUserToResizeRows = false;
            this.dataGridViewApartados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewApartados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewApartados.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewApartados.Location = new System.Drawing.Point(15, 39);
            this.dataGridViewApartados.Name = "dataGridViewApartados";
            this.dataGridViewApartados.ReadOnly = true;
            this.dataGridViewApartados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewApartados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewApartados.Size = new System.Drawing.Size(760, 239);
            this.dataGridViewApartados.TabIndex = 7;
            this.dataGridViewApartados.Click += new System.EventHandler(this.dataGridViewApartados_Click);
            this.dataGridViewApartados.DoubleClick += new System.EventHandler(this.dataGridViewApartados_DoubleClick);
            // 
            // labelRealizarBApartados
            // 
            this.labelRealizarBApartados.AutoSize = true;
            this.labelRealizarBApartados.BackColor = System.Drawing.Color.Transparent;
            this.labelRealizarBApartados.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRealizarBApartados.Location = new System.Drawing.Point(12, 15);
            this.labelRealizarBApartados.Name = "labelRealizarBApartados";
            this.labelRealizarBApartados.Size = new System.Drawing.Size(96, 13);
            this.labelRealizarBApartados.TabIndex = 23;
            this.labelRealizarBApartados.Text = "Realizar Búsqueda";
            // 
            // textBoxEntradaApartados
            // 
            this.textBoxEntradaApartados.Location = new System.Drawing.Point(114, 12);
            this.textBoxEntradaApartados.Name = "textBoxEntradaApartados";
            this.textBoxEntradaApartados.Size = new System.Drawing.Size(227, 20);
            this.textBoxEntradaApartados.TabIndex = 25;
            this.textBoxEntradaApartados.TextChanged += new System.EventHandler(this.textBoxEntradaApartados_TextChanged);
            // 
            // textBoxIdApartado
            // 
            this.textBoxIdApartado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxIdApartado.Location = new System.Drawing.Point(136, 284);
            this.textBoxIdApartado.Name = "textBoxIdApartado";
            this.textBoxIdApartado.Size = new System.Drawing.Size(227, 20);
            this.textBoxIdApartado.TabIndex = 37;
            this.textBoxIdApartado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdApartado_KeyPress);
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxIdProducto.Location = new System.Drawing.Point(136, 310);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.Size = new System.Drawing.Size(227, 20);
            this.textBoxIdProducto.TabIndex = 38;
            this.textBoxIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdProducto_KeyPress);
            // 
            // textBoxNombre_Cliente
            // 
            this.textBoxNombre_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNombre_Cliente.Location = new System.Drawing.Point(136, 336);
            this.textBoxNombre_Cliente.Name = "textBoxNombre_Cliente";
            this.textBoxNombre_Cliente.Size = new System.Drawing.Size(227, 20);
            this.textBoxNombre_Cliente.TabIndex = 39;
            this.textBoxNombre_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_Cliente_KeyPress);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTelefono.Location = new System.Drawing.Point(136, 362);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(227, 20);
            this.textBoxTelefono.TabIndex = 40;
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            // 
            // textBoxAbono_1
            // 
            this.textBoxAbono_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAbono_1.Location = new System.Drawing.Point(136, 388);
            this.textBoxAbono_1.Name = "textBoxAbono_1";
            this.textBoxAbono_1.Size = new System.Drawing.Size(227, 20);
            this.textBoxAbono_1.TabIndex = 41;
            this.textBoxAbono_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAbono_1_KeyPress);
            // 
            // textBoxAbono_2
            // 
            this.textBoxAbono_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAbono_2.Location = new System.Drawing.Point(136, 414);
            this.textBoxAbono_2.Name = "textBoxAbono_2";
            this.textBoxAbono_2.Size = new System.Drawing.Size(227, 20);
            this.textBoxAbono_2.TabIndex = 42;
            this.textBoxAbono_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAbono_2_KeyPress);
            // 
            // textBoxAbono_3
            // 
            this.textBoxAbono_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAbono_3.Location = new System.Drawing.Point(136, 440);
            this.textBoxAbono_3.Name = "textBoxAbono_3";
            this.textBoxAbono_3.Size = new System.Drawing.Size(227, 20);
            this.textBoxAbono_3.TabIndex = 43;
            this.textBoxAbono_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAbono_3_KeyPress);
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxImporte.Location = new System.Drawing.Point(136, 466);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(227, 20);
            this.textBoxImporte.TabIndex = 44;
            this.textBoxImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImporte_KeyPress);
            // 
            // textBoxResta
            // 
            this.textBoxResta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxResta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxResta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResta.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxResta.Location = new System.Drawing.Point(136, 492);
            this.textBoxResta.Name = "textBoxResta";
            this.textBoxResta.ReadOnly = true;
            this.textBoxResta.Size = new System.Drawing.Size(227, 20);
            this.textBoxResta.TabIndex = 0;
            this.textBoxResta.TabStop = false;
            this.textBoxResta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxResta_KeyPress);
            this.textBoxResta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxResta_KeyUp);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxTotal.Location = new System.Drawing.Point(548, 284);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(227, 20);
            this.textBoxTotal.TabIndex = 0;
            this.textBoxTotal.TabStop = false;
            this.textBoxTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTotal_KeyPress);
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxComentario.Location = new System.Drawing.Point(548, 310);
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(227, 20);
            this.textBoxComentario.TabIndex = 47;
            this.textBoxComentario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxComentario_KeyPress);
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
            this.label1.TabIndex = 48;
            this.label1.Text = "idApartado";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(72, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "idProducto";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(34, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nombre del Cliente";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(81, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(77, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "1.- Abono";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(77, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "2.- Abono";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(77, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "3.- Abono";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(88, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Importe";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(95, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Resta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(472, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Total a pagar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(482, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Comentario";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAgregar.BackColor = System.Drawing.Color.Gold;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgregar.Location = new System.Drawing.Point(15, 526);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(166, 23);
            this.buttonAgregar.TabIndex = 59;
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
            this.buttonModificar.TabIndex = 60;
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
            this.buttonEliminar.TabIndex = 61;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // FormApartados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxResta);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.textBoxAbono_3);
            this.Controls.Add(this.textBoxAbono_2);
            this.Controls.Add(this.textBoxAbono_1);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxNombre_Cliente);
            this.Controls.Add(this.textBoxIdProducto);
            this.Controls.Add(this.textBoxIdApartado);
            this.Controls.Add(this.textBoxEntradaApartados);
            this.Controls.Add(this.labelRealizarBApartados);
            this.Controls.Add(this.dataGridViewApartados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormApartados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartados";
            this.Load += new System.EventHandler(this.FormApartados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApartados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewApartados;
        private System.Windows.Forms.Label labelRealizarBApartados;
        private System.Windows.Forms.TextBox textBoxEntradaApartados;
        private System.Windows.Forms.TextBox textBoxIdApartado;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.TextBox textBoxNombre_Cliente;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxAbono_1;
        private System.Windows.Forms.TextBox textBoxAbono_2;
        private System.Windows.Forms.TextBox textBoxAbono_3;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.TextBox textBoxResta;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}