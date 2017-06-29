using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLibrary;

namespace Example04
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void convertButton_Click(object sender, EventArgs e)
		{
			Score score = new Score();
			float gpa = score.ToGPA(scoreTextBox.Text);
			if (score.IsConvertable)
			{
				gpaLabel.Text = "GPA: " + gpa.ToString();
			}
			else
			{
				MessageBox.Show("輸入格式錯誤,請重新輸入!");
			}
		}
	}
}

/*GpaConvertor c = new GpaConvertor();
int score = 0;
float gpa = 0.0f;
bool isConvertable = int.TryParse(scoreTextBox.Text, out score);
if (!isConvertable)
{
	gpa = c.Convert(score);
	gpaLabel.Text = "GPA: " + gpa.ToString();
}
else
{
	MessageBox.Show("輸入格式錯誤,請重新輸入!");
}*/