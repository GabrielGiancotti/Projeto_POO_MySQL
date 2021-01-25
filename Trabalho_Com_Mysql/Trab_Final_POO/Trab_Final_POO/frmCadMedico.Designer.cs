namespace Trab_Final_POO
{
    partial class frmCadMedico
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
            this.lblNomeMedico = new System.Windows.Forms.Label();
            this.btnCadastrarMedico = new System.Windows.Forms.Button();
            this.lblCpfMedico = new System.Windows.Forms.Label();
            this.lblCrmMedico = new System.Windows.Forms.Label();
            this.lblEspecialidadeMedico = new System.Windows.Forms.Label();
            this.lblEnderecoMedico = new System.Windows.Forms.Label();
            this.lblSexoMedico = new System.Windows.Forms.Label();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.txtCpfMedico = new System.Windows.Forms.MaskedTextBox();
            this.txtCrmMedico = new System.Windows.Forms.MaskedTextBox();
            this.txtEspecialidadeMedico = new System.Windows.Forms.TextBox();
            this.txtEnderecoMedico = new System.Windows.Forms.TextBox();
            this.cbxSexoMedico = new System.Windows.Forms.ComboBox();
            this.lblTelefoneMedico = new System.Windows.Forms.Label();
            this.txtTelefoneMedico = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNomeMedico
            // 
            this.lblNomeMedico.AutoSize = true;
            this.lblNomeMedico.Location = new System.Drawing.Point(12, 9);
            this.lblNomeMedico.Name = "lblNomeMedico";
            this.lblNomeMedico.Size = new System.Drawing.Size(41, 13);
            this.lblNomeMedico.TabIndex = 0;
            this.lblNomeMedico.Text = "Nome: ";
            // 
            // btnCadastrarMedico
            // 
            this.btnCadastrarMedico.Location = new System.Drawing.Point(12, 398);
            this.btnCadastrarMedico.Name = "btnCadastrarMedico";
            this.btnCadastrarMedico.Size = new System.Drawing.Size(776, 23);
            this.btnCadastrarMedico.TabIndex = 8;
            this.btnCadastrarMedico.Text = "Cadastrar";
            this.btnCadastrarMedico.UseVisualStyleBackColor = true;
            this.btnCadastrarMedico.Click += new System.EventHandler(this.btnCadastrarMedico_Click);
            // 
            // lblCpfMedico
            // 
            this.lblCpfMedico.AutoSize = true;
            this.lblCpfMedico.Location = new System.Drawing.Point(12, 143);
            this.lblCpfMedico.Name = "lblCpfMedico";
            this.lblCpfMedico.Size = new System.Drawing.Size(33, 13);
            this.lblCpfMedico.TabIndex = 2;
            this.lblCpfMedico.Text = "CPF: ";
            // 
            // lblCrmMedico
            // 
            this.lblCrmMedico.AutoSize = true;
            this.lblCrmMedico.Location = new System.Drawing.Point(187, 143);
            this.lblCrmMedico.Name = "lblCrmMedico";
            this.lblCrmMedico.Size = new System.Drawing.Size(37, 13);
            this.lblCrmMedico.TabIndex = 3;
            this.lblCrmMedico.Text = "CRM: ";
            // 
            // lblEspecialidadeMedico
            // 
            this.lblEspecialidadeMedico.AutoSize = true;
            this.lblEspecialidadeMedico.Location = new System.Drawing.Point(12, 95);
            this.lblEspecialidadeMedico.Name = "lblEspecialidadeMedico";
            this.lblEspecialidadeMedico.Size = new System.Drawing.Size(79, 13);
            this.lblEspecialidadeMedico.TabIndex = 4;
            this.lblEspecialidadeMedico.Text = "Especialidade: ";
            // 
            // lblEnderecoMedico
            // 
            this.lblEnderecoMedico.AutoSize = true;
            this.lblEnderecoMedico.Location = new System.Drawing.Point(12, 54);
            this.lblEnderecoMedico.Name = "lblEnderecoMedico";
            this.lblEnderecoMedico.Size = new System.Drawing.Size(59, 13);
            this.lblEnderecoMedico.TabIndex = 5;
            this.lblEnderecoMedico.Text = "Endereco: ";
            // 
            // lblSexoMedico
            // 
            this.lblSexoMedico.AutoSize = true;
            this.lblSexoMedico.Location = new System.Drawing.Point(15, 241);
            this.lblSexoMedico.Name = "lblSexoMedico";
            this.lblSexoMedico.Size = new System.Drawing.Size(37, 13);
            this.lblSexoMedico.TabIndex = 6;
            this.lblSexoMedico.Text = "Sexo: ";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Location = new System.Drawing.Point(15, 25);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(272, 20);
            this.txtNomeMedico.TabIndex = 1;
            // 
            // txtCpfMedico
            // 
            this.txtCpfMedico.Location = new System.Drawing.Point(15, 159);
            this.txtCpfMedico.Mask = "000.000.000-00";
            this.txtCpfMedico.Name = "txtCpfMedico";
            this.txtCpfMedico.Size = new System.Drawing.Size(100, 20);
            this.txtCpfMedico.TabIndex = 4;
            // 
            // txtCrmMedico
            // 
            this.txtCrmMedico.Location = new System.Drawing.Point(187, 159);
            this.txtCrmMedico.Mask = "00-00000-0";
            this.txtCrmMedico.Name = "txtCrmMedico";
            this.txtCrmMedico.Size = new System.Drawing.Size(100, 20);
            this.txtCrmMedico.TabIndex = 5;
            // 
            // txtEspecialidadeMedico
            // 
            this.txtEspecialidadeMedico.Location = new System.Drawing.Point(15, 111);
            this.txtEspecialidadeMedico.Name = "txtEspecialidadeMedico";
            this.txtEspecialidadeMedico.Size = new System.Drawing.Size(272, 20);
            this.txtEspecialidadeMedico.TabIndex = 3;
            // 
            // txtEnderecoMedico
            // 
            this.txtEnderecoMedico.Location = new System.Drawing.Point(15, 70);
            this.txtEnderecoMedico.Name = "txtEnderecoMedico";
            this.txtEnderecoMedico.Size = new System.Drawing.Size(272, 20);
            this.txtEnderecoMedico.TabIndex = 2;
            // 
            // cbxSexoMedico
            // 
            this.cbxSexoMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexoMedico.FormattingEnabled = true;
            this.cbxSexoMedico.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexoMedico.Location = new System.Drawing.Point(15, 257);
            this.cbxSexoMedico.Name = "cbxSexoMedico";
            this.cbxSexoMedico.Size = new System.Drawing.Size(100, 21);
            this.cbxSexoMedico.TabIndex = 7;
            // 
            // lblTelefoneMedico
            // 
            this.lblTelefoneMedico.AutoSize = true;
            this.lblTelefoneMedico.Location = new System.Drawing.Point(12, 190);
            this.lblTelefoneMedico.Name = "lblTelefoneMedico";
            this.lblTelefoneMedico.Size = new System.Drawing.Size(55, 13);
            this.lblTelefoneMedico.TabIndex = 14;
            this.lblTelefoneMedico.Text = "Telefone: ";
            // 
            // txtTelefoneMedico
            // 
            this.txtTelefoneMedico.Location = new System.Drawing.Point(15, 206);
            this.txtTelefoneMedico.Mask = "(00)00000-0000";
            this.txtTelefoneMedico.Name = "txtTelefoneMedico";
            this.txtTelefoneMedico.Size = new System.Drawing.Size(100, 20);
            this.txtTelefoneMedico.TabIndex = 6;
            // 
            // frmCadMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtTelefoneMedico);
            this.Controls.Add(this.lblTelefoneMedico);
            this.Controls.Add(this.cbxSexoMedico);
            this.Controls.Add(this.txtEnderecoMedico);
            this.Controls.Add(this.txtEspecialidadeMedico);
            this.Controls.Add(this.txtCrmMedico);
            this.Controls.Add(this.txtCpfMedico);
            this.Controls.Add(this.txtNomeMedico);
            this.Controls.Add(this.lblSexoMedico);
            this.Controls.Add(this.lblEnderecoMedico);
            this.Controls.Add(this.lblEspecialidadeMedico);
            this.Controls.Add(this.lblCrmMedico);
            this.Controls.Add(this.lblCpfMedico);
            this.Controls.Add(this.btnCadastrarMedico);
            this.Controls.Add(this.lblNomeMedico);
            this.Name = "frmCadMedico";
            this.Text = "Cadastro de Medicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeMedico;
        private System.Windows.Forms.Button btnCadastrarMedico;
        private System.Windows.Forms.Label lblCpfMedico;
        private System.Windows.Forms.Label lblCrmMedico;
        private System.Windows.Forms.Label lblEspecialidadeMedico;
        private System.Windows.Forms.Label lblEnderecoMedico;
        private System.Windows.Forms.Label lblSexoMedico;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.MaskedTextBox txtCpfMedico;
        private System.Windows.Forms.MaskedTextBox txtCrmMedico;
        private System.Windows.Forms.TextBox txtEspecialidadeMedico;
        private System.Windows.Forms.TextBox txtEnderecoMedico;
        private System.Windows.Forms.ComboBox cbxSexoMedico;
        private System.Windows.Forms.Label lblTelefoneMedico;
        private System.Windows.Forms.MaskedTextBox txtTelefoneMedico;
    }
}