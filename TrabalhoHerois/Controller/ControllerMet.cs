using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.Controller
{
    internal class ControllerMet
    {
        SqlDataAdapter data;
        DataSet dataSetTable;
        SqlCommandBuilder sqlbd;
        Pessoa pessoa = new Pessoa();

        //metodo para a exclusão de dados do banco de dados
        #region metodos de exclusão
        public void atualizaLista(CheckedListBox clb, string nomeTabela, string idPessoa)
        {
            try
            {
                clb.Items.Clear();
                string sql = "select " + idPessoa + ", nome from " + nomeTabela;
                SqlCommand cmd = new SqlCommand(sql, Conexao.obterConexao());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    clb.Items.Add("ID-" + dr[0].ToString() + " \t|    NOME:" + dr[1].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        #endregion

        //metodos para a consulta no banco de dados
        #region metodos de consulta

        public void consultaGeral(DataGridView dgv, string nomeTabela)
        {
            string sql = "select * from " + nomeTabela;
            //executa o comando do sql
            SqlCommand exesql = new SqlCommand(sql, Conexao.obterConexao());
            // data adapter executa o comando do sql, busca os dados da tabela e traz pra variavel data
            SqlDataAdapter data = new SqlDataAdapter(exesql);
            // data set cria um tabela local para o programa
            DataSet dataSetTable = new DataSet();
            // o data com o parameetro de fill recebendo a tabela local empurra os dados para o programa
            data.Fill(dataSetTable);
            dgv.DataSource = dataSetTable.Tables[0];
        }
        public void consultaId(DataGridView dgv, string nomeTabela, string whereId, int idPessoa)//(usado tambem na atualização)
        {
            try
            {
                string sql = "select * from " + nomeTabela + " where " + whereId + " = " + idPessoa;
                //executa o comando do sql
                SqlCommand exesql = new SqlCommand(sql, Conexao.obterConexao());
                // data adapter executa o comando do sql, busca os dados da tabela e traz pra variavel data
                data = new SqlDataAdapter(exesql);
                // data set cria um tabela local para o programa
                dataSetTable = new DataSet();
                // o data com o parameetro de fill recebendo a tabela local empurra os dados para o programa
                data.Fill(dataSetTable);
                dgv.DataSource = dataSetTable.Tables[0];
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                Conexao.fecharConexao();
            }
        }

        public void atualizaLista(ComboBox cb, string nomeTabela, string idPessoa)//(usado tambem na atualização)
        {
            try
            {
                cb.Items.Clear();
                string sql = "select " + idPessoa + ", nome from " + nomeTabela;
                SqlCommand cmd = new SqlCommand(sql, Conexao.obterConexao());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add("ID-" + dr[0].ToString() + " \t|    NOME:" + dr[1].ToString());
                }
                dr.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        #endregion

        #region metodos de atualização
        public void consultaId(DataGridView dgv, string nomeTabela, string whereId, int idPessoa, string SQLquery)//(usado tambem na atualização)
        {
            try
            {
                string sql = "select " + " " + whereId + " as ID, " + SQLquery + " from " + nomeTabela + " where " + whereId + " = " + idPessoa;
                //executa o comando do sql
                SqlCommand exesql = new SqlCommand(sql, Conexao.obterConexao());
                // data adapter executa o comando do sql, busca os dados da tabela e traz pra variavel data
                data = new SqlDataAdapter(exesql);
                // data set cria um tabela local para o programa
                dataSetTable = new DataSet();
                // o data com o parameetro de fill recebendo a tabela local empurra os dados para o programa
                data.Fill(dataSetTable);
                dgv.DataSource = dataSetTable.Tables[0];
                dgv.Columns.Remove("ID");
            }
            catch(SqlException ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        public void atualizaCad()
        {
            sqlbd = new SqlCommandBuilder(data);
            data.Update(dataSetTable);
        }

        public void atualizaIdadeBD(string nomeTabela, string whereId, int idPessoa)
        {
            try
            {
                string sql = "select anoNasc as ANO from " + nomeTabela + " where " + whereId + " = " + idPessoa;
                SqlCommand exesql = new SqlCommand(sql, Conexao.obterConexao());

                SqlDataReader sqlread = exesql.ExecuteReader();
                sqlread.Read();
                pessoa.calcularIdade(Convert.ToInt32(sqlread["ANO"]));
                sql = "update " + nomeTabela + " set idade = " + pessoa.Idade + " where " + whereId + " = " + idPessoa;
                exesql = new SqlCommand(sql, Conexao.obterConexao());
                exesql.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }
            finally 
            { 
                Conexao.fecharConexao(); 
            }
        }
        #endregion
    }
}
