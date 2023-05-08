using System;
using System.Windows.Forms;

namespace TrabalhoHerois
{
    internal class Methods
    {
        //cria uma variavel de armazenamento de um Form
        private Form selectForm;

        //metodo que remove o placeholder de um textbox(serve apenas para textbox e caso
        //o metodo esteja sendo usado com dado Tag)
        #region remove o placeholder
        //ESTE METODO SÓ PODE SER USADO SE O TEXT BOX POSSUIR UMA TAG QUE CONTENHA O MESMO
        //TEXTO QUE SERA SER USADO NO PLACEHOLDER
        public void clearText(TextBox box)
        {
            //verifica se o texto que contem dentro do textbox é igual a Tag
            if (box.Text == box.Tag.ToString())
                //remove o texto do textbox caso passe pelo if
                box.Text = string.Empty;
        }
        #endregion

        //metodo que adciona o placeholder de um textbox(serve apenas para textbox)
        #region adiciona o placeholder
        public void addText(TextBox box, string value)
        {
            //verifica se ja tem algum texto dentro do textbox
            if (box.Text == "".Trim())
                //atribui um texto da escolha do desenvolvedor caso passe pelo if
                box.Text = value;
        }
        #endregion

        //metodo para o upload de uma imagem à um picturebox
        #region upload de imagem
        public void uploadImage(PictureBox pic)
        {
            //criação da variavel que vai armazenar o caminho da imagem selecionada
            string imagePath = string.Empty;
            //--TENTA EXECUTAR O METODO CASO NÃO DE CERTO...
            try
            {
                //instancia o objeto com o nome 'uploadImg'
                OpenFileDialog uploadImg = new OpenFileDialog();
                //filtra quais formatos o programa aceita
                uploadImg.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png";
                //abre a janela para a seleção de arquivos e atribui a imagem ao picturebox
                if (uploadImg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //atribui o caminho da imagem à variavel 'imagePath'
                    imagePath = uploadImg.FileName;
                    //adiciona a imagem dentro do picturebox
                    pic.ImageLocation = imagePath;
                }
            }
            //..VERIFICA O ERRO E EXIBE NA TELA--
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex + "\nTente novamente!", "ERRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
        #endregion

        //metodo para a abertura de forms dentro de um painel
        #region abertura de forms
        public void OpenForm(Form oForm, Panel painel)
        {
            //fecha o forms quando nao nulo
            selectForm?.Close();
            //atribui o selectForm para o selectForm para evitar objeto descartado
            selectForm = oForm;
            //deixa o formulario junto do programa principal(sem abrir uma nova janela)
            oForm.TopLevel = false;
            //retira qualquer tipo de borda dentro do forms e deixa sem poder redimensionar o forms
            oForm.FormBorderStyle = FormBorderStyle.None;
            //faz o forms ficar no estilo Dock Fill
            oForm.Dock = DockStyle.Fill;
            //coloca o forms dentro do painel de escolha
            painel.Controls.Add(oForm);
            //adiciona a tag do forms ao painel
            painel.Tag = oForm;
            //coloca o forms pra frente de qualquer outro objeto
            oForm.BringToFront();
            //abre o forms
            oForm.Show();
        }
        #endregion
    }
}
