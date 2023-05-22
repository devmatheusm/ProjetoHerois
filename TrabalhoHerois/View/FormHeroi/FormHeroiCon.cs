using System;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;
using System.Text.RegularExpressions;
using TrabalhoHerois.Controller;
namespace TrabalhoHerois.View.FormHeroi
{
    public partial class FormHeroiCon : Form
    {
        HeroiDAO DAO;
        ControllerMet met;
        Heroi heroi;
        public FormHeroiCon()
        {
            InitializeComponent();
            DAO = new HeroiDAO();
            met = new ControllerMet();
            heroi = new Heroi();
            met.atualizaLista(cbConIdHeroi, "herois", "idHeroi");
        }

        private void btConsGeralAmigo_Click(object sender, EventArgs e)
        {
            met.consultaGeral(dgvHeroi, "herois");
        }

        private void btPerAmigoID_Click(object sender, EventArgs e) 
        {
            Match match = Regex.Match(cbConIdHeroi.Text, @"(?<=\-)\-?\d+");
            heroi.IdHeroi = Convert.ToInt32(match.Value);
            met.consultaId(dgvHeroi, "herois", "idHeroi", heroi.IdHeroi);
        }
    }
}
