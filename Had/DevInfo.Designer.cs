namespace Had
{
    partial class DevInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFL = new System.Windows.Forms.Label();
            this.lblHL = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLenght = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food location: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Head location: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // lblFL
            // 
            this.lblFL.AutoSize = true;
            this.lblFL.Location = new System.Drawing.Point(174, 9);
            this.lblFL.Name = "lblFL";
            this.lblFL.Size = new System.Drawing.Size(17, 20);
            this.lblFL.TabIndex = 3;
            this.lblFL.Text = "0";
            // 
            // lblHL
            // 
            this.lblHL.AutoSize = true;
            this.lblHL.Location = new System.Drawing.Point(174, 29);
            this.lblHL.Name = "lblHL";
            this.lblHL.Size = new System.Drawing.Size(17, 20);
            this.lblHL.TabIndex = 4;
            this.lblHL.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(174, 49);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(17, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Snake lenght:";
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Location = new System.Drawing.Point(174, 69);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(17, 20);
            this.lblLenght.TabIndex = 7;
            this.lblLenght.Text = "0";
            // 
            // DevInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 104);
            this.Controls.Add(this.lblLenght);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblHL);
            this.Controls.Add(this.lblFL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DevInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevInfo";
            this.Load += new System.EventHandler(this.DevInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblFL;
        private Label lblHL;
        private Label lblScore;
        private Label label7;
        private Label lblLenght;
    }
}