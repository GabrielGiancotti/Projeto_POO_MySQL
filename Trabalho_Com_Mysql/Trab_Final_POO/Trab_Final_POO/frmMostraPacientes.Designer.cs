namespace Trab_Final_POO
{
    partial class frmMostraPacientes
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
            this.txtPesquisaPaciente = new System.Windows.Forms.TextBox();
            this.dgvMostraPaciente = new System.Windows.Forms.DataGridView();
            this.lblPesquisaPaciente = new System.Windows.Forms.Label();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.btnExcluirPaciente = new System.Windows.Forms.Button();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.lblTelefonePaciente = new System.Windows.Forms.Label();
            this.lblEnderecoPaciente = new System.Windows.Forms.Label();
            this.txtEnderecoPaciente = new System.Windows.Forms.TextBox();
            this.lblSexoPaciente = new System.Windows.Forms.Label();
            this.btnAlterarPaciente = new System.Windows.Forms.Button();
            this.cbxSexoPaciente = new System.Windows.Forms.ComboBox();
            this.txtCpfPaciente = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonePaciente = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarPaciente = new System.Windows.Forms.Button();
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaPaciente
            // 
            this.txtPesquisaPaciente.Location = new System.Drawing.Point(108, 21);
            this.txtPesquisaPaciente.Name = "txtPesquisaPaciente";
            this.txtPesquisaPaciente.Size = new System.Drawing.Size(127, 20);
            this.txtPesquisaPaciente.TabIndex = 1;
            // 
            // dgvMostraPaciente
            // 
            this.dgvMostraPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraPaciente.Location = new System.Drawing.Point(12, 95);
            this.dgvMostraPaciente.Name = "dgvMostraPaciente";
            this.dgvMostraPaciente.Size = new System.Drawing.Size(776, 297);
            this.dgvMostraPaciente.TabIndex = 100;
            // 
            // lblPesquisaPaciente
            // 
            this.lblPesquisaPaciente.AutoSize = true;
            this.lblPesquisaPaciente.Location = new System.Drawing.Point(105, 5);
            this.lblPesquisaPaciente.Name = "lblPesquisaPaciente";
            this.lblPesquisaPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPesquisaPaciente.TabIndex = 2;
            this.lblPesquisaPaciente.Text = "Paciênte";
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(12, 398);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(223, 23);
            this.btnPesquisarPaciente.TabIndex = 2;
            this.btnPesquisarPaciente.Text = "Pesquisar";
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisarPaciente.Click += new System.EventHandler(this.btnPesquisarPaciente_Click);
            // 
            // btnExcluirPaciente
            // 
            this.btnExcluirPaciente.Location = new System.Drawing.Point(565, 398);
            this.btnExcluirPaciente.Name = "btnExcluirPaciente";
            this.btnExcluirPaciente.Size = new System.Drawing.Size(223, 23);
            this.btnExcluirPaciente.TabIndex = 4;
            this.btnExcluirPaciente.Text = "Excluir";
            this.btnExcluirPaciente.UseVisualStyleBackColor = true;
            this.btnExcluirPaciente.Click += new System.EventHandler(this.btnExcluirPaciente_Click);
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Location = new System.Drawing.Point(251, 5);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(33, 13);
            this.lblCpfPaciente.TabIndex = 5;
            this.lblCpfPaciente.Text = "CPF: ";
            this.lblCpfPaciente.Visible = false;
            // 
            // lblTelefonePaciente
            // 
            this.lblTelefonePaciente.AutoSize = true;
            this.lblTelefonePaciente.Location = new System.Drawing.Point(358, 5);
            this.lblTelefonePaciente.Name = "lblTelefonePaciente";
            this.lblTelefonePaciente.Size = new System.Drawing.Size(55, 13);
            this.lblTelefonePaciente.TabIndex = 6;
            this.lblTelefonePaciente.Text = "Telefone: ";
            this.lblTelefonePaciente.Visible = false;
            // 
            // lblEnderecoPaciente
            // 
            this.lblEnderecoPaciente.AutoSize = true;
            this.lblEnderecoPaciente.Location = new System.Drawing.Point(461, 5);
            this.lblEnderecoPaciente.Name = "lblEnderecoPaciente";
            this.lblEnderecoPaciente.Size = new System.Drawing.Size(59, 13);
            this.lblEnderecoPaciente.TabIndex = 9;
            this.lblEnderecoPaciente.Text = "Endereço: ";
            this.lblEnderecoPaciente.Visible = false;
            // 
            // txtEnderecoPaciente
            // 
            this.txtEnderecoPaciente.Location = new System.Drawing.Point(464, 21);
            this.txtEnderecoPaciente.Name = "txtEnderecoPaciente";
            this.txtEnderecoPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtEnderecoPaciente.TabIndex = 7;
            this.txtEnderecoPaciente.Visible = false;
            // 
            // lblSexoPaciente
            // 
            this.lblSexoPaciente.AutoSize = true;
            this.lblSexoPaciente.Location = new System.Drawing.Point(577, 4);
            this.lblSexoPaciente.Name = "lblSexoPaciente";
            this.lblSexoPaciente.Size = new System.Drawing.Size(37, 13);
            this.lblSexoPaciente.TabIndex = 11;
            this.lblSexoPaciente.Text = "Sexo: ";
            this.lblSexoPaciente.Visible = false;
            // 
            // btnAlterarPaciente
            // 
            this.btnAlterarPaciente.Location = new System.Drawing.Point(288, 398);
            this.btnAlterarPaciente.Name = "btnAlterarPaciente";
            this.btnAlterarPaciente.Size = new System.Drawing.Size(223, 23);
            this.btnAlterarPaciente.TabIndex = 3;
            this.btnAlterarPaciente.Text = "Alterar";
            this.btnAlterarPaciente.UseVisualStyleBackColor = true;
            this.btnAlterarPaciente.Click += new System.EventHandler(this.btnAlterarPaciente_Click);
            // 
            // cbxSexoPaciente
            // 
            this.cbxSexoPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexoPaciente.FormattingEnabled = true;
            this.cbxSexoPaciente.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexoPaciente.Location = new System.Drawing.Point(580, 20);
            this.cbxSexoPaciente.Name = "cbxSexoPaciente";
            this.cbxSexoPaciente.Size = new System.Drawing.Size(121, 21);
            this.cbxSexoPaciente.TabIndex = 8;
            this.cbxSexoPaciente.Visible = false;
            // 
            // txtCpfPaciente
            // 
            this.txtCpfPaciente.Location = new System.Drawing.Point(254, 21);
            this.txtCpfPaciente.Mask = "000.000.000-00";
            this.txtCpfPaciente.Name = "txtCpfPaciente";
            this.txtCpfPaciente.Size = new System.Drawing.Size(84, 20);
            this.txtCpfPaciente.TabIndex = 5;
            this.txtCpfPaciente.Visible = false;
            // 
            // txtTelefonePaciente
            // 
            this.txtTelefonePaciente.Location = new System.Drawing.Point(361, 21);
            this.txtTelefonePaciente.Mask = "(00)00000-0000";
            this.txtTelefonePaciente.Name = "txtTelefonePaciente";
            this.txtTelefonePaciente.Size = new System.Drawing.Size(84, 20);
            this.txtTelefonePaciente.TabIndex = 6;
            this.txtTelefonePaciente.Visible = false;
            // 
            // btnSalvarPaciente
            // 
            this.btnSalvarPaciente.Location = new System.Drawing.Point(15, 66);
            this.btnSalvarPaciente.Name = "btnSalvarPaciente";
            this.btnSalvarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPaciente.TabIndex = 9;
            this.btnSalvarPaciente.Text = "Salvar";
            this.btnSalvarPaciente.UseVisualStyleBackColor = true;
            this.btnSalvarPaciente.Visible = false;
            this.btnSalvarPaciente.Click += new System.EventHandler(this.btnSalvarPaciente_Click);
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.Location = new System.Drawing.Point(12, 9);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(22, 13);
            this.lblIdPaciente.TabIndex = 101;
            this.lblIdPaciente.Text = "Id: ";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(2, 21);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(88, 20);
            this.txtIdPaciente.TabIndex = 102;
            this.txtIdPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPaciente_KeyPress);
            // 
            // frmMostraPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.btnSalvarPaciente);
            this.Controls.Add(this.txtTelefonePaciente);
            this.Controls.Add(this.txtCpfPaciente);
            this.Controls.Add(this.cbxSexoPaciente);
            this.Controls.Add(this.btnAlterarPaciente);
            this.Controls.Add(this.lblSexoPaciente);
            this.Controls.Add(this.txtEnderecoPaciente);
            this.Controls.Add(this.lblEnderecoPaciente);
            this.Controls.Add(this.lblTelefonePaciente);
            this.Controls.Add(this.lblCpfPaciente);
            this.Controls.Add(this.btnExcluirPaciente);
            this.Controls.Add(this.btnPesquisarPaciente);
            this.Controls.Add(this.lblPesquisaPaciente);
            this.Controls.Add(this.dgvMostraPaciente);
            this.Controls.Add(this.txtPesquisaPaciente);
            this.Name = "frmMostraPacientes";
            this.Text = "frmMostraPacientes";
            this.Load += new System.EventHandler(this.frmMostraPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisaPaciente;
        private System.Windows.Forms.DataGridView dgvMostraPaciente;
        private System.Windows.Forms.Label lblPesquisaPaciente;
        private System.Windows.Forms.Button btnPesquisarPaciente;
        private System.Windows.Forms.Button btnExcluirPaciente;
        private System.Windows.Forms.Label lblCpfPaciente;
        private System.Windows.Forms.Label lblTelefonePaciente;
        private System.Windows.Forms.Label lblEnderecoPaciente;
        private System.Windows.Forms.TextBox txtEnderecoPaciente;
        private System.Windows.Forms.Label lblSexoPaciente;
        private System.Windows.Forms.Button btnAlterarPaciente;
        private System.Windows.Forms.ComboBox cbxSexoPaciente;
        private System.Windows.Forms.MaskedTextBox txtCpfPaciente;
        private System.Windows.Forms.MaskedTextBox txtTelefonePaciente;
        private System.Windows.Forms.Button btnSalvarPaciente;
        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.TextBox txtIdPaciente;
    }
}