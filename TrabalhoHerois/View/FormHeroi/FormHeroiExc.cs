using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;
using TrabalhoHerois.Controller;

namespace TrabalhoHerois.View.FormHeroi
{
    public partial class FormHeroiExc : Form
    {
        HeroiDAO DAO;
        Heroi heroi;
        ControllerMet met;
        public FormHeroiExc()
        {
            InitializeComponent();
            DAO = new HeroiDAO();
            heroi = new Heroi();
            met = new ControllerMet();
            met.atualizaLista(clbHeroi, "herois", "idHeroi");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o(s) cadastro(s) selecionado(s)?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                try
                {
                    foreach (string i in clbHeroi.CheckedItems)
                    {
                        Match match = Regex.Match(i, @"(?<=\-)\-?\d+");
                        heroi.IdHeroi = Convert.ToInt32(match.Value);
                        DAO.excluir(heroi);
                    }
                    met.atualizaLista(clbHeroi, "amigosHeroi", "idamigo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o ID " + heroi.IdHeroi + "\nERROR:" + ex.Message);
                }
        }
    }
}