
namespace Timer_ile_Renklendirme
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.chkbGS = new System.Windows.Forms.CheckBox();
            this.chkbFB = new System.Windows.Forms.CheckBox();
            this.chkbTS = new System.Windows.Forms.CheckBox();
            this.chkbBJK = new System.Windows.Forms.CheckBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 183);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 183);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(446, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 183);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(669, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 183);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 183);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(228, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 183);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(446, 192);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(217, 183);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(669, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(217, 183);
            this.button8.TabIndex = 4;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // chkbGS
            // 
            this.chkbGS.AutoSize = true;
            this.chkbGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkbGS.Location = new System.Drawing.Point(399, 395);
            this.chkbGS.Name = "chkbGS";
            this.chkbGS.Size = new System.Drawing.Size(114, 24);
            this.chkbGS.TabIndex = 8;
            this.chkbGS.Text = "Galatasaray";
            this.chkbGS.UseVisualStyleBackColor = true;
            this.chkbGS.CheckedChanged += new System.EventHandler(this.chkbGS_CheckedChanged);
            // 
            // chkbFB
            // 
            this.chkbFB.AutoSize = true;
            this.chkbFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkbFB.Location = new System.Drawing.Point(281, 395);
            this.chkbFB.Name = "chkbFB";
            this.chkbFB.Size = new System.Drawing.Size(114, 24);
            this.chkbFB.TabIndex = 9;
            this.chkbFB.Text = "Fenerbahçe";
            this.chkbFB.UseVisualStyleBackColor = true;
            this.chkbFB.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkbTS
            // 
            this.chkbTS.AutoSize = true;
            this.chkbTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkbTS.Location = new System.Drawing.Point(626, 395);
            this.chkbTS.Name = "chkbTS";
            this.chkbTS.Size = new System.Drawing.Size(117, 24);
            this.chkbTS.TabIndex = 11;
            this.chkbTS.Text = "Trabzonspor";
            this.chkbTS.UseVisualStyleBackColor = true;
            this.chkbTS.CheckedChanged += new System.EventHandler(this.chkbTS_CheckedChanged);
            // 
            // chkbBJK
            // 
            this.chkbBJK.AutoSize = true;
            this.chkbBJK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkbBJK.Location = new System.Drawing.Point(526, 395);
            this.chkbBJK.Name = "chkbBJK";
            this.chkbBJK.Size = new System.Drawing.Size(89, 24);
            this.chkbBJK.TabIndex = 10;
            this.chkbBJK.Text = "Beşiktaş";
            this.chkbBJK.UseVisualStyleBackColor = true;
            this.chkbBJK.CheckedChanged += new System.EventHandler(this.chkbBJK_CheckedChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.Location = new System.Drawing.Point(818, 395);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(20, 24);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 381);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(244, 45);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 438);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.chkbTS);
            this.Controls.Add(this.chkbBJK);
            this.Controls.Add(this.chkbFB);
            this.Controls.Add(this.chkbGS);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox chkbGS;
        private System.Windows.Forms.CheckBox chkbFB;
        private System.Windows.Forms.CheckBox chkbTS;
        private System.Windows.Forms.CheckBox chkbBJK;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

