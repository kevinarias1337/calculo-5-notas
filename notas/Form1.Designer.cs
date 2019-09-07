namespace notas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nota1txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nota2txt = new System.Windows.Forms.TextBox();
            this.nota3txt = new System.Windows.Forms.TextBox();
            this.nota4txt = new System.Windows.Forms.TextBox();
            this.nota5txt = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de notas y promedio.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(250, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la nota #1:";
            // 
            // nota1txt
            // 
            this.nota1txt.Location = new System.Drawing.Point(382, 45);
            this.nota1txt.Name = "nota1txt";
            this.nota1txt.Size = new System.Drawing.Size(42, 20);
            this.nota1txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(250, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese la nota #2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(250, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese la nota #3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(250, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese la nota #4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(250, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ingrese la nota #5:";
            // 
            // nota2txt
            // 
            this.nota2txt.Location = new System.Drawing.Point(382, 72);
            this.nota2txt.Name = "nota2txt";
            this.nota2txt.Size = new System.Drawing.Size(42, 20);
            this.nota2txt.TabIndex = 7;
            // 
            // nota3txt
            // 
            this.nota3txt.Location = new System.Drawing.Point(382, 98);
            this.nota3txt.Name = "nota3txt";
            this.nota3txt.Size = new System.Drawing.Size(42, 20);
            this.nota3txt.TabIndex = 8;
            // 
            // nota4txt
            // 
            this.nota4txt.Location = new System.Drawing.Point(382, 125);
            this.nota4txt.Name = "nota4txt";
            this.nota4txt.Size = new System.Drawing.Size(42, 20);
            this.nota4txt.TabIndex = 9;
            // 
            // nota5txt
            // 
            this.nota5txt.Location = new System.Drawing.Point(382, 153);
            this.nota5txt.Name = "nota5txt";
            this.nota5txt.Size = new System.Drawing.Size(42, 20);
            this.nota5txt.TabIndex = 10;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(430, 95);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(82, 24);
            this.btncalcular.TabIndex = 11;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "__________________________________________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 235);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.nota5txt);
            this.Controls.Add(this.nota4txt);
            this.Controls.Add(this.nota3txt);
            this.Controls.Add(this.nota2txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nota1txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculo de notas y promedio.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nota1txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nota2txt;
        private System.Windows.Forms.TextBox nota3txt;
        private System.Windows.Forms.TextBox nota4txt;
        private System.Windows.Forms.TextBox nota5txt;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label7;
    }
}

