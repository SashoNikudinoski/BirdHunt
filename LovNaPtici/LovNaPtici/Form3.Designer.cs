<<<<<<< HEAD
﻿namespace LovNaPtici
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnGameOver = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTs = new System.Windows.Forms.Label();
            this.lblSc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ptica1 = new System.Windows.Forms.PictureBox();
            this.ptica3 = new System.Windows.Forms.PictureBox();
            this.ptica2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 60;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnGameOver
            // 
            this.btnGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGameOver.BackColor = System.Drawing.Color.Transparent;
            this.btnGameOver.BackgroundImage = global::LovNaPtici.Properties.Resources.buttonRed;
            this.btnGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGameOver.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameOver.ForeColor = System.Drawing.Color.Black;
            this.btnGameOver.Image = global::LovNaPtici.Properties.Resources.buttonRed;
            this.btnGameOver.Location = new System.Drawing.Point(363, 590);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(188, 57);
            this.btnGameOver.TabIndex = 8;
            this.btnGameOver.Text = "Main menu";
            this.btnGameOver.UseVisualStyleBackColor = false;
            this.btnGameOver.Visible = false;
            this.btnGameOver.Click += new System.EventHandler(this.btnGameOver_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::LovNaPtici.Properties.Resources.buttonRed;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::LovNaPtici.Properties.Resources.buttonRed;
            this.btnNext.Location = new System.Drawing.Point(363, 511);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(188, 57);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next Level";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTs);
            this.groupBox2.Controls.Add(this.lblSc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 152);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(119, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 26);
            this.lblTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time:";
            // 
            // lblTs
            // 
            this.lblTs.AutoSize = true;
            this.lblTs.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTs.Location = new System.Drawing.Point(190, 112);
            this.lblTs.Name = "lblTs";
            this.lblTs.Size = new System.Drawing.Size(0, 26);
            this.lblTs.TabIndex = 3;
            // 
            // lblSc
            // 
            this.lblSc.AutoSize = true;
            this.lblSc.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSc.Location = new System.Drawing.Point(108, 58);
            this.lblSc.Name = "lblSc";
            this.lblSc.Size = new System.Drawing.Size(0, 26);
            this.lblSc.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Score:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ptica1
            // 
            this.ptica1.BackColor = System.Drawing.Color.Transparent;
            this.ptica1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptica1.Image = global::LovNaPtici.Properties.Resources.W8fWP13NK8og;
            this.ptica1.Location = new System.Drawing.Point(22, 12);
            this.ptica1.Name = "ptica1";
            this.ptica1.Size = new System.Drawing.Size(109, 63);
            this.ptica1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica1.TabIndex = 10;
            this.ptica1.TabStop = false;
            this.ptica1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica1_MouseClick);
            // 
            // ptica3
            // 
            this.ptica3.BackColor = System.Drawing.Color.Transparent;
            this.ptica3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptica3.ErrorImage = null;
            this.ptica3.Image = global::LovNaPtici.Properties.Resources.bird2_flip;
            this.ptica3.Location = new System.Drawing.Point(31, 429);
            this.ptica3.Name = "ptica3";
            this.ptica3.Size = new System.Drawing.Size(100, 50);
            this.ptica3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica3.TabIndex = 11;
            this.ptica3.TabStop = false;
            this.ptica3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica3_MouseClick);
            // 
            // ptica2
            // 
            this.ptica2.BackColor = System.Drawing.Color.Transparent;
            this.ptica2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptica2.Image = ((System.Drawing.Image)(resources.GetObject("ptica2.Image")));
            this.ptica2.Location = new System.Drawing.Point(1028, 159);
            this.ptica2.Name = "ptica2";
            this.ptica2.Size = new System.Drawing.Size(81, 75);
            this.ptica2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica2.TabIndex = 12;
            this.ptica2.TabStop = false;
            this.ptica2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica2_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTimeLeft
            // 
            this.timerTimeLeft.Interval = 1000;
            this.timerTimeLeft.Tick += new System.EventHandler(this.timerTimeLeft_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(395, 226);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(355, 69);
            this.lblGameOver.TabIndex = 13;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LovNaPtici.Properties.Resources.beachBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 662);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.ptica2);
            this.Controls.Add(this.ptica3);
            this.Controls.Add(this.ptica1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.btnNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Bird Hunt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Click += new System.EventHandler(this.Form3_Click);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnGameOver;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTs;
        private System.Windows.Forms.Label lblSc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox ptica1;
        private System.Windows.Forms.PictureBox ptica3;
        private System.Windows.Forms.PictureBox ptica2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTimeLeft;
        private System.Windows.Forms.Label lblGameOver;
    }
