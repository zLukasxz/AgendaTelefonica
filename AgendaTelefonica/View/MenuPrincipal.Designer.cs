namespace AgendaTelefonica.View
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            btn_Adicionar = new Button();
            btn_Remover = new Button();
            btn_Alterar = new Button();
            btn_BuscarCodigo = new Button();
            btn_BuscarNome = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btn_Fechar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Font = new Font("LEMON MILK", 12F);
            btn_Adicionar.Location = new Point(42, 45);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(262, 55);
            btn_Adicionar.TabIndex = 1;
            btn_Adicionar.Text = "Adicionar Contato";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click_1;
            // 
            // btn_Remover
            // 
            btn_Remover.Font = new Font("LEMON MILK", 12F);
            btn_Remover.Location = new Point(42, 110);
            btn_Remover.Name = "btn_Remover";
            btn_Remover.Size = new Size(262, 55);
            btn_Remover.TabIndex = 2;
            btn_Remover.Text = "Remover Contato";
            btn_Remover.UseVisualStyleBackColor = true;
            btn_Remover.Click += btn_Remover_Click;
            // 
            // btn_Alterar
            // 
            btn_Alterar.Font = new Font("LEMON MILK", 12F);
            btn_Alterar.Location = new Point(42, 175);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(262, 55);
            btn_Alterar.TabIndex = 3;
            btn_Alterar.Text = "Alterar Contato";
            btn_Alterar.UseVisualStyleBackColor = true;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_BuscarCodigo
            // 
            btn_BuscarCodigo.Font = new Font("LEMON MILK", 12F);
            btn_BuscarCodigo.Location = new Point(42, 240);
            btn_BuscarCodigo.Name = "btn_BuscarCodigo";
            btn_BuscarCodigo.Size = new Size(262, 55);
            btn_BuscarCodigo.TabIndex = 4;
            btn_BuscarCodigo.Text = "Procurar Contato por Código";
            btn_BuscarCodigo.UseVisualStyleBackColor = true;
            btn_BuscarCodigo.Click += btn_BuscarCodigo_Click;
            // 
            // btn_BuscarNome
            // 
            btn_BuscarNome.Font = new Font("LEMON MILK", 12F);
            btn_BuscarNome.Location = new Point(42, 305);
            btn_BuscarNome.Name = "btn_BuscarNome";
            btn_BuscarNome.Size = new Size(262, 55);
            btn_BuscarNome.TabIndex = 5;
            btn_BuscarNome.Text = "Procurar Contato por Nome";
            btn_BuscarNome.UseVisualStyleBackColor = true;
            btn_BuscarNome.Click += btn_BuscarNome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 232);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btn_BuscarCodigo);
            groupBox1.Controls.Add(btn_Adicionar);
            groupBox1.Controls.Add(btn_BuscarNome);
            groupBox1.Controls.Add(btn_Remover);
            groupBox1.Controls.Add(btn_Alterar);
            groupBox1.Font = new Font("LEMON MILK Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(430, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 372);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Funções";
            // 
            // btn_Fechar
            // 
            btn_Fechar.Font = new Font("LEMON MILK", 12F);
            btn_Fechar.Location = new Point(177, 386);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(85, 33);
            btn_Fechar.TabIndex = 19;
            btn_Fechar.Text = "Sair";
            btn_Fechar.UseVisualStyleBackColor = true;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btn_Fechar);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            Text = "Agenda Telefônica - Menu Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Adicionar;
        private Button btn_Remover;
        private Button btn_Alterar;
        private Button btn_BuscarCodigo;
        private Button btn_BuscarNome;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btn_Fechar;
    }
}