namespace DragandDrog
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
            this.lisDestino = new System.Windows.Forms.ListBox();
            this.lisOrigen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lisDestino
            // 
            this.lisDestino.AllowDrop = true;
            this.lisDestino.FormattingEnabled = true;
            this.lisDestino.Location = new System.Drawing.Point(13, 13);
            this.lisDestino.Name = "lisDestino";
            this.lisDestino.Size = new System.Drawing.Size(120, 225);
            this.lisDestino.TabIndex = 0;
            this.lisDestino.DragDrop += new System.Windows.Forms.DragEventHandler(this.lisDestino_DragDrop);
            this.lisDestino.DragOver += new System.Windows.Forms.DragEventHandler(this.lisDestino_DragOver);
            this.lisDestino.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lisDestino_MouseDown);
            // 
            // lisOrigen
            // 
            this.lisOrigen.AllowDrop = true;
            this.lisOrigen.FormattingEnabled = true;
            this.lisOrigen.Location = new System.Drawing.Point(159, 13);
            this.lisOrigen.Name = "lisOrigen";
            this.lisOrigen.Size = new System.Drawing.Size(120, 225);
            this.lisOrigen.TabIndex = 1;
            this.lisOrigen.DragDrop += new System.Windows.Forms.DragEventHandler(this.lisOrigen_DragDrop);
            this.lisOrigen.DragOver += new System.Windows.Forms.DragEventHandler(this.lisOrigen_DragOver);
            this.lisOrigen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lisOrigen_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 266);
            this.Controls.Add(this.lisOrigen);
            this.Controls.Add(this.lisDestino);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lisDestino;
        private System.Windows.Forms.ListBox lisOrigen;
    }
}

