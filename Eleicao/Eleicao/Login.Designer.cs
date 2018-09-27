namespace Eleicao
{
    partial class FormLogin
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
            this.btnCadastrarLogin = new System.Windows.Forms.Button();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.lblRMLogin = new System.Windows.Forms.Label();
            this.lblBoasVindasLogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.BackColor = System.Drawing.Color.DimGray;
            this.btnEntrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarLogin.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEntrarLogin.Location = new System.Drawing.Point(12, 159);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(161, 23);
            this.btnEntrarLogin.TabIndex = 3;
            this.btnEntrarLogin.Text = "Entrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarLogin
            // 
            this.btnCadastrarLogin.BackColor = System.Drawing.Color.DimGray;
            this.btnCadastrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarLogin.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCadastrarLogin.Location = new System.Drawing.Point(12, 188);
            this.btnCadastrarLogin.Name = "btnCadastrarLogin";
            this.btnCadastrarLogin.Size = new System.Drawing.Size(161, 23);
            this.btnCadastrarLogin.TabIndex = 4;
            this.btnCadastrarLogin.Text = "Cadastrar Eleitor";
            this.btnCadastrarLogin.UseVisualStyleBackColor = false;
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSenhaLogin.Location = new System.Drawing.Point(12, 111);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaLogin.TabIndex = 5;
            this.lblSenhaLogin.Text = "Senha";
            // 
            // lblRMLogin
            // 
            this.lblRMLogin.AutoSize = true;
            this.lblRMLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRMLogin.Location = new System.Drawing.Point(12, 71);
            this.lblRMLogin.Name = "lblRMLogin";
            this.lblRMLogin.Size = new System.Drawing.Size(109, 13);
            this.lblRMLogin.TabIndex = 5;
            this.lblRMLogin.Text = "Registro de Matrícula";
            // 
            // lblBoasVindasLogin
            // 
            this.lblBoasVindasLogin.AutoSize = true;
            this.lblBoasVindasLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBoasVindasLogin.Location = new System.Drawing.Point(30, 16);
            this.lblBoasVindasLogin.Name = "lblBoasVindasLogin";
            this.lblBoasVindasLogin.Size = new System.Drawing.Size(127, 39);
            this.lblBoasVindasLogin.TabIndex = 5;
            this.lblBoasVindasLogin.Text = "OS Eleitor Representante\r\n\r\nETEC Zona Leste";
            this.lblBoasVindasLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 127);
            this.textBox1.MaxLength = 32;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 87);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar Aluno";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(187, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBoasVindasLogin);
            this.Controls.Add(this.lblRMLogin);
            this.Controls.Add(this.lblSenhaLogin);
            this.Controls.Add(this.btnCadastrarLogin);
            this.Controls.Add(this.btnEntrarLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Button btnCadastrarLogin;
        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.Label lblRMLogin;
        private System.Windows.Forms.Label lblBoasVindasLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}