namespace BouncingBall
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
            this.picDisplayBox = new System.Windows.Forms.PictureBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.btnUP = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.RightTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftTimer = new System.Windows.Forms.Timer(this.components);
            this.DownTimer = new System.Windows.Forms.Timer(this.components);
            this.UpTimer = new System.Windows.Forms.Timer(this.components);
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            this.btnInsert = new System.Windows.Forms.Button();
            this.Bricks = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnRandomButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerRandom = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplayBox
            // 
            this.picDisplayBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.picDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDisplayBox.Location = new System.Drawing.Point(9, 25);
            this.picDisplayBox.Name = "picDisplayBox";
            this.picDisplayBox.Size = new System.Drawing.Size(613, 428);
            this.picDisplayBox.TabIndex = 0;
            this.picDisplayBox.TabStop = false;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRandom.Enabled = false;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.Color.Red;
            this.btnRandom.Location = new System.Drawing.Point(12, 484);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(55, 23);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Start";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(132, 483);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(44, 3);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(24, 20);
            this.txtInsert.TabIndex = 4;
            // 
            // timerStart
            // 
            this.timerStart.Tick += new System.EventHandler(this.timerRandom_Tick);
            // 
            // btnUP
            // 
            this.btnUP.BackColor = System.Drawing.Color.SlateGray;
            this.btnUP.Enabled = false;
            this.btnUP.ForeColor = System.Drawing.Color.Transparent;
            this.btnUP.Location = new System.Drawing.Point(266, 499);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(32, 23);
            this.btnUP.TabIndex = 5;
            this.btnUP.Text = "U";
            this.btnUP.UseVisualStyleBackColor = false;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.SlateGray;
            this.btnDown.Enabled = false;
            this.btnDown.ForeColor = System.Drawing.Color.Transparent;
            this.btnDown.Location = new System.Drawing.Point(266, 528);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(32, 23);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "D";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.SlateGray;
            this.btnL.Enabled = false;
            this.btnL.ForeColor = System.Drawing.Color.Transparent;
            this.btnL.Location = new System.Drawing.Point(229, 513);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(32, 23);
            this.btnL.TabIndex = 7;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.SlateGray;
            this.btnR.Enabled = false;
            this.btnR.ForeColor = System.Drawing.Color.Transparent;
            this.btnR.Location = new System.Drawing.Point(305, 512);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(32, 23);
            this.btnR.TabIndex = 8;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // RightTimer
            // 
            this.RightTimer.Tick += new System.EventHandler(this.Right_Tick);
            // 
            // LeftTimer
            // 
            this.LeftTimer.Tick += new System.EventHandler(this.Left_Tick);
            // 
            // DownTimer
            // 
            this.DownTimer.Tick += new System.EventHandler(this.Down_Tick);
            // 
            // UpTimer
            // 
            this.UpTimer.Tick += new System.EventHandler(this.Up_Tick);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Red;
            this.btnInsert.Location = new System.Drawing.Point(443, 512);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(43, 32);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "£1";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Bricks
            // 
            this.Bricks.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Bricks.Enabled = false;
            this.Bricks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bricks.ForeColor = System.Drawing.Color.Red;
            this.Bricks.Location = new System.Drawing.Point(73, 483);
            this.Bricks.Name = "Bricks";
            this.Bricks.Size = new System.Drawing.Size(53, 23);
            this.Bricks.TabIndex = 10;
            this.Bricks.Text = "Bricks";
            this.Bricks.UseVisualStyleBackColor = false;
            this.Bricks.Click += new System.EventHandler(this.Bricks_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(517, 4);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score";
            // 
            // btnRandomButton
            // 
            this.btnRandomButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRandomButton.Enabled = false;
            this.btnRandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomButton.ForeColor = System.Drawing.Color.Red;
            this.btnRandomButton.Location = new System.Drawing.Point(63, 523);
            this.btnRandomButton.Name = "btnRandomButton";
            this.btnRandomButton.Size = new System.Drawing.Size(79, 22);
            this.btnRandomButton.TabIndex = 13;
            this.btnRandomButton.Text = "Random";
            this.btnRandomButton.UseVisualStyleBackColor = false;
            this.btnRandomButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lives";
            // 
            // timerRandom
            // 
            this.timerRandom.Tick += new System.EventHandler(this.timerRandom_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandomButton);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.Bricks);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.picDisplayBox);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplayBox;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Timer RightTimer;
        private System.Windows.Forms.Timer LeftTimer;
        private System.Windows.Forms.Timer DownTimer;
        private System.Windows.Forms.Timer UpTimer;
        private System.Windows.Forms.Timer timerControl;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button Bricks;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnRandomButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerRandom;
    }
}

