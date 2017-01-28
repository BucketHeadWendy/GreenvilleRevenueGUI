namespace GreenvilleRevenueGUI
{
    partial class GreenvilleGUI
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
            this.lastLabel = new System.Windows.Forms.Label();
            this.thisLabel = new System.Windows.Forms.Label();
            this.lastYearBox = new System.Windows.Forms.Label();
            this.thisYearBox = new System.Windows.Forms.Label();
            this.CalcNow = new System.Windows.Forms.Button();
            this.revenueBox = new System.Windows.Forms.Label();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.thisBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(13, 61);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(281, 13);
            this.lastLabel.TabIndex = 0;
            this.lastLabel.Text = "Enter the number of contestants in last year\'s competition: ";
            // 
            // thisLabel
            // 
            this.thisLabel.AutoSize = true;
            this.thisLabel.Location = new System.Drawing.Point(13, 113);
            this.thisLabel.Name = "thisLabel";
            this.thisLabel.Size = new System.Drawing.Size(281, 13);
            this.thisLabel.TabIndex = 1;
            this.thisLabel.Text = "Enter the number of contestants in this year\'s competition: ";
            // 
            // lastYearBox
            // 
            this.lastYearBox.AutoSize = true;
            this.lastYearBox.Location = new System.Drawing.Point(13, 217);
            this.lastYearBox.Name = "lastYearBox";
            this.lastYearBox.Size = new System.Drawing.Size(0, 13);
            this.lastYearBox.TabIndex = 2;
            // 
            // thisYearBox
            // 
            this.thisYearBox.AutoSize = true;
            this.thisYearBox.Location = new System.Drawing.Point(13, 265);
            this.thisYearBox.Name = "thisYearBox";
            this.thisYearBox.Size = new System.Drawing.Size(0, 13);
            this.thisYearBox.TabIndex = 3;
            // 
            // CalcNow
            // 
            this.CalcNow.Location = new System.Drawing.Point(243, 169);
            this.CalcNow.Name = "CalcNow";
            this.CalcNow.Size = new System.Drawing.Size(134, 23);
            this.CalcNow.TabIndex = 4;
            this.CalcNow.Text = "Click to Calculate";
            this.CalcNow.UseVisualStyleBackColor = true;
            this.CalcNow.Click += new System.EventHandler(this.button1_Click);
            // 
            // revenueBox
            // 
            this.revenueBox.AutoSize = true;
            this.revenueBox.Location = new System.Drawing.Point(16, 308);
            this.revenueBox.Name = "revenueBox";
            this.revenueBox.Size = new System.Drawing.Size(0, 13);
            this.revenueBox.TabIndex = 5;
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(301, 53);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(100, 20);
            this.lastBox.TabIndex = 6;
            // 
            // thisBox
            // 
            this.thisBox.Location = new System.Drawing.Point(301, 105);
            this.thisBox.Name = "thisBox";
            this.thisBox.Size = new System.Drawing.Size(100, 20);
            this.thisBox.TabIndex = 7;
            // 
            // GreenvilleGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 395);
            this.Controls.Add(this.thisBox);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.revenueBox);
            this.Controls.Add(this.CalcNow);
            this.Controls.Add(this.thisYearBox);
            this.Controls.Add(this.lastYearBox);
            this.Controls.Add(this.thisLabel);
            this.Controls.Add(this.lastLabel);
            this.Name = "GreenvilleGUI";
            this.Text = "Greenville Revenue Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.Label thisLabel;
        private System.Windows.Forms.Label lastYearBox;
        private System.Windows.Forms.Label thisYearBox;
        private System.Windows.Forms.Button CalcNow;
        private System.Windows.Forms.Label revenueBox;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.TextBox thisBox;
    }
}

