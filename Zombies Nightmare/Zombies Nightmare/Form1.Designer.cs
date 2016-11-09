namespace Zombies_Nightmare
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
            this.pbSoldier = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbZombi1 = new System.Windows.Forms.PictureBox();
            this.pbZombi2 = new System.Windows.Forms.PictureBox();
            this.pbZombi3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoldier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZombi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZombi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZombi3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbSoldier
            // 
            this.pbSoldier.BackColor = System.Drawing.Color.Transparent;
            this.pbSoldier.Image = ((System.Drawing.Image)(resources.GetObject("pbSoldier.Image")));
            this.pbSoldier.Location = new System.Drawing.Point(20, 410);
            this.pbSoldier.Name = "pbSoldier";
            this.pbSoldier.Size = new System.Drawing.Size(166, 183);
            this.pbSoldier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSoldier.TabIndex = 1;
            this.pbSoldier.TabStop = false;
            this.pbSoldier.Click += new System.EventHandler(this.pbSoldier_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1022, 702);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pbZombi1
            // 
            this.pbZombi1.BackColor = System.Drawing.Color.Transparent;
            this.pbZombi1.Location = new System.Drawing.Point(1180, 369);
            this.pbZombi1.Name = "pbZombi1";
            this.pbZombi1.Size = new System.Drawing.Size(169, 214);
            this.pbZombi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZombi1.TabIndex = 1;
            this.pbZombi1.TabStop = false;
            this.pbZombi1.Click += new System.EventHandler(this.pbZombi1_Click);
            this.pbZombi1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pbZombi1_ControlRemoved);
            this.pbZombi1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbZombi1_MouseDown);
            this.pbZombi1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbZombi1_MouseUp);
            // 
            // pbZombi2
            // 
            this.pbZombi2.BackColor = System.Drawing.Color.Transparent;
            this.pbZombi2.Location = new System.Drawing.Point(1180, 369);
            this.pbZombi2.Name = "pbZombi2";
            this.pbZombi2.Size = new System.Drawing.Size(169, 214);
            this.pbZombi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZombi2.TabIndex = 1;
            this.pbZombi2.TabStop = false;
            this.pbZombi2.Click += new System.EventHandler(this.pbZombi2_Click);
            this.pbZombi2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbZombi2_MouseDown);
            this.pbZombi2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbZombi2_MouseUp);
            // 
            // pbZombi3
            // 
            this.pbZombi3.BackColor = System.Drawing.Color.Transparent;
            this.pbZombi3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbZombi3.Location = new System.Drawing.Point(1180, 369);
            this.pbZombi3.Name = "pbZombi3";
            this.pbZombi3.Size = new System.Drawing.Size(169, 214);
            this.pbZombi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZombi3.TabIndex = 2;
            this.pbZombi3.TabStop = false;
            this.pbZombi3.Click += new System.EventHandler(this.pbZombi3_Click);
            this.pbZombi3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbZombi3_MouseDown);
            this.pbZombi3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbZombi3_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 702);
            this.Controls.Add(this.pbZombi3);
            this.Controls.Add(this.pbZombi2);
            this.Controls.Add(this.pbZombi1);
            this.Controls.Add(this.pbSoldier);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSoldier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZombi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZombi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZombi3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbSoldier;
        private System.Windows.Forms.PictureBox pbZombi1;
        private System.Windows.Forms.PictureBox pbZombi2;
        private System.Windows.Forms.PictureBox pbZombi3;
    }
}

