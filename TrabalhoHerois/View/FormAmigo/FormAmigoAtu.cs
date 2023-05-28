using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormAmigo
{
    public partial class FormAmigoAtu : Form
    {
        ControllerMet met;
        AmigoHeroi amigo;
        public FormAmigoAtu()
        {
            InitializeComponent();
            met = new ControllerMet();
            amigo = new AmigoHeroi();
            met.atualizaLista(cbAtuAmigo, "amigosHeroi", "idAmigo");
        }

        private void cbAtuAmigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(cbAtuAmigo.Text, @"(?<=\-)\-?\d+");
            amigo.IdPessoa = Convert.ToInt32(match.Value);
            met.consultaId(dgvAtuAmigo, "amigosHeroi", "idAmigo", amigo.IdPessoa, "nome, anonasc, email, hobby, atividadeProfissional");
        }

        private void btAtuAmigo_Click(object sender, EventArgs e)
        {
            try
            {
                met.atualizaCad();
                met.atualizaLista(cbAtuAmigo, "amigosHeroi", "idAmigo");
                met.atualizaIdadeBD("amigosHeroi", "idAmigo", amigo.IdPessoa);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
