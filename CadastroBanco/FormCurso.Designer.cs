namespace CadastroBanco
{
    partial class FormCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurso));
            tabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            btCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btSalvar = new ReaLTaiizor.Controls.MaterialButton();
            cbArea = new ReaLTaiizor.Controls.MaterialComboBox();
            tbDuracao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            cbNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            btNovo = new ReaLTaiizor.Controls.MaterialButton();
            btEditar = new ReaLTaiizor.Controls.MaterialButton();
            btExcluir = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewCurso = new DataGridView();
            imageList1 = new ImageList(components);
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageCadastro);
            tabControl.Controls.Add(tabPageConsulta);
            tabControl.Depth = 0;
            tabControl.ImageList = imageList1;
            tabControl.Location = new Point(6, 67);
            tabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(788, 377);
            tabControl.TabIndex = 1;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btCancelar);
            tabPageCadastro.Controls.Add(btSalvar);
            tabPageCadastro.Controls.Add(cbArea);
            tabPageCadastro.Controls.Add(tbDuracao);
            tabPageCadastro.Controls.Add(cbPeriodo);
            tabPageCadastro.Controls.Add(cbNivel);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.Controls.Add(tbCodigo);
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.ImageKey = "Forms - Icon.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(780, 342);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            btCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btCancelar.Depth = 0;
            btCancelar.HighEmphasis = true;
            btCancelar.Icon = null;
            btCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btCancelar.Location = new Point(549, 253);
            btCancelar.Margin = new Padding(4, 6, 4, 6);
            btCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btCancelar.Name = "btCancelar";
            btCancelar.NoAccentTextColor = Color.Empty;
            btCancelar.Size = new Size(96, 36);
            btCancelar.TabIndex = 8;
            btCancelar.Text = "Cancelar";
            btCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btCancelar.UseAccentColor = false;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btSalvar.Depth = 0;
            btSalvar.HighEmphasis = true;
            btSalvar.Icon = null;
            btSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btSalvar.Location = new Point(671, 253);
            btSalvar.Margin = new Padding(4, 6, 4, 6);
            btSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btSalvar.Name = "btSalvar";
            btSalvar.NoAccentTextColor = Color.Empty;
            btSalvar.Size = new Size(76, 36);
            btSalvar.TabIndex = 7;
            btSalvar.Text = "Salvar";
            btSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btSalvar.UseAccentColor = false;
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // cbArea
            // 
            cbArea.AutoResize = false;
            cbArea.BackColor = Color.FromArgb(255, 255, 255);
            cbArea.Depth = 0;
            cbArea.DrawMode = DrawMode.OwnerDrawVariable;
            cbArea.DropDownHeight = 174;
            cbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArea.DropDownWidth = 121;
            cbArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbArea.FormattingEnabled = true;
            cbArea.Hint = "Área do Curso";
            cbArea.IntegralHeight = false;
            cbArea.ItemHeight = 43;
            cbArea.Items.AddRange(new object[] { "Licenciatura", "Informática", "Indústria", "Administração" });
            cbArea.Location = new Point(410, 177);
            cbArea.MaxDropDownItems = 4;
            cbArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(337, 49);
            cbArea.StartIndex = 0;
            cbArea.TabIndex = 6;
            // 
            // tbDuracao
            // 
            tbDuracao.AnimateReadOnly = false;
            tbDuracao.AutoCompleteMode = AutoCompleteMode.None;
            tbDuracao.AutoCompleteSource = AutoCompleteSource.None;
            tbDuracao.BackgroundImageLayout = ImageLayout.None;
            tbDuracao.CharacterCasing = CharacterCasing.Normal;
            tbDuracao.Depth = 0;
            tbDuracao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDuracao.HideSelection = true;
            tbDuracao.Hint = "Duração do Curso (em semestres)";
            tbDuracao.LeadingIcon = null;
            tbDuracao.Location = new Point(17, 177);
            tbDuracao.MaxLength = 32767;
            tbDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDuracao.Name = "tbDuracao";
            tbDuracao.PasswordChar = '\0';
            tbDuracao.PrefixSuffixText = null;
            tbDuracao.ReadOnly = false;
            tbDuracao.RightToLeft = RightToLeft.No;
            tbDuracao.SelectedText = "";
            tbDuracao.SelectionLength = 0;
            tbDuracao.SelectionStart = 0;
            tbDuracao.ShortcutsEnabled = true;
            tbDuracao.Size = new Size(370, 48);
            tbDuracao.TabIndex = 5;
            tbDuracao.TabStop = false;
            tbDuracao.TextAlign = HorizontalAlignment.Left;
            tbDuracao.TrailingIcon = null;
            tbDuracao.UseSystemPasswordChar = false;
            // 
            // cbPeriodo
            // 
            cbPeriodo.AutoResize = false;
            cbPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            cbPeriodo.Depth = 0;
            cbPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            cbPeriodo.DropDownHeight = 174;
            cbPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPeriodo.DropDownWidth = 121;
            cbPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbPeriodo.FormattingEnabled = true;
            cbPeriodo.Hint = "Período do Curso";
            cbPeriodo.IntegralHeight = false;
            cbPeriodo.ItemHeight = 43;
            cbPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            cbPeriodo.Location = new Point(410, 96);
            cbPeriodo.MaxDropDownItems = 4;
            cbPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbPeriodo.Name = "cbPeriodo";
            cbPeriodo.Size = new Size(337, 49);
            cbPeriodo.StartIndex = 0;
            cbPeriodo.TabIndex = 4;
            // 
            // cbNivel
            // 
            cbNivel.AutoResize = false;
            cbNivel.BackColor = Color.FromArgb(255, 255, 255);
            cbNivel.Depth = 0;
            cbNivel.DrawMode = DrawMode.OwnerDrawVariable;
            cbNivel.DropDownHeight = 174;
            cbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNivel.DropDownWidth = 121;
            cbNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbNivel.FormattingEnabled = true;
            cbNivel.Hint = "Nível de Curso";
            cbNivel.IntegralHeight = false;
            cbNivel.ItemHeight = 43;
            cbNivel.Items.AddRange(new object[] { "Técnico", "Superior" });
            cbNivel.Location = new Point(17, 96);
            cbNivel.MaxDropDownItems = 4;
            cbNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbNivel.Name = "cbNivel";
            cbNivel.Size = new Size(370, 49);
            cbNivel.StartIndex = 0;
            cbNivel.TabIndex = 3;
            // 
            // tbNome
            // 
            tbNome.AnimateReadOnly = false;
            tbNome.AutoCompleteMode = AutoCompleteMode.None;
            tbNome.AutoCompleteSource = AutoCompleteSource.None;
            tbNome.BackgroundImageLayout = ImageLayout.None;
            tbNome.CharacterCasing = CharacterCasing.Normal;
            tbNome.Depth = 0;
            tbNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbNome.HideSelection = true;
            tbNome.Hint = "Nome";
            tbNome.LeadingIcon = null;
            tbNome.Location = new Point(458, 18);
            tbNome.MaxLength = 32767;
            tbNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbNome.Name = "tbNome";
            tbNome.PasswordChar = '\0';
            tbNome.PrefixSuffixText = null;
            tbNome.ReadOnly = false;
            tbNome.RightToLeft = RightToLeft.No;
            tbNome.SelectedText = "";
            tbNome.SelectionLength = 0;
            tbNome.SelectionStart = 0;
            tbNome.ShortcutsEnabled = true;
            tbNome.Size = new Size(289, 48);
            tbNome.TabIndex = 2;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
            // 
            // tbCodigo
            // 
            tbCodigo.AnimateReadOnly = false;
            tbCodigo.AutoCompleteMode = AutoCompleteMode.None;
            tbCodigo.AutoCompleteSource = AutoCompleteSource.None;
            tbCodigo.BackgroundImageLayout = ImageLayout.None;
            tbCodigo.CharacterCasing = CharacterCasing.Normal;
            tbCodigo.Depth = 0;
            tbCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCodigo.HideSelection = true;
            tbCodigo.Hint = "Código do Curso";
            tbCodigo.LeadingIcon = null;
            tbCodigo.Location = new Point(184, 18);
            tbCodigo.MaxLength = 32767;
            tbCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbCodigo.Name = "tbCodigo";
            tbCodigo.PasswordChar = '\0';
            tbCodigo.PrefixSuffixText = null;
            tbCodigo.ReadOnly = false;
            tbCodigo.RightToLeft = RightToLeft.No;
            tbCodigo.SelectedText = "";
            tbCodigo.SelectionLength = 0;
            tbCodigo.SelectionStart = 0;
            tbCodigo.ShortcutsEnabled = true;
            tbCodigo.Size = new Size(250, 48);
            tbCodigo.TabIndex = 1;
            tbCodigo.TabStop = false;
            tbCodigo.TextAlign = HorizontalAlignment.Left;
            tbCodigo.TrailingIcon = null;
            tbCodigo.UseSystemPasswordChar = false;
            // 
            // tbId
            // 
            tbId.AnimateReadOnly = false;
            tbId.AutoCompleteMode = AutoCompleteMode.None;
            tbId.AutoCompleteSource = AutoCompleteSource.None;
            tbId.BackgroundImageLayout = ImageLayout.None;
            tbId.CharacterCasing = CharacterCasing.Normal;
            tbId.Depth = 0;
            tbId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbId.HideSelection = true;
            tbId.Hint = "ID";
            tbId.LeadingIcon = null;
            tbId.Location = new Point(17, 18);
            tbId.MaxLength = 32767;
            tbId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbId.Name = "tbId";
            tbId.PasswordChar = '\0';
            tbId.PrefixSuffixText = null;
            tbId.ReadOnly = true;
            tbId.RightToLeft = RightToLeft.No;
            tbId.SelectedText = "";
            tbId.SelectionLength = 0;
            tbId.SelectionStart = 0;
            tbId.ShortcutsEnabled = true;
            tbId.Size = new Size(140, 48);
            tbId.TabIndex = 0;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btNovo);
            tabPageConsulta.Controls.Add(btEditar);
            tabPageConsulta.Controls.Add(btExcluir);
            tabPageConsulta.Controls.Add(dataGridViewCurso);
            tabPageConsulta.ImageKey = "Search - Icon.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(780, 342);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // btNovo
            // 
            btNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btNovo.Depth = 0;
            btNovo.HighEmphasis = true;
            btNovo.Icon = null;
            btNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btNovo.Location = new Point(502, 258);
            btNovo.Margin = new Padding(4, 6, 4, 6);
            btNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btNovo.Name = "btNovo";
            btNovo.NoAccentTextColor = Color.Empty;
            btNovo.Size = new Size(64, 36);
            btNovo.TabIndex = 3;
            btNovo.Text = "Novo";
            btNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btNovo.UseAccentColor = false;
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // btEditar
            // 
            btEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btEditar.Depth = 0;
            btEditar.HighEmphasis = true;
            btEditar.Icon = null;
            btEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btEditar.Location = new Point(587, 258);
            btEditar.Margin = new Padding(4, 6, 4, 6);
            btEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btEditar.Name = "btEditar";
            btEditar.NoAccentTextColor = Color.Empty;
            btEditar.Size = new Size(71, 36);
            btEditar.TabIndex = 2;
            btEditar.Text = "Editar";
            btEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btEditar.UseAccentColor = false;
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btExcluir
            // 
            btExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btExcluir.Depth = 0;
            btExcluir.HighEmphasis = true;
            btExcluir.Icon = null;
            btExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btExcluir.Location = new Point(676, 258);
            btExcluir.Margin = new Padding(4, 6, 4, 6);
            btExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btExcluir.Name = "btExcluir";
            btExcluir.NoAccentTextColor = Color.Empty;
            btExcluir.Size = new Size(80, 36);
            btExcluir.TabIndex = 1;
            btExcluir.Text = "Excluir";
            btExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btExcluir.UseAccentColor = false;
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // dataGridViewCurso
            // 
            dataGridViewCurso.AllowUserToAddRows = false;
            dataGridViewCurso.AllowUserToDeleteRows = false;
            dataGridViewCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCurso.Dock = DockStyle.Top;
            dataGridViewCurso.Location = new Point(3, 3);
            dataGridViewCurso.Name = "dataGridViewCurso";
            dataGridViewCurso.ReadOnly = true;
            dataGridViewCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCurso.Size = new Size(774, 237);
            dataGridViewCurso.TabIndex = 0;
            dataGridViewCurso.CellDoubleClick += dataGridViewCurso_CellDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Forms - Icon.png");
            imageList1.Images.SetKeyName(1, "Search - Icon.png");
            // 
            // FormCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 401);
            Controls.Add(tabControl);
            DrawerTabControl = tabControl;
            Name = "FormCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Curso";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControl;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCodigo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
        private ReaLTaiizor.Controls.MaterialComboBox cbNivel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
        private ReaLTaiizor.Controls.MaterialButton btCancelar;
        private ReaLTaiizor.Controls.MaterialButton btSalvar;
        private ReaLTaiizor.Controls.MaterialComboBox cbArea;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbDuracao;
        private ReaLTaiizor.Controls.MaterialComboBox cbPeriodo;
        private ReaLTaiizor.Controls.MaterialButton btExcluir;
        private DataGridView dataGridViewCurso;
        private ReaLTaiizor.Controls.MaterialButton btNovo;
        private ReaLTaiizor.Controls.MaterialButton btEditar;
        private ImageList imageList1;
    }
}