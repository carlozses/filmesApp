﻿namespace filmesApp1A
{
    partial class frmFilmes
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
            btEditar = new Button();
            btRemover = new Button();
            btCadastrar = new Button();
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anoLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmeBindingSource = new BindingSource(components);
            btBuscar = new Button();
            txtBuscar = new TextBox();
            btGerenciar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(412, 278);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(92, 23);
            btEditar.TabIndex = 11;
            btEditar.Text = "Editar Filme";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRemover
            // 
            btRemover.Enabled = false;
            btRemover.Location = new Point(514, 278);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(99, 23);
            btRemover.TabIndex = 10;
            btRemover.Text = "Remover Filme";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(12, 278);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(88, 23);
            btCadastrar.TabIndex = 9;
            btCadastrar.Text = "Novo Filme";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, anoLancamentoDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = filmeBindingSource;
            dgvFilmes.Location = new Point(12, 51);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.Size = new Size(597, 221);
            dgvFilmes.TabIndex = 8;
            dgvFilmes.CellClick += dgvFilmes_CellClick;
            dgvFilmes.CellContentClick += dgvFilmes_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // anoLancamentoDataGridViewTextBoxColumn
            // 
            anoLancamentoDataGridViewTextBoxColumn.DataPropertyName = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.HeaderText = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.Name = "anoLancamentoDataGridViewTextBoxColumn";
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // filmeBindingSource
            // 
            filmeBindingSource.DataSource = typeof(Models.Filme);
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(538, 8);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 24);
            btBuscar.TabIndex = 7;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 10);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(520, 23);
            txtBuscar.TabIndex = 6;
            // 
            // btGerenciar
            // 
            btGerenciar.Enabled = false;
            btGerenciar.Location = new Point(289, 278);
            btGerenciar.Name = "btGerenciar";
            btGerenciar.Size = new Size(117, 23);
            btGerenciar.TabIndex = 12;
            btGerenciar.Text = "Gerenciar elenco";
            btGerenciar.UseVisualStyleBackColor = true;
            btGerenciar.Click += btGerenciar_Click;
            // 
            // frmFilmes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 334);
            Controls.Add(btGerenciar);
            Controls.Add(btEditar);
            Controls.Add(btRemover);
            Controls.Add(btCadastrar);
            Controls.Add(dgvFilmes);
            Controls.Add(btBuscar);
            Controls.Add(txtBuscar);
            MaximizeBox = false;
            Name = "frmFilmes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFilmes";
            FormClosing += frmFilmes_FormClosing;
            Load += frmFilmes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEditar;
        private Button btRemover;
        private Button btCadastrar;
        private DataGridView dgvFilmes;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource filmeBindingSource;
        private Button btBuscar;
        private TextBox txtBuscar;
        private Button btGerenciar;
    }
}