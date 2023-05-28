using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormAmigo
{
    public partial class FormAmigoExc : Form
    {
        AmigoDAO DAO;
        AmigoHeroi amigo;
        ControllerMet met;
        public FormAmigoExc()
        {
            InitializeComponent();
            DAO = new AmigoDAO();
            amigo = new AmigoHeroi();
            met = new ControllerMet();
            met.atualizaLista(clbAmigo, "amigosHeroi", "idamigo");
        }

        private void button1_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja excluir o(s) cadastro(s) selecionado(s)?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                try {
                    foreach (string i in clbAmigo.CheckedItems) {
                        Match match = Regex.Match(i, @"(?<=\-)\-?\d+");
                        amigo.IdAmigo = Convert.ToInt32(match.Value);

                        DAO.excluir(amigo);
                    }
                    met.atualizaLista(clbAmigo, "amigosHeroi", "idamigo");
                } catch (Exception ex) {
                    MessageBox.Show("Erro ao excluir o ID " + amigo.IdAmigo + "\nERROR:" + ex.Message);
                }
        }
    }
}
