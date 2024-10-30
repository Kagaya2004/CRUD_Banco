namespace CadastroBanco
{
    partial class FormAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            imageList1 = new ImageList(components);
            TabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            tbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btSalvar = new ReaLTaiizor.Controls.MaterialButton();
            tbCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbSenha = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            tbDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabPageConsulta = new TabPage();
            dataGridViewAluno = new DataGridView();
            btNovo = new ReaLTaiizor.Controls.MaterialButton();
            btEditar = new ReaLTaiizor.Controls.MaterialButton();
            btExcluir = new ReaLTaiizor.Controls.MaterialButton();
            TabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAluno).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Forms - Icon.png");
            imageList1.Images.SetKeyName(1, "Search - Icon.png");
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPageCadastro);
            TabControl.Controls.Add(tabPageConsulta);
            TabControl.Depth = 0;
            TabControl.Dock = DockStyle.Fill;
            TabControl.ImageList = imageList1;
            TabControl.Location = new Point(3, 64);
            TabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(747, 481);
            TabControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(tbId);
            tabPageCadastro.Controls.Add(btCancelar);
            tabPageCadastro.Controls.Add(btSalvar);
            tabPageCadastro.Controls.Add(tbCidade);
            tabPageCadastro.Controls.Add(tbSenha);
            tabPageCadastro.Controls.Add(tbBairro);
            tabPageCadastro.Controls.Add(tbEndereco);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.Controls.Add(tbMatricula);
            tabPageCadastro.Controls.Add(cbEstado);
            tabPageCadastro.Controls.Add(tbDataNascimento);
            tabPageCadastro.ImageKey = "Forms - Icon.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(739, 446);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
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
            tbId.ImeMode = ImeMode.Disable;
            tbId.LeadingIcon = null;
            tbId.Location = new Point(20, 23);
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
            tbId.Size = new Size(75, 48);
            tbId.TabIndex = 10;
            tbId.TabStop = false;
            tbId.TextAlign = HorizontalAlignment.Left;
            tbId.TrailingIcon = null;
            tbId.UseSystemPasswordChar = false;
            // 
            // btCancelar
            // 
            btCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btCancelar.Depth = 0;
            btCancelar.HighEmphasis = true;
            btCancelar.Icon = null;
            btCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btCancelar.Location = new Point(530, 404);
            btCancelar.Margin = new Padding(4, 6, 4, 6);
            btCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btCancelar.Name = "btCancelar";
            btCancelar.NoAccentTextColor = Color.Empty;
            btCancelar.Size = new Size(96, 36);
            btCancelar.TabIndex = 8;
            btCancelar.Text = "CANCELAR";
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
            btSalvar.Location = new Point(644, 404);
            btSalvar.Margin = new Padding(4, 6, 4, 6);
            btSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btSalvar.Name = "btSalvar";
            btSalvar.NoAccentTextColor = Color.Empty;
            btSalvar.Size = new Size(76, 36);
            btSalvar.TabIndex = 9;
            btSalvar.Text = "SALVAR";
            btSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btSalvar.UseAccentColor = false;
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // tbCidade
            // 
            tbCidade.AnimateReadOnly = false;
            tbCidade.AutoCompleteMode = AutoCompleteMode.None;
            tbCidade.AutoCompleteSource = AutoCompleteSource.None;
            tbCidade.BackgroundImageLayout = ImageLayout.None;
            tbCidade.CharacterCasing = CharacterCasing.Normal;
            tbCidade.Depth = 0;
            tbCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCidade.HideSelection = true;
            tbCidade.Hint = "Cidade";
            tbCidade.LeadingIcon = null;
            tbCidade.Location = new Point(20, 273);
            tbCidade.MaxLength = 32767;
            tbCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbCidade.Name = "tbCidade";
            tbCidade.PasswordChar = '\0';
            tbCidade.PrefixSuffixText = null;
            tbCidade.ReadOnly = false;
            tbCidade.RightToLeft = RightToLeft.No;
            tbCidade.SelectedText = "";
            tbCidade.SelectionLength = 0;
            tbCidade.SelectionStart = 0;
            tbCidade.ShortcutsEnabled = true;
            tbCidade.Size = new Size(554, 48);
            tbCidade.TabIndex = 5;
            tbCidade.TabStop = false;
            tbCidade.TextAlign = HorizontalAlignment.Left;
            tbCidade.TrailingIcon = null;
            tbCidade.UseSystemPasswordChar = false;
            // 
            // tbSenha
            // 
            tbSenha.AllowPromptAsInput = true;
            tbSenha.AnimateReadOnly = false;
            tbSenha.AsciiOnly = false;
            tbSenha.BackgroundImageLayout = ImageLayout.None;
            tbSenha.BeepOnError = false;
            tbSenha.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbSenha.Depth = 0;
            tbSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSenha.HidePromptOnLeave = false;
            tbSenha.HideSelection = true;
            tbSenha.Hint = "Senha";
            tbSenha.InsertKeyMode = InsertKeyMode.Default;
            tbSenha.LeadingIcon = (Image)resources.GetObject("tbSenha.LeadingIcon");
            tbSenha.Location = new Point(20, 337);
            tbSenha.Mask = "";
            tbSenha.MaxLength = 32767;
            tbSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.PrefixSuffixText = null;
            tbSenha.PromptChar = '_';
            tbSenha.ReadOnly = false;
            tbSenha.RejectInputOnFirstFailure = false;
            tbSenha.ResetOnPrompt = true;
            tbSenha.ResetOnSpace = true;
            tbSenha.RightToLeft = RightToLeft.No;
            tbSenha.SelectedText = "";
            tbSenha.SelectionLength = 0;
            tbSenha.SelectionStart = 0;
            tbSenha.ShortcutsEnabled = true;
            tbSenha.Size = new Size(698, 48);
            tbSenha.SkipLiterals = true;
            tbSenha.TabIndex = 7;
            tbSenha.TabStop = false;
            tbSenha.TextAlign = HorizontalAlignment.Left;
            tbSenha.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbSenha.TrailingIcon = null;
            tbSenha.UseSystemPasswordChar = false;
            tbSenha.ValidatingType = null;
            // 
            // tbBairro
            // 
            tbBairro.AnimateReadOnly = false;
            tbBairro.AutoCompleteMode = AutoCompleteMode.None;
            tbBairro.AutoCompleteSource = AutoCompleteSource.None;
            tbBairro.BackgroundImageLayout = ImageLayout.None;
            tbBairro.CharacterCasing = CharacterCasing.Normal;
            tbBairro.Depth = 0;
            tbBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbBairro.HideSelection = true;
            tbBairro.Hint = "Bairro";
            tbBairro.LeadingIcon = null;
            tbBairro.Location = new Point(20, 215);
            tbBairro.MaxLength = 32767;
            tbBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbBairro.Name = "tbBairro";
            tbBairro.PasswordChar = '\0';
            tbBairro.PrefixSuffixText = null;
            tbBairro.ReadOnly = false;
            tbBairro.RightToLeft = RightToLeft.No;
            tbBairro.SelectedText = "";
            tbBairro.SelectionLength = 0;
            tbBairro.SelectionStart = 0;
            tbBairro.ShortcutsEnabled = true;
            tbBairro.Size = new Size(698, 48);
            tbBairro.TabIndex = 4;
            tbBairro.TabStop = false;
            tbBairro.TextAlign = HorizontalAlignment.Left;
            tbBairro.TrailingIcon = null;
            tbBairro.UseSystemPasswordChar = false;
            // 
            // tbEndereco
            // 
            tbEndereco.AnimateReadOnly = false;
            tbEndereco.AutoCompleteMode = AutoCompleteMode.None;
            tbEndereco.AutoCompleteSource = AutoCompleteSource.None;
            tbEndereco.BackgroundImageLayout = ImageLayout.None;
            tbEndereco.CharacterCasing = CharacterCasing.Normal;
            tbEndereco.Depth = 0;
            tbEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEndereco.HideSelection = true;
            tbEndereco.Hint = "Endereço";
            tbEndereco.LeadingIcon = null;
            tbEndereco.Location = new Point(20, 154);
            tbEndereco.MaxLength = 32767;
            tbEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEndereco.Name = "tbEndereco";
            tbEndereco.PasswordChar = '\0';
            tbEndereco.PrefixSuffixText = null;
            tbEndereco.ReadOnly = false;
            tbEndereco.RightToLeft = RightToLeft.No;
            tbEndereco.SelectedText = "";
            tbEndereco.SelectionLength = 0;
            tbEndereco.SelectionStart = 0;
            tbEndereco.ShortcutsEnabled = true;
            tbEndereco.Size = new Size(698, 48);
            tbEndereco.TabIndex = 3;
            tbEndereco.TabStop = false;
            tbEndereco.TextAlign = HorizontalAlignment.Left;
            tbEndereco.TrailingIcon = null;
            tbEndereco.UseSystemPasswordChar = false;
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
            tbNome.Location = new Point(20, 88);
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
            tbNome.Size = new Size(698, 48);
            tbNome.TabIndex = 2;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
            // 
            // tbMatricula
            // 
            tbMatricula.AnimateReadOnly = false;
            tbMatricula.AutoCompleteMode = AutoCompleteMode.None;
            tbMatricula.AutoCompleteSource = AutoCompleteSource.None;
            tbMatricula.BackgroundImageLayout = ImageLayout.None;
            tbMatricula.CharacterCasing = CharacterCasing.Normal;
            tbMatricula.Depth = 0;
            tbMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbMatricula.HideSelection = true;
            tbMatricula.Hint = "Matrícula";
            tbMatricula.LeadingIcon = null;
            tbMatricula.Location = new Point(101, 23);
            tbMatricula.MaxLength = 32767;
            tbMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbMatricula.Name = "tbMatricula";
            tbMatricula.PasswordChar = '\0';
            tbMatricula.PrefixSuffixText = null;
            tbMatricula.ReadOnly = false;
            tbMatricula.RightToLeft = RightToLeft.No;
            tbMatricula.SelectedText = "";
            tbMatricula.SelectionLength = 0;
            tbMatricula.SelectionStart = 0;
            tbMatricula.ShortcutsEnabled = true;
            tbMatricula.Size = new Size(266, 48);
            tbMatricula.TabIndex = 0;
            tbMatricula.TabStop = false;
            tbMatricula.TextAlign = HorizontalAlignment.Left;
            tbMatricula.TrailingIcon = null;
            tbMatricula.UseSystemPasswordChar = false;
            // 
            // cbEstado
            // 
            cbEstado.AutoResize = false;
            cbEstado.BackColor = Color.FromArgb(255, 255, 255);
            cbEstado.Depth = 0;
            cbEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cbEstado.DropDownHeight = 174;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.DropDownWidth = 121;
            cbEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEstado.FormattingEnabled = true;
            cbEstado.IntegralHeight = false;
            cbEstado.ItemHeight = 43;
            cbEstado.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PI", "PR", "RN", "RR", "RS", "SC", "SE", "SP", "TO" });
            cbEstado.Location = new Point(599, 273);
            cbEstado.MaxDropDownItems = 4;
            cbEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(121, 49);
            cbEstado.StartIndex = 0;
            cbEstado.TabIndex = 6;
            // 
            // tbDataNascimento
            // 
            tbDataNascimento.AllowPromptAsInput = true;
            tbDataNascimento.AnimateReadOnly = false;
            tbDataNascimento.AsciiOnly = false;
            tbDataNascimento.BackgroundImageLayout = ImageLayout.None;
            tbDataNascimento.BeepOnError = false;
            tbDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbDataNascimento.Depth = 0;
            tbDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataNascimento.HidePromptOnLeave = false;
            tbDataNascimento.HideSelection = true;
            tbDataNascimento.Hint = "Data de Nascimento";
            tbDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            tbDataNascimento.LeadingIcon = null;
            tbDataNascimento.Location = new Point(383, 23);
            tbDataNascimento.Mask = "99/99/9999";
            tbDataNascimento.MaxLength = 32767;
            tbDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataNascimento.Name = "tbDataNascimento";
            tbDataNascimento.PasswordChar = '\0';
            tbDataNascimento.PrefixSuffixText = null;
            tbDataNascimento.PromptChar = '_';
            tbDataNascimento.ReadOnly = false;
            tbDataNascimento.RejectInputOnFirstFailure = false;
            tbDataNascimento.ResetOnPrompt = true;
            tbDataNascimento.ResetOnSpace = true;
            tbDataNascimento.RightToLeft = RightToLeft.No;
            tbDataNascimento.SelectedText = "";
            tbDataNascimento.SelectionLength = 0;
            tbDataNascimento.SelectionStart = 0;
            tbDataNascimento.ShortcutsEnabled = true;
            tbDataNascimento.Size = new Size(337, 48);
            tbDataNascimento.SkipLiterals = true;
            tbDataNascimento.TabIndex = 1;
            tbDataNascimento.TabStop = false;
            tbDataNascimento.Text = "  /  /";
            tbDataNascimento.TextAlign = HorizontalAlignment.Left;
            tbDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbDataNascimento.TrailingIcon = null;
            tbDataNascimento.UseSystemPasswordChar = false;
            tbDataNascimento.ValidatingType = null;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(dataGridViewAluno);
            tabPageConsulta.Controls.Add(btNovo);
            tabPageConsulta.Controls.Add(btEditar);
            tabPageConsulta.Controls.Add(btExcluir);
            tabPageConsulta.ImageKey = "Search - Icon.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(739, 446);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // dataGridViewAluno
            // 
            dataGridViewAluno.AllowUserToAddRows = false;
            dataGridViewAluno.AllowUserToDeleteRows = false;
            dataGridViewAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAluno.Dock = DockStyle.Top;
            dataGridViewAluno.Location = new Point(3, 3);
            dataGridViewAluno.Name = "dataGridViewAluno";
            dataGridViewAluno.ReadOnly = true;
            dataGridViewAluno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAluno.Size = new Size(733, 373);
            dataGridViewAluno.TabIndex = 4;
            dataGridViewAluno.CellDoubleClick += dataGridViewAluno_CellDoubleClick;
            // 
            // btNovo
            // 
            btNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btNovo.Depth = 0;
            btNovo.HighEmphasis = true;
            btNovo.Icon = null;
            btNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btNovo.Location = new Point(479, 394);
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
            btEditar.Location = new Point(561, 394);
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
            btExcluir.Location = new Point(649, 394);
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
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 548);
            Controls.Add(TabControl);
            DrawerTabControl = TabControl;
            Name = "FormAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Aluno";
            TabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAluno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTabControl TabControl;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbMatricula;
        private ReaLTaiizor.Controls.MaterialComboBox cbEstado;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbDataNascimento;
        private ReaLTaiizor.Controls.MaterialButton btCancelar;
        private ReaLTaiizor.Controls.MaterialButton btSalvar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCidade;
        private ReaLTaiizor.Controls.MaterialButton btNovo;
        private ReaLTaiizor.Controls.MaterialButton btEditar;
        private ReaLTaiizor.Controls.MaterialButton btExcluir;
        private DataGridView dataGridViewAluno;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbId;
    }
}