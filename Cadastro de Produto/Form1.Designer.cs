namespace Cadastro_de_Produto
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
            tx_Codigo = new TextBox();
            tx_PrecoAquisicao = new TextBox();
            tx_Descricao = new TextBox();
            tx_Lucro = new TextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label_4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            lb_ValorVenda = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tx_Codigo
            // 
            tx_Codigo.Location = new Point(167, 102);
            tx_Codigo.Name = "tx_Codigo";
            tx_Codigo.Size = new Size(125, 27);
            tx_Codigo.TabIndex = 0;
            // 
            // tx_PrecoAquisicao
            // 
            tx_PrecoAquisicao.Location = new Point(167, 167);
            tx_PrecoAquisicao.Name = "tx_PrecoAquisicao";
            tx_PrecoAquisicao.Size = new Size(125, 27);
            tx_PrecoAquisicao.TabIndex = 1;
            // 
            // tx_Descricao
            // 
            tx_Descricao.Location = new Point(561, 105);
            tx_Descricao.Name = "tx_Descricao";
            tx_Descricao.Size = new Size(125, 27);
            tx_Descricao.TabIndex = 2;
            // 
            // tx_Lucro
            // 
            tx_Lucro.Location = new Point(561, 170);
            tx_Lucro.Name = "tx_Lucro";
            tx_Lucro.Size = new Size(125, 27);
            tx_Lucro.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(437, 275);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Novo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 38);
            label1.TabIndex = 7;
            label1.Text = "Cadastro De Produto";
            // 
            // button2
            // 
            button2.Location = new Point(571, 275);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(694, 275);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(92, 103);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 10;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 171);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 11;
            label3.Text = "Preço de Aquisição:";
            // 
            // label_4
            // 
            label_4.AutoSize = true;
            label_4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_4.Location = new Point(26, 235);
            label_4.Name = "label_4";
            label_4.Size = new Size(135, 23);
            label_4.TabIndex = 12;
            label_4.Text = "Valor da Venda :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(468, 106);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 13;
            label5.Text = "Descrição:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(480, 174);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 14;
            label6.Text = "Lucro %:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 117);
            dataGridView1.TabIndex = 15;
            // 
            // lb_ValorVenda
            // 
            lb_ValorVenda.AutoSize = true;
            lb_ValorVenda.Location = new Point(174, 237);
            lb_ValorVenda.Name = "lb_ValorVenda";
            lb_ValorVenda.Size = new Size(50, 20);
            lb_ValorVenda.TabIndex = 16;
            lb_ValorVenda.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_ValorVenda);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label_4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(tx_Lucro);
            Controls.Add(tx_Descricao);
            Controls.Add(tx_PrecoAquisicao);
            Controls.Add(tx_Codigo);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_Codigo;
        private TextBox tx_PrecoAquisicao;
        private TextBox tx_Descricao;
        private TextBox tx_Lucro;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label_4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Label lb_ValorVenda;
    }
}