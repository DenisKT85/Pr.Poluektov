using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._12._2.Bibl
{
	public partial class Transport : Form
	{
		public List<Transport> transports = new List<Transport>();
		static int count;
		public int id { get; set; }
        public string Marka { get; set; }
		public string Nomer { get; set; }

		Transport(string marka, string nomer)
		{
			count++;
			id=count;
			Marka=marka;
			Nomer=nomer;
			
		}

		public Transport()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			transports.Add(new Transport(textBox1.Text, textBox2.Text));
			MessageBox.Show($"{textBox2.Text} добавлен");
			Marka=textBox1.Text;
			Nomer = textBox2.Text;
			Close();
			textBox1.Text = null;
			textBox2.Text = null;
        }
	}
}
