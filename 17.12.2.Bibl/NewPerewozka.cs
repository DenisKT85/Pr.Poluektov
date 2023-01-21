using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _17._12._2.Bibl
{
    public partial class NewPerewozka : Form
    {
		public List<NewPerewozka> perewozka = new List<NewPerewozka>();
		static int count;
		public int id { get; set; }
		public DateTime date { get; set; }
		public int idPerevoz { get; set; }
		public int idKlient { get; set; }
		public int PriceKlient { get; set; }
		public int PricePerev { get; set; }
		public string Gruz { get; set; }
		public int idDriver { get; set; }
		public int idTransprt { get; set; }
		
		
		NewPerewozka(int  idP,DateTime date, int idK, int PK, int PP, string Gr, int idDr, int idTR )
		{
			count++;
			this.id = count;
			this.date = date;
			this.idPerevoz = idP;
			this.idKlient = idK;
			this.PriceKlient = PK;
			this.PricePerev = PP;
			this.Gruz = Gr;
			this.date = date;
			this.idDriver = idDr;
			this.idTransprt = idTR;
			
		}

		public Kontragent kontragent = new Kontragent();
        public Driver driver = new Driver();
        public Transport transport = new Transport();

        public NewPerewozka()
        {
            InitializeComponent();
			
		}
		private void NewPerewozka_Load(object sender, EventArgs e)
		{

		}
		
		private void button1_Click(object sender, EventArgs e)
        {
            kontragent.ShowDialog();
            comboBox1.Items.Add(kontragent.Name);
            
            comboBox2.Items.Add(kontragent.Name);
		}
		      

        private void button6_Click(object sender, EventArgs e)
        {
			foreach (Kontragent kontr in kontragent.kontragents)
			{
				if (comboBox1.Text== kontr.Name)
				{
					kontragent.kontragents.RemoveAt(kontr.id-1);
					MessageBox.Show($"{kontr.Name} удален");
					break;
				}
			}
			comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		
		private void button5_Click(object sender, EventArgs e)
		{
            kontragent.ShowDialog();
			comboBox1.Items.Add(kontragent.Name);
			
			comboBox2.Items.Add(kontragent.Name);
            
        }

		public void NEW_Click(object sender, EventArgs e)
        {
			int x=-1, y=-1, z=-1, w=-1;
			
            foreach (Kontragent kontr in kontragent.kontragents)
            {
				if (kontr.Name == comboBox1.Text)
				{
					x = kontr.id;
				}
				if (kontr.Name == comboBox2.Text)
				{ 
					y = kontr.id;
				}
            }
			foreach (Driver driver in driver.drivers)
			{
                if (driver.SurName == comboBox3.Text)
                {
                    z = driver.id;
                }
            }
            foreach (Transport tr in transport.transports)
            {
                if (tr.Nomer == comboBox4.Text)
                {
                    w = tr.id;
                }
            }
						
			perewozka.Add(new NewPerewozka(x, dateTimePicker1.Value, y, int.Parse(textBox3.Text), int.Parse(textBox1.Text),
				textBox2.Text, z, w));
										            
            Close();
			dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
			comboBox1.Text = null;
			comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
			textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
			
		}

		private void button7_Click(object sender, EventArgs e)
		{
            
            driver.ShowDialog();
            			
			comboBox3.Items.Add(driver.SurName);
		}

		private void button8_Click(object sender, EventArgs e)
		{
            
            transport.ShowDialog();
            comboBox4.Items.Add(transport.Nomer);
		}

		private void button9_Click(object sender, EventArgs e)
		{
            Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
            foreach (Kontragent kontr in kontragent.kontragents)
            { 
                if (comboBox1.Text== kontr.Name)
                {
                    kontragent.kontragents.RemoveAt(kontr.id-1);
					MessageBox.Show($"{kontr.Name} удален");
                    break;
				}
            }
			comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
		}
		public void Redact(int index)
		{
			foreach (Kontragent kontr in kontragent.kontragents)
			{
				if (kontr.id == perewozka[index].idPerevoz)
				{
					comboBox1.Text = kontr.Name;
				}
				if (kontr.id == perewozka[index].idKlient)
				{
					comboBox2.Text = kontr.Name;
				}
			}
			dateTimePicker1.Value = perewozka[index].date;
			textBox1.Text = perewozka[index].PricePerev.ToString();
			textBox2.Text = perewozka[index].Gruz;
			textBox3.Text = perewozka[index].PriceKlient.ToString();
			foreach (Driver driver in driver.drivers)
			{
				if (driver.id == perewozka[index].idDriver)
				{
					 comboBox3.Text = driver.SurName;
				}
			}
			foreach (Transport tr in transport.transports)
			{
				if (tr.id == perewozka[index].idTransprt)
				{
					comboBox4.Text = tr.Nomer;
				}
			}
			perewozka.RemoveAt(index);
						
		}		
	}
}
