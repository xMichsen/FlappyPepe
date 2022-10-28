namespace FlappyBirdGame
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.GameOver = new System.Windows.Forms.Label();
            this.StartInfo = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.PepeBird = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PepeBird)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Ground);
            this.panel1.Controls.Add(this.GameOver);
            this.panel1.Controls.Add(this.StartInfo);
            this.panel1.Controls.Add(this.Score);
            this.panel1.Controls.Add(this.ScoreText);
            this.panel1.Controls.Add(this.PepeBird);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 561);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Ground
            // 
            this.Ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(0, 499);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(584, 62);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 6;
            this.Ground.TabStop = false;
            // 
            // GameOver
            // 
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOver.Location = new System.Drawing.Point(158, 202);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(266, 99);
            this.GameOver.TabIndex = 5;
            this.GameOver.Text = "You died!\r\n\r\nPress \"R\" to restart\r\n";
            this.GameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOver.Visible = false;
            // 
            // StartInfo
            // 
            this.StartInfo.BackColor = System.Drawing.Color.Transparent;
            this.StartInfo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartInfo.Location = new System.Drawing.Point(158, 171);
            this.StartInfo.Name = "StartInfo";
            this.StartInfo.Size = new System.Drawing.Size(266, 161);
            this.StartInfo.TabIndex = 4;
            this.StartInfo.Text = "Flap your wings using \"space\" or \"up arrow\" as hard as you can to avoid the red p" +
    "ipes.\r\nPress \"S\" to start.\r\n";
            this.StartInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score.Location = new System.Drawing.Point(274, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(50, 23);
            this.Score.TabIndex = 3;
            this.Score.Text = "0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Score.Visible = false;
            // 
            // ScoreText
            // 
            this.ScoreText.BackColor = System.Drawing.Color.Transparent;
            this.ScoreText.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreText.Location = new System.Drawing.Point(206, 9);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(68, 23);
            this.ScoreText.TabIndex = 2;
            this.ScoreText.Text = "Score:";
            this.ScoreText.Visible = false;
            // 
            // PepeBird
            // 
            this.PepeBird.BackColor = System.Drawing.Color.Transparent;
            this.PepeBird.Image = ((System.Drawing.Image)(resources.GetObject("PepeBird.Image")));
            this.PepeBird.InitialImage = ((System.Drawing.Image)(resources.GetObject("PepeBird.InitialImage")));
            this.PepeBird.Location = new System.Drawing.Point(260, 250);
            this.PepeBird.Name = "PepeBird";
            this.PepeBird.Size = new System.Drawing.Size(64, 64);
            this.PepeBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PepeBird.TabIndex = 1;
            this.PepeBird.TabStop = false;
            this.PepeBird.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flappy Pepe";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PepeBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PepeBird;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label StartInfo;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.PictureBox Ground;
    }
}

