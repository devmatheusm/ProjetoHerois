using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormVilao
{
    public partial class FormVilaoExc : Form
    {
        //PROTOTIPO DE INSTANCIAÇÕES
        VilaoDAO DAO;
        Vilao vilao;
        ControllerMet met;
        //CONSTRUTOR DO FORMVILAOEXC
        public FormVilaoExc()
        {
            InitializeComponent();
            DAO = new VilaoDAO();
            vilao = new Vilao();
            met = new ControllerMet();
            met.atualizaLista(clbVilao, "viloes", "idVilao");
        }
        //botão que vai excluir todos os dado que estiverem "checkados"
        private void btExcAmigo_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o(s) cadastro(s) selecionado(s)?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                try
                {
                    foreach (string i in clbVilao.CheckedItems)
                    {
                        //procura dentro de uma string o primeiro numero de um ou mais digitos que esteja antecedendo um '-'
                        Match match = Regex.Match(i, @"(?<=\-)\-?\d+");
                        vilao.IdPessoa = Convert.ToInt32(match.Value);
                        DAO.excluir(vilao);
                    }
                    met.atualizaLista(clbVilao, "viloes", "idVilao");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o ID " + vilao.IdPessoa + "\nERROR:" + ex.Message);
                }
        }
    }
}

