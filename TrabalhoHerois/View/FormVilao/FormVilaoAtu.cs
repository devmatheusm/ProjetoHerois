using System;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;
using TrabalhoHerois.Controller;
using System.Text.RegularExpressions;

namespace TrabalhoHerois.View.FormVilao
{
    public partial class FormVilaoAtu : Form
    {
        VilaoDAO DAO;
        Vilao vilao;
        ControllerMet met;
        
        public FormVilaoAtu()
        {
            InitializeComponent();
            DAO = new VilaoDAO();
            vilao = new Vilao();
            met = new ControllerMet();
            met.atualizaLista(cbAtuVilao, "viloes", "idVilao");
        } 

        private void cbAtuVilao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(cbAtuVilao.Text, @"(?<=\-)\-?\d+");
            vilao.IdVilao = Convert.ToInt32(match.Value);
            met.consultaId(dgvAtuVilao, "viloes", "idVilao", vilao.IdVilao, "nome, anoNasc, email, nomeVilao, planetaOrigem, parceiro, superPoder");
        }

        private void btAtuVilao_Click(object sender, EventArgs e)
        {
            met.atualizaCad();
            met.atualizaLista(cbAtuVilao, "viloes", "idVilao");
            met.atualizaIdadeBD("viloes", "idVilao", vilao.IdPessoa);
        }
    }
}
