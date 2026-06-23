using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTeamManagement
{
    public partial class FmrPrincipal : Form
    {
        public FmrPrincipal()
        {
            InitializeComponent();
        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função em Desenvolvimento","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja realmete sair?", "Sair?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(escolha == DialogResult.Yes) 
            { 
                Application.Exit();
            }
        }

        private void btn_GerenciaEquipe_Click(object sender, EventArgs e)
        {
            //FmrEquipe telaEquipe = new FmrEquipe();

            //telaEquipe.Show();
            //this.Hide();
        }
    }
}
