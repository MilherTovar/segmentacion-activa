namespace Aplicacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cargar = new System.Windows.Forms.Button();
            this.segmentar = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.listado = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(24, 13);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(105, 28);
            this.cargar.TabIndex = 0;
            this.cargar.Text = "Cargar iamgen";
            this.cargar.UseVisualStyleBackColor = true;
            // 
            // segmentar
            // 
            this.segmentar.Location = new System.Drawing.Point(147, 15);
            this.segmentar.Name = "segmentar";
            this.segmentar.Size = new System.Drawing.Size(133, 25);
            this.segmentar.TabIndex = 1;
            this.segmentar.Text = "Segmentar";
            this.segmentar.UseVisualStyleBackColor = true;
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(27, 57);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(252, 184);
            this.imagen.TabIndex = 2;
            this.imagen.TabStop = false;
            // 
            // listado
            // 
            this.listado.FormattingEnabled = true;
            this.listado.Location = new System.Drawing.Point(307, 54);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(194, 186);
            this.listado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 282);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.segmentar);
            this.Controls.Add(this.cargar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Button segmentar;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.ListBox listado;
    }
}

