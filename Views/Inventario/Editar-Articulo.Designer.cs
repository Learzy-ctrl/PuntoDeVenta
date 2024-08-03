namespace PuntoDeVenta.Views
{
    partial class Editar_Articulo
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProveedorList = new System.Windows.Forms.ComboBox();
            this.CategoriaList = new System.Windows.Forms.ComboBox();
            this.SubirImagen = new System.Windows.Forms.Button();
            this.imgbox = new System.Windows.Forms.PictureBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioCompra = new Guna.UI.WinForms.GunaTextBox();
            this.PrecioVenta = new Guna.UI.WinForms.GunaTextBox();
            this.Stock = new Guna.UI.WinForms.GunaTextBox();
            this.Descripcion = new Guna.UI.WinForms.GunaTextBox();
            this.CodBarras = new Guna.UI.WinForms.GunaTextBox();
            this.NombreArticulo = new Guna.UI.WinForms.GunaTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::PuntoDeVenta.Properties.Resources.Color_rojo;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(-2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 76);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(666, 69);
            this.label3.TabIndex = 0;
            this.label3.Text = "Editar articulo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ProveedorList);
            this.panel1.Controls.Add(this.CategoriaList);
            this.panel1.Controls.Add(this.SubirImagen);
            this.panel1.Controls.Add(this.imgbox);
            this.panel1.Controls.Add(this.Guardar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PrecioCompra);
            this.panel1.Controls.Add(this.PrecioVenta);
            this.panel1.Controls.Add(this.Stock);
            this.panel1.Controls.Add(this.Descripcion);
            this.panel1.Controls.Add(this.CodBarras);
            this.panel1.Controls.Add(this.NombreArticulo);
            this.panel1.Location = new System.Drawing.Point(31, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 431);
            this.panel1.TabIndex = 20;
            // 
            // ProveedorList
            // 
            this.ProveedorList.FormattingEnabled = true;
            this.ProveedorList.Location = new System.Drawing.Point(293, 223);
            this.ProveedorList.Name = "ProveedorList";
            this.ProveedorList.Size = new System.Drawing.Size(227, 24);
            this.ProveedorList.TabIndex = 26;
            // 
            // CategoriaList
            // 
            this.CategoriaList.FormattingEnabled = true;
            this.CategoriaList.Location = new System.Drawing.Point(18, 223);
            this.CategoriaList.Name = "CategoriaList";
            this.CategoriaList.Size = new System.Drawing.Size(227, 24);
            this.CategoriaList.TabIndex = 25;
            // 
            // SubirImagen
            // 
            this.SubirImagen.Location = new System.Drawing.Point(564, 327);
            this.SubirImagen.Name = "SubirImagen";
            this.SubirImagen.Size = new System.Drawing.Size(265, 23);
            this.SubirImagen.TabIndex = 24;
            this.SubirImagen.Text = "Imagen";
            this.SubirImagen.UseVisualStyleBackColor = true;
            this.SubirImagen.Click += new System.EventHandler(this.SubirImagen_Click);
            // 
            // imgbox
            // 
            this.imgbox.Location = new System.Drawing.Point(564, 96);
            this.imgbox.Name = "imgbox";
            this.imgbox.Size = new System.Drawing.Size(265, 206);
            this.imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbox.TabIndex = 23;
            this.imgbox.TabStop = false;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(343, 391);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(157, 23);
            this.Guardar.TabIndex = 22;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Precio de Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio de Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Codigo de Barras:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.BaseColor = System.Drawing.Color.White;
            this.PrecioCompra.BorderColor = System.Drawing.Color.Silver;
            this.PrecioCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrecioCompra.FocusedBaseColor = System.Drawing.Color.White;
            this.PrecioCompra.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PrecioCompra.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PrecioCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrecioCompra.Location = new System.Drawing.Point(18, 125);
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.PasswordChar = '\0';
            this.PrecioCompra.Size = new System.Drawing.Size(227, 32);
            this.PrecioCompra.TabIndex = 8;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.BaseColor = System.Drawing.Color.White;
            this.PrecioVenta.BorderColor = System.Drawing.Color.Silver;
            this.PrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PrecioVenta.FocusedBaseColor = System.Drawing.Color.White;
            this.PrecioVenta.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PrecioVenta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PrecioVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrecioVenta.Location = new System.Drawing.Point(293, 125);
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.PasswordChar = '\0';
            this.PrecioVenta.Size = new System.Drawing.Size(227, 32);
            this.PrecioVenta.TabIndex = 7;
            // 
            // Stock
            // 
            this.Stock.BaseColor = System.Drawing.Color.White;
            this.Stock.BorderColor = System.Drawing.Color.Silver;
            this.Stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Stock.FocusedBaseColor = System.Drawing.Color.White;
            this.Stock.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Stock.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Stock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Stock.Location = new System.Drawing.Point(564, 38);
            this.Stock.Name = "Stock";
            this.Stock.PasswordChar = '\0';
            this.Stock.Size = new System.Drawing.Size(247, 32);
            this.Stock.TabIndex = 6;
            // 
            // Descripcion
            // 
            this.Descripcion.BaseColor = System.Drawing.Color.White;
            this.Descripcion.BorderColor = System.Drawing.Color.Silver;
            this.Descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Descripcion.FocusedBaseColor = System.Drawing.Color.White;
            this.Descripcion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Descripcion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Descripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Descripcion.Location = new System.Drawing.Point(18, 317);
            this.Descripcion.MultiLine = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.PasswordChar = '\0';
            this.Descripcion.Size = new System.Drawing.Size(276, 58);
            this.Descripcion.TabIndex = 5;
            // 
            // CodBarras
            // 
            this.CodBarras.BaseColor = System.Drawing.Color.White;
            this.CodBarras.BorderColor = System.Drawing.Color.Silver;
            this.CodBarras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodBarras.FocusedBaseColor = System.Drawing.Color.White;
            this.CodBarras.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CodBarras.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.CodBarras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CodBarras.Location = new System.Drawing.Point(293, 38);
            this.CodBarras.Name = "CodBarras";
            this.CodBarras.PasswordChar = '\0';
            this.CodBarras.Size = new System.Drawing.Size(227, 32);
            this.CodBarras.TabIndex = 4;
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.BaseColor = System.Drawing.Color.White;
            this.NombreArticulo.BorderColor = System.Drawing.Color.Silver;
            this.NombreArticulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreArticulo.FocusedBaseColor = System.Drawing.Color.White;
            this.NombreArticulo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NombreArticulo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.NombreArticulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NombreArticulo.Location = new System.Drawing.Point(18, 38);
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.PasswordChar = '\0';
            this.NombreArticulo.Size = new System.Drawing.Size(227, 32);
            this.NombreArticulo.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Editar_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Editar_Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar_Articulo";
            this.Load += new System.EventHandler(this.Editar_Articulo_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox PrecioCompra;
        private Guna.UI.WinForms.GunaTextBox PrecioVenta;
        private Guna.UI.WinForms.GunaTextBox Stock;
        private Guna.UI.WinForms.GunaTextBox Descripcion;
        private Guna.UI.WinForms.GunaTextBox CodBarras;
        private Guna.UI.WinForms.GunaTextBox NombreArticulo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.PictureBox imgbox;
        private System.Windows.Forms.Button SubirImagen;
        private System.Windows.Forms.ComboBox CategoriaList;
        private System.Windows.Forms.ComboBox ProveedorList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}