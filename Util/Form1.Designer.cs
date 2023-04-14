
namespace Util
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPatagonia = new System.Windows.Forms.Button();
            this.btnQuintoCuarto = new System.Windows.Forms.Button();
            this.btnMercadoInterno = new System.Windows.Forms.Button();
            this.btnLaCaballada = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(679, 303);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 43);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ODBC local";
            // 
            // btnPatagonia
            // 
            this.btnPatagonia.Location = new System.Drawing.Point(21, 143);
            this.btnPatagonia.Name = "btnPatagonia";
            this.btnPatagonia.Size = new System.Drawing.Size(153, 29);
            this.btnPatagonia.TabIndex = 3;
            this.btnPatagonia.Text = "Patagonia";
            this.btnPatagonia.UseVisualStyleBackColor = true;
            this.btnPatagonia.Click += new System.EventHandler(this.btnPatagonia_Click);
            // 
            // btnQuintoCuarto
            // 
            this.btnQuintoCuarto.Location = new System.Drawing.Point(21, 108);
            this.btnQuintoCuarto.Name = "btnQuintoCuarto";
            this.btnQuintoCuarto.Size = new System.Drawing.Size(153, 29);
            this.btnQuintoCuarto.TabIndex = 2;
            this.btnQuintoCuarto.Text = "Quinto Cuarto";
            this.btnQuintoCuarto.UseVisualStyleBackColor = true;
            this.btnQuintoCuarto.Click += new System.EventHandler(this.btnQuintoCuarto_Click);
            // 
            // btnMercadoInterno
            // 
            this.btnMercadoInterno.Location = new System.Drawing.Point(21, 73);
            this.btnMercadoInterno.Name = "btnMercadoInterno";
            this.btnMercadoInterno.Size = new System.Drawing.Size(153, 29);
            this.btnMercadoInterno.TabIndex = 1;
            this.btnMercadoInterno.Text = "Mercado Interno";
            this.btnMercadoInterno.UseVisualStyleBackColor = true;
            this.btnMercadoInterno.Click += new System.EventHandler(this.btnMercadoInterno_Click_1);
            // 
            // btnLaCaballada
            // 
            this.btnLaCaballada.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLaCaballada.Location = new System.Drawing.Point(21, 38);
            this.btnLaCaballada.Name = "btnLaCaballada";
            this.btnLaCaballada.Size = new System.Drawing.Size(153, 29);
            this.btnLaCaballada.TabIndex = 0;
            this.btnLaCaballada.Text = "La Caballada";
            this.btnLaCaballada.UseVisualStyleBackColor = false;
            this.btnLaCaballada.Click += new System.EventHandler(this.btnLaCaballada_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLaCaballada);
            this.groupBox2.Controls.Add(this.btnPatagonia);
            this.groupBox2.Controls.Add(this.btnMercadoInterno);
            this.groupBox2.Controls.Add(this.btnQuintoCuarto);
            this.groupBox2.Location = new System.Drawing.Point(28, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 190);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DSN Trazpro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Utilitarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPatagonia;
        private System.Windows.Forms.Button btnQuintoCuarto;
        private System.Windows.Forms.Button btnMercadoInterno;
        private System.Windows.Forms.Button btnLaCaballada;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

