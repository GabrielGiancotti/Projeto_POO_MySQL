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
    public partial class frmCadAgendamento : Form
    {
        public frmCadAgendamento()
        {
            InitializeComponent();
        }

        private void btnCadastrarAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdPacienteAge.Text != "" && txtIdMedicoAge.Text != "" && dtpDataAgendamento.Text != "" && cbxHoraAgendamento.Text != "") 
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.InserirAgendamento(txtIdPacienteAge.Text, txtIdMedicoAge.Text, dtpDataAgendamento.Text, cbxHoraAgendamento.Text);
                    txtIdMedicoAge.Clear();
                    txtIdPacienteAge.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos acima!!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void txtIdMedicoAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtIdPacienteAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
