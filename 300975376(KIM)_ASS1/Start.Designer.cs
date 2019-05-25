namespace _300975376_Kim_ASS1
{
    partial class Start
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
            btnSub = new System.Windows.Forms.Button();
            btnPub = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSub
            // 
            btnSub.Location = new System.Drawing.Point(43, 146);
            btnSub.Name = "btnSub";
            btnSub.Size = new System.Drawing.Size(243, 67);
            btnSub.TabIndex = 0;
            btnSub.Text = "Manage Subscription";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnPub
            // 
            btnPub.Location = new System.Drawing.Point(335, 146);
            btnPub.Name = "btnPub";
            btnPub.Size = new System.Drawing.Size(240, 67);
            btnPub.TabIndex = 1;
            btnPub.Text = "Publish Notification";
            btnPub.UseVisualStyleBackColor = true;
            btnPub.Click += new System.EventHandler(this.btnPub_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(640, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 67);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 333);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(btnPub);
            this.Controls.Add(btnSub);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public static System.Windows.Forms.Button btnSub;
        public static System.Windows.Forms.Button btnPub;
        private System.Windows.Forms.Button btnExit;
    }
}