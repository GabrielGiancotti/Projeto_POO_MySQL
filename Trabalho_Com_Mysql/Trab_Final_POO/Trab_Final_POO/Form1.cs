using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Trab_Final_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuCadastroPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadPaciente CadPac = new frmCadPaciente();
                CadPac.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                CadPac.MdiParent = this;
                CadPac.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuCadastroMedico_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadMedico CadMed = new frmCadMedico();
                CadMed.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                CadMed.MdiParent = this;
                CadMed.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuCadastroProntuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadProntuario CadPront = new frmCadProntuario();
                CadPront.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                CadPront.MdiParent = this;
                CadPront.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuJanela_Click(object sender, EventArgs e)
        {
            try
            {
                this.LayoutMdi(MdiLayout.TileVertical);
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuExcluirPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraPacientes ExcluirPac = new frmMostraPacientes();
                ExcluirPac.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                ExcluirPac.MdiParent = this;
                ExcluirPac.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuPesquisarPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraPacientes MostrarPac = new frmMostraPacientes();
                MostrarPac.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                MostrarPac.MdiParent = this;
                MostrarPac.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuPesquisarMedicos_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraMedicos MostrarMed = new frmMostraMedicos();
                MostrarMed.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                MostrarMed.MdiParent = this;
                MostrarMed.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuExcluirMedico_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraMedicos ExcluirMed = new frmMostraMedicos();
                ExcluirMed.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                ExcluirMed.MdiParent = this;
                ExcluirMed.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuExcluirProntuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraProntuario ExcluirPront = new frmMostraProntuario();
                ExcluirPront.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                ExcluirPront.MdiParent = this;
                ExcluirPront.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuPesquisarProntuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraProntuario MostrarPront = new frmMostraProntuario();
                MostrarPront.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                MostrarPront.MdiParent = this;
                MostrarPront.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuAlterarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraPacientes AlterarPac = new frmMostraPacientes();
                AlterarPac.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                AlterarPac.MdiParent = this;
                AlterarPac.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuAlterarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraMedicos AlterarMed = new frmMostraMedicos();
                AlterarMed.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                AlterarMed.MdiParent = this;
                AlterarMed.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuAlterarProntuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraProntuario AlterarPront = new frmMostraProntuario();
                AlterarPront.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                AlterarPront.MdiParent = this;
                AlterarPront.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuCadastroAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadAgendamento CadAgen = new frmCadAgendamento();
                CadAgen.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                CadAgen.MdiParent = this;
                CadAgen.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuPesquisaAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraAgendamentos MostrarAgend = new frmMostraAgendamentos();
                MostrarAgend.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                MostrarAgend.MdiParent = this;
                MostrarAgend.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuExcluirAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraAgendamentos ExcluirAgend = new frmMostraAgendamentos();
                ExcluirAgend.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                ExcluirAgend.MdiParent = this;
                ExcluirAgend.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }

        private void mnuAlterarAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostraAgendamentos AlterarAgend = new frmMostraAgendamentos();
                AlterarAgend.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                AlterarAgend.MdiParent = this;
                AlterarAgend.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}", ex.ToString());
            }
        }
    }
}
