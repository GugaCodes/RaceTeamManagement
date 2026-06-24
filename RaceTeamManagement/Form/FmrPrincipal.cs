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

    public enum Tela
    {
        Menu,
        GerenciamentoEquipes,
        GerenciamentoPilotos,
        GerenciamentoCarros,
        GerenciarDashBoard
    }

    public partial class FmrPrincipal : Form
    {
        public FmrPrincipal()
        {
            InitializeComponent();
        }


        public void MudarTela(Tela tela)
        {
            PanelMenu.Visible = false;
            PanelGerenciarEquipes.Visible = false;
            PanelGerenciarPiloto.Visible = false;
            PanelGerenciarCarros.Visible = false;
            PanelDahsBoard.Visible = false;

            switch (tela)
            {
                case Tela.Menu:
                    PanelMenu.Visible = true;
                    break;
                case Tela.GerenciamentoEquipes:
                    PanelGerenciarEquipes.Visible = true;
                    break;
                case Tela.GerenciamentoPilotos:
                    PanelGerenciarPiloto.Visible = true;
                    break;
                case Tela.GerenciamentoCarros:
                    PanelGerenciarCarros.Visible = true;
                    break;
                case Tela.GerenciarDashBoard:
                    PanelDahsBoard.Visible = true;
                    break;

            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em Desenvolvimento","AVISO",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show("Deseja realmente sair?","Sair",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado== DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
    
}
