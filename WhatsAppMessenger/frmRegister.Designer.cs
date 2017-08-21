namespace WhatsAppMessenger
{
	partial class frmRegister
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
			this.button1 = new System.Windows.Forms.Button();
			this.grbRequestCode = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.grbRequestCode.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(230, 82);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(70, 29);
			this.button1.TabIndex = 0;
			this.button1.Text = "Request";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// grbRequestCode
			// 
			this.grbRequestCode.Controls.Add(this.textBox2);
			this.grbRequestCode.Controls.Add(this.button1);
			this.grbRequestCode.Controls.Add(this.label2);
			this.grbRequestCode.Controls.Add(this.textBox1);
			this.grbRequestCode.Controls.Add(this.label1);
			this.grbRequestCode.Location = new System.Drawing.Point(12, 24);
			this.grbRequestCode.Name = "grbRequestCode";
			this.grbRequestCode.Size = new System.Drawing.Size(328, 140);
			this.grbRequestCode.TabIndex = 1;
			this.grbRequestCode.TabStop = false;
			this.grbRequestCode.Text = "Step 1: Request Code";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Phone Number: ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(108, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(108, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(192, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Full name: ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(12, 179);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 93);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Step 2: Confirm Code";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(230, 51);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(70, 29);
			this.button2.TabIndex = 0;
			this.button2.Text = "Confirm";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(108, 25);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(192, 20);
			this.textBox4.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Sms Code: ";
			// 
			// frmRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 537);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grbRequestCode);
			this.Name = "frmRegister";
			this.Text = "frmRegister";
			this.grbRequestCode.ResumeLayout(false);
			this.grbRequestCode.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox grbRequestCode;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
	}
}