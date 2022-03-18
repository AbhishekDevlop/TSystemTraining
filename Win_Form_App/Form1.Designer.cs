namespace Win_Form_App
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
            this.labUId = new System.Windows.Forms.Label();
            this.txtUId = new System.Windows.Forms.TextBox();
            this.labPass = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labUId
            // 
            this.labUId.AutoSize = true;
            this.labUId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUId.Location = new System.Drawing.Point(211, 101);
            this.labUId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUId.Name = "labUId";
            this.labUId.Size = new System.Drawing.Size(70, 20);
            this.labUId.TabIndex = 0;
            this.labUId.Text = "User Id";
            // 
            // txtUId
            // 
            this.txtUId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUId.Location = new System.Drawing.Point(301, 97);
            this.txtUId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUId.Name = "txtUId";
            this.txtUId.Size = new System.Drawing.Size(229, 24);
            this.txtUId.TabIndex = 1;
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPass.Location = new System.Drawing.Point(184, 156);
            this.labPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(91, 20);
            this.labPass.TabIndex = 2;
            this.labPass.Text = "Password";
            // 
            // textPass
            // 
            this.textPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.Location = new System.Drawing.Point(301, 155);
            this.textPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(229, 24);
            this.textPass.TabIndex = 3;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(301, 218);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(95, 30);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.Location = new System.Drawing.Point(429, 218);
            this.btnClr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(103, 30);
            this.btnClr.TabIndex = 5;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 593);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.txtUId);
            this.Controls.Add(this.labUId);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Log In Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUId;
        private System.Windows.Forms.TextBox txtUId;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnClr;
    }
}

