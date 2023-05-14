using System;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;
using System.Linq.Expressions;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois {
    public partial class FormAmigoCad : Form {
        //Instancia a classe de metodos
        Methods met = new Methods();
        AmigoDAO dao = new AmigoDAO();
        public FormAmigoCad() {
            InitializeComponent();
        }

        //Ao clicar nesse Botão é pego todas as informações contidas dentro dos textbox
        //e registra no banco de dados
        #region cadastro de informação
        private void bt_enviar_Click(object sender, EventArgs e) {
            AmigoHeroi amigo = new AmigoHeroi();
            try {
                amigo.NomePessoa = tbNome.Text + " " + tbSobreNome.Text;
                amigo.Email = tbEmail.Text;
                amigo.AnoNasc = Convert.ToInt32(dtpNasc.Text);
                amigo.AtividadeProfissional = tbAtiPro.Text;
                amigo.Hobby = tbHobby.Text;
                amigo.CaminhoImagem = btUpload.Text;
                amigo.calcularIdade(amigo.AnoNasc);
                dao.inserir(amigo);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        //Ao clicar no Botão chama o metodo que faz o upload de uma imagem a escolha do usuario
        #region upload de imagem
        private void btUpload_Click(object sender, EventArgs e) {
            met.uploadImage(pbFoto);
        }
        #endregion

        //Chama o metodo que ao sair do textbox e perder o 'focar' do texto retorna o
        //texto que esta contido na tag de volta ao textbox
        #region placeholder's enter
        private void tbNome_Leave(object sender, EventArgs e) {
            met.addText(tbNome, tbNome.Tag.ToString());
        }

        private void tbSobreNome_Leave(object sender, EventArgs e) {
            met.addText(tbSobreNome, tbSobreNome.Tag.ToString());
        }

        private void tbEmail_Leave(object sender, EventArgs e) {
            met.addText(tbEmail, tbEmail.Tag.ToString());
        }

        private void tbAtiPro_Leave(object sender, EventArgs e) {
            met.addText(tbAtiPro, tbAtiPro.Tag.ToString());
        }

        private void tbHobby_Leave(object sender, EventArgs e) {
            met.addText(tbHobby, tbHobby.Tag.ToString());
        }
        #endregion

        //Chama o metodo que ao entrar no textbox e ganhar o 'foco' do texto apaga o
        //texto que estava contido dentro do textbox, desde que não seja o texto do usuario
        #region placeholder's clear
        private void tbNome_Enter(object sender, EventArgs e) {
            met.clearText(tbNome);
        }

        private void tbSobreNome_Enter(object sender, EventArgs e) {
            met.clearText(tbSobreNome);
        }

        private void tbEmail_Enter(object sender, EventArgs e) {
            met.clearText(tbEmail);
        }

        private void tbAtiPro_Enter(object sender, EventArgs e) {
            met.clearText(tbAtiPro);
        }

        private void tbHobby_Enter(object sender, EventArgs e) {
            met.clearText(tbHobby);
        }
        #endregion

        private void FormAmigo_Load(object sender, EventArgs e) {

        }
    }
}
