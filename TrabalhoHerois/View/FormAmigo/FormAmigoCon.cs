using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;
using TrabalhoHerois.Controller;

namespace TrabalhoHerois.View.FormAmigo
{
    public partial class FormAmigoCon : Form
    {
        AmigoDAO DAO;
        AmigoHeroi amigo;
        ControllerMet met;
        public FormAmigoCon()
        {
            InitializeComponent();
            DAO = new AmigoDAO();
            amigo = new AmigoHeroi();
            met = new ControllerMet();
            met.atualizaLista(cbConIdAmigo, "amigosHeroi", "idAmigo");
        }

        private void btConsGeralAmigo_Click(object sender, EventArgs e)
        {
            met.consultaGeral(dgvAmigo, "amigosHeroi");
        }

        private void btPerIDAmigo_Click(object sender, EventArgs e)
        {

            Match match = Regex.Match(cbConIdAmigo.Text, @"(?<=\-)\-?\d+");
            amigo.IdAmigo = Convert.ToInt32(match.Value);
            met.consultaId(dgvAmigo, "amigosHeroi", "idAmigo", amigo.IdAmigo);
        }
    }
}
