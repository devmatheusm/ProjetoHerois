using System;
using System.Windows.Forms;
using TrabalhoHerois.View.FormAmigo;
using TrabalhoHerois.View.FormHeroi;
using TrabalhoHerois.View.FormVilao;

namespace TrabalhoHerois.View.FormMenu
{
    public partial class FormMenuCad : Form
    {
        //Instancia a classe de metodos
        Methods met;

        public FormMenuCad()
        {
            InitializeComponent();
            met = new Methods();
        }

        //botao para fechar o programa
        #region fecha o programa
        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //botao para maximizar todo o programa
        #region maximiza o programa
        private void maxForm(object sender, EventArgs e)
        {
            //verifica se esta maximizado
            if (this.WindowState == FormWindowState.Maximized)
                //se o programa ja estiver em maximizado ele volta ao estado normal
                this.WindowState = FormWindowState.Normal;
            else
                //se não ele maximiza
                this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        //botao para minimizar todo o programa
        #region minimiza o programa
        private void minForm(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        //coleção de botões que fazem a abertura do context menu para os outros forms
        #region botões de abertura dos cadastros
        //abre o menu de cadastro do heroi
        private void bt_hero_Click(object sender, EventArgs e)
        {
            cmHeroi.Show(bt_hero, bt_hero.Width, 0);
        }
        //abre o menu de cadastro do amigo do heroi
        private void bt_friend_Click(object sender, EventArgs e)
        {
            cmAmigo.Show(bt_friend, bt_friend.Width, 0);
        }
        //abre o menu do vilão
        private void bt_villain_Click(object sender, EventArgs e)
        {
            cmVilao.Show(bt_villain, bt_villain.Width, 0);
        }

        #endregion

        //abertura dos forms do context menu
        #region contextMenu
        private void cmHeroi_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Cadastrar":
                    met.OpenForm(new FormHeroiCad(), painelMenu);
                    break;
                case "Atualizar":
                    met.OpenForm(new FormHeroiAtu(), painelMenu);
                    break;
                case "Consultar":
                    met.OpenForm(new FormHeroiCon(), painelMenu);
                    break;
                case "Excluir":
                    met.OpenForm(new FormHeroiExc(), painelMenu);
                    break;
            }
        }

        private void cmAmigo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Cadastrar":
                    met.OpenForm(new FormAmigoCad(), painelMenu);
                    break;
                case "Atualizar":
                    met.OpenForm(new FormAmigoAtu(), painelMenu);
                    break;
                case "Consultar":
                    met.OpenForm(new FormAmigoCon(), painelMenu);
                    break;
                case "Excluir":
                    met.OpenForm(new FormAmigoExc(), painelMenu);
                    break;
            }
        }

        private void cmVilao_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Cadastrar":
                    met.OpenForm(new FormVilaoCad(), painelMenu);
                    break;
                case "Atualizar":
                    met.OpenForm(new FormVilaoAtu(), painelMenu);
                    break;
                case "Consultar":
                    met.OpenForm(new FormVilaoCon(), painelMenu);
                    break;
                case "Excluir":
                    met.OpenForm(new FormVilaoExc(), painelMenu);
                    break;
            }
        }
        #endregion
    }
}
