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
        VilaoDAO DAO;
        Vilao vilao;
        ControllerMet met;

        public FormVilaoExc()
        {
            InitializeComponent();
            DAO = new VilaoDAO();
            vilao = new Vilao();
            met = new ControllerMet();
            met.atualizaLista(clbVilao, "viloes", "idVilao");
        }

        private void btExcAmigo_Click(object sender, System.EventArgs e)
        {

            try
            {
                foreach (string i in clbVilao.CheckedItems)
                {
                    Match match = Regex.Match(i, @"(?<=\-)\-?\d+");
                    vilao.IdVilao = Convert.ToInt32(match.Value);
                    DAO.excluir(vilao);
                }
                met.atualizaLista(clbVilao, "viloes", "idVilao");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o ID " + vilao.IdVilao + "\nERROR:" + ex.Message);
            }
        }
    }
}

