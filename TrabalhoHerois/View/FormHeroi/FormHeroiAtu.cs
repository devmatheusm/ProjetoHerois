using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormHeroi
{
    public partial class FormHeroiAtu : Form
    {
        //PROTOTIPO DOS OBJETOS
        Heroi heroi;
        ControllerMet met;
        //CONTRUTOR DO FORMHEROIATU
        public FormHeroiAtu()
        {
            InitializeComponent();
            heroi = new Heroi();
            met = new ControllerMet();
            met.atualizaLista(cbAtuHeroi, "herois", "idHeroi");
        }
        //atualiza a datagridview todo momento que o combobox é selecionado
        private void cbAtuHeroi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(cbAtuHeroi.Text, @"(?<=\-)\-?\d+");
            heroi.IdPessoa = Convert.ToInt32(match.Value);
            met.consultaId(dgvAtuHeroi, "herois", "idHeroi", heroi.IdPessoa, "nome, anoNasc, email, nomeHeroi, planetaOrigem, atividadeProfissional, parceiro, superPoder, grupo, pontoFraco");
        }
        //atualiza o banco de dados do heroi toda vez que o botão é apertado com base no datagridview
        private void btAtuHeroi_Click(object sender, EventArgs e)
        {
            met.atualizaCad();
            met.atualizaLista(cbAtuHeroi, "herois", "idHeroi");
            met.atualizaIdadeBD("herois", "idHeroi", heroi.IdPessoa);
        }
    }
}
