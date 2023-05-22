using System;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;
using System.Text.RegularExpressions;
using TrabalhoHerois.Controller;

namespace TrabalhoHerois.View.FormVilao
{
    public partial class FormVilaoCon : Form
    {
        VilaoDAO DAO;
        ControllerMet met;
        Vilao vilao;
        public FormVilaoCon()
        {
            InitializeComponent();
            DAO = new VilaoDAO();
            met = new ControllerMet();
            vilao = new Vilao();
            met.atualizaLista(cbConIdVilao, "viloes", "idVilao");
        }

        private void btConsGeralVilao_Click(object sender, EventArgs e)
        {
            met.consultaGeral(dgvVilaoCon, "viloes");
        }
         private void btPerIDVilao_Click(object sender, EventArgs e)
        {
            Match match = Regex.Match(cbConIdVilao.Text, @"(?<=\-)\-?\d+");
            vilao.IdVilao = Convert.ToInt32(match.Value);
            met.consultaId(dgvVilaoCon, "viloes", "idVilao", vilao.IdVilao);
        }
    }
}
