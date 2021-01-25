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
    public partial class frmMostraProntuario : Form
    {
        string numeroguiaantigo;
        public frmMostraProntuario()
        {
            InitializeComponent();
        }

        private void frmMostraProntuario_Load(object sender, EventArgs e)
        {
            try
            {
                Operacoes MyOp = new Operacoes(new Dados());
                MyOp.ListarProntuarios(dgvMostraProntuario);
                dgvMostraProntuario.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnPesquisarProntuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroGuia.Text != "")
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.PesquisarProntuario(dgvMostraProntuario, txtNumeroGuia.Text);
                    txtNumeroGuia.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha o número da guia para realizar a pesquisa!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnAlterarProntuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroGuia.Text != "")
                {
                    lblAlcoolatraProntuario.Visible = true;
                    lblAlergiaProntuario.Visible = true;
                    lblCardiacoProntuario.Visible = true;
                    lblDataProntuario.Visible = true;
                    lblDiabeteProntuario.Visible = true;
                    lblFumanteProntuario.Visible = true;
                    lblHipertensaoProntuario.Visible = true;
                    lblIndicacaoProntuario.Visible = true;
                    lblMedicacaoProntuario.Visible = true;
                    lblIdMedicoProntuario.Visible = true;
                    lblIdPacienteProntuario.Visible = true;
                    lblObservacaoProntuario.Visible = true;
                    lblPrioridadeProntuario.Visible = true;
                    txtIndicacaoProntuario.Visible = true;
                    txtMedicacaoProntuario.Visible = true;
                    txtIdMedicoProntuario.Visible = true;
                    txtIdPacienteProntuario.Visible = true;
                    txtObservacaoProntuario.Visible = true;
                    txtPrioridadeProntuario.Visible = true;
                    dtpDataProntuario.Visible = true;
                    cbxAlcoolotraProntuario.Visible = true;
                    cbxAlergiaProntuario.Visible = true;
                    cbxCardiacoProntuario.Visible = true;
                    cbxDiabeteProntuario.Visible = true;
                    cbxFumanteProntuario.Visible = true;
                    cbxHipertensaoProntuario.Visible = true;
                    btnSalvarProntuario.Visible = true;
                    txtNumeroGuia.Enabled = false;
                    numeroguiaantigo = txtNumeroGuia.Text;
                }
                else
                {
                    MessageBox.Show("Preencha o campo guia para realizar a alteração!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnExcluirProntuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeroGuia.Text != "")
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.ExcluirProntuario(dgvMostraProntuario, txtNumeroGuia.Text);
                    MyOp.ListarProntuarios(dgvMostraProntuario);
                    txtNumeroGuia.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha o campo guia para realizar a exclusão!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnSalvarProntuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDataProntuario.Text != "" && txtIndicacaoProntuario.Text != "" && txtPrioridadeProntuario.Text != "" && txtMedicacaoProntuario.Text != "" && cbxDiabeteProntuario.Text != "" && cbxCardiacoProntuario.Text != "" && cbxHipertensaoProntuario.Text != "" && cbxAlergiaProntuario.Text != "" && cbxFumanteProntuario.Text != "" && cbxAlcoolotraProntuario.Text != "" && txtObservacaoProntuario.Text != "" && txtIdPacienteProntuario.Text != "" && txtIdMedicoProntuario.Text != "")
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.AlterarProntuario(dgvMostraProntuario, numeroguiaantigo, dtpDataProntuario.Text, txtIndicacaoProntuario.Text, txtPrioridadeProntuario.Text, txtMedicacaoProntuario.Text, cbxDiabeteProntuario.Text, cbxCardiacoProntuario.Text, cbxHipertensaoProntuario.Text, cbxAlergiaProntuario.Text, cbxFumanteProntuario.Text, cbxAlcoolotraProntuario.Text, txtObservacaoProntuario.Text, txtIdPacienteProntuario.Text, txtIdMedicoProntuario.Text);
                    lblAlcoolatraProntuario.Visible = false;
                    lblAlergiaProntuario.Visible = false;
                    lblCardiacoProntuario.Visible = false;
                    lblDataProntuario.Visible = false;
                    lblDiabeteProntuario.Visible = false;
                    lblFumanteProntuario.Visible = false;
                    lblHipertensaoProntuario.Visible = false;
                    lblIndicacaoProntuario.Visible = false;
                    lblMedicacaoProntuario.Visible = false;
                    lblIdMedicoProntuario.Visible = false;
                    lblIdPacienteProntuario.Visible = false;
                    lblObservacaoProntuario.Visible = false;
                    lblPrioridadeProntuario.Visible = false;
                    txtIndicacaoProntuario.Visible = false;
                    txtMedicacaoProntuario.Visible = false;
                    txtIdMedicoProntuario.Visible = false;
                    txtIdPacienteProntuario.Visible = false;
                    txtObservacaoProntuario.Visible = false;
                    txtPrioridadeProntuario.Visible = false;
                    dtpDataProntuario.Visible = false;
                    cbxAlcoolotraProntuario.Visible = false;
                    cbxAlergiaProntuario.Visible = false;
                    cbxCardiacoProntuario.Visible = false;
                    cbxDiabeteProntuario.Visible = false;
                    cbxFumanteProntuario.Visible = false;
                    cbxHipertensaoProntuario.Visible = false;
                    btnSalvarProntuario.Visible = false;
                    txtNumeroGuia.Enabled = true;
                    MyOp.ListarProntuarios(dgvMostraProntuario);
                    txtIndicacaoProntuario.Clear();
                    txtMedicacaoProntuario.Clear();
                    txtIdMedicoProntuario.Clear();
                    txtIdPacienteProntuario.Clear();
                    txtNumeroGuia.Clear();
                    txtObservacaoProntuario.Clear();
                    txtPrioridadeProntuario.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para salvar a alteração!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void txtNumeroGuia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtIdPacienteProntuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtIdMedicoProntuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
