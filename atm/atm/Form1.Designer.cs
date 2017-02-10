namespace atm
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
            this.TSU_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passEnter = new System.Windows.Forms.Button();
            this.passCancel = new System.Windows.Forms.Button();
            this.passClear = new System.Windows.Forms.Button();
            this.keyOne = new System.Windows.Forms.Button();
            this.keyTwo = new System.Windows.Forms.Button();
            this.keyThree = new System.Windows.Forms.Button();
            this.keyFour = new System.Windows.Forms.Button();
            this.keyZero = new System.Windows.Forms.Button();
            this.keySix = new System.Windows.Forms.Button();
            this.keySeven = new System.Windows.Forms.Button();
            this.keyEight = new System.Windows.Forms.Button();
            this.keyNine = new System.Windows.Forms.Button();
            this.keyFive = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.btnBlank = new System.Windows.Forms.Button();
            this.lblPin = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSU_name
            // 
            this.TSU_name.AutoSize = true;
            this.TSU_name.ForeColor = System.Drawing.Color.Blue;
            this.TSU_name.Location = new System.Drawing.Point(28, 19);
            this.TSU_name.Name = "TSU_name";
            this.TSU_name.Size = new System.Drawing.Size(138, 13);
            this.TSU_name.TabIndex = 0;
            this.TSU_name.Text = "Tenneesee State University";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(27, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER YOUR PIN";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.SystemColors.Info;
            this.passwordBox.Location = new System.Drawing.Point(31, 116);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(375, 80);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.UseWaitCursor = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // passEnter
            // 
            this.passEnter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passEnter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passEnter.Location = new System.Drawing.Point(279, 192);
            this.passEnter.Name = "passEnter";
            this.passEnter.Size = new System.Drawing.Size(75, 53);
            this.passEnter.TabIndex = 3;
            this.passEnter.Text = "ENTER";
            this.passEnter.UseVisualStyleBackColor = false;
            this.passEnter.Click += new System.EventHandler(this.passEnter_Click);
            // 
            // passCancel
            // 
            this.passCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passCancel.Location = new System.Drawing.Point(281, 17);
            this.passCancel.Name = "passCancel";
            this.passCancel.Size = new System.Drawing.Size(75, 53);
            this.passCancel.TabIndex = 4;
            this.passCancel.Text = "CANCEL";
            this.passCancel.UseVisualStyleBackColor = false;
            this.passCancel.Click += new System.EventHandler(this.passCancel_Click);
            // 
            // passClear
            // 
            this.passClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passClear.Location = new System.Drawing.Point(281, 71);
            this.passClear.Name = "passClear";
            this.passClear.Size = new System.Drawing.Size(75, 53);
            this.passClear.TabIndex = 5;
            this.passClear.Text = "CLEAR";
            this.passClear.UseVisualStyleBackColor = false;
            this.passClear.Click += new System.EventHandler(this.passClear_Click);
            // 
            // keyOne
            // 
            this.keyOne.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keyOne.Location = new System.Drawing.Point(3, 12);
            this.keyOne.Name = "keyOne";
            this.keyOne.Size = new System.Drawing.Size(75, 53);
            this.keyOne.TabIndex = 6;
            this.keyOne.Text = "1";
            this.keyOne.UseVisualStyleBackColor = false;
            this.keyOne.Click += new System.EventHandler(this.keyOne_Click);
            // 
            // keyTwo
            // 
            this.keyTwo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyTwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keyTwo.Location = new System.Drawing.Point(97, 12);
            this.keyTwo.Name = "keyTwo";
            this.keyTwo.Size = new System.Drawing.Size(75, 53);
            this.keyTwo.TabIndex = 7;
            this.keyTwo.Text = "2";
            this.keyTwo.UseVisualStyleBackColor = false;
            this.keyTwo.Click += new System.EventHandler(this.keyTwo_Click);
            // 
            // keyThree
            // 
            this.keyThree.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyThree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keyThree.Location = new System.Drawing.Point(189, 14);
            this.keyThree.Name = "keyThree";
            this.keyThree.Size = new System.Drawing.Size(75, 53);
            this.keyThree.TabIndex = 8;
            this.keyThree.Text = "3";
            this.keyThree.UseVisualStyleBackColor = false;
            this.keyThree.Click += new System.EventHandler(this.keyThree_Click);
            // 
            // keyFour
            // 
            this.keyFour.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyFour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keyFour.Location = new System.Drawing.Point(3, 71);
            this.keyFour.Name = "keyFour";
            this.keyFour.Size = new System.Drawing.Size(75, 53);
            this.keyFour.TabIndex = 9;
            this.keyFour.Text = "4";
            this.keyFour.UseVisualStyleBackColor = false;
            this.keyFour.Click += new System.EventHandler(this.keyFour_Click);
            // 
            // keyZero
            // 
            this.keyZero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyZero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keyZero.Location = new System.Drawing.Point(97, 192);
            this.keyZero.Name = "keyZero";
            this.keyZero.Size = new System.Drawing.Size(75, 53);
            this.keyZero.TabIndex = 10;
            this.keyZero.Text = "0";
            this.keyZero.UseVisualStyleBackColor = false;
            this.keyZero.Click += new System.EventHandler(this.keyZero_Click);
            // 
            // keySix
            // 
            this.keySix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keySix.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keySix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keySix.Location = new System.Drawing.Point(190, 74);
            this.keySix.Name = "keySix";
            this.keySix.Size = new System.Drawing.Size(75, 53);
            this.keySix.TabIndex = 12;
            this.keySix.Text = "6";
            this.keySix.UseVisualStyleBackColor = false;
            this.keySix.Click += new System.EventHandler(this.keySix_Click);
            // 
            // keySeven
            // 
            this.keySeven.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keySeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keySeven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keySeven.Location = new System.Drawing.Point(3, 130);
            this.keySeven.Name = "keySeven";
            this.keySeven.Size = new System.Drawing.Size(75, 53);
            this.keySeven.TabIndex = 13;
            this.keySeven.Text = "7";
            this.keySeven.UseVisualStyleBackColor = false;
            this.keySeven.Click += new System.EventHandler(this.keySeven_Click);
            // 
            // keyEight
            // 
            this.keyEight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyEight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keyEight.Location = new System.Drawing.Point(97, 133);
            this.keyEight.Name = "keyEight";
            this.keyEight.Size = new System.Drawing.Size(75, 53);
            this.keyEight.TabIndex = 14;
            this.keyEight.Text = "8";
            this.keyEight.UseVisualStyleBackColor = false;
            this.keyEight.Click += new System.EventHandler(this.keyEight_Click);
            // 
            // keyNine
            // 
            this.keyNine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyNine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keyNine.Location = new System.Drawing.Point(189, 133);
            this.keyNine.Name = "keyNine";
            this.keyNine.Size = new System.Drawing.Size(75, 53);
            this.keyNine.TabIndex = 15;
            this.keyNine.Text = "9";
            this.keyNine.UseVisualStyleBackColor = false;
            this.keyNine.Click += new System.EventHandler(this.keyNine_Click);
            // 
            // keyFive
            // 
            this.keyFive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyFive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keyFive.Location = new System.Drawing.Point(97, 71);
            this.keyFive.Name = "keyFive";
            this.keyFive.Size = new System.Drawing.Size(75, 53);
            this.keyFive.TabIndex = 16;
            this.keyFive.Text = "5";
            this.keyFive.UseVisualStyleBackColor = false;
            this.keyFive.Click += new System.EventHandler(this.keyFive_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Blue;
            this.lblWelcome.Location = new System.Drawing.Point(28, 32);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(378, 13);
            this.lblWelcome.TabIndex = 17;
            this.lblWelcome.Text = "Welcome to the Department of Computer Science\'s ATM Machine";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pnlGreen);
            this.panel1.Controls.Add(this.pnlYellow);
            this.panel1.Controls.Add(this.pnlRed);
            this.panel1.Controls.Add(this.btnBlank);
            this.panel1.Controls.Add(this.keyOne);
            this.panel1.Controls.Add(this.keyTwo);
            this.panel1.Controls.Add(this.keyZero);
            this.panel1.Controls.Add(this.passEnter);
            this.panel1.Controls.Add(this.passClear);
            this.panel1.Controls.Add(this.keyNine);
            this.panel1.Controls.Add(this.passCancel);
            this.panel1.Controls.Add(this.keyFive);
            this.panel1.Controls.Add(this.keyEight);
            this.panel1.Controls.Add(this.keyThree);
            this.panel1.Controls.Add(this.keySeven);
            this.panel1.Controls.Add(this.keyFour);
            this.panel1.Controls.Add(this.keySix);
            this.panel1.Location = new System.Drawing.Point(31, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 263);
            this.panel1.TabIndex = 18;
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.Chartreuse;
            this.pnlGreen.Location = new System.Drawing.Point(298, 230);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(40, 5);
            this.pnlGreen.TabIndex = 21;
            // 
            // pnlYellow
            // 
            this.pnlYellow.BackColor = System.Drawing.Color.Gold;
            this.pnlYellow.Location = new System.Drawing.Point(298, 108);
            this.pnlYellow.Name = "pnlYellow";
            this.pnlYellow.Size = new System.Drawing.Size(40, 5);
            this.pnlYellow.TabIndex = 20;
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.Red;
            this.pnlRed.Location = new System.Drawing.Point(298, 55);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(40, 5);
            this.pnlRed.TabIndex = 18;
            // 
            // btnBlank
            // 
            this.btnBlank.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlank.Location = new System.Drawing.Point(281, 130);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Size = new System.Drawing.Size(75, 53);
            this.btnBlank.TabIndex = 17;
            this.btnBlank.UseVisualStyleBackColor = false;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPin.Location = new System.Drawing.Point(31, 116);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(25, 13);
            this.lblPin.TabIndex = 19;
            this.lblPin.Text = "PIN";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 5);
            this.panel4.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 540);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TSU_name);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TSU_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button passEnter;
        private System.Windows.Forms.Button passCancel;
        private System.Windows.Forms.Button passClear;
        private System.Windows.Forms.Button keyOne;
        private System.Windows.Forms.Button keyTwo;
        private System.Windows.Forms.Button keyThree;
        private System.Windows.Forms.Button keyFour;
        private System.Windows.Forms.Button keyZero;
        private System.Windows.Forms.Button keySix;
        private System.Windows.Forms.Button keySeven;
        private System.Windows.Forms.Button keyEight;
        private System.Windows.Forms.Button keyNine;
        private System.Windows.Forms.Button keyFive;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Panel pnlYellow;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Panel panel4;
    }
}

