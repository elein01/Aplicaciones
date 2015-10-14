namespace lectura_escritura_archivos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lbArchivo = new System.Windows.Forms.Label();
            this.lvPersonas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(116, 108);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(116, 70);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // btnEscribir
            // 
            this.btnEscribir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEscribir.ImageIndex = 1;
            this.btnEscribir.ImageList = this.imageList1;
            this.btnEscribir.Location = new System.Drawing.Point(60, 167);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(188, 59);
            this.btnEscribir.TabIndex = 6;
            this.btnEscribir.Text = "Escribir en archivo";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "archivo-300x248.jpg");
            this.imageList1.Images.SetKeyName(1, "iso-file.png");
            // 
            // btnAbrir
            // 
            this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAbrir.ImageIndex = 0;
            this.btnAbrir.ImageList = this.imageList1;
            this.btnAbrir.Location = new System.Drawing.Point(585, 246);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(134, 53);
            this.btnAbrir.TabIndex = 7;
            this.btnAbrir.Text = "Abrir Archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lbArchivo
            // 
            this.lbArchivo.AutoSize = true;
            this.lbArchivo.Location = new System.Drawing.Point(218, 266);
            this.lbArchivo.Name = "lbArchivo";
            this.lbArchivo.Size = new System.Drawing.Size(99, 13);
            this.lbArchivo.TabIndex = 8;
            this.lbArchivo.Text = "Nombre del archivo";
            // 
            // lvPersonas
            // 
            this.lvPersonas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPersonas.GridLines = true;
            this.lvPersonas.Location = new System.Drawing.Point(272, 12);
            this.lvPersonas.Name = "lvPersonas";
            this.lvPersonas.Size = new System.Drawing.Size(397, 214);
            this.lvPersonas.TabIndex = 9;
            this.lvPersonas.UseCompatibleStateImageBehavior = false;
            this.lvPersonas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Direccion";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Edad";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Archivos de texto|*.txt";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(340, 266);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(220, 20);
            this.txtArchivo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 311);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.lvPersonas);
            this.Controls.Add(this.lbArchivo);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lbArchivo;
        private System.Windows.Forms.ListView lvPersonas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtArchivo;
    }
}

