namespace AgendaTelefonica.View
{
    partial class ProcurarContatoNome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcurarContatoNome));
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txb_Nome = new TextBox();
            btn_Buscar = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btn_Fechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Telefone, Email, Endereco });
            dataGridView1.Location = new Point(12, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(776, 231);
            dataGridView1.TabIndex = 0;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Width = 71;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 65;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.Width = 76;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 61;
            // 
            // Endereco
            // 
            Endereco.HeaderText = "Endereço";
            Endereco.Name = "Endereco";
            Endereco.Width = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("LEMON MILK", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 152);
            label1.Name = "label1";
            label1.Size = new Size(256, 23);
            label1.TabIndex = 1;
            label1.Text = "Digite o Nome do Contato:";
            // 
            // txb_Nome
            // 
            txb_Nome.Font = new Font("LEMON MILK", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_Nome.Location = new Point(274, 149);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(298, 29);
            txb_Nome.TabIndex = 2;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("LEMON MILK Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Buscar.Location = new Point(600, 149);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(188, 29);
            btn_Buscar.TabIndex = 3;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("LEMON MILK Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(274, 46);
            label2.Name = "label2";
            label2.Size = new Size(395, 30);
            label2.TabIndex = 8;
            label2.Text = "Procurar Contato por Nome";
            // 
            // btn_Fechar
            // 
            btn_Fechar.Font = new Font("LEMON MILK", 12F);
            btn_Fechar.Location = new Point(652, 94);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(85, 33);
            btn_Fechar.TabIndex = 19;
            btn_Fechar.Text = "Sair";
            btn_Fechar.UseVisualStyleBackColor = true;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // ProcurarContatoNome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btn_Fechar);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Buscar);
            Controls.Add(txb_Nome);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProcurarContatoNome";
            Text = "Busca de Contato por Nome";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txb_Nome;
        private Button btn_Buscar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Endereco;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btn_Fechar;
    }
}