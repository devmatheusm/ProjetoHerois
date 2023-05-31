using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrabalhoHerois.Controller;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormAmigo
{
    public partial class FormAmigoAtu : Form
    {
        //PROTOTIPO DOS OBJETOS
        ControllerMet met;
        AmigoHeroi amigo;
        //CONTRUTOR DO FORMAMIGOATU
        public FormAmigoAtu()
        {
            InitializeComponent();
            met = new ControllerMet();
            amigo = new AmigoHeroi();
            met.atualizaLista(cbAtuAmigo, "amigosHeroi", "idAmigo");
        }
        //atualiza a datagridview todo momento que o combobox é selecionado
        private void cbAtuAmigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(cbAtuAmigo.Text, @"(?<=\-)\-?\d+");
            amigo.IdPessoa = Convert.ToInt32(match.Value);
            met.consultaId(dgvAtuAmigo, "amigosHeroi", "idAmigo", amigo.IdPessoa, "nome, anonasc, email, hobby, atividadeProfissional");
        }
        //atualiza o banco de dados do amigo toda vez que o botão é apertado com base no datagridview
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
