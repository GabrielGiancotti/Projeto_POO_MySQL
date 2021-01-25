using System;
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
    public partial class frmMostraAgendamentos : Form
    {
        string IdAntigo;
        private Operacoes MyOp;
        public frmMostraAgendamentos()
        {
            InitializeComponent();
        }

        private void btnPesquisarAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoAgendamento.Text != "")
                {
                    MyOp = new Operacoes(new Dados());
                    MyOp.PesquisarAgendamento(dgvMostraAgendamento, txtCodigoAgendamento.Text);
                    dgvMostraAgendamento.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos Acima!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void frmMostraAgendamentos_Load(object sender, EventArgs e)
        {
            try
            {
                MyOp = new Operacoes(new Dados());
                MyOp.ListarAgendamentos(dgvMostraAgendamento);

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnAlterarAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoAgendamento.Text != "")
                {
                    lblCodigoAgendamento.Visible = true;
                    lblDataAgendamento.Visible = true;
                    lblHoraAgendamento.Visible = true;
                    lblIdMedicoAgendamento.Visible = true;
                    lblIdPacienteAgendamento.Visible = true;
                    txtCodigoAgendamento.Visible = true;
                    dtpDataAgendamento.Visible = true;
                    cbxHoraAgendamento.Visible = true;
                    txtIdMedicoAgendamento.Visible = true;
                    txtIdPacienteAgendamento.Visible = true;
                    btnSalvarAgendamento.Visible = true;
                    IdAntigo = txtCodigoAgendamento.Text;
                    txtCodigoAgendamento.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos Acima!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnExcluirAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoAgendamento.Text != "")
                {
                    MyOp = new Operacoes(new Dados());
                    MyOp.ExcluirAgendamento(dgvMostraAgendamento, txtCodigoAgendamento.Text);
                    MyOp.ListarAgendamentos(dgvMostraAgendamento);
                    txtCodigoAgendamento.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos Acima!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnSalvarAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoAgendamento.Text != "" && dtpDataAgendamento.Text != "" && txtIdPacienteAgendamento.Text != "" && txtIdMedicoAgendamento.Text != "" && cbxHoraAgendamento.Text != "")
                {
                    MyOp = new Operacoes(new Dados());
                    IdAntigo = txtCodigoAgendamento.Text;
                    MyOp.AlterarAgendamento(dgvMostraAgendamento, IdAntigo, dtpDataAgendamento.Text, txtIdMedicoAgendamento.Text, txtIdPacienteAgendamento.Text, cbxHoraAgendamento.Text);
                    lblDataAgendamento.Visible = false;
                    lblHoraAgendamento.Visible = false;
                    lblIdMedicoAgendamento.Visible = false;
                    lblIdPacienteAgendamento.Visible = false;
                    dtpDataAgendamento.Visible = false;
                    txtIdMedicoAgendamento.Visible = false;
                    txtIdPacienteAgendamento.Visible = false;
                    cbxHoraAgendamento.Visible = false;
                    btnSalvarAgendamento.Visible = false;
                    txtCodigoAgendamento.Text = null;
                    txtCodigoAgendamento.Enabled = true;
                    MyOp.ListarAgendamentos(dgvMostraAgendamento);
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos Acima!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void txtCodigoAgendamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtIdPacienteAgendamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtIdMedicoAgendamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
