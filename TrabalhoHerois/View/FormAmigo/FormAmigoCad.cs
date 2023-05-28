using System;
using System.Drawing;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;
using System.Web;

namespace TrabalhoHerois.View.FormAmigo
{
    public partial class FormAmigoCad : Form
    {
        //Instancia a classe de metodos
        Methods met;
        AmigoDAO dao;
        AmigoHeroi amigo;
        public FormAmigoCad()
        {
            InitializeComponent();
            dao = new AmigoDAO();
            amigo = new AmigoHeroi();
            met = new Methods();
        }

        //Ao clicar nesse Botão é pego todas as informações contidas dentro dos textbox
        //e registra no banco de dados
        #region cadastro de informação
        private void bt_enviar_Click(object sender, EventArgs e)
        {
            bool concluido;
            try
            {
                concluido = true;
                if (tbNome.Text != tbNome.Tag.ToString())
                    amigo.NomePessoa = tbNome.Text;
                else
                {
                    tbNome.ForeColor = Color.Red;
                    concluido = false;
                }
                if (tbEmail.Text != tbEmail.Tag.ToString())
                    amigo.Email = tbEmail.Text;
                else
                {
                    tbEmail.ForeColor = Color.Red;
                    concluido = false;
                }
                amigo.AnoNasc = Convert.ToInt32(dtpNasc.Text);
                if (tbAtiPro.Text != tbAtiPro.Tag.ToString())
                    amigo.AtividadeProfissional = tbAtiPro.Text;
                else
                {
                    tbAtiPro.ForeColor = Color.Red;
                    concluido = false;
                }
                if (tbHobby.Text != tbHobby.Tag.ToString())
                    amigo.Hobby = tbHobby.Text;
                else
                {
                    tbHobby.ForeColor = Color.Red;
                    concluido = false;
                }
                amigo.CaminhoImagem = pbFoto.ImageLocation;
                amigo.calcularIdade(amigo.AnoNasc);
                if (concluido && dao.inserir(amigo))
                    MessageBox.Show("Cadastro concluido");
                else
                    MessageBox.Show("Está faltando alguns itens!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        //Ao clicar no Botão chama o metodo que faz o upload de uma imagem a escolha do usuario
        #region upload de imagem
        private void btUpload_Click(object sender, EventArgs e)
        {
            met.uploadImage(pbFoto);
        }
        #endregion

        //Chama o metodo que ao sair do textbox e perder o 'focar' do texto retorna o
        //texto que esta contido na tag de volta ao textbox
        #region placeholder's enter
        private void tbNome_Leave(object sender, EventArgs e)
        {
            met.addText(tbNome, tbNome.Tag.ToString());
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            met.addText(tbEmail, tbEmail.Tag.ToString());
        }

        private void tbAtiPro_Leave(object sender, EventArgs e)
        {
            met.addText(tbAtiPro, tbAtiPro.Tag.ToString());
        }

        private void tbHobby_Leave(object sender, EventArgs e)
        {
            met.addText(tbHobby, tbHobby.Tag.ToString());
        }
        #endregion

        //Chama o metodo que ao entrar no textbox e ganhar o 'foco' do texto apaga o
        //texto que estava contido dentro do textbox, desde que não seja o texto do usuario
        #region placeholder's clear
        private void tbNome_Enter(object sender, EventArgs e)
        {
            met.clearText(tbNome);
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            met.clearText(tbEmail);
        }

        private void tbAtiPro_Enter(object sender, EventArgs e)
        {
            met.clearText(tbAtiPro);
        }

        private void tbHobby_Enter(object sender, EventArgs e)
        {
            met.clearText(tbHobby);
        }
        #endregion

        private void eg1f2c_Click(object sender, EventArgs e) {
            MessageBox.Show("Parabéns por encontrar o secreto!", "PARABENS!!!");
        }
    }
}
