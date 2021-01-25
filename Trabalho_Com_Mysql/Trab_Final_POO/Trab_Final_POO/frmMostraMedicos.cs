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
    public partial class frmMostraMedicos : Form
    {
        string NomeAntigoMedico;
        string IdAntigoMedico;
        public frmMostraMedicos()
        {
            InitializeComponent();
        }

        private void frmMostraMedicos_Load(object sender, EventArgs e)
        {
            try
            {
                Operacoes MyOp = new Operacoes(new Dados());
                MyOp.ListarMedicos(dgvMedicos);
                dgvMedicos.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnExcluirMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaMedico.Text != "" || txtIdMedico.Text != "") 
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.ExcluirMedico(dgvMedicos, txtPesquisaMedico.Text, txtIdMedico.Text);
                    MyOp.ListarMedicos(dgvMedicos);
                    txtIdMedico.Clear();
                    txtPesquisaMedico.Clear();
                }
                else{
                    MessageBox.Show("Preencha o campo ID ou o campo Nome para realizar a exclusão!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnAlterarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaMedico.Text != "" || txtIdMedico.Text != "")
                {
                    lblCpfMedico.Visible = true;
                    lblEnderecoMedico.Visible = true;
                    lblSexoMedico.Visible = true;
                    lblTelefoneMedico.Visible = true;
                    lblCrmMedico.Visible = true;
                    lblEspecialidadeMedico.Visible = true;
                    lblIdMedico.Visible = false;
                    txtCpfMedico.Visible = true;
                    txtEnderecoMedico.Visible = true;
                    cbxSexoMedico.Visible = true;
                    txtTelefoneMedico.Visible = true;
                    txtCrmMedico.Visible = true;
                    txtEspecialidadeMedico.Visible = true;
                    txtIdMedico.Visible = false;
                    btnSalvarMedico.Visible = true;
                    NomeAntigoMedico = txtPesquisaMedico.Text;
                    IdAntigoMedico = txtIdMedico.Text;
                }
                else
                {
                    MessageBox.Show("Preencha o campo ID ou o campo Nome para realizar a alteração!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnSalvarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaMedico.Text != "" && txtCpfMedico.MaskCompleted == true && txtTelefoneMedico.MaskCompleted && txtEnderecoMedico.Text != "" && cbxSexoMedico.Text != "" && txtCrmMedico.MaskCompleted == true && txtEspecialidadeMedico.Text != "")
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.AlterarMedico(dgvMedicos, IdAntigoMedico, NomeAntigoMedico, txtPesquisaMedico.Text, txtCpfMedico.Text, txtTelefoneMedico.Text, txtEnderecoMedico.Text, cbxSexoMedico.Text, txtCrmMedico.Text, txtEspecialidadeMedico.Text);
                    //Mudando visibilidade dos campos
                    lblCpfMedico.Visible = false;
                    lblEnderecoMedico.Visible = false;
                    lblSexoMedico.Visible = false;
                    lblTelefoneMedico.Visible = false;
                    lblCrmMedico.Visible = false;
                    lblEspecialidadeMedico.Visible = false;
                    lblIdMedico.Visible = true;
                    txtCpfMedico.Visible = false;
                    txtEnderecoMedico.Visible = false;
                    cbxSexoMedico.Visible = false;
                    txtTelefoneMedico.Visible = false;
                    txtCrmMedico.Visible = false;
                    txtEspecialidadeMedico.Visible = false;
                    txtIdMedico.Visible = true;
                    btnSalvarMedico.Visible = false;
                    txtPesquisaMedico.Text = null;
                    MyOp.ListarMedicos(dgvMedicos);
                    // Limpar os Campos
                    txtIdMedico.Clear();
                    txtPesquisaMedico.Clear();
                    txtCpfMedico.Clear();
                    txtCrmMedico.Clear();
                    txtEnderecoMedico.Clear();
                    txtEspecialidadeMedico.Clear();
                    txtTelefoneMedico.Clear();
                }
                else{
                    MessageBox.Show("Preencha todos os campos acima para salvar as alterações!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void btnPesquisarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaMedico.Text != "" || txtIdMedico.Text != "")
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.PesquisarMedico(dgvMedicos, txtPesquisaMedico.Text, txtIdMedico.Text);
                    txtPesquisaMedico.Clear();
                    txtIdMedico.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha o campo ID ou o campo Nome para realizar a pesquisa!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void txtIdMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
