namespace PIM_3_TOTEN
{
    partial class Iniciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciar));
            Btn_Iniciar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Btn_Iniciar
            // 
            Btn_Iniciar.BackColor = Color.Gray;
            Btn_Iniciar.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Iniciar.Location = new Point(72, 200);
            Btn_Iniciar.Name = "Btn_Iniciar";
            Btn_Iniciar.Size = new Size(128, 66);
            Btn_Iniciar.TabIndex = 1;
            Btn_Iniciar.Text = "Iniciar";
            Btn_Iniciar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 463);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Iniciar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 463);
            Controls.Add(Btn_Iniciar);
            Controls.Add(pictureBox1);
            Name = "Iniciar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "iniciar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Btn_Iniciar;
        private PictureBox pictureBox1;
    }
}
