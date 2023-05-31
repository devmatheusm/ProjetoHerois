using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.Entities;
namespace TrabalhoHerois.View.FormHeroi
{
    public partial class FormHeroiCon : Form
    {
        ControllerMet met;
        Heroi heroi;
        //CONSTRUTOR DO FORMHEROICON
        public FormHeroiCon()
        {
            InitializeComponent();
            met = new ControllerMet();
            heroi = new Heroi();
            met.atualizaLista(cbConIdHeroi, "herois", "idHeroi");
        }
        //botão que faz a consulta de tudo dentro da tabela heroi
        private void btConsGeralHeroi_Click(object sender, EventArgs e)
        {
            met.consultaGeral(dgvHeroi, "Herois");
        }
        //faz a consulta por um ID escolhido dentro do combobox
        private void btPerIDHeroi_Click(object sender, EventArgs e)
        {
            if (cbConIdHeroi.SelectedItem != null)
                try
                {
                    Match match = Regex.Match(cbConIdHeroi.Text, @"(?<=\-)\-?\d+");
                    heroi.IdPessoa = Convert.ToInt32(match.Value);
                    met.consultaId(dgvHeroi, "herois", "idHeroi", heroi.IdPessoa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
