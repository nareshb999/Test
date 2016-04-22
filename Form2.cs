using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonDesignPattern
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 formtoShow = Form1.CreateInstance();

			formtoShow.Show();
			formtoShow.Focus();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form3 formthreetoShow = new Form3();
			formthreetoShow.Show();
		}
	}
}
