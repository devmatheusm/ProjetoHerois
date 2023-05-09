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
    public partial class FormMenu : Form
    {
        //Instancia a classe de metodos
        Methods met;

        public FormMenu()
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

        //coleção de botões que fazem a abertura dos formularios de cadastro
        #region botões de abertura dos cadastros
        //abre o menu de cadastro do heroi
        private void bt_hero_Click(object sender, EventArgs e)
        {
            met.OpenForm(new FormHeroi(), painelMenu);
        }
        //abre o menu de cadastro do amigo do heroi
        private void bt_friend_Click(object sender, EventArgs e)
        {
            met.OpenForm(new FormAmigo(), painelMenu);
        }
        //abre o menu do vilão
        private void bt_villain_Click(object sender, EventArgs e)
        {
            met.OpenForm(new FormVilao(), painelMenu);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.obterConexao();
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
    }
}
