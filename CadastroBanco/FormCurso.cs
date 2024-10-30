using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroBanco
{
    public partial class FormCurso : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server=127.0.0.1;" +
                          "uid=root;" +
                          "pwd=K@gaya011526;" +
                          "database=academico";
        public FormCurso()
        {
            InitializeComponent();
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
            }
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(tbCodigo.Text))
            {
                MessageBox.Show("Atenção!\nCampo Código não preenchido!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCodigo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Atenção!\nCampo Nome não preenchido!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbNivel.Text))
            {
                MessageBox.Show("Atenção!\nCampo Nível não preenchido!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNivel.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbPeriodo.Text))
            {
                MessageBox.Show("Atenção!\nCampo Período não preenchido!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbPeriodo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbDuracao.Text))
            {
                MessageBox.Show("Atenção!\nCampo Duração não preenchido!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDuracao.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbArea.Text))
            {
                MessageBox.Show("Atenção!\nCampo Área não preenchido!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbArea.Focus();
                return false;
            }
            return true;
        }

        private void Salvar()
        {
            // Variável para realizar a conexão com o Banco de Dados
            var con = new MySqlConnection(conexao);
            // Abrir a Base de Dados
            con.Open();
            // Variável para realizar os comandos no Banco de Dados
            var sql = "";
            if (isAlteracao) // Update de Dados
            {
                sql = "UPDATE curso SET " +
                      "codigo = @codigo, " +
                      "nome = @nome, " +
                      "nivel = @nivel, " +
                      "periodo = @periodo, " +
                      "duracao = @duracao, " +
                      "area = @area " +
                      " WHERE id = @id";
            }
            else // Adicionar novos Dados
            {
                sql = "INSERT INTO curso " +
                      " (codigo, nome, nivel, periodo, duracao, area) " +
                      "VALUES " +
                      " (@codigo, @nome, @nivel, @periodo, @duracao, @area) ";
            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@codigo", tbCodigo.Text);
            cmd.Parameters.AddWithValue("@nome", tbNome.Text);
            cmd.Parameters.AddWithValue("@nivel", cbNivel.Text);
            cmd.Parameters.AddWithValue("@periodo", cbPeriodo.Text);
            cmd.Parameters.AddWithValue("@duracao", tbDuracao.Text);
            cmd.Parameters.AddWithValue("@area", cbArea.Text);

            if (isAlteracao)
            {
                cmd.Parameters.AddWithValue("@id", tbId.Text);
            }

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            LimpaCampos();
        }

        private void Novo()
        {
            tabControl.SelectedIndex = 0;
            LimpaCampos();
            tbCodigo.Focus();
        }

        private void Editar()
        {
            if (dataGridViewCurso.Rows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewCurso.SelectedRows[0];
                tbId.Text = linha.Cells["id"].Value.ToString();
                tbCodigo.Text = linha.Cells["codigo"].Value.ToString();
                cbNivel.Text = linha.Cells["nivel"].Value.ToString();
                cbPeriodo.Text = linha.Cells["periodo"].Value.ToString();
                tbDuracao.Text = linha.Cells["duracao"].Value.ToString();
                cbArea.Text = linha.Cells["area"].Value.ToString();
                tabControl.SelectedIndex = 0;
                tbCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Atenção!\nSelecione um curso para realizar alteração!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Excluir(int id)
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM curso WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Cancelar()
        {
            if ((MessageBox.Show("Atenção!\nAs informação não salvas serão perdidas...\nDeseja continuar?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                LimpaCampos();
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewCurso.DataSource = dt;
            con.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                tabControl.SelectedIndex = 1;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridViewCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewCurso.SelectedRows.Count > 0)
            {
                if ((MessageBox.Show("Atenção!\nDeseja realmente excluir esse curso?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    int id = (int)dataGridViewCurso.SelectedRows[0].Cells["id"].Value;
                    Excluir(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Atenção!\nSelecione um curso para excluir!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
