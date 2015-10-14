namespace TorresHanoi
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
            this.cmbDiscos = new System.Windows.Forms.ComboBox();
            this.Torre1 = new System.Windows.Forms.ListBox();
            this.Torre2 = new System.Windows.Forms.ListBox();
            this.Torre3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMovimientos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discos";
            // 
            // cmbDiscos
            // 
            this.cmbDiscos.FormattingEnabled = true;
            this.cmbDiscos.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cmbDiscos.Location = new System.Drawing.Point(66, 56);
            this.cmbDiscos.Name = "cmbDiscos";
            this.cmbDiscos.Size = new System.Drawing.Size(83, 21);
            this.cmbDiscos.TabIndex = 1;
            this.cmbDiscos.SelectedIndexChanged += new System.EventHandler(this.cmbDiscos_SelectedIndexChanged);
            // 
            // Torre1
            // 
            this.Torre1.AllowDrop = true;
            this.Torre1.BackColor = System.Drawing.Color.MediumPurple;
            this.Torre1.FormattingEnabled = true;
            this.Torre1.Location = new System.Drawing.Point(27, 103);
            this.Torre1.Name = "Torre1";
            this.Torre1.Size = new System.Drawing.Size(120, 173);
            this.Torre1.TabIndex = 2;
            this.Torre1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Torre1_DragDrop);
            this.Torre1.DragOver += new System.Windows.Forms.DragEventHandler(this.Torre1_DragOver);
            this.Torre1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Torre1_MouseDown);
            // 
            // Torre2
            // 
            this.Torre2.AllowDrop = true;
            this.Torre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Torre2.FormattingEnabled = true;
            this.Torre2.Location = new System.Drawing.Point(160, 103);
            this.Torre2.Name = "Torre2";
            this.Torre2.Size = new System.Drawing.Size(120, 173);
            this.Torre2.TabIndex = 3;
            this.Torre2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Torre2_DragDrop);
            this.Torre2.DragOver += new System.Windows.Forms.DragEventHandler(this.Torre2_DragOver);
            this.Torre2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Torre2_MouseDown);
            // 
            // Torre3
            // 
            this.Torre3.AllowDrop = true;
            this.Torre3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Torre3.FormattingEnabled = true;
            this.Torre3.Location = new System.Drawing.Point(297, 103);
            this.Torre3.Name = "Torre3";
            this.Torre3.Size = new System.Drawing.Size(120, 173);
            this.Torre3.TabIndex = 4;
            this.Torre3.DragDrop += new System.Windows.Forms.DragEventHandler(this.Torre3_DragDrop);
            this.Torre3.DragOver += new System.Windows.Forms.DragEventHandler(this.Torre3_DragOver);
            this.Torre3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Torre3_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Movimientos:";
            // 
            // lbMovimientos
            // 
            this.lbMovimientos.AutoSize = true;
            this.lbMovimientos.Location = new System.Drawing.Point(245, 307);
            this.lbMovimientos.Name = "lbMovimientos";
            this.lbMovimientos.Size = new System.Drawing.Size(61, 13);
            this.lbMovimientos.TabIndex = 6;
            this.lbMovimientos.Text = "_________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "TORRES DE HANOI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(450, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMovimientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Torre3);
            this.Controls.Add(this.Torre2);
            this.Controls.Add(this.Torre1);
            this.Controls.Add(this.cmbDiscos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDiscos;
        private System.Windows.Forms.ListBox Torre1;
        private System.Windows.Forms.ListBox Torre2;
        private System.Windows.Forms.ListBox Torre3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMovimientos;
        private System.Windows.Forms.Label label3;
    }
}

