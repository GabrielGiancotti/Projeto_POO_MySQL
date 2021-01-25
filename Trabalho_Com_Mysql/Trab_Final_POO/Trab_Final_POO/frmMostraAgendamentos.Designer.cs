namespace Trab_Final_POO
{
    partial class frmMostraAgendamentos
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
            this.btnSalvarAgendamento = new System.Windows.Forms.Button();
            this.lblHoraAgendamento = new System.Windows.Forms.Label();
            this.lblDataAgendamento = new System.Windows.Forms.Label();
            this.lblIdMedicoAgendamento = new System.Windows.Forms.Label();
            this.lblIdPacienteAgendamento = new System.Windows.Forms.Label();
            this.lblCodigoAgendamento = new System.Windows.Forms.Label();
            this.dgvMostraAgendamento = new System.Windows.Forms.DataGridView();
            this.txtCodigoAgendamento = new System.Windows.Forms.TextBox();
            this.btnAlterarAgendamento = new System.Windows.Forms.Button();
            this.btnExcluirAgendamento = new System.Windows.Forms.Button();
            this.btnPesquisarAgendamento = new System.Windows.Forms.Button();
            this.txtIdPacienteAgendamento = new System.Windows.Forms.TextBox();
            this.txtIdMedicoAgendamento = new System.Windows.Forms.TextBox();
            this.cbxHoraAgendamento = new System.Windows.Forms.ComboBox();
            this.dtpDataAgendamento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarAgendamento
            // 
            this.btnSalvarAgendamento.Location = new System.Drawing.Point(15, 66);
            this.btnSalvarAgendamento.Name = "btnSalvarAgendamento";
            this.btnSalvarAgendamento.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAgendamento.TabIndex = 109;
            this.btnSalvarAgendamento.Text = "Salvar";
            this.btnSalvarAgendamento.UseVisualStyleBackColor = true;
            this.btnSalvarAgendamento.Visible = false;
            this.btnSalvarAgendamento.Click += new System.EventHandler(this.btnSalvarAgendamento_Click);
            // 
            // lblHoraAgendamento
            // 
            this.lblHoraAgendamento.AutoSize = true;
            this.lblHoraAgendamento.Location = new System.Drawing.Point(655, 9);
            this.lblHoraAgendamento.Name = "lblHoraAgendamento";
            this.lblHoraAgendamento.Size = new System.Drawing.Size(36, 13);
            this.lblHoraAgendamento.TabIndex = 111;
            this.lblHoraAgendamento.Text = "Hora: ";
            this.lblHoraAgendamento.Visible = false;
            // 
            // lblDataAgendamento
            // 
            this.lblDataAgendamento.AutoSize = true;
            this.lblDataAgendamento.Location = new System.Drawing.Point(368, 9);
            this.lblDataAgendamento.Name = "lblDataAgendamento";
            this.lblDataAgendamento.Size = new System.Drawing.Size(36, 13);
            this.lblDataAgendamento.TabIndex = 110;
            this.lblDataAgendamento.Text = "Data: ";
            this.lblDataAgendamento.Visible = false;
            // 
            // lblIdMedicoAgendamento
            // 
            this.lblIdMedicoAgendamento.AutoSize = true;
            this.lblIdMedicoAgendamento.Location = new System.Drawing.Point(265, 9);
            this.lblIdMedicoAgendamento.Name = "lblIdMedicoAgendamento";
            this.lblIdMedicoAgendamento.Size = new System.Drawing.Size(62, 13);
            this.lblIdMedicoAgendamento.TabIndex = 106;
            this.lblIdMedicoAgendamento.Text = "ID Medico: ";
            this.lblIdMedicoAgendamento.Visible = false;
            // 
            // lblIdPacienteAgendamento
            // 
            this.lblIdPacienteAgendamento.AutoSize = true;
            this.lblIdPacienteAgendamento.Location = new System.Drawing.Point(158, 9);
            this.lblIdPacienteAgendamento.Name = "lblIdPacienteAgendamento";
            this.lblIdPacienteAgendamento.Size = new System.Drawing.Size(69, 13);
            this.lblIdPacienteAgendamento.TabIndex = 104;
            this.lblIdPacienteAgendamento.Text = "ID Paciente: ";
            this.lblIdPacienteAgendamento.Visible = false;
            // 
            // lblCodigoAgendamento
            // 
            this.lblCodigoAgendamento.AutoSize = true;
            this.lblCodigoAgendamento.Location = new System.Drawing.Point(12, 9);
            this.lblCodigoAgendamento.Name = "lblCodigoAgendamento";
            this.lblCodigoAgendamento.Size = new System.Drawing.Size(115, 13);
            this.lblCodigoAgendamento.TabIndex = 102;
            this.lblCodigoAgendamento.Text = "Codigo Agendamento: ";
            // 
            // dgvMostraAgendamento
            // 
            this.dgvMostraAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraAgendamento.Location = new System.Drawing.Point(12, 95);
            this.dgvMostraAgendamento.Name = "dgvMostraAgendamento";
            this.dgvMostraAgendamento.Size = new System.Drawing.Size(776, 297);
            this.dgvMostraAgendamento.TabIndex = 112;
            // 
            // txtCodigoAgendamento
            // 
            this.txtCodigoAgendamento.Location = new System.Drawing.Point(15, 25);
            this.txtCodigoAgendamento.Name = "txtCodigoAgendamento";
            this.txtCodigoAgendamento.Size = new System.Drawing.Size(127, 20);
            this.txtCodigoAgendamento.TabIndex = 101;
            this.txtCodigoAgendamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoAgendamento_KeyPress);
            // 
            // btnAlterarAgendamento
            // 
            this.btnAlterarAgendamento.Location = new System.Drawing.Point(288, 398);
            this.btnAlterarAgendamento.Name = "btnAlterarAgendamento";
            this.btnAlterarAgendamento.Size = new System.Drawing.Size(223, 23);
            this.btnAlterarAgendamento.TabIndex = 114;
            this.btnAlterarAgendamento.Text = "Alterar";
            this.btnAlterarAgendamento.UseVisualStyleBackColor = true;
            this.btnAlterarAgendamento.Click += new System.EventHandler(this.btnAlterarAgendamento_Click);
            // 
            // btnExcluirAgendamento
            // 
            this.btnExcluirAgendamento.Location = new System.Drawing.Point(565, 398);
            this.btnExcluirAgendamento.Name = "btnExcluirAgendamento";
            this.btnExcluirAgendamento.Size = new System.Drawing.Size(223, 23);
            this.btnExcluirAgendamento.TabIndex = 115;
            this.btnExcluirAgendamento.Text = "Excluir";
            this.btnExcluirAgendamento.UseVisualStyleBackColor = true;
            this.btnExcluirAgendamento.Click += new System.EventHandler(this.btnExcluirAgendamento_Click);
            // 
            // btnPesquisarAgendamento
            // 
            this.btnPesquisarAgendamento.Location = new System.Drawing.Point(12, 398);
            this.btnPesquisarAgendamento.Name = "btnPesquisarAgendamento";
            this.btnPesquisarAgendamento.Size = new System.Drawing.Size(223, 23);
            this.btnPesquisarAgendamento.TabIndex = 113;
            this.btnPesquisarAgendamento.Text = "Pesquisar";
            this.btnPesquisarAgendamento.UseVisualStyleBackColor = true;
            this.btnPesquisarAgendamento.Click += new System.EventHandler(this.btnPesquisarAgendamento_Click);
            // 
            // txtIdPacienteAgendamento
            // 
            this.txtIdPacienteAgendamento.Location = new System.Drawing.Point(161, 25);
            this.txtIdPacienteAgendamento.Name = "txtIdPacienteAgendamento";
            this.txtIdPacienteAgendamento.Size = new System.Drawing.Size(100, 20);
            this.txtIdPacienteAgendamento.TabIndex = 116;
            this.txtIdPacienteAgendamento.Visible = false;
            this.txtIdPacienteAgendamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPacienteAgendamento_KeyPress);
            // 
            // txtIdMedicoAgendamento
            // 
            this.txtIdMedicoAgendamento.Location = new System.Drawing.Point(268, 25);
            this.txtIdMedicoAgendamento.Name = "txtIdMedicoAgendamento";
            this.txtIdMedicoAgendamento.Size = new System.Drawing.Size(100, 20);
            this.txtIdMedicoAgendamento.TabIndex = 117;
            this.txtIdMedicoAgendamento.Visible = false;
            this.txtIdMedicoAgendamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdMedicoAgendamento_KeyPress);
            // 
            // cbxHoraAgendamento
            // 
            this.cbxHoraAgendamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHoraAgendamento.FormattingEnabled = true;
            this.cbxHoraAgendamento.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00"});
            this.cbxHoraAgendamento.Location = new System.Drawing.Point(657, 25);
            this.cbxHoraAgendamento.Name = "cbxHoraAgendamento";
            this.cbxHoraAgendamento.Size = new System.Drawing.Size(121, 21);
            this.cbxHoraAgendamento.TabIndex = 118;
            this.cbxHoraAgendamento.Visible = false;
            // 
            // dtpDataAgendamento
            // 
            this.dtpDataAgendamento.Location = new System.Drawing.Point(374, 25);
            this.dtpDataAgendamento.Name = "dtpDataAgendamento";
            this.dtpDataAgendamento.Size = new System.Drawing.Size(275, 20);
            this.dtpDataAgendamento.TabIndex = 119;
            this.dtpDataAgendamento.Visible = false;
            // 
            // frmMostraAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDataAgendamento);
            this.Controls.Add(this.cbxHoraAgendamento);
            this.Controls.Add(this.txtIdMedicoAgendamento);
            this.Controls.Add(this.txtIdPacienteAgendamento);
            this.Controls.Add(this.btnAlterarAgendamento);
            this.Controls.Add(this.btnExcluirAgendamento);
            this.Controls.Add(this.btnPesquisarAgendamento);
            this.Controls.Add(this.btnSalvarAgendamento);
            this.Controls.Add(this.lblHoraAgendamento);
            this.Controls.Add(this.lblDataAgendamento);
            this.Controls.Add(this.lblIdMedicoAgendamento);
            this.Controls.Add(this.lblIdPacienteAgendamento);
            this.Controls.Add(this.lblCodigoAgendamento);
            this.Controls.Add(this.dgvMostraAgendamento);
            this.Controls.Add(this.txtCodigoAgendamento);
            this.Name = "frmMostraAgendamentos";
            this.Text = "frmMostraAgendamentos";
            this.Load += new System.EventHandler(this.frmMostraAgendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarAgendamento;
        private System.Windows.Forms.Label lblHoraAgendamento;
        private System.Windows.Forms.Label lblDataAgendamento;
        private System.Windows.Forms.Label lblIdMedicoAgendamento;
        private System.Windows.Forms.Label lblIdPacienteAgendamento;
        private System.Windows.Forms.Label lblCodigoAgendamento;
        private System.Windows.Forms.DataGridView dgvMostraAgendamento;
        private System.Windows.Forms.TextBox txtCodigoAgendamento;
        private System.Windows.Forms.Button btnAlterarAgendamento;
        private System.Windows.Forms.Button btnExcluirAgendamento;
        private System.Windows.Forms.Button btnPesquisarAgendamento;
        private System.Windows.Forms.TextBox txtIdPacienteAgendamento;
        private System.Windows.Forms.TextBox txtIdMedicoAgendamento;
        private System.Windows.Forms.ComboBox cbxHoraAgendamento;
        private System.Windows.Forms.DateTimePicker dtpDataAgendamento;
    }
}