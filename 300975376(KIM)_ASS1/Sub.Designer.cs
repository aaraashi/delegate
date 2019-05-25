namespace _300975376_Kim_ASS1
{
    partial class Sub
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
            this.btnSub = new System.Windows.Forms.Button();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.checkMobile = new System.Windows.Forms.CheckBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textMobile = new System.Windows.Forms.TextBox();
            this.btnUnsub = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblValEmail = new System.Windows.Forms.Label();
            this.lblValMobile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(131, 288);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(123, 35);
            this.btnSub.TabIndex = 0;
            this.btnSub.Text = "Subscribe";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Location = new System.Drawing.Point(131, 90);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(201, 24);
            this.checkEmail.TabIndex = 1;
            this.checkEmail.Text = "Message Sent by Email";
            this.checkEmail.UseVisualStyleBackColor = true;
            // 
            // checkMobile
            // 
            this.checkMobile.AutoSize = true;
            this.checkMobile.Location = new System.Drawing.Point(131, 177);
            this.checkMobile.Name = "checkMobile";
            this.checkMobile.Size = new System.Drawing.Size(208, 24);
            this.checkMobile.TabIndex = 2;
            this.checkMobile.Text = "Message Sent by Mobile";
            this.checkMobile.UseVisualStyleBackColor = true;
            // 
            // textEmail
            // 
            this.textEmail.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textEmail.Location = new System.Drawing.Point(378, 90);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(276, 30);
            this.textEmail.TabIndex = 3;
            this.textEmail.Text = "ex) XXX@XXX.XXX";
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            // 
            // textMobile
            // 
            this.textMobile.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textMobile.Location = new System.Drawing.Point(378, 173);
            this.textMobile.Multiline = true;
            this.textMobile.Name = "textMobile";
            this.textMobile.Size = new System.Drawing.Size(276, 30);
            this.textMobile.TabIndex = 4;
            this.textMobile.Text = "ex) XXX-XXX-XXXX";
            this.textMobile.Enter += new System.EventHandler(this.textMobile_Enter);
            // 
            // btnUnsub
            // 
            this.btnUnsub.Location = new System.Drawing.Point(325, 288);
            this.btnUnsub.Name = "btnUnsub";
            this.btnUnsub.Size = new System.Drawing.Size(136, 35);
            this.btnUnsub.TabIndex = 5;
            this.btnUnsub.Text = "Unsubscribe";
            this.btnUnsub.UseVisualStyleBackColor = true;
            this.btnUnsub.Click += new System.EventHandler(this.btnUnsub_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(543, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblValEmail
            // 
            this.lblValEmail.AutoSize = true;
            this.lblValEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblValEmail.Location = new System.Drawing.Point(378, 127);
            this.lblValEmail.Name = "lblValEmail";
            this.lblValEmail.Size = new System.Drawing.Size(0, 20);
            this.lblValEmail.TabIndex = 7;
            // 
            // lblValMobile
            // 
            this.lblValMobile.AutoSize = true;
            this.lblValMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblValMobile.Location = new System.Drawing.Point(378, 210);
            this.lblValMobile.Name = "lblValMobile";
            this.lblValMobile.Size = new System.Drawing.Size(0, 20);
            this.lblValMobile.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(137, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "- If you click Cancel, your data will be saved and go back to the first step.";
            // 
            // Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValMobile);
            this.Controls.Add(this.lblValEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnsub);
            this.Controls.Add(this.textMobile);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.checkMobile);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.btnSub);
            this.Name = "Sub";
            this.Text = "Manage Subscription";
            this.Load += new System.EventHandler(this.Sub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.CheckBox checkMobile;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textMobile;
        private System.Windows.Forms.Button btnUnsub;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblValEmail;
        private System.Windows.Forms.Label lblValMobile;
        private System.Windows.Forms.Label label1;
    }
}