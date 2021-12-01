
namespace AplicaciónPorDefecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TxtTitulo1 = new System.Windows.Forms.Label();
            this.TxtTitulo2 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 23);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(36, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 23);
            this.textBox4.TabIndex = 4;
            // 
            // TxtTitulo1
            // 
            this.TxtTitulo1.AutoSize = true;
            this.TxtTitulo1.Location = new System.Drawing.Point(36, 45);
            this.TxtTitulo1.Name = "TxtTitulo1";
            this.TxtTitulo1.Size = new System.Drawing.Size(94, 15);
            this.TxtTitulo1.TabIndex = 5;
            this.TxtTitulo1.Text = "Digitar Números";
            this.TxtTitulo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtTitulo2
            // 
            this.TxtTitulo2.AutoSize = true;
            this.TxtTitulo2.Location = new System.Drawing.Point(390, 45);
            this.TxtTitulo2.Name = "TxtTitulo2";
            this.TxtTitulo2.Size = new System.Drawing.Size(59, 15);
            this.TxtTitulo2.TabIndex = 6;
            this.TxtTitulo2.Text = "Resultado";
            // 
            // TxtResultado
            // 
            this.TxtResultado.AutoSize = true;
            this.TxtResultado.Location = new System.Drawing.Point(390, 122);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(38, 15);
            this.TxtResultado.TabIndex = 7;
            this.TxtResultado.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtTitulo2);
            this.Controls.Add(this.TxtTitulo1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label TxtTitulo1;
        private System.Windows.Forms.Label TxtTitulo2;
        private System.Windows.Forms.Label TxtResultado;
    }
}

