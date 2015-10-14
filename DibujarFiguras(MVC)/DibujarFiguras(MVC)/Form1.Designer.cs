namespace DibujarFiguras_MVC_
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
            this.grpFiguras = new System.Windows.Forms.GroupBox();
            this.rdCirculo = new System.Windows.Forms.RadioButton();
            this.rdRectangulo = new System.Windows.Forms.RadioButton();
            this.grpRectangulo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbResAreaRec = new System.Windows.Forms.Label();
            this.txtP2y = new System.Windows.Forms.TextBox();
            this.txtP2x = new System.Windows.Forms.TextBox();
            this.txtP1y = new System.Windows.Forms.TextBox();
            this.txtP1x = new System.Windows.Forms.TextBox();
            this.lbAreaRec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCirculo = new System.Windows.Forms.GroupBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAreaCir = new System.Windows.Forms.Label();
            this.txtPy = new System.Windows.Forms.TextBox();
            this.txtPx = new System.Windows.Forms.TextBox();
            this.lbResAreaCirc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrae = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.grpFiguras.SuspendLayout();
            this.grpRectangulo.SuspendLayout();
            this.grpCirculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFiguras
            // 
            this.grpFiguras.Controls.Add(this.rdCirculo);
            this.grpFiguras.Controls.Add(this.rdRectangulo);
            this.grpFiguras.Location = new System.Drawing.Point(12, 12);
            this.grpFiguras.Name = "grpFiguras";
            this.grpFiguras.Size = new System.Drawing.Size(176, 185);
            this.grpFiguras.TabIndex = 0;
            this.grpFiguras.TabStop = false;
            this.grpFiguras.Text = "Figuras";
            // 
            // rdCirculo
            // 
            this.rdCirculo.AutoSize = true;
            this.rdCirculo.Location = new System.Drawing.Point(19, 86);
            this.rdCirculo.Name = "rdCirculo";
            this.rdCirculo.Size = new System.Drawing.Size(54, 17);
            this.rdCirculo.TabIndex = 1;
            this.rdCirculo.TabStop = true;
            this.rdCirculo.Text = "Ciculo";
            this.rdCirculo.UseVisualStyleBackColor = true;
            this.rdCirculo.CheckedChanged += new System.EventHandler(this.rdCirculo_CheckedChanged);
            // 
            // rdRectangulo
            // 
            this.rdRectangulo.AutoSize = true;
            this.rdRectangulo.Location = new System.Drawing.Point(19, 44);
            this.rdRectangulo.Name = "rdRectangulo";
            this.rdRectangulo.Size = new System.Drawing.Size(80, 17);
            this.rdRectangulo.TabIndex = 0;
            this.rdRectangulo.TabStop = true;
            this.rdRectangulo.Text = "Rectangulo";
            this.rdRectangulo.UseVisualStyleBackColor = true;
            this.rdRectangulo.CheckedChanged += new System.EventHandler(this.rdRectangulo_CheckedChanged);
            // 
            // grpRectangulo
            // 
            this.grpRectangulo.Controls.Add(this.label8);
            this.grpRectangulo.Controls.Add(this.label5);
            this.grpRectangulo.Controls.Add(this.lbResAreaRec);
            this.grpRectangulo.Controls.Add(this.txtP2y);
            this.grpRectangulo.Controls.Add(this.txtP2x);
            this.grpRectangulo.Controls.Add(this.txtP1y);
            this.grpRectangulo.Controls.Add(this.txtP1x);
            this.grpRectangulo.Controls.Add(this.lbAreaRec);
            this.grpRectangulo.Controls.Add(this.label4);
            this.grpRectangulo.Controls.Add(this.label3);
            this.grpRectangulo.Controls.Add(this.label2);
            this.grpRectangulo.Controls.Add(this.label1);
            this.grpRectangulo.Location = new System.Drawing.Point(12, 220);
            this.grpRectangulo.Name = "grpRectangulo";
            this.grpRectangulo.Size = new System.Drawing.Size(223, 226);
            this.grpRectangulo.TabIndex = 1;
            this.grpRectangulo.TabStop = false;
            this.grpRectangulo.Text = "Rectangulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "X";
            // 
            // lbResAreaRec
            // 
            this.lbResAreaRec.AutoSize = true;
            this.lbResAreaRec.Location = new System.Drawing.Point(57, 153);
            this.lbResAreaRec.Name = "lbResAreaRec";
            this.lbResAreaRec.Size = new System.Drawing.Size(67, 13);
            this.lbResAreaRec.TabIndex = 11;
            this.lbResAreaRec.Text = "__________";
            // 
            // txtP2y
            // 
            this.txtP2y.Location = new System.Drawing.Point(162, 89);
            this.txtP2y.Name = "txtP2y";
            this.txtP2y.Size = new System.Drawing.Size(43, 20);
            this.txtP2y.TabIndex = 8;
            // 
            // txtP2x
            // 
            this.txtP2x.Location = new System.Drawing.Point(60, 89);
            this.txtP2x.Name = "txtP2x";
            this.txtP2x.Size = new System.Drawing.Size(43, 20);
            this.txtP2x.TabIndex = 7;
            // 
            // txtP1y
            // 
            this.txtP1y.Location = new System.Drawing.Point(162, 47);
            this.txtP1y.Name = "txtP1y";
            this.txtP1y.Size = new System.Drawing.Size(43, 20);
            this.txtP1y.TabIndex = 6;
            // 
            // txtP1x
            // 
            this.txtP1x.Location = new System.Drawing.Point(60, 47);
            this.txtP1x.Name = "txtP1x";
            this.txtP1x.Size = new System.Drawing.Size(43, 20);
            this.txtP1x.TabIndex = 5;
            // 
            // lbAreaRec
            // 
            this.lbAreaRec.AutoSize = true;
            this.lbAreaRec.Location = new System.Drawing.Point(16, 153);
            this.lbAreaRec.Name = "lbAreaRec";
            this.lbAreaRec.Size = new System.Drawing.Size(35, 13);
            this.lbAreaRec.TabIndex = 4;
            this.lbAreaRec.Text = "Area: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Punto 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Punto 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Punto 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto 1:";
            // 
            // grpCirculo
            // 
            this.grpCirculo.Controls.Add(this.txtRadio);
            this.grpCirculo.Controls.Add(this.label9);
            this.grpCirculo.Controls.Add(this.lbAreaCir);
            this.grpCirculo.Controls.Add(this.txtPy);
            this.grpCirculo.Controls.Add(this.txtPx);
            this.grpCirculo.Controls.Add(this.lbResAreaCirc);
            this.grpCirculo.Controls.Add(this.label7);
            this.grpCirculo.Controls.Add(this.label6);
            this.grpCirculo.Location = new System.Drawing.Point(271, 220);
            this.grpCirculo.Name = "grpCirculo";
            this.grpCirculo.Size = new System.Drawing.Size(223, 226);
            this.grpCirculo.TabIndex = 1;
            this.grpCirculo.TabStop = false;
            this.grpCirculo.Text = "Circulo";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(81, 115);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(43, 20);
            this.txtRadio.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Radio:";
            // 
            // lbAreaCir
            // 
            this.lbAreaCir.AutoSize = true;
            this.lbAreaCir.Location = new System.Drawing.Point(28, 153);
            this.lbAreaCir.Name = "lbAreaCir";
            this.lbAreaCir.Size = new System.Drawing.Size(32, 13);
            this.lbAreaCir.TabIndex = 12;
            this.lbAreaCir.Text = "Area:";
            // 
            // txtPy
            // 
            this.txtPy.Location = new System.Drawing.Point(81, 79);
            this.txtPy.Name = "txtPy";
            this.txtPy.Size = new System.Drawing.Size(43, 20);
            this.txtPy.TabIndex = 10;
            // 
            // txtPx
            // 
            this.txtPx.Location = new System.Drawing.Point(81, 43);
            this.txtPx.Name = "txtPx";
            this.txtPx.Size = new System.Drawing.Size(43, 20);
            this.txtPx.TabIndex = 9;
            // 
            // lbResAreaCirc
            // 
            this.lbResAreaCirc.AutoSize = true;
            this.lbResAreaCirc.Location = new System.Drawing.Point(66, 153);
            this.lbResAreaCirc.Name = "lbResAreaCirc";
            this.lbResAreaCirc.Size = new System.Drawing.Size(67, 13);
            this.lbResAreaCirc.TabIndex = 7;
            this.lbResAreaCirc.Text = "__________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Punto Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Punto X:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(238, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 184);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(532, 233);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(86, 31);
            this.btnDibujar.TabIndex = 3;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(532, 289);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 36);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Area";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrae
            // 
            this.btnBorrae.Location = new System.Drawing.Point(532, 350);
            this.btnBorrae.Name = "btnBorrae";
            this.btnBorrae.Size = new System.Drawing.Size(86, 36);
            this.btnBorrae.TabIndex = 5;
            this.btnBorrae.Text = "Borrar";
            this.btnBorrae.UseVisualStyleBackColor = true;
            this.btnBorrae.Click += new System.EventHandler(this.btnBorrae_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(649, 469);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBorrae);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.grpCirculo);
            this.Controls.Add(this.grpRectangulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpFiguras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpFiguras.ResumeLayout(false);
            this.grpFiguras.PerformLayout();
            this.grpRectangulo.ResumeLayout(false);
            this.grpRectangulo.PerformLayout();
            this.grpCirculo.ResumeLayout(false);
            this.grpCirculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiguras;
        private System.Windows.Forms.GroupBox grpRectangulo;
        private System.Windows.Forms.GroupBox grpCirculo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdCirculo;
        private System.Windows.Forms.RadioButton rdRectangulo;
        private System.Windows.Forms.TextBox txtP2y;
        private System.Windows.Forms.TextBox txtP2x;
        private System.Windows.Forms.TextBox txtP1y;
        private System.Windows.Forms.TextBox txtP1x;
        private System.Windows.Forms.Label lbAreaRec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPy;
        private System.Windows.Forms.TextBox txtPx;
        private System.Windows.Forms.Label lbResAreaCirc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbResAreaRec;
        private System.Windows.Forms.Label lbAreaCir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBorrae;
        private System.Windows.Forms.Label label10;
    }
}

