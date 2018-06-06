namespace Ex05062018
{
    partial class Form_Ex5
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
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // numValor
            // 
            this.numValor.Location = new System.Drawing.Point(12, 12);
            this.numValor.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(120, 20);
            this.numValor.TabIndex = 0;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(12, 39);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(120, 23);
            this.BtnPrint.TabIndex = 1;
            this.BtnPrint.Text = "Imprimir";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.Items.AddRange(new object[] {
            "0"});
            this.List.Location = new System.Drawing.Point(13, 69);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(120, 43);
            this.List.TabIndex = 2;
            // 
            // Form_Ex5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 123);
            this.Controls.Add(this.List);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.numValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ex5";
            this.Text = "Exercício 5";
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.ListBox List;
    }
}