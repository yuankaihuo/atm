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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 540);
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
    }
}

