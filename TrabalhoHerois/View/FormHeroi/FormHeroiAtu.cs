using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormHeroi
{
    public partial class FormHeroiAtu : Form
    {
        HeroiDAO DAO;
        Heroi heroi;
        ControllerMet met;
        
        public FormHeroiAtu()
        {
            InitializeComponent();
            DAO = new HeroiDAO();
            heroi = new Heroi();
            met = new ControllerMet();
            met.atualizaLista(cbAtuHeroi, "herois", "idHeroi");
        }
        private void cbAtuHeroi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(cbAtuHeroi.Text, @"(?<=\-)\-?\d+");
            heroi.IdPessoa = Convert.ToInt32(match.Value);
            met.consultaId(dgvAtuHeroi, "herois", "idHeroi", heroi.IdPessoa, "nome, anoNasc, email, nomeHeroi, planetaOrigem, atividadeProfissional, parceiro, superPoder, grupo, pontoFraco");
        }

        private void btAtuHeroi_Click(object sender, EventArgs e)
        {
            met.atualizaCad();
            met.atualizaLista(cbAtuHeroi, "herois", "idHeroi");
            met.atualizaIdadeBD("herois", "idHeroi", heroi.IdPessoa);
        }
    }
}
