namespace AplicaionWindowsForms
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnEscribirArchivo = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbNomArchivo = new System.Windows.Forms.Label();
            this.txtNomArchivo = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(12, 51);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(4, 88);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(55, 13);
            this.lbDireccion.TabIndex = 1;
            this.lbDireccion.Text = "Direccion:";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(12, 122);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(32, 13);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(65, 85);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(65, 119);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // btnEscribirArchivo
            // 
            this.btnEscribirArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscribirArchivo.ImageIndex = 1;
            this.btnEscribirArchivo.ImageList = this.imageList1;
            this.btnEscribirArchivo.Location = new System.Drawing.Point(26, 173);
            this.btnEscribirArchivo.Name = "btnEscribirArchivo";
            this.btnEscribirArchivo.Size = new System.Drawing.Size(130, 45);
            this.btnEscribirArchivo.TabIndex = 6;
            this.btnEscribirArchivo.Text = "Escribir Archivo";
            this.btnEscribirArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEscribirArchivo.UseVisualStyleBackColor = true;
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirArchivo.ImageIndex = 0;
            this.btnAbrirArchivo.ImageList = this.imageList1;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(412, 268);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(112, 46);
            this.btnAbrirArchivo.TabIndex = 7;
            this.btnAbrirArchivo.Text = "Abrir Archivo";
            this.btnAbrirArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(183, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(341, 242);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lbNomArchivo
            // 
            this.lbNomArchivo.AutoSize = true;
            this.lbNomArchivo.Location = new System.Drawing.Point(180, 282);
            this.lbNomArchivo.Name = "lbNomArchivo";
            this.lbNomArchivo.Size = new System.Drawing.Size(86, 13);
            this.lbNomArchivo.TabIndex = 9;
            this.lbNomArchivo.Text = "Nombre Archivo:";
            // 
            // txtNomArchivo
            // 
            this.txtNomArchivo.Enabled = false;
            this.txtNomArchivo.Location = new System.Drawing.Point(272, 277);
            this.txtNomArchivo.Name = "txtNomArchivo";
            this.txtNomArchivo.Size = new System.Drawing.Size(134, 20);
            this.txtNomArchivo.TabIndex = 10;
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
            this.openFileDialog1.Filter = "Archivo de texto|*.txt";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "archivo.png");
            this.imageList1.Images.SetKeyName(1, "escribir.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 326);
            this.Controls.Add(this.txtNomArchivo);
            this.Controls.Add(this.lbNomArchivo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.btnEscribirArchivo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnEscribirArchivo;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbNomArchivo;
        private System.Windows.Forms.TextBox txtNomArchivo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

