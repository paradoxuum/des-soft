namespace Eleicao
{
    partial class CadEleitor
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
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlunosCadastrados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.BackColor = System.Drawing.Color.DimGray;
            this.btnEntrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarLogin.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEntrarLogin.Location = new System.Drawing.Point(34, 97);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(124, 26);
            this.btnEntrarLogin.TabIndex = 9;
            this.btnEntrarLogin.Text = "Cadastrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = false;
            // 
            // txbNome
            // 
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Location = new System.Drawing.Point(34, 71);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(124, 20);
            this.txbNome.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "RM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlunosCadastrados
            // 
            this.lblAlunosCadastrados.AutoSize = true;
            this.lblAlunosCadastrados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunosCadastrados.Location = new System.Drawing.Point(51, 26);
            this.lblAlunosCadastrados.Name = "lblAlunosCadastrados";
            this.lblAlunosCadastrados.Size = new System.Drawing.Size(91, 20);
            this.lblAlunosCadastrados.TabIndex = 44;
            this.lblAlunosCadastrados.Text = "Cadastre-se";
            this.lblAlunosCadastrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CadEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(193, 157);
            this.Controls.Add(this.lblAlunosCadastrados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnEntrarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadEleitor";
            this.Text = "Cadastro de Eleitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlunosCadastrados;
    }
}