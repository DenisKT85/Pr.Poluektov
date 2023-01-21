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
	public partial class Driver : Form
	{
		public List<Driver> drivers = new List<Driver>();
		static int count;
		public int id { get; set; }
		public string SurName { get; set; }
		string Name { get; set; }
		string Otch { get; set; }
		int Passport { get; set; }
		Driver(string surName, string name, string otch, int passport)
		{
			count++;
			id = count;
			SurName=surName;
			Name=name;
			Otch=otch;
			Passport=passport;
			
		}

		public Driver()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			drivers.Add(new Driver(textBox1.Text, textBox2.Text, textBox3.Text,
				int.Parse(textBox4.Text)));
			MessageBox.Show($"{textBox1.Text} добавлен!");
			SurName = textBox1.Text;
			Close();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }
	}
}
