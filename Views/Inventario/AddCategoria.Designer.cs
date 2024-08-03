namespace PuntoDeVenta.Views
{
    partial class AddCategoria
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
            this.Categoria = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PuntoDeVenta.Properties.Resources.Color_rojo;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 76);
            this.panel3.TabIndex = 24;
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
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 69);
            this.label3.TabIndex = 0;
            this.label3.Text = "Agregar Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Categoria
            // 
            this.Categoria.BaseColor = System.Drawing.Color.White;
            this.Categoria.BorderColor = System.Drawing.Color.Silver;
            this.Categoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Categoria.FocusedBaseColor = System.Drawing.Color.White;
            this.Categoria.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Categoria.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Categoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Categoria.Location = new System.Drawing.Point(68, 49);
            this.Categoria.Name = "Categoria";
            this.Categoria.PasswordChar = '\0';
            this.Categoria.Size = new System.Drawing.Size(227, 32);
            this.Categoria.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(101, 131);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(157, 23);
            this.Guardar.TabIndex = 22;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Guardar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Categoria);
            this.panel1.Location = new System.Drawing.Point(43, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 181);
            this.panel1.TabIndex = 25;
            // 
            // AddCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "AddCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategoria";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox Categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Panel panel1;
    }
}