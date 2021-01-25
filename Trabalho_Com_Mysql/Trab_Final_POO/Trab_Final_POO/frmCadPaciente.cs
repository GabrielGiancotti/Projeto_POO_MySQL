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
    public partial class frmCadPaciente : Form
    {
        
        public frmCadPaciente()
        {
            InitializeComponent();
        }

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomePaciente.Text != "" && txtCpfPaciente.MaskCompleted == true && txtTelefonePaciente.MaskCompleted == true && txtEnderecoPaciente.Text != "" && cbxSexoPaciente.Text != "") {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.InserirPaciente(txtNomePaciente.Text, txtCpfPaciente.Text, txtTelefonePaciente.Text, txtEnderecoPaciente.Text, cbxSexoPaciente.Text);
                    txtNomePaciente.Clear();
                    txtCpfPaciente.Clear();
                    txtTelefonePaciente.Clear();
                    txtEnderecoPaciente.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos acima!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }
    }
}
