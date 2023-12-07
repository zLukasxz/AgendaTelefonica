namespace AgendaTelefonica.View
{
    partial class ProcurarContatoCod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcurarContatoCod));
            btn_Fechar = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btn_Buscar = new Button();
            txb_Id = new TextBox();
            label5 = new Label();
            txb_Nome = new TextBox();
            txb_Endereco = new TextBox();
            label1 = new Label();
            txb_Email = new TextBox();
            label2 = new Label();
            txb_Fone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Fechar
            // 
            btn_Fechar.Font = new Font("LEMON MILK", 12F);
            btn_Fechar.Location = new Point(123, 395);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(85, 33);
            btn_Fechar.TabIndex = 18;
            btn_Fechar.Text = "Sair";
            btn_Fechar.UseVisualStyleBackColor = true;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 232);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btn_Buscar);
            groupBox1.Controls.Add(txb_Id);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txb_Nome);
            groupBox1.Controls.Add(txb_Endereco);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txb_Email);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txb_Fone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("LEMON MILK Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(337, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 474);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar Contato";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("LEMON MILK", 12F);
            btn_Buscar.Location = new Point(33, 401);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(323, 55);
            btn_Buscar.TabIndex = 11;
            btn_Buscar.Text = "Procurar Contato";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txb_Id
            // 
            txb_Id.Font = new Font("LEMON MILK", 12F);
            txb_Id.Location = new Point(33, 71);
            txb_Id.Name = "txb_Id";
            txb_Id.Size = new Size(323, 29);
            txb_Id.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("LEMON MILK Medium", 12F, FontStyle.Bold);
            label5.Location = new Point(178, 38);
            label5.Name = "label5";
            label5.Size = new Size(32, 23);
            label5.TabIndex = 9;
            label5.Text = "ID:";
            // 
            // txb_Nome
            // 
            txb_Nome.Font = new Font("LEMON MILK", 12F);
            txb_Nome.Location = new Point(33, 138);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(323, 29);
            txb_Nome.TabIndex = 4;
            // 
            // txb_Endereco
            // 
            txb_Endereco.Font = new Font("LEMON MILK", 12F);
            txb_Endereco.Location = new Point(33, 354);
            txb_Endereco.Name = "txb_Endereco";
            txb_Endereco.Size = new Size(323, 29);
            txb_Endereco.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK Medium", 12F, FontStyle.Bold);
            label1.Location = new Point(161, 105);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txb_Email
            // 
            txb_Email.Font = new Font("LEMON MILK", 12F);
            txb_Email.Location = new Point(33, 282);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(323, 29);
            txb_Email.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("LEMON MILK Medium", 12F, FontStyle.Bold);
            label2.Location = new Point(164, 177);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 1;
            label2.Text = "Fone:";
            // 
            // txb_Fone
            // 
            txb_Fone.Font = new Font("LEMON MILK", 12F);
            txb_Fone.Location = new Point(33, 210);
            txb_Fone.Name = "txb_Fone";
            txb_Fone.Size = new Size(323, 29);
            txb_Fone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("LEMON MILK Medium", 12F, FontStyle.Bold);
            label3.Location = new Point(157, 249);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 2;
            label3.Text = "E-Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("LEMON MILK Medium", 12F, FontStyle.Bold);
            label4.Location = new Point(141, 321);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // ProcurarContatoCod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(723, 497);
            ControlBox = false;
            Controls.Add(btn_Fechar);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProcurarContatoCod";
            Text = "Procurar Contato por Código";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Fechar;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btn_Buscar;
        private TextBox txb_Id;
        private Label label5;
        private TextBox txb_Nome;
        private TextBox txb_Endereco;
        private Label label1;
        private TextBox txb_Email;
        private Label label2;
        private TextBox txb_Fone;
        private Label label3;
        private Label label4;
    }
}