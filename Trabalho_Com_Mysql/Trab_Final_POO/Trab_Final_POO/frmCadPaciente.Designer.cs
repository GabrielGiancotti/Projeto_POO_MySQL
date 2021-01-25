namespace Trab_Final_POO
{
    partial class frmCadPaciente
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
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.txtEnderecoPaciente = new System.Windows.Forms.TextBox();
            this.lblEnderecoPaciente = new System.Windows.Forms.Label();
            this.lblTelefonePaciente = new System.Windows.Forms.Label();
            this.txtTelefonePaciente = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfPaciente = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrarPaciente = new System.Windows.Forms.Button();
            this.cbxSexoPaciente = new System.Windows.Forms.ComboBox();
            this.lblSexoPaciente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(12, 25);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(41, 13);
            this.lblNomePaciente.TabIndex = 0;
            this.lblNomePaciente.Text = "Nome: ";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(12, 41);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(227, 20);
            this.txtNomePaciente.TabIndex = 1;
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Location = new System.Drawing.Point(12, 70);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(33, 13);
            this.lblCpfPaciente.TabIndex = 2;
            this.lblCpfPaciente.Text = "CPF: ";
            // 
            // txtEnderecoPaciente
            // 
            this.txtEnderecoPaciente.Location = new System.Drawing.Point(12, 180);
            this.txtEnderecoPaciente.Name = "txtEnderecoPaciente";
            this.txtEnderecoPaciente.Size = new System.Drawing.Size(227, 20);
            this.txtEnderecoPaciente.TabIndex = 4;
            // 
            // lblEnderecoPaciente
            // 
            this.lblEnderecoPaciente.AutoSize = true;
            this.lblEnderecoPaciente.Location = new System.Drawing.Point(12, 164);
            this.lblEnderecoPaciente.Name = "lblEnderecoPaciente";
            this.lblEnderecoPaciente.Size = new System.Drawing.Size(59, 13);
            this.lblEnderecoPaciente.TabIndex = 4;
            this.lblEnderecoPaciente.Text = "Endereço: ";
            // 
            // lblTelefonePaciente
            // 
            this.lblTelefonePaciente.AutoSize = true;
            this.lblTelefonePaciente.Location = new System.Drawing.Point(9, 119);
            this.lblTelefonePaciente.Name = "lblTelefonePaciente";
            this.lblTelefonePaciente.Size = new System.Drawing.Size(55, 13);
            this.lblTelefonePaciente.TabIndex = 6;
            this.lblTelefonePaciente.Text = "Telefone: ";
            // 
            // txtTelefonePaciente
            // 
            this.txtTelefonePaciente.Location = new System.Drawing.Point(12, 135);
            this.txtTelefonePaciente.Mask = "(00)00000-0000";
            this.txtTelefonePaciente.Name = "txtTelefonePaciente";
            this.txtTelefonePaciente.Size = new System.Drawing.Size(84, 20);
            this.txtTelefonePaciente.TabIndex = 3;
            // 
            // txtCpfPaciente
            // 
            this.txtCpfPaciente.Location = new System.Drawing.Point(12, 86);
            this.txtCpfPaciente.Mask = "000.000.000-00";
            this.txtCpfPaciente.Name = "txtCpfPaciente";
            this.txtCpfPaciente.Size = new System.Drawing.Size(84, 20);
            this.txtCpfPaciente.TabIndex = 2;
            // 
            // btnCadastrarPaciente
            // 
            this.btnCadastrarPaciente.Location = new System.Drawing.Point(12, 398);
            this.btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            this.btnCadastrarPaciente.Size = new System.Drawing.Size(776, 23);
            this.btnCadastrarPaciente.TabIndex = 6;
            this.btnCadastrarPaciente.Text = "Cadastrar";
            this.btnCadastrarPaciente.UseVisualStyleBackColor = true;
            this.btnCadastrarPaciente.Click += new System.EventHandler(this.btnCadastrarPaciente_Click);
            // 
            // cbxSexoPaciente
            // 
            this.cbxSexoPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexoPaciente.FormattingEnabled = true;
            this.cbxSexoPaciente.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexoPaciente.Location = new System.Drawing.Point(12, 225);
            this.cbxSexoPaciente.Name = "cbxSexoPaciente";
            this.cbxSexoPaciente.Size = new System.Drawing.Size(121, 21);
            this.cbxSexoPaciente.TabIndex = 5;
            // 
            // lblSexoPaciente
            // 
            this.lblSexoPaciente.AutoSize = true;
            this.lblSexoPaciente.Location = new System.Drawing.Point(12, 209);
            this.lblSexoPaciente.Name = "lblSexoPaciente";
            this.lblSexoPaciente.Size = new System.Drawing.Size(37, 13);
            this.lblSexoPaciente.TabIndex = 14;
            this.lblSexoPaciente.Text = "Sexo: ";
            // 
            // frmCadPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblSexoPaciente);
            this.Controls.Add(this.cbxSexoPaciente);
            this.Controls.Add(this.btnCadastrarPaciente);
            this.Controls.Add(this.txtCpfPaciente);
            this.Controls.Add(this.txtTelefonePaciente);
            this.Controls.Add(this.lblTelefonePaciente);
            this.Controls.Add(this.txtEnderecoPaciente);
            this.Controls.Add(this.lblEnderecoPaciente);
            this.Controls.Add(this.lblCpfPaciente);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.lblNomePaciente);
            this.Name = "frmCadPaciente";
            this.Text = "Cadastro de Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label lblCpfPaciente;
        private System.Windows.Forms.TextBox txtEnderecoPaciente;
        private System.Windows.Forms.Label lblEnderecoPaciente;
        private System.Windows.Forms.Label lblTelefonePaciente;
        private System.Windows.Forms.MaskedTextBox txtTelefonePaciente;
        private System.Windows.Forms.MaskedTextBox txtCpfPaciente;
        private System.Windows.Forms.Button btnCadastrarPaciente;
        private System.Windows.Forms.ComboBox cbxSexoPaciente;
        private System.Windows.Forms.Label lblSexoPaciente;
    }
}