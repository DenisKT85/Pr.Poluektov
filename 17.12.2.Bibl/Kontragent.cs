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
    public partial class Kontragent : Form
    {
        public List<Kontragent> kontragents = new List<Kontragent>();
        static int count;
        public int id ;
		public string Name { get; set; }
        public int INN { get; set; }
        public int KPP { get; set; }
        public string Adress { get; set; }
        
       public Kontragent(string name, int inn,int kpp, string adress)
        {
            count++;
            this.id=count;
            this.Name = name;
            this.INN = inn;
            this.KPP = kpp;
            this.Adress = adress;

        }

        public Kontragent()
        {
            InitializeComponent();
           
        }
              

        public void button1_Click(object sender, EventArgs e)
        {
           kontragents.Add(new Kontragent(textBox1.Text, int.Parse(textBox2.Text),
               int.Parse(textBox3.Text), textBox4.Text));
            foreach(Kontragent agent in kontragents)
            {
                if (agent.Name == textBox1.Text)
                MessageBox.Show($"{textBox1.Text} добавлен! id.{agent.id}");
            }
            
            Name = textBox1.Text;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            Close();
            

        }
    }
}
