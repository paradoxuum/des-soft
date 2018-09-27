namespace Eleicao
{
    partial class CadAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbResponsavel = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblRM = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbRM = new System.Windows.Forms.TextBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblAlunosCadastrados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.BackColor = System.Drawing.Color.DimGray;
            this.btnEntrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarLogin.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEntrarLogin.Location = new System.Drawing.Point(355, 12);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(74, 23);
            this.btnEntrarLogin.TabIndex = 8;
            this.btnEntrarLogin.Text = "Cadastrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Location = new System.Drawing.Point(99, 15);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(183, 20);
            this.txbNome.TabIndex = 22;
            // 
            // txbResponsavel
            // 
            this.txbResponsavel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbResponsavel.Location = new System.Drawing.Point(99, 75);
            this.txbResponsavel.Name = "txbResponsavel";
            this.txbResponsavel.Size = new System.Drawing.Size(183, 20);
            this.txbResponsavel.TabIndex = 25;
            // 
            // txbEndereco
            // 
            this.txbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEndereco.Location = new System.Drawing.Point(99, 104);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(183, 20);
            this.txbEndereco.TabIndex = 24;
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            this.lblRM.Location = new System.Drawing.Point(11, 44);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(27, 13);
            this.lblRM.TabIndex = 26;
            this.lblRM.Text = "RM:";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(11, 75);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(72, 13);
            this.lblResponsavel.TabIndex = 27;
            this.lblResponsavel.Text = "Responsável:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(11, 104);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 28;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(11, 175);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 29;
            this.lblSexo.Text = "Sexo:";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(99, 173);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 30;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.rdbMasculino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbMasculino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbMasculino.Location = new System.Drawing.Point(191, 175);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(72, 17);
            this.rdbMasculino.TabIndex = 31;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = false;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(11, 139);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 32;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mskTelefone
            // 
            this.mskTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefone.Location = new System.Drawing.Point(99, 139);
            this.mskTelefone.Mask = "(00) 90000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(98, 20);
            this.mskTelefone.TabIndex = 33;
            // 
            // txbRM
            // 
            this.txbRM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRM.Location = new System.Drawing.Point(99, 44);
            this.txbRM.Name = "txbRM";
            this.txbRM.Size = new System.Drawing.Size(183, 20);
            this.txbRM.TabIndex = 23;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(14, 230);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(416, 175);
            this.dgvAlunos.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Location = new System.Drawing.Point(355, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.Location = new System.Drawing.Point(355, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.button3.Location = new System.Drawing.Point(355, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lblAlunosCadastrados
            // 
            this.lblAlunosCadastrados.AutoSize = true;
            this.lblAlunosCadastrados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunosCadastrados.Location = new System.Drawing.Point(12, 207);
            this.lblAlunosCadastrados.Name = "lblAlunosCadastrados";
            this.lblAlunosCadastrados.Size = new System.Drawing.Size(168, 20);
            this.lblAlunosCadastrados.TabIndex = 43;
            this.lblAlunosCadastrados.Text = "Alunos já Cadastrados:";
            // 
            // CadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(441, 417);
            this.Controls.Add(this.lblAlunosCadastrados);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.lblRM);
            this.Controls.Add(this.txbResponsavel);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbRM);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnEntrarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadAluno";
            this.Text = "Cadastro de Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbResponsavel;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblRM;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txbRM;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblAlunosCadastrados;

    }
}