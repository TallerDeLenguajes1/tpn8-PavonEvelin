namespace TP8
{
    partial class Form1
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
            this.Historial = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.TBPantalla = new System.Windows.Forms.TextBox();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnCociente = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Historial
            // 
            this.Historial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Historial.FormattingEnabled = true;
            this.Historial.Location = new System.Drawing.Point(392, 71);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(299, 212);
            this.Historial.TabIndex = 0;
            this.Historial.SelectedIndexChanged += new System.EventHandler(this.Historial_SelectedIndexChanged);
            this.Historial.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Historial_MouseDoubleClick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(61, 205);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 39);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(133, 205);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 39);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(199, 205);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 39);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(61, 164);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 39);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(133, 164);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(49, 39);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(199, 164);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(49, 39);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(61, 115);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(49, 39);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(133, 115);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(49, 39);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(199, 115);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(49, 39);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(61, 247);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(49, 39);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // TBPantalla
            // 
            this.TBPantalla.Location = new System.Drawing.Point(61, 71);
            this.TBPantalla.Name = "TBPantalla";
            this.TBPantalla.Size = new System.Drawing.Size(187, 20);
            this.TBPantalla.TabIndex = 11;
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(133, 247);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(49, 39);
            this.btnPunto.TabIndex = 12;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(199, 247);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(49, 39);
            this.btnIgual.TabIndex = 13;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(268, 247);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(49, 39);
            this.btnSuma.TabIndex = 14;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(268, 205);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(49, 39);
            this.btnResta.TabIndex = 15;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(268, 164);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(49, 39);
            this.btnProducto.TabIndex = 16;
            this.btnProducto.Text = "*";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnCociente
            // 
            this.btnCociente.Location = new System.Drawing.Point(268, 114);
            this.btnCociente.Name = "btnCociente";
            this.btnCociente.Size = new System.Drawing.Size(49, 41);
            this.btnCociente.TabIndex = 17;
            this.btnCociente.Text = "/";
            this.btnCociente.UseVisualStyleBackColor = true;
            this.btnCociente.Click += new System.EventHandler(this.btnCociente_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(268, 71);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(49, 29);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "C";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCociente);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.TBPantalla);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Historial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Historial;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox TBPantalla;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnCociente;
        private System.Windows.Forms.Button btnBorrar;
    }
}

