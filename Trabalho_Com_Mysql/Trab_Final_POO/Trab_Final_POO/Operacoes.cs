using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trab_Final_POO
{
    class Operacoes
    {
        private Dados MeusDados;
        private Paciente MeuPaciente;
        private Medico MeuMedico;
        private Prontuario MeuProntuario;
        private Agendamento MyAgend;

        public Operacoes(Dados D)
        {
            MeusDados = new Dados();
        }

        public void InserirPaciente(string nome, string cpf, string telefone, string endereco, string sexo)
        {
            MeuPaciente = new Paciente();
            MeuPaciente.Nome = nome;
            MeuPaciente.CPF = cpf;
            MeuPaciente.Telefone = telefone;
            MeuPaciente.Endereco = endereco;
            MeuPaciente.Sexo = sexo;

            MeusDados.InserirPaciente(MeuPaciente);

        }

        public void InserirMedico(string nome, string cpf, string telefone, string endereco, string sexo, string crm, string especialidade)
        {
            MeuMedico = new Medico();
            MeuMedico.Nome = nome;
            MeuMedico.CPF = cpf;
            MeuMedico.Telefone = telefone;
            MeuMedico.Endereco = endereco;
            MeuMedico.Sexo = sexo;
            MeuMedico.CRM = crm;
            MeuMedico.Especialidade = especialidade;

            MeusDados.InserirMedico(MeuMedico);
        }

        public void InserirAgendamento(string idpaciente, string idmedico, string data, string hora)
        {
            Agendamento MeuAgendamento = new Agendamento();
            MeuAgendamento.IdMedicoAgendamento = idmedico;
            MeuAgendamento.IdPacienteAgendamento = idpaciente;
            MeuAgendamento.DataAgendamento = data;
            MeuAgendamento.HoraAgendamento = hora;

            MeusDados.InserirAgendamento(MeuAgendamento);
        }

        public void InserirProntuario(string dataprontuario, string indicacao, string prioridade, string medicacao, string diabete, string cardiaco, string hipertenso, string alergia, string fumante, string alcoolotra, string observacao, string nomepacienteprontuario, string nomemedicoprontuario)
        {
            Prontuario MeuProntuario = new Prontuario();
            MeuProntuario.DataPront = dataprontuario;
            MeuProntuario.IndicacaoClinica = indicacao;
            MeuProntuario.Prioridade = prioridade;
            MeuProntuario.Medicacao = medicacao;
            MeuProntuario.Diabetes = diabete;
            MeuProntuario.Cardiaco = cardiaco;
            MeuProntuario.Hipertenso = hipertenso;
            MeuProntuario.Alergia = alergia;
            MeuProntuario.Fumante = fumante;
            MeuProntuario.Alcoolismo = alcoolotra;
            MeuProntuario.Observacao = observacao;
            MeuProntuario.IdPaciente = nomepacienteprontuario;
            MeuProntuario.IdMedico = nomemedicoprontuario;

            MeusDados.InserirProntuario(MeuProntuario);
        }

        public void ListarPacientes(DataGridView data)
        {
            data.DataSource = MeusDados.ListaPacientes();
            data.DataMember = "paciente";
        }

        public void ListarMedicos(DataGridView data)
        {
            data.DataSource = MeusDados.ListarMedicos();
            data.DataMember = "medico";
        }

        public void ListarAgendamentos(DataGridView data)
        {
            data.DataSource = MeusDados.ListaAgendamentos();
            data.DataMember = "agendamento";
        }

        public void ListarProntuarios(DataGridView data)
        {
            data.DataSource = MeusDados.ListarProntuarios();
            data.DataMember = "prontuario";
        }

        public void PesquisarPacientes(DataGridView data, string nome, string id)
        {
            data.DataSource = MeusDados.PesquisarPacientes(nome, id);
            data.DataMember = "paciente";
        }

        public void PesquisarMedico(DataGridView data, string nome, string id)
        {
            data.DataSource = MeusDados.PesquisarMedico(nome, id);
            data.DataMember = "medico";
        }

        public void PesquisarAgendamento(DataGridView data, string id)
        {
            data.DataSource = MeusDados.PesquisarAgendamento(id);
        }

        public void PesquisarProntuario(DataGridView data, string numeroguia)
        {
            data.DataSource = MeusDados.PesquisarProntuario(numeroguia);
        }
        
        public void ExcluirPacientes(DataGridView data, string nome, string id)
        {
            data.DataSource = MeusDados.ExcluirPacientes(nome, id);
        }

        public void ExcluirMedico(DataGridView data, string nome, string id)
        {
            data.DataSource = MeusDados.ExcluirMedico(nome, id);
        }

        public void ExcluirAgendamento(DataGridView data, string id)
        {
            data.DataSource = MeusDados.ExcluirAgendamento(id);
        }

        public void ExcluirProntuario(DataGridView data, string numeroguia)
        {
            data.DataSource = MeusDados.ExcluirProntuario(numeroguia);
        }
        
        public void AlterarMedico(DataGridView data, string idantigo, string nomeantigo, string nome, string cpf, string telefone, string endereco, string sexo, string crm, string especialidade)
        {
            MeuMedico = new Medico();
            MeuMedico.Nome = nome;
            MeuMedico.CPF = cpf;
            MeuMedico.Telefone = telefone;
            MeuMedico.Endereco = endereco;
            MeuMedico.Sexo = sexo;
            MeuMedico.CRM = crm;
            MeuMedico.Especialidade = especialidade;
            data.DataSource = MeusDados.AlterarMedico(idantigo, nomeantigo, MeuMedico);
        }

        public void AlterarPacientes(DataGridView data, string idantigo, string nomeantigo, string nome, string cpf, string telefone, string endereco, string sexo)
        {
            MeuPaciente = new Paciente();
            MeuPaciente.Nome = nome;
            MeuPaciente.CPF = cpf;
            MeuPaciente.Telefone = telefone;
            MeuPaciente.Endereco = endereco;
            MeuPaciente.Sexo = sexo;
            data.DataSource = MeusDados.AlterarPacientes(idantigo, nomeantigo, MeuPaciente);
        }

        public void AlterarAgendamento(DataGridView data, string idantigo, string dataconsulta, string idmedico, string idpaciente, string hora)
        {
            MyAgend = new Agendamento();
            MyAgend.DataAgendamento = dataconsulta;
            MyAgend.HoraAgendamento = hora;
            MyAgend.IdPacienteAgendamento = idpaciente;
            MyAgend.IdMedicoAgendamento = idmedico;
            data.DataSource = MeusDados.AlterarAgendamento(idantigo, MyAgend);
        }

        public void AlterarProntuario(DataGridView data,string numeroguiaantigo, string datapron, string indicacao, string prioridade, string medicacao, string diabete, string cardiaco, string hipertensao, string alergia, string fumante, string alcoolotra, string observacao, string idpacientepront, string idmedicopront)
        {
            MeuProntuario = new Prontuario();
            MeuProntuario.DataPront = datapron;
            MeuProntuario.IndicacaoClinica = indicacao;
            MeuProntuario.Prioridade = prioridade;
            MeuProntuario.Medicacao = medicacao;
            MeuProntuario.Diabetes = diabete;
            MeuProntuario.Cardiaco = cardiaco;
            MeuProntuario.Hipertenso = hipertensao;
            MeuProntuario.Alergia = alergia;
            MeuProntuario.Fumante = fumante;
            MeuProntuario.Alcoolismo = alcoolotra;
            MeuProntuario.Observacao = observacao;
            MeuProntuario.IdPaciente = idpacientepront;
            MeuProntuario.IdMedico = idmedicopront;

            data.DataSource = MeusDados.AlterarProntuario(numeroguiaantigo, MeuProntuario);
        }
        
    }
}
