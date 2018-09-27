namespace Ex05062018
{
    partial class Form_Ex6
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
            this.TxtBoxNum = new System.Windows.Forms.TextBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtBoxNum
            // 
            this.TxtBoxNum.Location = new System.Drawing.Point(12, 12);
            this.TxtBoxNum.Name = "TxtBoxNum";
            this.TxtBoxNum.Size = new System.Drawing.Size(109, 20);
            this.TxtBoxNum.TabIndex = 0;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(12, 38);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(109, 23);
            this.BtnPrint.TabIndex = 1;
            this.BtnPrint.Text = "Imprimir";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // ListBox
            // 
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(12, 67);
            this.List.Name = "ListBox";
            this.List.Size = new System.Drawing.Size(109, 95);
            this.List.TabIndex = 2;
            // 
            // Form_Ex6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 174);
            this.Controls.Add(this.List);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.TxtBoxNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ex6";
            this.Text = "Exercício 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxNum;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.ListBox List;
    }
}