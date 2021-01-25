using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Trab_Final_POO
{
    class Dados
    {
        private MySqlConnection conexao = new MySqlConnection("server=localhost;database=trabalho_poo;uid=root;password=");
        private MySqlDataAdapter adaptacao;
        private DataSet dataSet;
        public void InserirPaciente(Paciente paciente)
        {
            conexao.Open();
            String comando = "INSERT INTO paciente(id, nome, cpf, telefone, sexo, endereco) " +
                "VALUES (null, " + "'" + paciente.Nome.ToUpper() + "','" + paciente.CPF.ToUpper() + "','" + paciente.Telefone.ToUpper() + "','" + paciente.Sexo.ToUpper() + "','" + paciente.Endereco.ToUpper() + "')";
            MySqlCommand comandos = new MySqlCommand(comando, conexao);

            //Executa a Query SQL
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public void InserirMedico(Medico medico)
        {
            conexao.Open();
            String comando = "INSERT INTO medico(id, nome, cpf, telefone, sexo, endereco, crm, especialidade) " +
                "VALUES (null, " + "'" + medico.Nome.ToUpper() + "','" + medico.CPF.ToUpper() + "','" + medico.Telefone.ToUpper() + "','" + medico.Sexo.ToUpper() + "','" + medico.Endereco.ToUpper() + "','" + medico.CRM.ToUpper() + "','" + medico.Especialidade.ToUpper() + "')";
            MySqlCommand comandos = new MySqlCommand(comando, conexao);

            //Executa a Query SQL
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public void InserirAgendamento(Agendamento Agend)
        {
            conexao.Open();
            String comando = "INSERT INTO agendamento(id, data, hora, idpaciente, idmedico) " +
                "VALUES (null, " + "'" + Agend.DataAgendamento.ToUpper() + "','" + Agend.HoraAgendamento.ToUpper() + "', " + Agend.IdPacienteAgendamento + ", " + Agend.IdMedicoAgendamento +");";
            MySqlCommand comandos = new MySqlCommand(comando, conexao);

            //Executa a Query SQL
            comandos.ExecuteNonQuery();
            conexao.Close();

        }

        public void InserirProntuario(Prontuario prontuario)
        {           
            conexao.Open();
            String comando = "INSERT INTO prontuario(guia, data, indicacao, prioridade, medicacao, diabetes, cardiaco, hipertenso, alergia, fumante, alcoolismo, observacao, idpaciente, idmedico) " +
                "VALUES (null, " + "'" + prontuario.DataPront.ToUpper() + "','" + prontuario.IndicacaoClinica.ToUpper() + "','" + prontuario.Prioridade.ToUpper() + "','" + prontuario.Medicacao.ToUpper() + "','" + prontuario.Diabetes.ToUpper() + "','" + prontuario.Cardiaco.ToUpper() + "','" + prontuario.Hipertenso.ToUpper() + "','" + prontuario.Alergia.ToUpper() + "','" + prontuario.Fumante.ToUpper() + "','" + prontuario.Alcoolismo.ToUpper() + "','" + prontuario.Observacao.ToUpper() + "','" + prontuario.IdPaciente + "','" + prontuario.IdMedico + "')";
            MySqlCommand comandos = new MySqlCommand(comando, conexao);

            //Executa a Query SQL
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public DataSet ListaPacientes()
        {
            conexao.Open();
            dataSet = new DataSet();
            adaptacao = new MySqlDataAdapter("SELECT * FROM paciente", conexao);
            adaptacao.Fill(dataSet, "paciente");

            //Executa a Query SQL
            conexao.Close();
            return dataSet;
        }

        public DataSet ListarMedicos()
        {            
            conexao.Open();
            dataSet = new DataSet();
            adaptacao = new MySqlDataAdapter("SELECT * FROM medico", conexao);
            adaptacao.Fill(dataSet, "medico");
            conexao.Close();

            //Executa a Query SQL
            return dataSet;
        }

        public DataSet ListaAgendamentos()
        {
            conexao.Open();
            dataSet = new DataSet();
            adaptacao = new MySqlDataAdapter("SELECT agendamento.*, paciente.nome AS 'nome_paciente', medico.nome AS 'nome_medico' FROM agendamento Inner JOIN paciente on idpaciente = paciente.id Inner JOIN medico on idmedico = medico.id; ", conexao);
            adaptacao.Fill(dataSet, "agendamento");
            conexao.Close();

            //Executa a Query SQL
            return dataSet;
        }

        public DataSet ListarProntuarios()
        {
            conexao.Open();
            dataSet = new DataSet();
            adaptacao = new MySqlDataAdapter("SELECT prontuario.*, paciente.nome AS 'nome_paciente', medico.nome AS 'nome_medico' FROM `prontuario` Inner JOIN paciente on idpaciente = paciente.id Inner JOIN medico on idmedico = medico.id; ", conexao);
            adaptacao.Fill(dataSet, "prontuario");
            conexao.Close();

            //Executa a Query SQL
            return dataSet;
        }

        public DataSet PesquisarPacientes(string Nome, string Id)
        {
            Boolean temNome = false;
            Boolean temId = false;

            if (Nome != "")
            {
                temNome = true;
            }
            if (Id != "")
            {
                temId = true;
            }

            conexao.Open();
            dataSet = new DataSet();
            if (temNome == true && temId == true)
            {
                adaptacao = new MySqlDataAdapter("SELECT * FROM paciente where nome = '" + Nome.ToUpper() + "' and id = " + Id, conexao);
                adaptacao.Fill(dataSet, "paciente");
            }
            else if (temNome == true && temId == false)
            {
                adaptacao = new MySqlDataAdapter("SELECT * FROM paciente where nome = '" + Nome.ToUpper() + "'", conexao);
                adaptacao.Fill(dataSet, "paciente");
            }
            else if (temNome == false && temId == true)
            {
                adaptacao = new MySqlDataAdapter("SELECT * FROM paciente where id = " + Id, conexao);
                adaptacao.Fill(dataSet, "paciente");
            }
            conexao.Close();
            //Executa a Query SQL
            return dataSet;
        }

        public DataSet PesquisarMedico(string Nome, string Id)
        {
            Boolean temNome = false;
            Boolean temId = false;

            if (Nome != "")
            {
                temNome = true;
            }
            if (Id != "")
            {
                temId = true;
            }

            conexao.Open();
            dataSet = new DataSet();
            if (temNome == true && temId == true)
            {
                adaptacao = new MySqlDataAdapter("SELECT * FROM medico where nome = '" + Nome.ToUpper() + "' and id = " + Id, conexao);
                adaptacao.Fill(dataSet, "medico");
            }
            else if (temNome == true && temId == false)
            {
                adaptacao = new MySqlDataAdapter("SELECT * FROM medico where nome = '" + Nome.ToUpper() + "'", conexao);
                adaptacao.Fill(dataSet, "medico");
            }
            else if (temNome == false && temId == true)
            {
                adaptacao = new MySqlDataAdapter("SELECT * FROM medico where id = " + Id, conexao);
                adaptacao.Fill(dataSet, "medico");
            }
            conexao.Close();
            //Executa a Query SQL
            return dataSet;
        }

        public DataSet PesquisarAgendamento(string Id)
        {
            conexao.Open();
            dataSet = new DataSet();
            adaptacao = new MySqlDataAdapter("SELECT agendamento.*, paciente.nome AS 'nome_paciente', medico.nome AS 'nome_medico' FROM agendamento Inner JOIN paciente on idpaciente = paciente.id Inner JOIN medico on idmedico = medico.id where agendamento.id = " + Id + ";", conexao);
            adaptacao.Fill(dataSet, "agendamento");
            conexao.Close();

            //Executa a Query SQL
            return dataSet;
        }

        public DataSet PesquisarProntuario(string NumeroGuia)
        {            
            conexao.Open();
            dataSet = new DataSet();
            adaptacao = new MySqlDataAdapter("SELECT prontuario.*, paciente.nome AS 'nome_paciente', medico.nome AS 'nome_medico' FROM `prontuario` Inner JOIN paciente on idpaciente = paciente.id Inner JOIN medico on idmedico = medico.id where guia = " + NumeroGuia + ";", conexao);
            adaptacao.Fill(dataSet, "prontuario");
            conexao.Close();

            //Executa a Query SQL
            return dataSet;
        }
       
        public DataSet ExcluirPacientes(string Nome, string Id)
        {
            Boolean temNome = false;
            Boolean temId = false;

            if (Nome != "")
            {
                temNome = true;
            }
            if (Id != "")
            {
                temId = true;
            }

            conexao.Open();
            dataSet = new DataSet();
            if (temNome == true && temId == true)
            {
                adaptacao = new MySqlDataAdapter("DELETE FROM paciente where nome = '" + Nome.ToUpper() + "' and id = " + Id, conexao);
                adaptacao.Fill(dataSet, "paciente");
            }
            else if (temNome == true && temId == false)
            {
                adaptacao = new MySqlDataAdapter("DELETE FROM paciente where nome = '" + Nome.ToUpper() + "'", conexao);
                adaptacao.Fill(dataSet, "paciente");
            }
            else if (temNome == false && temId == true)
            {
                adaptacao = new MySqlDataAdapter("DELETE FROM paciente where id = " + Id, conexao);
                adaptacao.Fill(dataSet, "paciente");
            }
            conexao.Close();
            //Executa a Query SQL
            return dataSet;
        }

        public DataSet ExcluirMedico(string Nome, string Id)
        {           
            Boolean temNome = false;
            Boolean temId = false;

            if (Nome != "")
            {
                temNome = true;
            }
            if (Id != "")
            {
                temId = true;
            }

            conexao.Open();
            dataSet = new DataSet();
            if (temNome == true && temId == true)
            {
                adaptacao = new MySqlDataAdapter("DELETE FROM medico where nome = '" + Nome.ToUpper() + "' and id = " + Id, conexao);
                adaptacao.Fill(dataSet, "medico");
            }
            else if (temNome == true && temId == false)
            {
                adaptacao = new MySqlDataAdapter("DELETE FROM medico where nome = '" + Nome.ToUpper() + "'", conexao);
                adaptacao.Fill(dataSet, "medico");
            }
            else if (temNome == false && temId == true)
            {
                adaptacao = new MySqlDataAdapter("DELETE FROM medico where id = " + Id, conexao);
                adaptacao.Fill(dataSet, "medico");
            }
            conexao.Close();
            //Executa a Query SQL
            return dataSet;
        }

        public DataSet ExcluirAgendamento(string Id)
        {            
            conexao.Open();
            dataSet = new DataSet();
            adaptacao = new MySqlDataAdapter("DELETE FROM agendamento where id = " + Id + ";", conexao);
            adaptacao.Fill(dataSet, "agendamento");
            conexao.Close();

            //Executa a Query SQL
            return dataSet;
        }

        public DataSet ExcluirProntuario(string NumeroGuia)
        {
            conexao.Open();
            dataSet = new DataSet();
            adaptacao = new MySqlDataAdapter("DELETE FROM prontuario where guia = " + NumeroGuia + ";", conexao);
            adaptacao.Fill(dataSet, "prontuario");
            conexao.Close();

            //Executa a Query SQL
            return dataSet;
        }
       

        public DataSet AlterarPacientes(string IdAntigo, string NomeAntigo, Paciente meuPaciente)
        {      
            Boolean temNome = false;
            Boolean temId = false;

            if (NomeAntigo != "")
            {
                temNome = true;
            }
            if (IdAntigo != "")
            {
                temId = true;
            }

            conexao.Open();
            dataSet = new DataSet();
            if (temNome == true && temId == true)
            {
                adaptacao = new MySqlDataAdapter("UPDATE paciente SET nome = '" + meuPaciente.Nome.ToUpper() + "', cpf = '" + meuPaciente.CPF.ToUpper() + "', telefone = '" + meuPaciente.Telefone.ToUpper() + "', sexo = '" + meuPaciente.Sexo.ToUpper() + "', endereco = '" + meuPaciente.Endereco.ToUpper() + "' where id = " + IdAntigo + " and nome = '" + NomeAntigo.ToUpper() + "'", conexao);
                adaptacao.Fill(dataSet, "paciente");
            }
            else if (temNome == true && temId == false)
            {
                adaptacao = new MySqlDataAdapter("UPDATE paciente SET nome = '" + meuPaciente.Nome.ToUpper() + "', cpf = '" + meuPaciente.CPF.ToUpper() + "', telefone = '" + meuPaciente.Telefone.ToUpper() + "', sexo = '" + meuPaciente.Sexo.ToUpper() + "', endereco = '" + meuPaciente.Endereco.ToUpper() + "' where nome = '" + NomeAntigo.ToUpper() + "'", conexao);
                adaptacao.Fill(dataSet, "paciente");
            }
            else if (temNome == false && temId == true)
            {
                adaptacao = new MySqlDataAdapter("UPDATE paciente SET nome = '" + meuPaciente.Nome.ToUpper() + "', cpf = '" + meuPaciente.CPF.ToUpper() + "', telefone = '" + meuPaciente.Telefone.ToUpper() + "', sexo = '" + meuPaciente.Sexo.ToUpper() + "', endereco = '" + meuPaciente.Endereco.ToUpper() + "' where id = " + IdAntigo, conexao);
                adaptacao.Fill(dataSet, "paciente");
            }
            conexao.Close();
            //Executa a Query SQL
            return dataSet;
        }

        public DataSet AlterarAgendamento(string IdAntigo, Agendamento myAgend)
        {
            conexao.Open();
            dataSet = new DataSet();
            adaptacao = new MySqlDataAdapter("UPDATE agendamento SET data = '" + myAgend.DataAgendamento.ToUpper() + "'," +
                "hora = '" + myAgend.HoraAgendamento + "'," +
                "idpaciente = " + myAgend.IdPacienteAgendamento + "," +
                "idmedico = " + myAgend.IdMedicoAgendamento +
                " where id = " + IdAntigo, conexao);
            adaptacao.Fill(dataSet, "agendamento");
            conexao.Close();

            //Executa a Query SQL
            return dataSet;
        }

        public DataSet AlterarMedico(string IdAntigo, string NomeAntigo, Medico MeuMedico)
        {
            Boolean temNome = false;
            Boolean temId = false;

            if (NomeAntigo != "")
            {
                temNome = true;
            }
            if (IdAntigo != "")
            {
                temId = true;
            }

            conexao.Open();
            dataSet = new DataSet();
            if (temNome == true && temId == true)
            {
                adaptacao = new MySqlDataAdapter("UPDATE medico SET nome = '" + MeuMedico.Nome.ToUpper() + "', cpf = '" + MeuMedico.CPF.ToUpper() + "', telefone = '" + MeuMedico.Telefone.ToUpper() + "', endereco = '" + MeuMedico.Endereco.ToUpper() + "', sexo = '" + MeuMedico.Sexo.ToUpper() + "', crm = '" + MeuMedico.CRM.ToUpper() + "', especialidade = '" + MeuMedico.Especialidade.ToUpper() + "' where id = " + IdAntigo + " and nome = '" + NomeAntigo.ToUpper() + "'", conexao);
                adaptacao.Fill(dataSet, "medico");
            }
            else if (temNome == true && temId == false)
            {
                adaptacao = new MySqlDataAdapter("UPDATE medico SET nome = '" + MeuMedico.Nome.ToUpper() + "', cpf = '" + MeuMedico.CPF.ToUpper() + "', telefone = '" + MeuMedico.Telefone.ToUpper() + "', endereco = '" + MeuMedico.Endereco.ToUpper() + "', sexo = '" + MeuMedico.Sexo.ToUpper() + "', crm = '" + MeuMedico.CRM.ToUpper() + "', especialidade = '" + MeuMedico.Especialidade.ToUpper() + "' where nome = '" + NomeAntigo.ToUpper() + "'", conexao);
                adaptacao.Fill(dataSet, "medico");
            }
            else if (temNome == false && temId == true)
            {
                adaptacao = new MySqlDataAdapter("UPDATE medico SET nome = '" + MeuMedico.Nome.ToUpper() + "', cpf = '" + MeuMedico.CPF.ToUpper() + "', telefone = '" + MeuMedico.Telefone.ToUpper() + "', endereco = '" + MeuMedico.Endereco.ToUpper() + "', sexo = '" + MeuMedico.Sexo.ToUpper() + "', crm = '" + MeuMedico.CRM.ToUpper() + "', especialidade = '" + MeuMedico.Especialidade.ToUpper() + "' where id = " + IdAntigo, conexao);
                adaptacao.Fill(dataSet, "medico");
            }
            conexao.Close();
            //Executa a Query SQL
            return dataSet;
        }

        public DataSet AlterarProntuario(string NumeroGuia, Prontuario MeuPront)
        {           
            conexao.Open();
            dataSet = new DataSet();
            adaptacao = new MySqlDataAdapter("UPDATE prontuario SET data = '" + MeuPront.DataPront.ToUpper() + "'," + 
                "indicacao = '" + MeuPront.IndicacaoClinica.ToUpper() + "'," +
                "prioridade = '" + MeuPront.Prioridade.ToUpper() + "'," + 
                "medicacao = '" + MeuPront.Medicacao.ToUpper() + "'," + 
                "diabetes = '" + MeuPront.Diabetes.ToUpper() + "'," + 
                "cardiaco = '" + MeuPront.Cardiaco.ToUpper() + "'," + 
                "hipertenso = '" + MeuPront.Hipertenso.ToUpper() + "'," + 
                "alergia = '" + MeuPront.Alergia.ToUpper() + "'," + 
                "fumante = '" + MeuPront.Fumante.ToUpper() + "'," + 
                "alcoolismo = '" + MeuPront.Alcoolismo.ToUpper() + "'," + 
                "observacao = '" + MeuPront.Observacao.ToUpper() + "'," +  
                "idpaciente = " + MeuPront.IdPaciente + "," + 
                "idmedico = " + MeuPront.IdMedico +  
                " where guia = " + NumeroGuia, conexao);
            adaptacao.Fill(dataSet, "prontuario");
            conexao.Close();

            //Executa a Query SQL
            return dataSet;
        }
    }
}
