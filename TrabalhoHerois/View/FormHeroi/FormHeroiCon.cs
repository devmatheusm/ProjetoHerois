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
        ControllerMet met;
        Heroi heroi;
        public FormHeroiCon()
        {
            InitializeComponent();
            met = new ControllerMet();
            heroi = new Heroi();
            met.atualizaLista(cbConIdHeroi, "herois", "idHeroi");
        }

        private void btConsGeralAmigo_Click(object sender, EventArgs e)
        {
            met.consultaGeral(dgvHeroi, "herois");
        }
        private void btPerIDHeroi_Click(object sender, EventArgs e) 
        {
            Match match = Regex.Match(cbConIdHeroi.Text, @"(?<=\-)\-?\d+");
            heroi.IdPessoa = Convert.ToInt32(match.Value);
            met.consultaId(dgvHeroi, "herois", "idHeroi", heroi.IdPessoa);
        }
    }
}
