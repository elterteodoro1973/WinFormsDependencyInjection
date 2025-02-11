namespace WinFormsApp8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnInserir = new Button();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            txtDetalhe1 = new TextBox();
            label2 = new Label();
            txtNome1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Abrir = new Button();
            tarefaBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detalhesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            concluidoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataCadastroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataConclusaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarefaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(34, 147);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(467, 47);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir ";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(txtDetalhe1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Location = new Point(24, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 230);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(47, 112);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Concluido ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtDetalhe1
            // 
            txtDetalhe1.Location = new Point(117, 74);
            txtDetalhe1.Name = "txtDetalhe1";
            txtDetalhe1.Size = new Size(384, 23);
            txtDetalhe1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 77);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Detalhes";
            // 
            // txtNome1
            // 
            txtNome1.Location = new Point(117, 34);
            txtNome1.Name = "txtNome1";
            txtNome1.Size = new Size(384, 23);
            txtNome1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 37);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, detalhesDataGridViewTextBoxColumn, concluidoDataGridViewCheckBoxColumn, dataCadastroDataGridViewTextBoxColumn, dataConclusaoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tarefaBindingSource;
            dataGridView1.Location = new Point(24, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1079, 250);
            dataGridView1.TabIndex = 2;
            // 
            // Abrir
            // 
            Abrir.Location = new Point(25, 325);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(196, 23);
            Abrir.TabIndex = 3;
            Abrir.Text = "Abrir";
            Abrir.UseVisualStyleBackColor = true;
            Abrir.Click += Abrir_Click;
            // 
            // tarefaBindingSource
            // 
            tarefaBindingSource.DataSource = typeof(TaskManager.API.Models.Tarefa);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalhesDataGridViewTextBoxColumn
            // 
            detalhesDataGridViewTextBoxColumn.DataPropertyName = "Detalhes";
            detalhesDataGridViewTextBoxColumn.HeaderText = "Detalhes";
            detalhesDataGridViewTextBoxColumn.Name = "detalhesDataGridViewTextBoxColumn";
            detalhesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // concluidoDataGridViewCheckBoxColumn
            // 
            concluidoDataGridViewCheckBoxColumn.DataPropertyName = "Concluido";
            concluidoDataGridViewCheckBoxColumn.HeaderText = "Concluido";
            concluidoDataGridViewCheckBoxColumn.Name = "concluidoDataGridViewCheckBoxColumn";
            concluidoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataConclusaoDataGridViewTextBoxColumn
            // 
            dataConclusaoDataGridViewTextBoxColumn.DataPropertyName = "DataConclusao";
            dataConclusaoDataGridViewTextBoxColumn.HeaderText = "DataConclusao";
            dataConclusaoDataGridViewTextBoxColumn.Name = "dataConclusaoDataGridViewTextBoxColumn";
            dataConclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 690);
            Controls.Add(Abrir);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarefaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInserir;
        private GroupBox groupBox1;
        private TextBox txtDetalhe1;
        private Label label2;
        private TextBox txtNome1;
        private Label label1;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private Button Abrir;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detalhesDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn concluidoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataConclusaoDataGridViewTextBoxColumn;
        private BindingSource tarefaBindingSource;
    }
}
