namespace Trab_Final_POO
{
    partial class frmMostraMedicos
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
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.btnPesquisarMedico = new System.Windows.Forms.Button();
            this.lblNomeMedico = new System.Windows.Forms.Label();
            this.txtPesquisaMedico = new System.Windows.Forms.TextBox();
            this.btnExcluirMedico = new System.Windows.Forms.Button();
            this.btnSalvarMedico = new System.Windows.Forms.Button();
            this.txtTelefoneMedico = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfMedico = new System.Windows.Forms.MaskedTextBox();
            this.cbxSexoMedico = new System.Windows.Forms.ComboBox();
            this.lblSexoMedico = new System.Windows.Forms.Label();
            this.txtEnderecoMedico = new System.Windows.Forms.TextBox();
            this.lblEnderecoMedico = new System.Windows.Forms.Label();
            this.lblTelefoneMedico = new System.Windows.Forms.Label();
            this.lblCpfMedico = new System.Windows.Forms.Label();
            this.btnAlterarMedico = new System.Windows.Forms.Button();
            this.txtCrmMedico = new System.Windows.Forms.MaskedTextBox();
            this.lblCrmMedico = new System.Windows.Forms.Label();
            this.txtEspecialidadeMedico = new System.Windows.Forms.TextBox();
            this.lblEspecialidadeMedico = new System.Windows.Forms.Label();
            this.lblIdMedico = new System.Windows.Forms.Label();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(12, 95);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.Size = new System.Drawing.Size(793, 297);
            this.dgvMedicos.TabIndex = 0;
            // 
            // btnPesquisarMedico
            // 
            this.btnPesquisarMedico.Location = new System.Drawing.Point(12, 398);
            this.btnPesquisarMedico.Name = "btnPesquisarMedico";
            this.btnPesquisarMedico.Size = new System.Drawing.Size(223, 23);
            this.btnPesquisarMedico.TabIndex = 2;
            this.btnPesquisarMedico.Text = "Pesquisar";
            this.btnPesquisarMedico.UseVisualStyleBackColor = true;
            this.btnPesquisarMedico.Click += new System.EventHandler(this.btnPesquisarMedico_Click);
            // 
            // lblNomeMedico
            // 
            this.lblNomeMedico.AutoSize = true;
            this.lblNomeMedico.Location = new System.Drawing.Point(115, 7);
            this.lblNomeMedico.Name = "lblNomeMedico";
            this.lblNomeMedico.Size = new System.Drawing.Size(42, 13);
            this.lblNomeMedico.TabIndex = 2;
            this.lblNomeMedico.Text = "Médico";
            // 
            // txtPesquisaMedico
            // 
            this.txtPesquisaMedico.Location = new System.Drawing.Point(118, 23);
            this.txtPesquisaMedico.Name = "txtPesquisaMedico";
            this.txtPesquisaMedico.Size = new System.Drawing.Size(127, 20);
            this.txtPesquisaMedico.TabIndex = 1;
            // 
            // btnExcluirMedico
            // 
            this.btnExcluirMedico.Location = new System.Drawing.Point(565, 398);
            this.btnExcluirMedico.Name = "btnExcluirMedico";
            this.btnExcluirMedico.Size = new System.Drawing.Size(223, 23);
            this.btnExcluirMedico.TabIndex = 4;
            this.btnExcluirMedico.Text = "Excluir";
            this.btnExcluirMedico.UseVisualStyleBackColor = true;
            this.btnExcluirMedico.Click += new System.EventHandler(this.btnExcluirMedico_Click);
            // 
            // btnSalvarMedico
            // 
            this.btnSalvarMedico.Location = new System.Drawing.Point(148, 67);
            this.btnSalvarMedico.Name = "btnSalvarMedico";
            this.btnSalvarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarMedico.TabIndex = 11;
            this.btnSalvarMedico.Text = "Salvar";
            this.btnSalvarMedico.UseVisualStyleBackColor = true;
            this.btnSalvarMedico.Visible = false;
            this.btnSalvarMedico.Click += new System.EventHandler(this.btnSalvarMedico_Click);
            // 
            // txtTelefoneMedico
            // 
            this.txtTelefoneMedico.Location = new System.Drawing.Point(341, 22);
            this.txtTelefoneMedico.Mask = "(00)00000-0000";
            this.txtTelefoneMedico.Name = "txtTelefoneMedico";
            this.txtTelefoneMedico.Size = new System.Drawing.Size(84, 20);
            this.txtTelefoneMedico.TabIndex = 6;
            this.txtTelefoneMedico.Visible = false;
            // 
            // txtCpfMedico
            // 
            this.txtCpfMedico.Location = new System.Drawing.Point(251, 22);
            this.txtCpfMedico.Mask = "000.000.000-00";
            this.txtCpfMedico.Name = "txtCpfMedico";
            this.txtCpfMedico.Size = new System.Drawing.Size(84, 20);
            this.txtCpfMedico.TabIndex = 5;
            this.txtCpfMedico.Visible = false;
            // 
            // cbxSexoMedico
            // 
            this.cbxSexoMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexoMedico.FormattingEnabled = true;
            this.cbxSexoMedico.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexoMedico.Location = new System.Drawing.Point(686, 21);
            this.cbxSexoMedico.Name = "cbxSexoMedico";
            this.cbxSexoMedico.Size = new System.Drawing.Size(121, 21);
            this.cbxSexoMedico.TabIndex = 8;
            this.cbxSexoMedico.Visible = false;
            // 
            // lblSexoMedico
            // 
            this.lblSexoMedico.AutoSize = true;
            this.lblSexoMedico.Location = new System.Drawing.Point(684, 5);
            this.lblSexoMedico.Name = "lblSexoMedico";
            this.lblSexoMedico.Size = new System.Drawing.Size(37, 13);
            this.lblSexoMedico.TabIndex = 22;
            this.lblSexoMedico.Text = "Sexo: ";
            this.lblSexoMedico.Visible = false;
            // 
            // txtEnderecoMedico
            // 
            this.txtEnderecoMedico.Location = new System.Drawing.Point(431, 22);
            this.txtEnderecoMedico.Name = "txtEnderecoMedico";
            this.txtEnderecoMedico.Size = new System.Drawing.Size(143, 20);
            this.txtEnderecoMedico.TabIndex = 7;
            this.txtEnderecoMedico.Visible = false;
            // 
            // lblEnderecoMedico
            // 
            this.lblEnderecoMedico.AutoSize = true;
            this.lblEnderecoMedico.Location = new System.Drawing.Point(428, 6);
            this.lblEnderecoMedico.Name = "lblEnderecoMedico";
            this.lblEnderecoMedico.Size = new System.Drawing.Size(59, 13);
            this.lblEnderecoMedico.TabIndex = 20;
            this.lblEnderecoMedico.Text = "Endereço: ";
            this.lblEnderecoMedico.Visible = false;
            // 
            // lblTelefoneMedico
            // 
            this.lblTelefoneMedico.AutoSize = true;
            this.lblTelefoneMedico.Location = new System.Drawing.Point(338, 5);
            this.lblTelefoneMedico.Name = "lblTelefoneMedico";
            this.lblTelefoneMedico.Size = new System.Drawing.Size(55, 13);
            this.lblTelefoneMedico.TabIndex = 19;
            this.lblTelefoneMedico.Text = "Telefone: ";
            this.lblTelefoneMedico.Visible = false;
            // 
            // lblCpfMedico
            // 
            this.lblCpfMedico.AutoSize = true;
            this.lblCpfMedico.Location = new System.Drawing.Point(249, 5);
            this.lblCpfMedico.Name = "lblCpfMedico";
            this.lblCpfMedico.Size = new System.Drawing.Size(33, 13);
            this.lblCpfMedico.TabIndex = 18;
            this.lblCpfMedico.Text = "CPF: ";
            this.lblCpfMedico.Visible = false;
            // 
            // btnAlterarMedico
            // 
            this.btnAlterarMedico.Location = new System.Drawing.Point(288, 398);
            this.btnAlterarMedico.Name = "btnAlterarMedico";
            this.btnAlterarMedico.Size = new System.Drawing.Size(223, 23);
            this.btnAlterarMedico.TabIndex = 3;
            this.btnAlterarMedico.Text = "Alterar";
            this.btnAlterarMedico.UseVisualStyleBackColor = true;
            this.btnAlterarMedico.Click += new System.EventHandler(this.btnAlterarMedico_Click);
            // 
            // txtCrmMedico
            // 
            this.txtCrmMedico.Location = new System.Drawing.Point(580, 22);
            this.txtCrmMedico.Mask = "00-00000-0";
            this.txtCrmMedico.Name = "txtCrmMedico";
            this.txtCrmMedico.Size = new System.Drawing.Size(100, 20);
            this.txtCrmMedico.TabIndex = 9;
            this.txtCrmMedico.Visible = false;
            // 
            // lblCrmMedico
            // 
            this.lblCrmMedico.AutoSize = true;
            this.lblCrmMedico.Location = new System.Drawing.Point(577, 6);
            this.lblCrmMedico.Name = "lblCrmMedico";
            this.lblCrmMedico.Size = new System.Drawing.Size(37, 13);
            this.lblCrmMedico.TabIndex = 28;
            this.lblCrmMedico.Text = "CRM: ";
            this.lblCrmMedico.Visible = false;
            // 
            // txtEspecialidadeMedico
            // 
            this.txtEspecialidadeMedico.Location = new System.Drawing.Point(15, 69);
            this.txtEspecialidadeMedico.Name = "txtEspecialidadeMedico";
            this.txtEspecialidadeMedico.Size = new System.Drawing.Size(127, 20);
            this.txtEspecialidadeMedico.TabIndex = 10;
            this.txtEspecialidadeMedico.Visible = false;
            // 
            // lblEspecialidadeMedico
            // 
            this.lblEspecialidadeMedico.AutoSize = true;
            this.lblEspecialidadeMedico.Location = new System.Drawing.Point(12, 53);
            this.lblEspecialidadeMedico.Name = "lblEspecialidadeMedico";
            this.lblEspecialidadeMedico.Size = new System.Drawing.Size(79, 13);
            this.lblEspecialidadeMedico.TabIndex = 30;
            this.lblEspecialidadeMedico.Text = "Especialidade: ";
            this.lblEspecialidadeMedico.Visible = false;
            // 
            // lblIdMedico
            // 
            this.lblIdMedico.AutoSize = true;
            this.lblIdMedico.Location = new System.Drawing.Point(9, 9);
            this.lblIdMedico.Name = "lblIdMedico";
            this.lblIdMedico.Size = new System.Drawing.Size(22, 13);
            this.lblIdMedico.TabIndex = 31;
            this.lblIdMedico.Text = "Id: ";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(12, 25);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(100, 20);
            this.txtIdMedico.TabIndex = 32;
            this.txtIdMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdMedico_KeyPress);
            // 
            // frmMostraMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.lblIdMedico);
            this.Controls.Add(this.txtEspecialidadeMedico);
            this.Controls.Add(this.lblEspecialidadeMedico);
            this.Controls.Add(this.txtCrmMedico);
            this.Controls.Add(this.lblCrmMedico);
            this.Controls.Add(this.btnAlterarMedico);
            this.Controls.Add(this.btnSalvarMedico);
            this.Controls.Add(this.txtTelefoneMedico);
            this.Controls.Add(this.txtCpfMedico);
            this.Controls.Add(this.cbxSexoMedico);
            this.Controls.Add(this.lblSexoMedico);
            this.Controls.Add(this.txtEnderecoMedico);
            this.Controls.Add(this.lblEnderecoMedico);
            this.Controls.Add(this.lblTelefoneMedico);
            this.Controls.Add(this.lblCpfMedico);
            this.Controls.Add(this.btnExcluirMedico);
            this.Controls.Add(this.txtPesquisaMedico);
            this.Controls.Add(this.lblNomeMedico);
            this.Controls.Add(this.btnPesquisarMedico);
            this.Controls.Add(this.dgvMedicos);
            this.Name = "frmMostraMedicos";
            this.Text = "frmMostraMedicos";
            this.Load += new System.EventHandler(this.frmMostraMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Button btnPesquisarMedico;
        private System.Windows.Forms.Label lblNomeMedico;
        private System.Windows.Forms.TextBox txtPesquisaMedico;
        private System.Windows.Forms.Button btnExcluirMedico;
        private System.Windows.Forms.Button btnSalvarMedico;
        private System.Windows.Forms.MaskedTextBox txtTelefoneMedico;
        private System.Windows.Forms.MaskedTextBox txtCpfMedico;
        private System.Windows.Forms.ComboBox cbxSexoMedico;
        private System.Windows.Forms.Label lblSexoMedico;
        private System.Windows.Forms.TextBox txtEnderecoMedico;
        private System.Windows.Forms.Label lblEnderecoMedico;
        private System.Windows.Forms.Label lblTelefoneMedico;
        private System.Windows.Forms.Label lblCpfMedico;
        private System.Windows.Forms.Button btnAlterarMedico;
        private System.Windows.Forms.MaskedTextBox txtCrmMedico;
        private System.Windows.Forms.Label lblCrmMedico;
        private System.Windows.Forms.TextBox txtEspecialidadeMedico;
        private System.Windows.Forms.Label lblEspecialidadeMedico;
        private System.Windows.Forms.Label lblIdMedico;
        private System.Windows.Forms.TextBox txtIdMedico;
    }
}