using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trab_Final_POO
{
    public partial class frmMostraPacientes : Form
    {
        string NomeAntigoPaciente;
        string IdAntigoPaciente;
        public frmMostraPacientes()
        {
            InitializeComponent();
        }

        private void frmMostraPacientes_Load(object sender, EventArgs e)
        {
            try
            {
                Operacoes MyOp = new Operacoes(new Dados());
                MyOp.ListarPacientes(dgvMostraPaciente);
                dgvMostraPaciente.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaPaciente.Text != "" || txtIdPaciente.Text != "")
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.PesquisarPacientes(dgvMostraPaciente, txtPesquisaPaciente.Text, txtIdPaciente.Text);
                    txtPesquisaPaciente.Clear();
                    txtIdPaciente.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha o campo ID ou o campo Paciente para realizar a pesquisa!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnExcluirPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaPaciente.Text != "" || txtIdPaciente.Text != "")
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.ExcluirPacientes(dgvMostraPaciente, txtPesquisaPaciente.Text, txtIdPaciente.Text);
                    MyOp.ListarPacientes(dgvMostraPaciente);
                    txtPesquisaPaciente.Clear();
                    txtIdPaciente.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha o campo ID ou o campo Paciente para realizar a exclusão!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        

        private void btnSalvarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaPaciente.Text != "" && txtCpfPaciente.MaskCompleted == true && txtTelefonePaciente.MaskCompleted && txtEnderecoPaciente.Text != "" && cbxSexoPaciente.Text != "")
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.AlterarPacientes(dgvMostraPaciente, IdAntigoPaciente, NomeAntigoPaciente, txtPesquisaPaciente.Text, txtCpfPaciente.Text, txtTelefonePaciente.Text, txtEnderecoPaciente.Text, cbxSexoPaciente.Text);
                    lblCpfPaciente.Visible = false;
                    lblEnderecoPaciente.Visible = false;
                    lblSexoPaciente.Visible = false;
                    lblTelefonePaciente.Visible = false;
                    lblIdPaciente.Visible = true;
                    txtCpfPaciente.Visible = false;
                    txtEnderecoPaciente.Visible = false;
                    cbxSexoPaciente.Visible = false;
                    txtTelefonePaciente.Visible = false;
                    btnSalvarPaciente.Visible = false;
                    txtPesquisaPaciente.Text = null;
                    txtIdPaciente.Visible = true;
                    MyOp.ListarPacientes(dgvMostraPaciente);

                    txtCpfPaciente.Clear();
                    txtEnderecoPaciente.Clear();
                    txtIdPaciente.Clear();
                    txtPesquisaPaciente.Clear();
                    txtTelefonePaciente.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos acima para salvar!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnAlterarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaPaciente.Text != "" || txtIdPaciente.Text != "")
                {
                    lblCpfPaciente.Visible = true;
                    lblEnderecoPaciente.Visible = true;
                    lblSexoPaciente.Visible = true;
                    lblTelefonePaciente.Visible = true;
                    lblIdPaciente.Visible = false;
                    txtCpfPaciente.Visible = true;
                    txtEnderecoPaciente.Visible = true;
                    cbxSexoPaciente.Visible = true;
                    txtTelefonePaciente.Visible = true;
                    txtIdPaciente.Visible = false;
                    btnSalvarPaciente.Visible = true;
                    NomeAntigoPaciente = txtPesquisaPaciente.Text;
                    IdAntigoPaciente = txtIdPaciente.Text;
                }
                else
                {
                    MessageBox.Show("Preencha o campo ID ou o campo Paciente para realizar a alteração!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }            
        }

        private void txtIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
