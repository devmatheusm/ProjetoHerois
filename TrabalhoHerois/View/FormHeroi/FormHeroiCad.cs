using System;
using System.Drawing;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.View.FormHeroi
{
    public partial class FormHeroiCad : Form
    {
        //Instancia a classe de metodos
        Methods met = new Methods();
        HeroiDAO dao;
        public FormHeroiCad()
        {
            InitializeComponent();
            dao = new HeroiDAO();
        }
        //Ao clicar nesse Botão é pego todas as informações contidas dentro dos textbox
        //e registra no banco de dados
        #region cadastro de informação
        private void bt_enviar_Click(object sender, EventArgs e)
        {
            Heroi heroi = new Heroi();
            bool concluido;
            try
            {
                concluido = true;
                if (tbNome.Text != tbNome.Tag.ToString())
                    heroi.NomePessoa = tbNome.Text;
                else
                {
                    tbNome.ForeColor = Color.Red;
                    concluido = false;
                }
                if (tbEmail.Text != tbEmail.Tag.ToString())
                    heroi.Email = tbEmail.Text;
                else
                {
                    tbEmail.ForeColor = Color.Red;
                    concluido = false;
                }
                if (tbPlaneta.Text != tbPlaneta.Tag.ToString())
                    heroi.PlanetaOrigem = tbPlaneta.Text;
                else
                {
                    tbPlaneta.ForeColor = Color.Red;
                    concluido = false;
                }
                if (tbPoder.Text != tbPoder.Tag.ToString())
                    heroi.SuperPoder = tbPoder.Text;
                else
                {
                    tbPoder.ForeColor = Color.Red;
                    concluido = false;
                }
                if (tbParceiro.Text != tbParceiro.Tag.ToString())
                    heroi.Parceiro = tbParceiro.Text;
                else
                {
                    tbParceiro.ForeColor = Color.Red;
                    concluido = false;
                }
                if (tbApelido.Text != tbApelido.Tag.ToString())
                    heroi.NomeHeroi = tbNome.Text;
                else
                {
                    tbApelido.ForeColor = Color.Red;
                    concluido = false;
                }
                if (tbAtiPro.Text != tbAtiPro.Tag.ToString())
                    heroi.AtividadeProfissional = tbAtiPro.Text;
                else
                {
                    tbAtiPro.ForeColor = Color.Red;
                    concluido = false;
                }
                if (tbGrupo.Text != tbGrupo.Tag.ToString())
                    heroi.Grupo = tbGrupo.Text;
                else
                {
                    tbGrupo.ForeColor = Color.Red;
                    concluido = false;
                }
                if (tbFraco.Text != tbFraco.Tag.ToString())
                    heroi.PontoFraco = tbFraco.Text;
                else
                {
                    tbFraco.ForeColor = Color.Red;
                    concluido = false;
                }
                heroi.CaminhoImagem = pbFoto.ImageLocation;
                heroi.AnoNasc = Convert.ToInt32(dtpNasc.Text);
                heroi.calcularIdade(heroi.AnoNasc);
                if (concluido && dao.inserir(heroi))
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
            //Chama o metodo que faz o upload da imagem ao picturebox
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
            met.addText(tbPoder, tbPoder.Tag.ToString());
        }
        //PARCEIRO
        private void tbParceiro_Leave(object sender, EventArgs e)
        {
            met.addText(tbParceiro, tbParceiro.Tag.ToString());
        }
        //APELIDO DO HEROI
        private void tbApelido_Leave(object sender, EventArgs e)
        {
            met.addText(tbApelido, tbApelido.Tag.ToString());
        }
        //ATIVIDADE PROFISSIONAL
        private void tbAtiPro_Leave(object sender, EventArgs e)
        {
            met.addText(tbAtiPro, tbAtiPro.Tag.ToString());
        }
        //GRUPO DO HEROI
        private void tbGrupo_Leave(object sender, EventArgs e)
        {
            met.addText(tbGrupo, tbGrupo.Tag.ToString());
        }
        //FRAQUEZA DO HEROI
        private void tbFraco_Leave(object sender, EventArgs e)
        {
            met.addText(tbFraco, tbFraco.Tag.ToString());
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
        //ATIVIDADE PROFISSIONAL
        private void tbAtiPro_Enter(object sender, EventArgs e)
        {
            met.clearText(tbAtiPro);
        }
        //NOME DO GRUPO
        private void tbGrupo_Enter(object sender, EventArgs e)
        {
            met.clearText(tbGrupo);
        }
        //FRAQUEZA DO HEROI
        private void tbFraco_Enter(object sender, EventArgs e)
        {
            met.clearText(tbFraco);
        }
        #endregion
    }
}