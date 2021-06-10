
namespace MyApplication
{
	partial class Form06
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
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test2Label = new System.Windows.Forms.Label();
            this.test2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(130, 9);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(118, 22);
            this.test2TextBox.TabIndex = 5;
            // 
            // test2Label
            // 
            this.test2Label.AutoSize = true;
            this.test2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.test2Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.test2Label.Location = new System.Drawing.Point(12, 9);
            this.test2Label.Name = "test2Label";
            this.test2Label.Size = new System.Drawing.Size(112, 17);
            this.test2Label.TabIndex = 4;
            this.test2Label.Text = "zeinab samani";
            // 
            // test2Button
            // 
            this.test2Button.Location = new System.Drawing.Point(15, 53);
            this.test2Button.Name = "test2Button";
            this.test2Button.Size = new System.Drawing.Size(109, 36);
            this.test2Button.TabIndex = 3;
            this.test2Button.Text = "zeinab samani";
            this.test2Button.UseVisualStyleBackColor = true;
            // 
            // Form06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test2Label);
            this.Controls.Add(this.test2Button);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form06";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.Label test2Label;
        private System.Windows.Forms.Button test2Button;
    }
}