=======
﻿namespace LovNaPtici
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnGameOver = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTs = new System.Windows.Forms.Label();
            this.lblSc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ptica1 = new System.Windows.Forms.PictureBox();
            this.ptica3 = new System.Windows.Forms.PictureBox();
            this.ptica2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 60;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnGameOver
            // 
            this.btnGameOver.BackColor = System.Drawing.Color.Transparent;
            this.btnGameOver.BackgroundImage = global::LovNaPtici.Properties.Resources.buttonRed;
            this.btnGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGameOver.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameOver.ForeColor = System.Drawing.Color.Black;
            this.btnGameOver.Image = global::LovNaPtici.Properties.Resources.buttonRed;
            this.btnGameOver.Location = new System.Drawing.Point(363, 590);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(188, 57);
            this.btnGameOver.TabIndex = 8;
            this.btnGameOver.Text = "Main menu";
            this.btnGameOver.UseVisualStyleBackColor = false;
            this.btnGameOver.Visible = false;
            this.btnGameOver.Click += new System.EventHandler(this.btnGameOver_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::LovNaPtici.Properties.Resources.buttonRed;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::LovNaPtici.Properties.Resources.buttonRed;
            this.btnNext.Location = new System.Drawing.Point(363, 511);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(188, 57);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next Level";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTs);
            this.groupBox2.Controls.Add(this.lblSc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 152);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(119, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 26);
            this.lblTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time:";
            // 
            // lblTs
            // 
            this.lblTs.AutoSize = true;
            this.lblTs.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTs.Location = new System.Drawing.Point(190, 112);
            this.lblTs.Name = "lblTs";
            this.lblTs.Size = new System.Drawing.Size(0, 26);
            this.lblTs.TabIndex = 3;
            // 
            // lblSc
            // 
            this.lblSc.AutoSize = true;
            this.lblSc.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSc.Location = new System.Drawing.Point(108, 58);
            this.lblSc.Name = "lblSc";
            this.lblSc.Size = new System.Drawing.Size(0, 26);
            this.lblSc.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Score:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ptica1
            // 
            this.ptica1.BackColor = System.Drawing.Color.Transparent;
            this.ptica1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptica1.Image = global::LovNaPtici.Properties.Resources.W8fWP13NK8og;
            this.ptica1.Location = new System.Drawing.Point(22, 12);
            this.ptica1.Name = "ptica1";
            this.ptica1.Size = new System.Drawing.Size(123, 80);
            this.ptica1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica1.TabIndex = 10;
            this.ptica1.TabStop = false;
            this.ptica1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica1_MouseClick);
            // 
            // ptica3
            // 
            this.ptica3.BackColor = System.Drawing.Color.Transparent;
            this.ptica3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptica3.ErrorImage = null;
            this.ptica3.Image = global::LovNaPtici.Properties.Resources.bird2_flip;
            this.ptica3.Location = new System.Drawing.Point(22, 292);
            this.ptica3.Name = "ptica3";
            this.ptica3.Size = new System.Drawing.Size(100, 50);
            this.ptica3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica3.TabIndex = 11;
            this.ptica3.TabStop = false;
            this.ptica3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica3_MouseClick);
            // 
            // ptica2
            // 
            this.ptica2.BackColor = System.Drawing.Color.Transparent;
            this.ptica2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptica2.Image = ((System.Drawing.Image)(resources.GetObject("ptica2.Image")));
            this.ptica2.Location = new System.Drawing.Point(987, 133);
            this.ptica2.Name = "ptica2";
            this.ptica2.Size = new System.Drawing.Size(113, 95);
            this.ptica2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica2.TabIndex = 12;
            this.ptica2.TabStop = false;
            this.ptica2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica2_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTimeLeft
            // 
            this.timerTimeLeft.Interval = 1000;
            this.timerTimeLeft.Tick += new System.EventHandler(this.timerTimeLeft_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(482, 237);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(355, 69);
            this.lblGameOver.TabIndex = 13;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LovNaPtici.Properties.Resources.beachBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 662);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.ptica2);
            this.Controls.Add(this.ptica3);
            this.Controls.Add(this.ptica1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.btnNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Bird Hunter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnGameOver;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTs;
        private System.Windows.Forms.Label lblSc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox ptica1;
        private System.Windows.Forms.PictureBox ptica3;
        private System.Windows.Forms.PictureBox ptica2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTimeLeft;
        private System.Windows.Forms.Label lblGameOver;
    }
>>>>>>> 8dd3a8a9a6ab642a57efaf122ace5b8f5aeeacda
}