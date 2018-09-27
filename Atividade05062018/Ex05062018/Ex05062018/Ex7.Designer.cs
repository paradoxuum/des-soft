namespace Ex05062018
{
    partial class Form_Ex7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxArlindo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxManoel = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arlindo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manoel";
            // 
            // TxtBoxArlindo
            // 
            this.TxtBoxArlindo.Location = new System.Drawing.Point(18, 55);
            this.TxtBoxArlindo.Name = "TxtBoxArlindo";
            this.TxtBoxArlindo.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxArlindo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insira as alturas";
            // 
            // TxtBoxManoel
            // 
            this.TxtBoxManoel.Location = new System.Drawing.Point(18, 103);
            this.TxtBoxManoel.Name = "TxtBoxManoel";
            this.TxtBoxManoel.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxManoel.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 131);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(121, 36);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Arlindo cresce 2cm por ano e Manoel 3cm.";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(16, 174);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(107, 23);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtBoxResult
            // 
            this.TxtBoxResult.Location = new System.Drawing.Point(9, 203);
            this.TxtBoxResult.Multiline = true;
            this.TxtBoxResult.Name = "TxtBoxResult";
            this.TxtBoxResult.ReadOnly = true;
            this.TxtBoxResult.Size = new System.Drawing.Size(121, 36);
            this.TxtBoxResult.TabIndex = 8;
            this.TxtBoxResult.Text = "Manoel será maior que Arlindo em:";
            this.TxtBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_Ex7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 246);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtBoxResult);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TxtBoxManoel);
            this.Controls.Add(this.TxtBoxArlindo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ex7";
            this.Text = "Exercício 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxArlindo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxManoel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtBoxResult;
    }
}