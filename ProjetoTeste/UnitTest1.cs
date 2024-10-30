using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;

namespace ProjetoTeste
{
    [TestClass]
    public class UnitTest1
    {
        public MySqlConnection GetConnection()
        {
            string c = @"server=127.0.0.1;" + "uid=root;" + "pwd=K@gaya011526;" + "database=academico";
            return new MySqlConnection(c);
        }

        [TestMethod]
        public void TestConnect()
        {
            var con = GetConnection();
            con.Open();
            Assert.IsTrue(con.State == System.Data.ConnectionState.Open); // Verificar se o Teste foi feito
        }

        [TestMethod]
        public void TestInsertAluno()
        {
            string sql = "INSERT INTO aluno " +
                " (matricula, dt_nascimento, nome, endereco, " +
                " bairro, cidade, estado, senha) " +
                " VALUES " +
                " (@matricula, @dt_nascimento, @nome, @endereco, " +
                " @bairro, @cidade, @estado, @senha)";

            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@matricula", "BI3017338");
            cmd.Parameters.AddWithValue("@dt_nascimento", new DateTime(2004, 07, 26));
            cmd.Parameters.AddWithValue("@nome", "Kayky Kenzo Ogaya");
            cmd.Parameters.AddWithValue("@endereco", "Rua Noroeste 390");
            cmd.Parameters.AddWithValue("@bairro", "Vila Roberto");
            cmd.Parameters.AddWithValue("@cidade", "Birigui");
            cmd.Parameters.AddWithValue("@estado", "SP");
            cmd.Parameters.AddWithValue("@senha", "K@gaya011526");

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        [TestMethod]
        public void TestSelectAluno()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * from aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);

            var dt = new DataTable();
            sqlAd.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Debug.WriteLine(dr["matricula"] + " ");
                Debug.WriteLine(dr["nome"] + " ");
                Debug.WriteLine(dr["dt_nascimento"] + " ");
                Debug.WriteLine(dr["endereco"] + " ");
                Debug.WriteLine(dr["cidade"] + " ");
                Debug.WriteLine(dr["bairro"] + " ");
                Debug.WriteLine(dr["estado"] + " ");
                Debug.WriteLine(dr["senha"] + " ");
                Debug.WriteLine(" ");
            }

            con.Close();
        }

        [TestMethod]
        public void TestInsertCurso()
        {
            string sql = "INSERT INTO curso " +
                         "(codigo, nome, nivel, periodo, duracao, area) " +
                         "VALUES " +
                         "(@codigo, @nome, @nivel, @periodo, @duracao, @area)";
            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@codigo", "ENG221");
            cmd.Parameters.AddWithValue("@nome", "Engenharia da Computação");
            cmd.Parameters.AddWithValue("@nivel", "Superior");
            cmd.Parameters.AddWithValue("@periodo", "Integral");
            cmd.Parameters.AddWithValue("@duracao", "10");
            cmd.Parameters.AddWithValue("@area", "Informática");

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        [TestMethod]
        public void TestSelectCurso()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);

            var dt = new DataTable();

            sqlAd.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Debug.WriteLine(dr["codigo"] + " ");
                Debug.WriteLine(dr["nome"] + " ");
                Debug.WriteLine(dr["nivel"] + " ");
                Debug.WriteLine(dr["periodo"] + " ");
                Debug.WriteLine(dr["duracao"] + " ");
                Debug.WriteLine(dr["area"] + " ");
                Debug.WriteLine(" ");
            }

            con.Close();
        }
    }
}