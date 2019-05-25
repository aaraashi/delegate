namespace _300975376_Kim_ASS1
{
    partial class Pub
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
            this.lblNoti = new System.Windows.Forms.Label();
            this.textNotiContent = new System.Windows.Forms.TextBox();
            this.btnPub = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoti
            // 
            this.lblNoti.AutoSize = true;
            this.lblNoti.Location = new System.Drawing.Point(52, 103);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(149, 20);
            this.lblNoti.TabIndex = 0;
            this.lblNoti.Text = "Notification Content";
            // 
            // textNotiContent
            // 
            this.textNotiContent.Location = new System.Drawing.Point(228, 96);
            this.textNotiContent.Name = "textNotiContent";
            this.textNotiContent.Size = new System.Drawing.Size(256, 26);
            this.textNotiContent.TabIndex = 1;
            
            // 
            // btnPub
            // 
            this.btnPub.Location = new System.Drawing.Point(120, 176);
            this.btnPub.Name = "btnPub";
            this.btnPub.Size = new System.Drawing.Size(145, 39);
            this.btnPub.TabIndex = 2;
            this.btnPub.Text = "Publish";
            this.btnPub.UseVisualStyleBackColor = true;
            this.btnPub.Click += new System.EventHandler(this.btnPub_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(360, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(56, 249);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 4;
            // 
            // Pub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 373);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPub);
            this.Controls.Add(this.textNotiContent);
            this.Controls.Add(this.lblNoti);
            this.Name = "Pub";
            this.Text = "Publish Notification";
            this.Load += new System.EventHandler(this.Pub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoti;
        private System.Windows.Forms.TextBox textNotiContent;
        private System.Windows.Forms.Button btnPub;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
    }
}