﻿namespace QuanLy
{
    partial class FormLogIn
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLogName = new System.Windows.Forms.TextBox();
            this.TxtLogPass = new System.Windows.Forms.TextBox();
            this.BtLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(41, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(41, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "PassWord";
            // 
            // TxtLogName
            // 
            this.TxtLogName.Location = new System.Drawing.Point(181, 47);
            this.TxtLogName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLogName.Name = "TxtLogName";
            this.TxtLogName.Size = new System.Drawing.Size(159, 22);
            this.TxtLogName.TabIndex = 16;
            // 
            // TxtLogPass
            // 
            this.TxtLogPass.Location = new System.Drawing.Point(181, 91);
            this.TxtLogPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLogPass.Name = "TxtLogPass";
            this.TxtLogPass.PasswordChar = '*';
            this.TxtLogPass.Size = new System.Drawing.Size(159, 22);
            this.TxtLogPass.TabIndex = 17;
            // 
            // BtLog
            // 
            this.BtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtLog.Location = new System.Drawing.Point(152, 148);
            this.BtLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtLog.Name = "BtLog";
            this.BtLog.Size = new System.Drawing.Size(100, 34);
            this.BtLog.TabIndex = 18;
            this.BtLog.Text = "Log In";
            this.BtLog.UseVisualStyleBackColor = true;
            this.BtLog.Click += new System.EventHandler(this.BtLog_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::QuanLy.Properties.Resources.sai_lam_khi_quan_ly_kho_hang1_1024x674;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 215);
            this.Controls.Add(this.BtLog);
            this.Controls.Add(this.TxtLogPass);
            this.Controls.Add(this.TxtLogName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLogName;
        private System.Windows.Forms.TextBox TxtLogPass;
        private System.Windows.Forms.Button BtLog;
    }
}