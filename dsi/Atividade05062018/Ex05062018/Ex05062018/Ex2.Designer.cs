namespace Ex05062018
{
    partial class Form_Ex2
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
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.LblDiv2 = new System.Windows.Forms.Label();
            this.LblDiv5 = new System.Windows.Forms.Label();
            this.LblDiv10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(13, 31);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(90, 20);
            this.TxtValor.TabIndex = 0;
            this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(14, 13);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(67, 13);
            this.Lbl.TabIndex = 1;
            this.Lbl.Text = "Insira o valor";
            // 
            // LblDiv2
            // 
            this.LblDiv2.AutoSize = true;
            this.LblDiv2.Location = new System.Drawing.Point(14, 58);
            this.LblDiv2.Name = "LblDiv2";
            this.LblDiv2.Size = new System.Drawing.Size(83, 13);
            this.LblDiv2.TabIndex = 2;
            this.LblDiv2.Text = "É divisível por 2";
            // 
            // LblDiv5
            // 
            this.LblDiv5.AutoSize = true;
            this.LblDiv5.Location = new System.Drawing.Point(14, 75);
            this.LblDiv5.Name = "LblDiv5";
            this.LblDiv5.Size = new System.Drawing.Size(83, 13);
            this.LblDiv5.TabIndex = 3;
            this.LblDiv5.Text = "É divisível por 5";
            // 
            // LblDiv10
            // 
            this.LblDiv10.AutoSize = true;
            this.LblDiv10.Location = new System.Drawing.Point(14, 92);
            this.LblDiv10.Name = "LblDiv10";
            this.LblDiv10.Size = new System.Drawing.Size(89, 13);
            this.LblDiv10.TabIndex = 4;
            this.LblDiv10.Text = "É divisível por 10";
            // 
            // Form_Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(117, 119);
            this.Controls.Add(this.LblDiv10);
            this.Controls.Add(this.LblDiv5);
            this.Controls.Add(this.LblDiv2);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.TxtValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ex2";
            this.Text = "Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label LblDiv2;
        private System.Windows.Forms.Label LblDiv5;
        private System.Windows.Forms.Label LblDiv10;

    }
}