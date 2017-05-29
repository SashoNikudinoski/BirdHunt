<<<<<<< HEAD
﻿namespace LovNaPtici
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ptica2 = new System.Windows.Forms.PictureBox();
            this.ptica3 = new System.Windows.Forms.PictureBox();
            this.ptica1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTs = new System.Windows.Forms.Label();
            this.lblSc = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGameOver = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptica2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptica2
            // 
            this.ptica2.BackColor = System.Drawing.Color.Transparent;
            this.ptica2.Image = global::LovNaPtici.Properties.Resources.bird2;
            this.ptica2.InitialImage = null;
            this.ptica2.Location = new System.Drawing.Point(985, 12);
            this.ptica2.Name = "ptica2";
            this.ptica2.Size = new System.Drawing.Size(84, 54);
            this.ptica2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica2.TabIndex = 0;
            this.ptica2.TabStop = false;
            this.ptica2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica2_MouseClick);
            // 
            // ptica3
            // 
            this.ptica3.BackColor = System.Drawing.Color.Transparent;
            this.ptica3.Image = global::LovNaPtici.Properties.Resources.bird2;
            this.ptica3.InitialImage = null;
            this.ptica3.Location = new System.Drawing.Point(896, 337);
            this.ptica3.Name = "ptica3";
            this.ptica3.Size = new System.Drawing.Size(75, 54);
            this.ptica3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica3.TabIndex = 1;
            this.ptica3.TabStop = false;
            this.ptica3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica3_MouseClick);
            // 
            // ptica1
            // 
            this.ptica1.BackColor = System.Drawing.Color.Transparent;
            this.ptica1.Image = global::LovNaPtici.Properties.Resources.ezgif_com_gif_maker__3_;
            this.ptica1.InitialImage = null;
            this.ptica1.Location = new System.Drawing.Point(80, 149);
            this.ptica1.Name = "ptica1";
            this.ptica1.Size = new System.Drawing.Size(80, 60);
            this.ptica1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica1.TabIndex = 2;
            this.ptica1.TabStop = false;
            this.ptica1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica1_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 45;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 65;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerTimeLeft
            // 
            this.timerTimeLeft.Interval = 1000;
            this.timerTimeLeft.Tick += new System.EventHandler(this.timerTimeLeft_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTs);
            this.groupBox1.Controls.Add(this.lblSc);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Location = new System.Drawing.Point(7, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(5, 110);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(148, 26);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(5, 56);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 26);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
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
            this.btnNext.Location = new System.Drawing.Point(366, 514);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(188, 57);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next Level";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnGameOver.Location = new System.Drawing.Point(366, 593);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(188, 57);
            this.btnGameOver.TabIndex = 5;
            this.btnGameOver.Text = "Main menu";
            this.btnGameOver.UseVisualStyleBackColor = false;
            this.btnGameOver.Visible = false;
            this.btnGameOver.Click += new System.EventHandler(this.btnGameOver_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(392, 203);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(355, 69);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LovNaPtici.Properties.Resources.horseBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 662);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptica1);
            this.Controls.Add(this.ptica3);
            this.Controls.Add(this.ptica2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Bird Hunt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.ptica2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptica2;
        private System.Windows.Forms.PictureBox ptica3;
        private System.Windows.Forms.PictureBox ptica1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerTimeLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTs;
        private System.Windows.Forms.Label lblSc;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGameOver;
        private System.Windows.Forms.Label lblGameOver;
    }
=======
﻿namespace LovNaPtici
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ptica2 = new System.Windows.Forms.PictureBox();
            this.ptica3 = new System.Windows.Forms.PictureBox();
            this.ptica1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTs = new System.Windows.Forms.Label();
            this.lblSc = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGameOver = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptica2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptica2
            // 
            this.ptica2.BackColor = System.Drawing.Color.Transparent;
            this.ptica2.Image = global::LovNaPtici.Properties.Resources.bird2;
            this.ptica2.InitialImage = null;
            this.ptica2.Location = new System.Drawing.Point(985, 12);
            this.ptica2.Name = "ptica2";
            this.ptica2.Size = new System.Drawing.Size(84, 54);
            this.ptica2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica2.TabIndex = 0;
            this.ptica2.TabStop = false;
            this.ptica2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica2_MouseClick);
            // 
            // ptica3
            // 
            this.ptica3.BackColor = System.Drawing.Color.Transparent;
            this.ptica3.Image = global::LovNaPtici.Properties.Resources.bird2;
            this.ptica3.InitialImage = null;
            this.ptica3.Location = new System.Drawing.Point(814, 288);
            this.ptica3.Name = "ptica3";
            this.ptica3.Size = new System.Drawing.Size(75, 54);
            this.ptica3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica3.TabIndex = 1;
            this.ptica3.TabStop = false;
            this.ptica3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica3_MouseClick);
            // 
            // ptica1
            // 
            this.ptica1.BackColor = System.Drawing.Color.Transparent;
            this.ptica1.Image = global::LovNaPtici.Properties.Resources.ezgif_com_gif_maker__3_;
            this.ptica1.InitialImage = null;
            this.ptica1.Location = new System.Drawing.Point(111, 134);
            this.ptica1.Name = "ptica1";
            this.ptica1.Size = new System.Drawing.Size(80, 60);
            this.ptica1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica1.TabIndex = 2;
            this.ptica1.TabStop = false;
            this.ptica1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptica1_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerTimeLeft
            // 
            this.timerTimeLeft.Interval = 1000;
            this.timerTimeLeft.Tick += new System.EventHandler(this.timerTimeLeft_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTs);
            this.groupBox1.Controls.Add(this.lblSc);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Location = new System.Drawing.Point(7, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(5, 110);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(148, 26);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(5, 56);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 26);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
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
            this.btnNext.Location = new System.Drawing.Point(366, 514);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(188, 57);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next Level";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnGameOver.Location = new System.Drawing.Point(366, 593);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(188, 57);
            this.btnGameOver.TabIndex = 5;
            this.btnGameOver.Text = "Main menu";
            this.btnGameOver.UseVisualStyleBackColor = false;
            this.btnGameOver.Visible = false;
            this.btnGameOver.Click += new System.EventHandler(this.btnGameOver_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(528, 213);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(355, 69);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LovNaPtici.Properties.Resources.horseBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 662);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptica1);
            this.Controls.Add(this.ptica3);
            this.Controls.Add(this.ptica2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Bird Hunter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.ptica2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptica2;
        private System.Windows.Forms.PictureBox ptica3;
        private System.Windows.Forms.PictureBox ptica1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerTimeLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTs;
        private System.Windows.Forms.Label lblSc;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGameOver;
        private System.Windows.Forms.Label lblGameOver;
    }
>>>>>>> 8dd3a8a9a6ab642a57efaf122ace5b8f5aeeacda
}