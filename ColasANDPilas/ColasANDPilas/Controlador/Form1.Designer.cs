namespace ColasANDPilas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbTurnPila = new System.Windows.Forms.Label();
            this.lbTurnCola = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lisPila = new System.Windows.Forms.ListBox();
            this.lisCola = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "COLA";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(323, 185);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(52, 13);
            this.lbCantidad.TabIndex = 2;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // lbTurnPila
            // 
            this.lbTurnPila.AutoSize = true;
            this.lbTurnPila.Location = new System.Drawing.Point(9, 289);
            this.lbTurnPila.Name = "lbTurnPila";
            this.lbTurnPila.Size = new System.Drawing.Size(38, 13);
            this.lbTurnPila.TabIndex = 3;
            this.lbTurnPila.Text = "Turno:";
            // 
            // lbTurnCola
            // 
            this.lbTurnCola.AutoSize = true;
            this.lbTurnCola.Location = new System.Drawing.Point(165, 289);
            this.lbTurnCola.Name = "lbTurnCola";
            this.lbTurnCola.Size = new System.Drawing.Size(38, 13);
            this.lbTurnCola.TabIndex = 4;
            this.lbTurnCola.Text = "Turno:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(326, 78);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(149, 20);
            this.txtItem.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(365, 115);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(44, 322);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(214, 23);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lisPila
            // 
            this.lisPila.FormattingEnabled = true;
            this.lisPila.Location = new System.Drawing.Point(12, 62);
            this.lisPila.Name = "lisPila";
            this.lisPila.Size = new System.Drawing.Size(137, 212);
            this.lisPila.TabIndex = 8;
            // 
            // lisCola
            // 
            this.lisCola.FormattingEnabled = true;
            this.lisCola.Location = new System.Drawing.Point(168, 62);
            this.lisCola.Name = "lisCola";
            this.lisCola.Size = new System.Drawing.Size(137, 212);
            this.lisCola.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 368);
            this.Controls.Add(this.lisCola);
            this.Controls.Add(this.lisPila);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lbTurnCola);
            this.Controls.Add(this.lbTurnPila);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbTurnPila;
        private System.Windows.Forms.Label lbTurnCola;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ListBox lisPila;
        private System.Windows.Forms.ListBox lisCola;
    }
}

