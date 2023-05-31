using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormVilao
{
    public partial class FormVilaoAtu : Form
    {
        //PROTOTIPO DOS OBJETOS
        Vilao vilao;
        ControllerMet met;
        //CONTRUTOR DO FORMVILAOATU
        public FormVilaoAtu()
        {
            InitializeComponent();
            vilao = new Vilao();
            met = new ControllerMet();
            met.atualizaLista(cbAtuVilao, "viloes", "idVilao");
        }
        //atualiza a datagridview todo momento que o combobox é selecionado
        private void cbAtuVilao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(cbAtuVilao.Text, @"(?<=\-)\-?\d+");
            vilao.IdPessoa = Convert.ToInt32(match.Value);
            met.consultaId(dgvAtuVilao, "viloes", "idVilao", vilao.IdPessoa, "nome, anoNasc, email, nomeVilao, planetaOrigem, parceiro, superPoder");
        }
        //atualiza o banco de dados do vilao toda vez que o botão é apertado com base no datagridview
        private void btAtuVilao_Click(object sender, EventArgs e)
        {
            met.atualizaCad();
            met.atualizaLista(cbAtuVilao, "viloes", "idVilao");
            met.atualizaIdadeBD("viloes", "idVilao", vilao.IdPessoa);
        }
    }
}
