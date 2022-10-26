using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label1.Text =string .Empty;
		}

		//private string getnow()
		//{
		//	return now;
		//}

		private void button1_Click(object sender, EventArgs e)
		{
			//Button click 時, 用 Label 顯示目前系統時間及問候語
			//用MessageBox 顯示目前時間,格式為 yyyy/MM/dd HH:mm:ss

			DateTime now = DateTime.Now;
			string now1 = now.ToString();
			label1.Text = "您好\r\n"+DateTime.Now.ToString();
			MessageBox.Show("您好\r\n"+now1);
		}
	}

}
