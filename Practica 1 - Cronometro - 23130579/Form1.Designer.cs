namespace Practica_1___Cronometro___23130579
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCronometro = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnIniciar = new Button();
            btnDetener = new Button();
            btnReiniciar = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            tmrTemporizador = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCronometro
            // 
            lblCronometro.AutoSize = true;
            lblCronometro.BackColor = Color.Ivory;
            lblCronometro.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCronometro.Location = new Point(280, 285);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(289, 81);
            lblCronometro.TabIndex = 0;
            lblCronometro.Text = "00:00:00";
            lblCronometro.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(503, 106);
            label1.TabIndex = 1;
            label1.Text = "Kronometro";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(30, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 10);
            panel1.TabIndex = 2;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 16.2F);
            btnIniciar.Location = new Point(148, 519);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(143, 46);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Font = new Font("Segoe UI", 16.2F);
            btnDetener.Location = new Point(329, 519);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(145, 46);
            btnDetener.TabIndex = 4;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Segoe UI", 16.2F);
            btnReiniciar.Location = new Point(508, 519);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(143, 46);
            btnReiniciar.TabIndex = 5;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(30, 503);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 10);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Location = new Point(30, 571);
            panel3.Name = "panel3";
            panel3.Size = new Size(736, 10);
            panel3.TabIndex = 3;
            // 
            // tmrTemporizador
            // 
            tmrTemporizador.Interval = 1000;
            tmrTemporizador.Tick += tmrTemporizador_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(736, 363);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 593);
            Controls.Add(lblCronometro);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnReiniciar);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCronometro;
        private Label label1;
        private Panel panel1;
        private Button btnIniciar;
        private Button btnDetener;
        private Button btnReiniciar;
        private Panel panel2;
        private Panel panel3;
        private System.Windows.Forms.Timer tmrTemporizador;
        private PictureBox pictureBox1;
    }
}
