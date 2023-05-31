using System;
using System.Drawing;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormVilao
{
    public partial class FormVilaoCad : Form
    {
        //PROTOTIPO DOS OBJETOS
        Methods met;
        VilaoDAO dao;
        Vilao vilao;
        //CONSTRUTOR DO FORMVILAOCAD
        public FormVilaoCad()
        {
            InitializeComponent();
            met = new Methods();
            dao = new VilaoDAO();
            vilao = new Vilao();
        }
        //Ao clicar nesse Botão é pego todas as informações contidas dentro dos textbox
        //e registra no banco de dados
        #region cadastro de informação
        private void bt_enviar_Click(object sender, EventArgs e)
        {
            bool concluido = true;
            try
            {
                if (tbNome.Text != tbNome.Tag.ToString())
                    vilao.NomePessoa = tbNome.Text;
                else
                {
                    tbNome.ForeColor = Color.Red;
                    concluido = false; MessageBox.Show(".");
                }
                if (tbEmail.Text != tbEmail.Tag.ToString())
                    vilao.Email = tbEmail.Text;
                else
                {
                    tbEmail.ForeColor = Color.Red;
                    concluido = false; MessageBox.Show("..");
                }
                if (tbPlaneta.Text != tbPlaneta.Tag.ToString())
                    vilao.PlanetaOrigem = tbPlaneta.Text;
                else
                {
                    tbPlaneta.ForeColor = Color.Red;
                    concluido = false; MessageBox.Show("..");
                }
                if (tbPoder.Text != tbPoder.Tag.ToString())
                    vilao.SuperPoder = tbPoder.Text;
                else
                {
                    tbPoder.ForeColor = Color.Red;
                    concluido = false; MessageBox.Show("...");
                }
                if (tbParceiro.Text != tbParceiro.Tag.ToString())
                    vilao.Parceiro = tbParceiro.Text;
                else
                {
                    tbParceiro.ForeColor = Color.Red;
                    concluido = false; MessageBox.Show("....");
                }
                if (tbApelido.Text != tbApelido.Tag.ToString())
                    vilao.NomeVilao = tbApelido.Text;
                else
                {
                    tbApelido.ForeColor = Color.Red;
                    concluido = false;
                    MessageBox.Show("......");
                }
                vilao.CaminhoImagem = pbFoto.ImageLocation;
                vilao.AnoNasc = Convert.ToInt32(dtpNasc.Text);
                vilao.calcularIdade(vilao.AnoNasc);
                if (concluido && dao.inserir(vilao))
                    MessageBox.Show("Cadastro concluido.");
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
        //PRIMEIRO NOME
        private void tbNome_Leave(object sender, EventArgs e)
        {
            met.addText(tbNome, tbNome.Tag.ToString());
        }
        //EMAIL
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            met.addText(tbEmail, tbEmail.Tag.ToString());
        }
        //PLANETA DE ORIGEM
        private void tbPlaneta_Leave(object sender, EventArgs e)
        {
            met.addText(tbPlaneta, tbPlaneta.Tag.ToString());
        }
        //SUPER PODER
        private void tbPoder_Leave(object sender, EventArgs e)
        {
            met.addText(tbPoder, tbPlaneta.Tag.ToString());
        }
        //PARCEIRO
        private void tbParceiro_Leave(object sender, EventArgs e)
        {
            met.addText(tbParceiro, tbParceiro.Tag.ToString());
        }
        //APELIDO DO VILÃO
        private void tbApelido_Leave(object sender, EventArgs e)
        {
            met.addText(tbApelido, tbApelido.Tag.ToString());
        }
        #endregion

        //Chama o metodo que ao entrar no textbox e ganhar o 'foco' do texto apaga o
        //texto que estava contido dentro do textbox, desde que não seja o texto do usuario
        #region placeholder's clear
        //PRIMEIRO NOME
        private void tbNome_Enter(object sender, EventArgs e)
        {
            met.clearText(tbNome);
        }
        //EMAIL
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            met.clearText(tbEmail);
        }
        //PLANETA DE ORIGEM
        private void tbPlaneta_Enter(object sender, EventArgs e)
        {
            met.clearText(tbPlaneta);
        }
        //SUPER PODER
        private void tbPoder_Enter(object sender, EventArgs e)
        {
            met.clearText(tbPoder);
        }
        //PARCEIRO
        private void tbParceiro_Enter(object sender, EventArgs e)
        {
            met.clearText(tbParceiro);
        }
        //APELIDO DO VILÃO
        private void tbApelido_Enter(object sender, EventArgs e)
        {
            met.clearText(tbApelido);
        }
        #endregion
    }
}
