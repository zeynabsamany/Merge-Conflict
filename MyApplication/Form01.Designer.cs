﻿
namespace MyApplication
{
	partial class Form01
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
            this.test2Button = new System.Windows.Forms.Button();
            this.test2Label = new System.Windows.Forms.Label();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // test2Button
            // 
            this.test2Button.Location = new System.Drawing.Point(130, 34);
            this.test2Button.Name = "test2Button";
            this.test2Button.Size = new System.Drawing.Size(100, 35);
            this.test2Button.TabIndex = 0;
            this.test2Button.Text = "click here";
            this.test2Button.UseVisualStyleBackColor = true;
            // 
            // test2Label
            // 
            this.test2Label.AutoSize = true;
            this.test2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.test2Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.test2Label.Location = new System.Drawing.Point(12, 9);
            this.test2Label.Name = "test2Label";
            this.test2Label.Size = new System.Drawing.Size(112, 17);
            this.test2Label.TabIndex = 1;
            this.test2Label.Text = "zeinab samani";
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(130, 6);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(492, 22);
            this.test2TextBox.TabIndex = 2;
            // 
            // Form01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test2Label);
            this.Controls.Add(this.test2Button);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form01";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button test2Button;
        private System.Windows.Forms.Label test2Label;
        private System.Windows.Forms.TextBox test2TextBox;
    }
}