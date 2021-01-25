namespace Trab_Final_POO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mnuProntuario = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCadastroMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCadastroProntuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCadastroAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPesquisarPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPesquisarMedicos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPesquisarProntuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPesquisaAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExcluirPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExcluirMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExcluirProntuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExcluirAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlterarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAlterarMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAlterarProntuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAlterarAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProntuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuProntuario
            // 
            resources.ApplyResources(this.mnuProntuario, "mnuProntuario");
            this.mnuProntuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro,
            this.mnuPesquisar,
            this.mnuExcluir,
            this.mnuAlterar,
            this.mnuJanela,
            this.mnuSair});
            this.mnuProntuario.Name = "mnuProntuario";
            // 
            // mnuCadastro
            // 
            resources.ApplyResources(this.mnuCadastro, "mnuCadastro");
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroPaciente,
            this.toolStripSeparator1,
            this.mnuCadastroMedico,
            this.toolStripSeparator2,
            this.mnuCadastroProntuario,
            this.toolStripSeparator9,
            this.mnuCadastroAgendamento});
            this.mnuCadastro.Name = "mnuCadastro";
            // 
            // mnuCadastroPaciente
            // 
            resources.ApplyResources(this.mnuCadastroPaciente, "mnuCadastroPaciente");
            this.mnuCadastroPaciente.Name = "mnuCadastroPaciente";
            this.mnuCadastroPaciente.Click += new System.EventHandler(this.mnuCadastroPaciente_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // mnuCadastroMedico
            // 
            resources.ApplyResources(this.mnuCadastroMedico, "mnuCadastroMedico");
            this.mnuCadastroMedico.Name = "mnuCadastroMedico";
            this.mnuCadastroMedico.Click += new System.EventHandler(this.mnuCadastroMedico_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // mnuCadastroProntuario
            // 
            resources.ApplyResources(this.mnuCadastroProntuario, "mnuCadastroProntuario");
            this.mnuCadastroProntuario.Name = "mnuCadastroProntuario";
            this.mnuCadastroProntuario.Click += new System.EventHandler(this.mnuCadastroProntuario_Click);
            // 
            // toolStripSeparator9
            // 
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            // 
            // mnuCadastroAgendamento
            // 
            resources.ApplyResources(this.mnuCadastroAgendamento, "mnuCadastroAgendamento");
            this.mnuCadastroAgendamento.Name = "mnuCadastroAgendamento";
            this.mnuCadastroAgendamento.Click += new System.EventHandler(this.mnuCadastroAgendamento_Click);
            // 
            // mnuPesquisar
            // 
            resources.ApplyResources(this.mnuPesquisar, "mnuPesquisar");
            this.mnuPesquisar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPesquisarPacientes,
            this.toolStripSeparator5,
            this.mnuPesquisarMedicos,
            this.toolStripSeparator6,
            this.mnuPesquisarProntuario,
            this.toolStripSeparator10,
            this.mnuPesquisaAgendamento});
            this.mnuPesquisar.Name = "mnuPesquisar";
            // 
            // mnuPesquisarPacientes
            // 
            resources.ApplyResources(this.mnuPesquisarPacientes, "mnuPesquisarPacientes");
            this.mnuPesquisarPacientes.Name = "mnuPesquisarPacientes";
            this.mnuPesquisarPacientes.Click += new System.EventHandler(this.mnuPesquisarPacientes_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // mnuPesquisarMedicos
            // 
            resources.ApplyResources(this.mnuPesquisarMedicos, "mnuPesquisarMedicos");
            this.mnuPesquisarMedicos.Name = "mnuPesquisarMedicos";
            this.mnuPesquisarMedicos.Click += new System.EventHandler(this.mnuPesquisarMedicos_Click);
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // mnuPesquisarProntuario
            // 
            resources.ApplyResources(this.mnuPesquisarProntuario, "mnuPesquisarProntuario");
            this.mnuPesquisarProntuario.Name = "mnuPesquisarProntuario";
            this.mnuPesquisarProntuario.Click += new System.EventHandler(this.mnuPesquisarProntuario_Click);
            // 
            // toolStripSeparator10
            // 
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            // 
            // mnuPesquisaAgendamento
            // 
            resources.ApplyResources(this.mnuPesquisaAgendamento, "mnuPesquisaAgendamento");
            this.mnuPesquisaAgendamento.Name = "mnuPesquisaAgendamento";
            this.mnuPesquisaAgendamento.Click += new System.EventHandler(this.mnuPesquisaAgendamento_Click);
            // 
            // mnuExcluir
            // 
            resources.ApplyResources(this.mnuExcluir, "mnuExcluir");
            this.mnuExcluir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExcluirPacientes,
            this.toolStripSeparator3,
            this.mnuExcluirMedico,
            this.toolStripSeparator4,
            this.mnuExcluirProntuario,
            this.toolStripSeparator11,
            this.mnuExcluirAgendamento});
            this.mnuExcluir.Name = "mnuExcluir";
            // 
            // mnuExcluirPacientes
            // 
            resources.ApplyResources(this.mnuExcluirPacientes, "mnuExcluirPacientes");
            this.mnuExcluirPacientes.Name = "mnuExcluirPacientes";
            this.mnuExcluirPacientes.Click += new System.EventHandler(this.mnuExcluirPacientes_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // mnuExcluirMedico
            // 
            resources.ApplyResources(this.mnuExcluirMedico, "mnuExcluirMedico");
            this.mnuExcluirMedico.Name = "mnuExcluirMedico";
            this.mnuExcluirMedico.Click += new System.EventHandler(this.mnuExcluirMedico_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // mnuExcluirProntuario
            // 
            resources.ApplyResources(this.mnuExcluirProntuario, "mnuExcluirProntuario");
            this.mnuExcluirProntuario.Name = "mnuExcluirProntuario";
            this.mnuExcluirProntuario.Click += new System.EventHandler(this.mnuExcluirProntuario_Click);
            // 
            // toolStripSeparator11
            // 
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            // 
            // mnuExcluirAgendamento
            // 
            resources.ApplyResources(this.mnuExcluirAgendamento, "mnuExcluirAgendamento");
            this.mnuExcluirAgendamento.Name = "mnuExcluirAgendamento";
            this.mnuExcluirAgendamento.Click += new System.EventHandler(this.mnuExcluirAgendamento_Click);
            // 
            // mnuAlterar
            // 
            resources.ApplyResources(this.mnuAlterar, "mnuAlterar");
            this.mnuAlterar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlterarPaciente,
            this.toolStripSeparator7,
            this.mnuAlterarMedico,
            this.toolStripSeparator8,
            this.mnuAlterarProntuario,
            this.toolStripSeparator12,
            this.mnuAlterarAgendamento});
            this.mnuAlterar.Name = "mnuAlterar";
            // 
            // mnuAlterarPaciente
            // 
            resources.ApplyResources(this.mnuAlterarPaciente, "mnuAlterarPaciente");
            this.mnuAlterarPaciente.Name = "mnuAlterarPaciente";
            this.mnuAlterarPaciente.Click += new System.EventHandler(this.mnuAlterarPaciente_Click);
            // 
            // toolStripSeparator7
            // 
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            // 
            // mnuAlterarMedico
            // 
            resources.ApplyResources(this.mnuAlterarMedico, "mnuAlterarMedico");
            this.mnuAlterarMedico.Name = "mnuAlterarMedico";
            this.mnuAlterarMedico.Click += new System.EventHandler(this.mnuAlterarMedico_Click);
            // 
            // toolStripSeparator8
            // 
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            // 
            // mnuAlterarProntuario
            // 
            resources.ApplyResources(this.mnuAlterarProntuario, "mnuAlterarProntuario");
            this.mnuAlterarProntuario.Name = "mnuAlterarProntuario";
            this.mnuAlterarProntuario.Click += new System.EventHandler(this.mnuAlterarProntuario_Click);
            // 
            // toolStripSeparator12
            // 
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            // 
            // mnuAlterarAgendamento
            // 
            resources.ApplyResources(this.mnuAlterarAgendamento, "mnuAlterarAgendamento");
            this.mnuAlterarAgendamento.Name = "mnuAlterarAgendamento";
            this.mnuAlterarAgendamento.Click += new System.EventHandler(this.mnuAlterarAgendamento_Click);
            // 
            // mnuJanela
            // 
            resources.ApplyResources(this.mnuJanela, "mnuJanela");
            this.mnuJanela.Name = "mnuJanela";
            this.mnuJanela.Click += new System.EventHandler(this.mnuJanela_Click);
            // 
            // mnuSair
            // 
            resources.ApplyResources(this.mnuSair, "mnuSair");
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mnuProntuario);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuProntuario;
            this.Name = "Form1";
            this.mnuProntuario.ResumeLayout(false);
            this.mnuProntuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProntuario;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroPaciente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroMedico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroProntuario;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuJanela;
        private System.Windows.Forms.ToolStripMenuItem mnuPesquisar;
        private System.Windows.Forms.ToolStripMenuItem mnuExcluir;
        private System.Windows.Forms.ToolStripMenuItem mnuExcluirPacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuExcluirMedico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuExcluirProntuario;
        private System.Windows.Forms.ToolStripMenuItem mnuPesquisarPacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuPesquisarMedicos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuPesquisarProntuario;
        private System.Windows.Forms.ToolStripMenuItem mnuAlterar;
        private System.Windows.Forms.ToolStripMenuItem mnuAlterarPaciente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnuAlterarMedico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnuAlterarProntuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroAgendamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem mnuPesquisaAgendamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem mnuExcluirAgendamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem mnuAlterarAgendamento;
    }
}

