using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroBanco
{
    public partial class FormAluno : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server=127.0.0.1;" +
                          "uid=root;" +
                          "pwd=K@gaya011526;" +
                          "database=academico";

        public FormAluno()
        {
            InitializeComponent();
        }

        private void Salvar()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "";
            if (isAlteracao) // Update
            {
                sql = "UPDATE aluno SET " +
                      "matricula = @matricula, " +
                      "nome = @nome, " +
                      "dt_nascimento = @dt_nascimento, " +
                      "endereco = @endereco, " +
                      "bairro = @bairro, " +
                      "cidade = @cidade, " +
                      "estado = @estado, " +
                      "senha = @senha " +
                      " WHERE id = @id";
            }
            else // Insert
            {
                sql = "INSERT INTO aluno " +
                " (matricula, dt_nascimento, nome, endereco, " +
                " bairro, cidade, estado, senha) " +
                " VALUES " +
                " (@matricula, @dt_nascimento, @nome, @endereco, " +
                " @bairro, @cidade, @estado, @senha)";
            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", tbMatricula.Text);
            DateTime.TryParse(tbDataNascimento.Text, out var dataNascimento);
            cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", tbNome.Text);
            cmd.Parameters.AddWithValue("@endereco", tbEndereco.Text);
            cmd.Parameters.AddWithValue("@cidade", tbCidade.Text);
            cmd.Parameters.AddWithValue("@bairro", tbBairro.Text);
            cmd.Parameters.AddWithValue("@estado", cbEstado.Text);
            cmd.Parameters.AddWithValue("@senha", tbSenha.Text);

            if (isAlteracao)
            {
                cmd.Parameters.AddWithValue("@id", tbId.Text);
            }

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            LimpaCampos();
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(tbMatricula.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Matrícula não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMatricula.Focus();
                return false;
            }
            if (!DateTime.TryParse(tbDataNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data de Nascimento inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDataNascimento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Nome não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbEndereco.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Endereço não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbCidade.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Cidade não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbEstado.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Estado não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEstado.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbSenha.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Senha não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSenha.Focus();
                return false;
            }
            return true;
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
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void Novo()
        {
            TabControl.SelectedIndex = 0;
            LimpaCampos();
            tbMatricula.Focus();
        }

        private void Editar()
        {
            if (dataGridViewAluno.Rows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewAluno.SelectedRows[0];
                tbId.Text = linha.Cells["id"].Value.ToString();
                tbMatricula.Text = linha.Cells["matricula"].Value.ToString();
                tbDataNascimento.Text = linha.Cells["dt_nascimento"].Value.ToString();
                tbNome.Text = linha.Cells["nome"].Value.ToString();
                tbEndereco.Text = linha.Cells["endereco"].Value.ToString();
                tbBairro.Text = linha.Cells["bairro"].Value.ToString();
                tbCidade.Text = linha.Cells["cidade"].Value.ToString();
                cbEstado.Text = linha.Cells["estado"].Value.ToString();
                tbSenha.Text = linha.Cells["senha"].Value.ToString();
                TabControl.SelectedIndex = 0;
                tbMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Excluir(int id)
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM aluno WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                TabControl.SelectedIndex = 1;
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewAluno.DataSource = dt;
            con.Close();
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Editar();

        }

        private void dataGridViewAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                if ((MessageBox.Show("Deseja realmente excluir?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewAluno.SelectedRows[0].Cells["id"].Value;
                    Excluir(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Atenção! As informações não salvas serão perdidas\nTem certeza?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                LimpaCampos();
            }
        }
    }
}
