using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormAmigo
{
    public partial class FormAmigoCon : Form
    {
        AmigoHeroi amigo;
        ControllerMet met;
        //CONSTRUTOR DO FORMAMIGOCON
        public FormAmigoCon()
        {
            InitializeComponent();
            amigo = new AmigoHeroi();
            met = new ControllerMet();
            met.atualizaLista(cbConIdAmigo, "amigosHeroi", "idAmigo");
        }
        //botão que faz a consulta de tudo dentro da tabela amigo
        private void btConsGeralAmigo_Click(object sender, EventArgs e)
        {
            met.consultaGeral(dgvAmigo, "amigosHeroi");
        }
        //faz a consulta por um ID escolhido dentro do combobox
        private void btPerIDAmigo_Click(object sender, EventArgs e)
        {
            Match match = Regex.Match(cbConIdAmigo.Text, @"(?<=\-)\-?\d+");
            amigo.IdPessoa = Convert.ToInt32(match.Value);
            met.consultaId(dgvAmigo, "amigosHeroi", "idAmigo", amigo.IdPessoa);
        }
    }
}
