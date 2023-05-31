using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormVilao
{
    public partial class FormVilaoCon : Form
    {
        //PROTOTIPO DOS OBJETOS
        ControllerMet met;
        Vilao vilao;
        //CONSTRUTOR DO FORMVILAOCON
        public FormVilaoCon()
        {
            InitializeComponent();
            met = new ControllerMet();
            vilao = new Vilao();
            met.atualizaLista(cbConIdVilao, "viloes", "idVilao");
        }
        //botão que faz a consulta de tudo dentro do vilao
        private void btConsGeralVilao_Click(object sender, EventArgs e)
        {
            met.consultaGeral(dgvVilaoCon, "viloes");
        }
        //faz a consulta por um ID escolhido dentro do combobox
        private void btPerIDVilao_Click(object sender, EventArgs e)
        {
            if (cbConIdVilao.SelectedItem != null)
                try
                {
                    Match match = Regex.Match(cbConIdVilao.Text, @"(?<=\-)\-?\d+");
                    vilao.IdPessoa = Convert.ToInt32(match.Value);
                    met.consultaId(dgvVilaoCon, "viloes", "idVilao", vilao.IdPessoa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
