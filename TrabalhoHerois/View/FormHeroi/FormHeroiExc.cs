using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormHeroi
{
    public partial class FormHeroiExc : Form
    {
        //PROTOTIPO DE INSTANCIAÇÕES
        HeroiDAO DAO;
        Heroi heroi;
        ControllerMet met;
        //CONSTRUTOR DO FORMHEROIEXC
        public FormHeroiExc()
        {
            InitializeComponent();
            DAO = new HeroiDAO();
            heroi = new Heroi();
            met = new ControllerMet();
            met.atualizaLista(clbHeroi, "herois", "idHeroi");
        }
        //botão que vai excluir todos os dado que estiverem "checkados"
        private void btExcHeroi_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o(s) cadastro(s) selecionado(s)?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                try
                {
                    foreach (string i in clbHeroi.CheckedItems)
                    {
                        //procura dentro de uma string o primeiro numero de um ou mais digitos que esteja antecedendo um '-'
                        Match match = Regex.Match(i, @"(?<=\-)\-?\d+");
                        heroi.IdPessoa = Convert.ToInt32(match.Value);
                        DAO.excluir(heroi);
                    }
                    met.atualizaLista(clbHeroi, "Herois", "idHeroi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o ID " + heroi.IdPessoa + "\nERROR:" + ex.Message);
                }
        }
    }
}