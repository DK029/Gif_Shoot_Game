namespace Gif_Shoot_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FireGame = new System.Windows.Forms.GroupBox();
            this.thirdBtn = new System.Windows.Forms.Button();
            this.secondBtn = new System.Windows.Forms.Button();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forthBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FireGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FireGame
            // 
            this.FireGame.BackColor = System.Drawing.Color.Transparent;
            this.FireGame.Controls.Add(this.button1);
            this.FireGame.Controls.Add(this.thirdBtn);
            this.FireGame.Controls.Add(this.secondBtn);
            this.FireGame.Controls.Add(this.FirstBtn);
            this.FireGame.Controls.Add(this.pictureBox1);
            this.FireGame.Location = new System.Drawing.Point(292, 23);
            this.FireGame.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FireGame.Name = "FireGame";
            this.FireGame.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FireGame.Size = new System.Drawing.Size(1030, 725);
            this.FireGame.TabIndex = 0;
            this.FireGame.TabStop = false;
            this.FireGame.Text = "groupBox1";
            this.FireGame.Visible = false;
            // 
            // thirdBtn
            // 
            this.thirdBtn.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdBtn.Location = new System.Drawing.Point(735, 520);
            this.thirdBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.thirdBtn.Name = "thirdBtn";
            this.thirdBtn.Size = new System.Drawing.Size(320, 102);
            this.thirdBtn.TabIndex = 3;
            this.thirdBtn.Text = "Fire Bullet";
            this.thirdBtn.UseVisualStyleBackColor = true;
            this.thirdBtn.Click += new System.EventHandler(this.thirdBtn_Click);
            // 
            // secondBtn
            // 
            this.secondBtn.Font = new System.Drawing.Font("Algerian", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondBtn.Location = new System.Drawing.Point(366, 525);
            this.secondBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.secondBtn.Name = "secondBtn";
            this.secondBtn.Size = new System.Drawing.Size(320, 102);
            this.secondBtn.TabIndex = 2;
            this.secondBtn.Text = "Spin Gun";
            this.secondBtn.UseVisualStyleBackColor = true;
            this.secondBtn.Click += new System.EventHandler(this.secondBtn_Click);
            // 
            // FirstBtn
            // 
            this.FirstBtn.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstBtn.Location = new System.Drawing.Point(34, 525);
            this.FirstBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Size = new System.Drawing.Size(320, 102);
            this.FirstBtn.TabIndex = 1;
            this.FirstBtn.Text = "Load Bullet";
            this.FirstBtn.UseVisualStyleBackColor = true;
            this.FirstBtn.Click += new System.EventHandler(this.FirstBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // forthBtn
            // 
            this.forthBtn.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forthBtn.Location = new System.Drawing.Point(313, 760);
            this.forthBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.forthBtn.Name = "forthBtn";
            this.forthBtn.Size = new System.Drawing.Size(320, 102);
            this.forthBtn.TabIndex = 4;
            this.forthBtn.Text = "Play Again";
            this.forthBtn.UseVisualStyleBackColor = true;
            this.forthBtn.Click += new System.EventHandler(this.forthBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Algerian", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(390, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 96);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fireaway";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.forthBtn);
            this.Controls.Add(this.FireGame);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FireGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox FireGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.Button secondBtn;
        private System.Windows.Forms.Button thirdBtn;
        private System.Windows.Forms.Button forthBtn;
        private System.Windows.Forms.Button button1;
    }
}

