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
	public partial class Form1 : Form
	{
		private Form1()
		{
			InitializeComponent();
		}

		public static volatile Form1 forminstance;

		public static Form1 CreateInstance()
		{
			//private static object lockingObject = new object();
			if (forminstance == null)
			{
	//			lock (lockingObject)
	//{
		if (forminstance == null)
	{

				forminstance = new Form1();
			}
//}
}

			return forminstance;

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		//public static Form1 CreateInstance()
		//{
		//	private 
		//}
	}
}
