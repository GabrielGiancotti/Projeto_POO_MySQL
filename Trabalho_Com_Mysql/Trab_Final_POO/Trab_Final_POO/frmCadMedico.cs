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
    public partial class frmCadMedico : Form
    {
        public frmCadMedico()
        {
            InitializeComponent();
        }

        private void btnCadastrarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeMedico.Text != "" && txtCpfMedico.MaskCompleted == true && txtTelefoneMedico.MaskCompleted == true &&  txtEnderecoMedico.Text != "" && cbxSexoMedico.Text != "" && txtCrmMedico.MaskCompleted == true && txtEspecialidadeMedico.Text != "")
                {
                    Operacoes MyOp = new Operacoes(new Dados());
                    MyOp.InserirMedico(txtNomeMedico.Text, txtCpfMedico.Text, txtTelefoneMedico.Text, txtEnderecoMedico.Text, cbxSexoMedico.Text, txtCrmMedico.Text, txtEspecialidadeMedico.Text);
                    txtNomeMedico.Clear();
                    txtCpfMedico.Clear();
                    txtCrmMedico.Clear();
                    txtTelefoneMedico.Clear();
                    txtEspecialidadeMedico.Clear();
                    txtEnderecoMedico.Clear();                    
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
