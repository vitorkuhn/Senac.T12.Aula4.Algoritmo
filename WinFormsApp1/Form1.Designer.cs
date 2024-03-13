namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            txtCidade = new TextBox();
            label5 = new Label();
            txtCep = new TextBox();
            label6 = new Label();
            txtIdade = new TextBox();
            label3 = new Label();
            txtSobrenome = new TextBox();
            label4 = new Label();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnNovo = new Button();
            btnImprimir = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCep);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtIdade);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSobrenome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de usuário";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(398, 161);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(193, 23);
            txtCidade.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 143);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "Cidade";
            label5.Click += label5_Click;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(37, 161);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(193, 23);
            txtCep.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 143);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 8;
            label6.Text = "CEP";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(398, 104);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(193, 23);
            txtIdade.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 86);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Idade";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(396, 52);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(195, 23);
            txtSobrenome.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 34);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 4;
            label4.Text = "Sobrenome";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(37, 104);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(193, 23);
            txtEndereco.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 86);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Endereço";
            label2.Click += label2_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(195, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(37, 34);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNovo);
            groupBox2.Controls.Add(btnImprimir);
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(btnSalvar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 205);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ações";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(146, 49);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(82, 45);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(498, 49);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(82, 45);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += button5_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(410, 49);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 45);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(322, 49);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 45);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(234, 49);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 45);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button btnNovo;
        private Button btnImprimir;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private TextBox txtIdade;
        private Label label3;
        private TextBox txtSobrenome;
        private Label label4;
        private TextBox txtCidade;
        private Label label5;
        private TextBox txtCep;
        private Label label6;
    }
}
