namespace PIM_3_TOTEN
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            pictureBox1 = new PictureBox();
            lbl_nome = new Label();
            textBox1 = new TextBox();
            btn_cadastrar = new Button();
            textBox3 = new TextBox();
            lbl_senha = new Label();
            lbl_cadastro = new Label();
            btn_voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = SystemColors.GradientInactiveCaption;
            lbl_nome.Location = new Point(33, 127);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(40, 15);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 2;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = SystemColors.GradientInactiveCaption;
            btn_cadastrar.Location = new Point(149, 268);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(75, 54);
            btn_cadastrar.TabIndex = 3;
            btn_cadastrar.Text = "Cadstrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(92, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 7;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = SystemColors.GradientInactiveCaption;
            lbl_senha.Location = new Point(33, 174);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(39, 15);
            lbl_senha.TabIndex = 6;
            lbl_senha.Text = "Senha";
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.BackColor = SystemColors.GradientInactiveCaption;
            lbl_cadastro.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cadastro.Location = new Point(13, 35);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(245, 33);
            lbl_cadastro.TabIndex = 8;
            lbl_cadastro.Text = "Cadastrar de usuario";
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientInactiveCaption;
            btn_voltar.Location = new Point(33, 268);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(75, 54);
            btn_voltar.TabIndex = 9;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 462);
            Controls.Add(btn_voltar);
            Controls.Add(lbl_cadastro);
            Controls.Add(textBox3);
            Controls.Add(lbl_senha);
            Controls.Add(btn_cadastrar);
            Controls.Add(textBox1);
            Controls.Add(lbl_nome);
            Controls.Add(pictureBox1);
            Name = "Cadastro";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_nome;
        private TextBox textBox1;
        private Button btn_cadastrar;
        private TextBox textBox3;
        private Label lbl_senha;
        private Label lbl_cadastro;
        private Button btn_voltar;
    }
}