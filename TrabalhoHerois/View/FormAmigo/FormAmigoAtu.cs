using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormAmigo
{
    public partial class FormAmigoAtu : Form
    {
        AmigoDAO dao;
        ControllerMet met;
        AmigoHeroi amigo;
        public FormAmigoAtu()
        {
            InitializeComponent();
            dao = new AmigoDAO();
            met = new ControllerMet();
            amigo = new AmigoHeroi();
            met.atualizaLista(cbAtuAmigo, "amigosHeroi", "idAmigo");
        }

        private void cbAtuAmigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(cbAtuAmigo.Text, @"(?<=\-)\-?\d+");
            amigo.IdAmigo = Convert.ToInt32(match.Value);
            met.consultaId(dgvAtuAmigo,"amigosHeroi", "idAmigo", amigo.IdAmigo, "nome, anonasc, email, hobby, atividadeProfissional");
        }

        private void btAtuAmigo_Click(object sender, EventArgs e)
        {
            try
            {
                met.atualizaCad();
                met.atualizaLista(cbAtuAmigo, "amigosHeroi", "idAmigo");
                met.atualizaIdadeBD("amigosHeroi", "idAmigo", amigo.IdAmigo);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
