namespace Example04
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.convertButton = new System.Windows.Forms.Button();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.scoreTextBox = new System.Windows.Forms.TextBox();
			this.gpaLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// convertButton
			// 
			this.convertButton.Location = new System.Drawing.Point(77, 162);
			this.convertButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(138, 45);
			this.convertButton.TabIndex = 0;
			this.convertButton.Text = "轉換為GPA";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
			// 
			// scoreLabel
			// 
			this.scoreLabel.AutoSize = true;
			this.scoreLabel.Location = new System.Drawing.Point(73, 57);
			this.scoreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(204, 24);
			this.scoreLabel.TabIndex = 1;
			this.scoreLabel.Text = "請輸入百分制原始成績:";
			this.scoreLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// scoreTextBox
			// 
			this.scoreTextBox.Location = new System.Drawing.Point(77, 102);
			this.scoreTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.scoreTextBox.Name = "scoreTextBox";
			this.scoreTextBox.Size = new System.Drawing.Size(213, 33);
			this.scoreTextBox.TabIndex = 2;
			this.scoreTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// gpaLabel
			// 
			this.gpaLabel.AutoSize = true;
			this.gpaLabel.Location = new System.Drawing.Point(309, 102);
			this.gpaLabel.Name = "gpaLabel";
			this.gpaLabel.Size = new System.Drawing.Size(52, 24);
			this.gpaLabel.TabIndex = 3;
			this.gpaLabel.Text = "GPA:";
			
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1018, 522);
			this.Controls.Add(this.gpaLabel);
			this.Controls.Add(this.scoreTextBox);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.convertButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.TextBox scoreTextBox;
		private System.Windows.Forms.Label gpaLabel;
	}
}

