using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace Trab_Final_POO
{
    public partial class frmCadProntuario : Form
    {
        public frmCadProntuario()
        {
            InitializeComponent();
        }

        private void btnCadastrarProntuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDataProntuario.Text != "" && txtIndicacaoProntuario.Text != "" && txtPrioridadeProntuario.Text != "" && txtMedicacaoProntuario.Text != "" && cbxDiabeteProntuario.Text != "" && cbxCardiacoProntuario.Text != "" && cbxHipertensaoProntuario.Text != "" && cbxAlergiaProntuario.Text != "" && cbxFumanteProntuario.Text != "" && cbxAlcoolotraProntuario.Text != "" && txtObservacaoProntuario.Text != "" && txtIdPacienteProntuario.Text != "" && txtIdMedicoProntuario.Text != "")
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.InserirProntuario(dtpDataProntuario.Text, txtIndicacaoProntuario.Text, txtPrioridadeProntuario.Text, txtMedicacaoProntuario.Text, cbxDiabeteProntuario.Text, cbxCardiacoProntuario.Text, cbxHipertensaoProntuario.Text, cbxAlergiaProntuario.Text, cbxFumanteProntuario.Text, cbxAlcoolotraProntuario.Text, txtObservacaoProntuario.Text, txtIdPacienteProntuario.Text, txtIdMedicoProntuario.Text);
                    txtIndicacaoProntuario.Clear();
                    txtMedicacaoProntuario.Clear();
                    txtIdMedicoProntuario.Clear();
                    txtIdPacienteProntuario.Clear();
                    txtObservacaoProntuario.Clear();
                    txtPrioridadeProntuario.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha todas as informações acima!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
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
