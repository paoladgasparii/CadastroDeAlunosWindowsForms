﻿namespace CadastroDeAlunosWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlteracao = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlteracaoCurso = new System.Windows.Forms.TextBox();
            this.btnAlterarCurso = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlteracaoCidade = new System.Windows.Forms.TextBox();
            this.btnAlterarCidade = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txtNome.Location = new System.Drawing.Point(237, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(356, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToOrderColumns = true;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Curso,
            this.Cidade});
            this.dgvAlunos.Location = new System.Drawing.Point(84, 215);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.Size = new System.Drawing.Size(578, 249);
            this.dgvAlunos.TabIndex = 2;
            this.dgvAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellClick);
            this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome:";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso:";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade:";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(237, 85);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(356, 20);
            this.txtCurso.TabIndex = 4;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(237, 151);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(124, 47);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(391, 152);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(122, 47);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alterar Nome:";
            // 
            // txtAlteracao
            // 
            this.txtAlteracao.Location = new System.Drawing.Point(195, 490);
            this.txtAlteracao.Name = "txtAlteracao";
            this.txtAlteracao.Size = new System.Drawing.Size(318, 20);
            this.txtAlteracao.TabIndex = 8;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(561, 489);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total de Alunos:";
            // 
            // btnTodos
            // 
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Location = new System.Drawing.Point(445, 601);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(89, 47);
            this.btnTodos.TabIndex = 11;
            this.btnTodos.Text = "Excluir Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(561, 601);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(89, 47);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar Sistema";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(273, 614);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alterar Curso:";
            // 
            // txtAlteracaoCurso
            // 
            this.txtAlteracaoCurso.Location = new System.Drawing.Point(195, 525);
            this.txtAlteracaoCurso.Name = "txtAlteracaoCurso";
            this.txtAlteracaoCurso.Size = new System.Drawing.Size(318, 20);
            this.txtAlteracaoCurso.TabIndex = 15;
            this.txtAlteracaoCurso.TextChanged += new System.EventHandler(this.txtAlteracaoCurso_TextChanged);
            // 
            // btnAlterarCurso
            // 
            this.btnAlterarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCurso.Location = new System.Drawing.Point(561, 523);
            this.btnAlterarCurso.Name = "btnAlterarCurso";
            this.btnAlterarCurso.Size = new System.Drawing.Size(101, 23);
            this.btnAlterarCurso.TabIndex = 16;
            this.btnAlterarCurso.Text = "Alterar";
            this.btnAlterarCurso.UseVisualStyleBackColor = true;
            this.btnAlterarCurso.Click += new System.EventHandler(this.btnAlterarCurso_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alterar Cidade:";
            // 
            // txtAlteracaoCidade
            // 
            this.txtAlteracaoCidade.Location = new System.Drawing.Point(195, 557);
            this.txtAlteracaoCidade.Name = "txtAlteracaoCidade";
            this.txtAlteracaoCidade.Size = new System.Drawing.Size(318, 20);
            this.txtAlteracaoCidade.TabIndex = 18;
            // 
            // btnAlterarCidade
            // 
            this.btnAlterarCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCidade.Location = new System.Drawing.Point(561, 556);
            this.btnAlterarCidade.Name = "btnAlterarCidade";
            this.btnAlterarCidade.Size = new System.Drawing.Size(101, 23);
            this.btnAlterarCidade.TabIndex = 19;
            this.btnAlterarCidade.Text = "Alterar";
            this.btnAlterarCidade.UseVisualStyleBackColor = true;
            this.btnAlterarCidade.Click += new System.EventHandler(this.btnAlterarCidade_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(237, 117);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(356, 20);
            this.txtCidade.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 690);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAlterarCidade);
            this.Controls.Add(this.txtAlteracaoCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAlterarCurso);
            this.Controls.Add(this.txtAlteracaoCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtAlteracao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlteracao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlteracaoCurso;
        private System.Windows.Forms.Button btnAlterarCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlteracaoCidade;
        private System.Windows.Forms.Button btnAlterarCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidade;
    }
}

