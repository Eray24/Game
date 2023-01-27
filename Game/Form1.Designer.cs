
namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.borualt = new System.Windows.Forms.PictureBox();
            this.boruust = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.zemin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borualt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1099);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1738, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // borualt
            // 
            this.borualt.Image = ((System.Drawing.Image)(resources.GetObject("borualt.Image")));
            this.borualt.Location = new System.Drawing.Point(558, 308);
            this.borualt.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.borualt.Name = "borualt";
            this.borualt.Size = new System.Drawing.Size(60, 186);
            this.borualt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.borualt.TabIndex = 1;
            this.borualt.TabStop = false;
            // 
            // boruust
            // 
            this.boruust.Image = ((System.Drawing.Image)(resources.GetObject("boruust.Image")));
            this.boruust.Location = new System.Drawing.Point(830, -1);
            this.boruust.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.boruust.Name = "boruust";
            this.boruust.Size = new System.Drawing.Size(57, 181);
            this.boruust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruust.TabIndex = 2;
            this.boruust.TabStop = false;
            this.boruust.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // flappybird
            // 
            this.flappybird.Image = ((System.Drawing.Image)(resources.GetObject("flappybird.Image")));
            this.flappybird.Location = new System.Drawing.Point(60, 142);
            this.flappybird.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(76, 61);
            this.flappybird.TabIndex = 3;
            this.flappybird.TabStop = false;
            this.flappybird.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.Indigo;
            this.scoreText.Location = new System.Drawing.Point(16, 9);
            this.scoreText.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.scoreText.MaximumSize = new System.Drawing.Size(2165, 2843);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(103, 43);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score:0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimeEvent);
            // 
            // zemin
            // 
            this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
            this.zemin.Location = new System.Drawing.Point(-1, 493);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(1041, 72);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 5;
            this.zemin.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1036, 565);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.boruust);
            this.Controls.Add(this.borualt);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borualt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox borualt;
        private System.Windows.Forms.PictureBox boruust;
        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox zemin;
    }
}

