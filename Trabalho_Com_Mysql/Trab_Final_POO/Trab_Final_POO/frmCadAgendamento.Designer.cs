namespace Trab_Final_POO
{
    partial class frmCadAgendamento
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
            this.txtIdPacienteAge = new System.Windows.Forms.TextBox();
            this.txtIdMedicoAge = new System.Windows.Forms.TextBox();
            this.lblIdPacienteAge = new System.Windows.Forms.Label();
            this.lblIdMedicoAgen = new System.Windows.Forms.Label();
            this.btnCadastrarAgendamento = new System.Windows.Forms.Button();
            this.dtpDataAgendamento = new System.Windows.Forms.DateTimePicker();
            this.lblDataAgendamento = new System.Windows.Forms.Label();
            this.cbxHoraAgendamento = new System.Windows.Forms.ComboBox();
            this.lblHoraAgendamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdPacienteAge
            // 
            this.txtIdPacienteAge.Location = new System.Drawing.Point(9, 131);
            this.txtIdPacienteAge.Name = "txtIdPacienteAge";
            this.txtIdPacienteAge.Size = new System.Drawing.Size(272, 20);
            this.txtIdPacienteAge.TabIndex = 3;
            this.txtIdPacienteAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPacienteAge_KeyPress);
            // 
            // txtIdMedicoAge
            // 
            this.txtIdMedicoAge.Location = new System.Drawing.Point(12, 33);
            this.txtIdMedicoAge.Name = "txtIdMedicoAge";
            this.txtIdMedicoAge.Size = new System.Drawing.Size(272, 20);
            this.txtIdMedicoAge.TabIndex = 2;
            this.txtIdMedicoAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdMedicoAge_KeyPress);
            // 
            // lblIdPacienteAge
            // 
            this.lblIdPacienteAge.AutoSize = true;
            this.lblIdPacienteAge.Location = new System.Drawing.Point(9, 115);
            this.lblIdPacienteAge.Name = "lblIdPacienteAge";
            this.lblIdPacienteAge.Size = new System.Drawing.Size(82, 13);
            this.lblIdPacienteAge.TabIndex = 15;
            this.lblIdPacienteAge.Text = "Id do Paciente: ";
            // 
            // lblIdMedicoAgen
            // 
            this.lblIdMedicoAgen.AutoSize = true;
            this.lblIdMedicoAgen.Location = new System.Drawing.Point(9, 14);
            this.lblIdMedicoAgen.Name = "lblIdMedicoAgen";
            this.lblIdMedicoAgen.Size = new System.Drawing.Size(76, 13);
            this.lblIdMedicoAgen.TabIndex = 14;
            this.lblIdMedicoAgen.Text = "ID do medico: ";
            // 
            // btnCadastrarAgendamento
            // 
            this.btnCadastrarAgendamento.Location = new System.Drawing.Point(12, 398);
            this.btnCadastrarAgendamento.Name = "btnCadastrarAgendamento";
            this.btnCadastrarAgendamento.Size = new System.Drawing.Size(776, 23);
            this.btnCadastrarAgendamento.TabIndex = 6;
            this.btnCadastrarAgendamento.Text = "Cadastrar";
            this.btnCadastrarAgendamento.UseVisualStyleBackColor = true;
            this.btnCadastrarAgendamento.Click += new System.EventHandler(this.btnCadastrarAgendamento_Click);
            // 
            // dtpDataAgendamento
            // 
            this.dtpDataAgendamento.Location = new System.Drawing.Point(9, 221);
            this.dtpDataAgendamento.Name = "dtpDataAgendamento";
            this.dtpDataAgendamento.Size = new System.Drawing.Size(275, 20);
            this.dtpDataAgendamento.TabIndex = 4;
            // 
            // lblDataAgendamento
            // 
            this.lblDataAgendamento.AutoSize = true;
            this.lblDataAgendamento.Location = new System.Drawing.Point(6, 202);
            this.lblDataAgendamento.Name = "lblDataAgendamento";
            this.lblDataAgendamento.Size = new System.Drawing.Size(36, 13);
            this.lblDataAgendamento.TabIndex = 20;
            this.lblDataAgendamento.Text = "Data: ";
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
            this.cbxHoraAgendamento.Location = new System.Drawing.Point(12, 314);
            this.cbxHoraAgendamento.Name = "cbxHoraAgendamento";
            this.cbxHoraAgendamento.Size = new System.Drawing.Size(121, 21);
            this.cbxHoraAgendamento.TabIndex = 5;
            // 
            // lblHoraAgendamento
            // 
            this.lblHoraAgendamento.AutoSize = true;
            this.lblHoraAgendamento.Location = new System.Drawing.Point(12, 295);
            this.lblHoraAgendamento.Name = "lblHoraAgendamento";
            this.lblHoraAgendamento.Size = new System.Drawing.Size(36, 13);
            this.lblHoraAgendamento.TabIndex = 21;
            this.lblHoraAgendamento.Text = "Hora: ";
            // 
            // frmCadAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cbxHoraAgendamento);
            this.Controls.Add(this.lblHoraAgendamento);
            this.Controls.Add(this.lblDataAgendamento);
            this.Controls.Add(this.dtpDataAgendamento);
            this.Controls.Add(this.txtIdPacienteAge);
            this.Controls.Add(this.txtIdMedicoAge);
            this.Controls.Add(this.lblIdPacienteAge);
            this.Controls.Add(this.lblIdMedicoAgen);
            this.Controls.Add(this.btnCadastrarAgendamento);
            this.Name = "frmCadAgendamento";
            this.Text = "frmCadAgendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdPacienteAge;
        private System.Windows.Forms.TextBox txtIdMedicoAge;
        private System.Windows.Forms.Label lblIdPacienteAge;
        private System.Windows.Forms.Label lblIdMedicoAgen;
        private System.Windows.Forms.Button btnCadastrarAgendamento;
        private System.Windows.Forms.DateTimePicker dtpDataAgendamento;
        private System.Windows.Forms.Label lblDataAgendamento;
        private System.Windows.Forms.ComboBox cbxHoraAgendamento;
        private System.Windows.Forms.Label lblHoraAgendamento;
    }
}