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
            this.SuspendLayout();
            // 
            // TSU_name
            // 
            this.TSU_name.AutoSize = true;
            this.TSU_name.Location = new System.Drawing.Point(28, 19);
            this.TSU_name.Name = "TSU_name";
            this.TSU_name.Size = new System.Drawing.Size(138, 13);
            this.TSU_name.TabIndex = 0;
            this.TSU_name.Text = "Tenneesee State University";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER YOUR PIN";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(103, 125);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(299, 20);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // passEnter
            // 
            this.passEnter.Location = new System.Drawing.Point(427, 359);
            this.passEnter.Name = "passEnter";
            this.passEnter.Size = new System.Drawing.Size(69, 52);
            this.passEnter.TabIndex = 3;
            this.passEnter.Text = "ENTER";
            this.passEnter.UseVisualStyleBackColor = true;
            this.passEnter.Click += new System.EventHandler(this.passEnter_Click);
            // 
            // passCancel
            // 
            this.passCancel.Location = new System.Drawing.Point(431, 221);
            this.passCancel.Name = "passCancel";
            this.passCancel.Size = new System.Drawing.Size(65, 50);
            this.passCancel.TabIndex = 4;
            this.passCancel.Text = "CANCEL";
            this.passCancel.UseVisualStyleBackColor = true;
            this.passCancel.Click += new System.EventHandler(this.passCancel_Click);
            // 
            // passClear
            // 
            this.passClear.Location = new System.Drawing.Point(431, 300);
            this.passClear.Name = "passClear";
            this.passClear.Size = new System.Drawing.Size(65, 53);
            this.passClear.TabIndex = 5;
            this.passClear.Text = "CLEAR";
            this.passClear.UseVisualStyleBackColor = true;
            this.passClear.Click += new System.EventHandler(this.passClear_Click);
            // 
            // keyOne
            // 
            this.keyOne.Location = new System.Drawing.Point(79, 203);
            this.keyOne.Name = "keyOne";
            this.keyOne.Size = new System.Drawing.Size(75, 23);
            this.keyOne.TabIndex = 6;
            this.keyOne.Text = "1";
            this.keyOne.UseVisualStyleBackColor = true;
            this.keyOne.Click += new System.EventHandler(this.keyOne_Click);
            // 
            // keyTwo
            // 
            this.keyTwo.Location = new System.Drawing.Point(192, 203);
            this.keyTwo.Name = "keyTwo";
            this.keyTwo.Size = new System.Drawing.Size(75, 23);
            this.keyTwo.TabIndex = 7;
            this.keyTwo.Text = "2";
            this.keyTwo.UseVisualStyleBackColor = true;
            this.keyTwo.Click += new System.EventHandler(this.keyTwo_Click);
            // 
            // keyThree
            // 
            this.keyThree.Location = new System.Drawing.Point(290, 203);
            this.keyThree.Name = "keyThree";
            this.keyThree.Size = new System.Drawing.Size(75, 23);
            this.keyThree.TabIndex = 8;
            this.keyThree.Text = "3";
            this.keyThree.UseVisualStyleBackColor = true;
            this.keyThree.Click += new System.EventHandler(this.keyThree_Click);
            // 
            // keyFour
            // 
            this.keyFour.Location = new System.Drawing.Point(79, 259);
            this.keyFour.Name = "keyFour";
            this.keyFour.Size = new System.Drawing.Size(75, 23);
            this.keyFour.TabIndex = 9;
            this.keyFour.Text = "4";
            this.keyFour.UseVisualStyleBackColor = true;
            this.keyFour.Click += new System.EventHandler(this.keyFour_Click);
            // 
            // keyZero
            // 
            this.keyZero.Location = new System.Drawing.Point(192, 374);
            this.keyZero.Name = "keyZero";
            this.keyZero.Size = new System.Drawing.Size(75, 23);
            this.keyZero.TabIndex = 10;
            this.keyZero.Text = "0";
            this.keyZero.UseVisualStyleBackColor = true;
            this.keyZero.Click += new System.EventHandler(this.keyZero_Click);
            // 
            // keySix
            // 
            this.keySix.Location = new System.Drawing.Point(290, 259);
            this.keySix.Name = "keySix";
            this.keySix.Size = new System.Drawing.Size(75, 23);
            this.keySix.TabIndex = 12;
            this.keySix.Text = "6";
            this.keySix.UseVisualStyleBackColor = true;
            this.keySix.Click += new System.EventHandler(this.keySix_Click);
            // 
            // keySeven
            // 
            this.keySeven.Location = new System.Drawing.Point(79, 315);
            this.keySeven.Name = "keySeven";
            this.keySeven.Size = new System.Drawing.Size(75, 23);
            this.keySeven.TabIndex = 13;
            this.keySeven.Text = "7";
            this.keySeven.UseVisualStyleBackColor = true;
            this.keySeven.Click += new System.EventHandler(this.keySeven_Click);
            // 
            // keyEight
            // 
            this.keyEight.Location = new System.Drawing.Point(192, 315);
            this.keyEight.Name = "keyEight";
            this.keyEight.Size = new System.Drawing.Size(75, 23);
            this.keyEight.TabIndex = 14;
            this.keyEight.Text = "8";
            this.keyEight.UseVisualStyleBackColor = true;
            this.keyEight.Click += new System.EventHandler(this.keyEight_Click);
            // 
            // keyNine
            // 
            this.keyNine.Location = new System.Drawing.Point(290, 315);
            this.keyNine.Name = "keyNine";
            this.keyNine.Size = new System.Drawing.Size(75, 23);
            this.keyNine.TabIndex = 15;
            this.keyNine.Text = "9";
            this.keyNine.UseVisualStyleBackColor = true;
            this.keyNine.Click += new System.EventHandler(this.keyNine_Click);
            // 
            // keyFive
            // 
            this.keyFive.Location = new System.Drawing.Point(192, 259);
            this.keyFive.Name = "keyFive";
            this.keyFive.Size = new System.Drawing.Size(75, 23);
            this.keyFive.TabIndex = 16;
            this.keyFive.Text = "5";
            this.keyFive.UseVisualStyleBackColor = true;
            this.keyFive.Click += new System.EventHandler(this.keyFive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 540);
            this.Controls.Add(this.keyFive);
            this.Controls.Add(this.keyNine);
            this.Controls.Add(this.keyEight);
            this.Controls.Add(this.keySeven);
            this.Controls.Add(this.keySix);
            this.Controls.Add(this.keyZero);
            this.Controls.Add(this.keyFour);
            this.Controls.Add(this.keyThree);
            this.Controls.Add(this.keyTwo);
            this.Controls.Add(this.keyOne);
            this.Controls.Add(this.passClear);
            this.Controls.Add(this.passCancel);
            this.Controls.Add(this.passEnter);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TSU_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

