namespace PIM_3_TOTEN
{
    partial class Loguin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loguin));
            lbl_nome = new Label();
            lbl_senha = new Label();
            lbl_login = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_voltar = new Button();
            btn_cadastro = new Button();
            pictureBox1 = new PictureBox();
            btn_loguin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = SystemColors.GradientInactiveCaption;
            lbl_nome.Location = new Point(43, 149);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(40, 15);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = SystemColors.GradientInactiveCaption;
            lbl_senha.Location = new Point(43, 211);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(39, 15);
            lbl_senha.TabIndex = 1;
            lbl_senha.Text = "Senha";
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.BackColor = SystemColors.GradientInactiveCaption;
            lbl_login.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(107, 77);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(69, 26);
            lbl_login.TabIndex = 2;
            lbl_login.Text = "Loguin";
            lbl_login.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 4;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientInactiveCaption;
            btn_voltar.Location = new Point(8, 289);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(75, 62);
            btn_voltar.TabIndex = 5;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            // 
            // btn_cadastro
            // 
            btn_cadastro.BackColor = SystemColors.GradientInactiveCaption;
            btn_cadastro.Location = new Point(98, 289);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(75, 62);
            btn_cadastro.TabIndex = 6;
            btn_cadastro.Text = "Cadastro";
            btn_cadastro.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 444);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_loguin
            // 
            btn_loguin.BackColor = SystemColors.GradientInactiveCaption;
            btn_loguin.Location = new Point(188, 289);
            btn_loguin.Name = "btn_loguin";
            btn_loguin.Size = new Size(75, 62);
            btn_loguin.TabIndex = 8;
            btn_loguin.Text = "Loguin";
            btn_loguin.UseVisualStyleBackColor = false;
            // 
            // Loguin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 444);
            Controls.Add(btn_loguin);
            Controls.Add(btn_cadastro);
            Controls.Add(btn_voltar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl_login);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_nome);
            Controls.Add(pictureBox1);
            Name = "Loguin";
            Text = "loguin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private Label lbl_senha;
        private Label lbl_login;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_voltar;
        private Button btn_cadastro;
        private PictureBox pictureBox1;
        private Button btn_loguin;
    }
}