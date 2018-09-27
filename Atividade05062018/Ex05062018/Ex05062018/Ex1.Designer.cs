namespace Ex05062018
{
    partial class Form_Ex1
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
            this.LblResultEX1 = new System.Windows.Forms.Label();
            this.LblVal1EX1 = new System.Windows.Forms.Label();
            this.LblVal2EX1 = new System.Windows.Forms.Label();
            this.BtnCalcularEX1 = new System.Windows.Forms.Button();
            this.TxtBoxVal1EX1 = new System.Windows.Forms.TextBox();
            this.TxtBoxVal2EX1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblResultEX1
            // 
            this.LblResultEX1.AutoSize = true;
            this.LblResultEX1.Location = new System.Drawing.Point(12, 101);
            this.LblResultEX1.Name = "LblResultEX1";
            this.LblResultEX1.Size = new System.Drawing.Size(61, 13);
            this.LblResultEX1.TabIndex = 12;
            this.LblResultEX1.Text = "Resultado: ";
            this.LblResultEX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblVal1EX1
            // 
            this.LblVal1EX1.AutoSize = true;
            this.LblVal1EX1.Location = new System.Drawing.Point(12, 9);
            this.LblVal1EX1.Name = "LblVal1EX1";
            this.LblVal1EX1.Size = new System.Drawing.Size(40, 13);
            this.LblVal1EX1.TabIndex = 10;
            this.LblVal1EX1.Text = "Valor 1";
            // 
            // LblVal2EX1
            // 
            this.LblVal2EX1.AutoSize = true;
            this.LblVal2EX1.Location = new System.Drawing.Point(12, 51);
            this.LblVal2EX1.Name = "LblVal2EX1";
            this.LblVal2EX1.Size = new System.Drawing.Size(40, 13);
            this.LblVal2EX1.TabIndex = 11;
            this.LblVal2EX1.Text = "Valor 2";
            // 
            // BtnCalcularEX1
            // 
            this.BtnCalcularEX1.Location = new System.Drawing.Point(47, 126);
            this.BtnCalcularEX1.Name = "BtnCalcularEX1";
            this.BtnCalcularEX1.Size = new System.Drawing.Size(95, 23);
            this.BtnCalcularEX1.TabIndex = 7;
            this.BtnCalcularEX1.Text = "Calcular";
            this.BtnCalcularEX1.UseVisualStyleBackColor = true;
            this.BtnCalcularEX1.Click += new System.EventHandler(this.BtnCalcularEX1_Click);
            // 
            // TxtBoxVal1EX1
            // 
            this.TxtBoxVal1EX1.Location = new System.Drawing.Point(12, 24);
            this.TxtBoxVal1EX1.Name = "TxtBoxVal1EX1";
            this.TxtBoxVal1EX1.Size = new System.Drawing.Size(167, 20);
            this.TxtBoxVal1EX1.TabIndex = 8;
            // 
            // TxtBoxVal2EX1
            // 
            this.TxtBoxVal2EX1.Location = new System.Drawing.Point(12, 67);
            this.TxtBoxVal2EX1.Name = "TxtBoxVal2EX1";
            this.TxtBoxVal2EX1.Size = new System.Drawing.Size(167, 20);
            this.TxtBoxVal2EX1.TabIndex = 9;
            // 
            // Form_Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 159);
            this.Controls.Add(this.LblResultEX1);
            this.Controls.Add(this.LblVal1EX1);
            this.Controls.Add(this.LblVal2EX1);
            this.Controls.Add(this.BtnCalcularEX1);
            this.Controls.Add(this.TxtBoxVal1EX1);
            this.Controls.Add(this.TxtBoxVal2EX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ex1";
            this.Text = "Exercícios 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblResultEX1;
        private System.Windows.Forms.Label LblVal1EX1;
        private System.Windows.Forms.Label LblVal2EX1;
        private System.Windows.Forms.Button BtnCalcularEX1;
        private System.Windows.Forms.TextBox TxtBoxVal1EX1;
        private System.Windows.Forms.TextBox TxtBoxVal2EX1;

    }
}