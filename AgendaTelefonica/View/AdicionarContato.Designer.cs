namespace AgendaTelefonica.View
{
    partial class AdicionarContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarContato));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txb_Nome = new TextBox();
            txb_Fone = new TextBox();
            txb_Email = new TextBox();
            txb_Endereco = new TextBox();
            groupBox1 = new GroupBox();
            btn_Cadastrar = new Button();
            pictureBox1 = new PictureBox();
            btn_Fechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK Medium", 12F, FontStyle.Bold);
            label1.Location = new Point(162, 40);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("LEMON MILK Medium", 12F, FontStyle.Bold);
            label2.Location = new Point(165, 112);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 1;
            label2.Text = "Fone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("LEMON MILK Medium", 12F, FontStyle.Bold);
            label3.Location = new Point(158, 184);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 2;
            label3.Text = "E-Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("LEMON MILK Medium", 12F, FontStyle.Bold);
            label4.Location = new Point(142, 256);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // txb_Nome
            // 
            txb_Nome.Font = new Font("LEMON MILK", 12F);
            txb_Nome.Location = new Point(34, 73);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(323, 29);
            txb_Nome.TabIndex = 4;
            // 
            // txb_Fone
            // 
            txb_Fone.Font = new Font("LEMON MILK", 12F);
            txb_Fone.Location = new Point(34, 145);
            txb_Fone.Name = "txb_Fone";
            txb_Fone.Size = new Size(323, 29);
            txb_Fone.TabIndex = 5;
            // 
            // txb_Email
            // 
            txb_Email.Font = new Font("LEMON MILK", 12F);
            txb_Email.Location = new Point(34, 217);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(323, 29);
            txb_Email.TabIndex = 6;
            // 
            // txb_Endereco
            // 
            txb_Endereco.Font = new Font("LEMON MILK", 12F);
            txb_Endereco.Location = new Point(34, 289);
            txb_Endereco.Name = "txb_Endereco";
            txb_Endereco.Size = new Size(323, 29);
            txb_Endereco.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btn_Cadastrar);
            groupBox1.Controls.Add(txb_Nome);
            groupBox1.Controls.Add(txb_Endereco);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txb_Email);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txb_Fone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("LEMON MILK Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(333, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 385);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Contato";
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Font = new Font("LEMON MILK", 12F);
            btn_Cadastrar.Location = new Point(109, 324);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(165, 55);
            btn_Cadastrar.TabIndex = 8;
            btn_Cadastrar.Text = "Cadastrar Contato";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 232);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btn_Fechar
            // 
            btn_Fechar.Font = new Font("LEMON MILK", 12F);
            btn_Fechar.Location = new Point(122, 347);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(85, 33);
            btn_Fechar.TabIndex = 9;
            btn_Fechar.Text = "Sair";
            btn_Fechar.UseVisualStyleBackColor = true;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // AdicionarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(721, 409);
            ControlBox = false;
            Controls.Add(btn_Fechar);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdicionarContato";
            Text = "Cadastro de Contato";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txb_Nome;
        private TextBox txb_Fone;
        private TextBox txb_Email;
        private TextBox txb_Endereco;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btn_Cadastrar;
        private Button btn_Fechar;
    }
}