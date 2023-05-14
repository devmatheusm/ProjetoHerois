using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;

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
                    break;
                case "Consultar":
                    break;
                case "Excluir":
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
                    break;
                case "Consultar":
                    break;
                case "Excluir":
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
                    break;
                case "Consultar":
                    break;
                case "Excluir":
                    break;
            }
        }
        #endregion
    }
}
