namespace AnimacionCirculo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearCirculo = new System.Windows.Forms.Button();
            this.chkAnimacion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 254);
            this.panel1.TabIndex = 0;
            // 
            // btnCrearCirculo
            // 
            this.btnCrearCirculo.Location = new System.Drawing.Point(47, 281);
            this.btnCrearCirculo.Name = "btnCrearCirculo";
            this.btnCrearCirculo.Size = new System.Drawing.Size(101, 30);
            this.btnCrearCirculo.TabIndex = 1;
            this.btnCrearCirculo.Text = "Crear Circulo";
            this.btnCrearCirculo.UseVisualStyleBackColor = true;
            this.btnCrearCirculo.Click += new System.EventHandler(this.btnCrearCirculo_Click);
            // 
            // chkAnimacion
            // 
            this.chkAnimacion.AutoSize = true;
            this.chkAnimacion.Location = new System.Drawing.Point(236, 289);
            this.chkAnimacion.Name = "chkAnimacion";
            this.chkAnimacion.Size = new System.Drawing.Size(75, 17);
            this.chkAnimacion.TabIndex = 2;
            this.chkAnimacion.Text = "Animacion";
            this.chkAnimacion.UseVisualStyleBackColor = true;
            this.chkAnimacion.CheckedChanged += new System.EventHandler(this.chkAnimacion_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 324);
            this.Controls.Add(this.chkAnimacion);
            this.Controls.Add(this.btnCrearCirculo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearCirculo;
        private System.Windows.Forms.CheckBox chkAnimacion;
    }
}

