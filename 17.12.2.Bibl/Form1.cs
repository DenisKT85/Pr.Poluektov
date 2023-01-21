using System;
using System.Windows.Forms;

namespace _17._12._2.Bibl
{
    public partial class Form1 : Form
    {
       NewPerewozka newPerewozka = new NewPerewozka();
       
        public Form1()
        {
            InitializeComponent();
			
		}
        private void button1_Click(object sender, EventArgs e)
        { 
            newPerewozka.ShowDialog();
			button2_Click(sender, e);
		}

		public void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
            
        }
       
        public string GR { get; set; }
        public void Info(String Gruz)
        {
           GR = Gruz;
        }

        public void button2_Click(object sender, EventArgs e)  
        {
            int prib = 0;
            listView1.Items.Clear();
            foreach (NewPerewozka nw in newPerewozka.perewozka)
            {
                prib += (nw.PriceKlient - nw.PricePerev);
                Zapolnenie(nw);
    
                label4.Text = $"Прибыль составила {prib} рублей."; 

            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int prib = 0;
            foreach (NewPerewozka nw in newPerewozka.perewozka)
            { 
                if (nw.date >= dateTimePicker1.Value && nw.date <= dateTimePicker2.Value)
                {
                    prib += (nw.PriceKlient - nw.PricePerev);
                    Zapolnenie(nw);
                    
                }
            }
            label4.Text = $"Прибыль составила {prib} рублей.";
                          
            
        }
        public void Zapolnenie(NewPerewozka nw)
        {
            ListViewItem lst = new ListViewItem((nw.id).ToString());
            lst.SubItems.Add((nw.date).ToShortDateString());

            foreach (Kontragent k in newPerewozka.kontragent.kontragents)
            {
                if (nw.idPerevoz == k.id)
                    lst.SubItems.Add(k.Name);

            }

            lst.SubItems.Add(nw.Gruz);
            foreach (Kontragent k in newPerewozka.kontragent.kontragents)
            {
                if (nw.idKlient == k.id)
                    lst.SubItems.Add(k.Name);
            }
            foreach (Driver dr in newPerewozka.driver.drivers)
            {
                if (nw.idDriver == dr.id)
                    lst.SubItems.Add(dr.SurName);
            }
            foreach (Transport tr in newPerewozka.transport.transports)
            {
                if (nw.idTransprt == tr.id)
                    lst.SubItems.Add(tr.Nomer);
            }
            lst.SubItems.Add(nw.PriceKlient.ToString());
            lst.SubItems.Add(nw.PricePerev.ToString());
            lst.SubItems.Add((nw.PriceKlient - nw.PricePerev).ToString());
            listView1.Items.Add(lst);
        }

		private void button4_Click(object sender, EventArgs e)
		{            
            int index=-1;
   
			foreach (ListViewItem c in listView1.Items)
            {
                if (c.Checked)
                {
                   index = c.Index;
                }
            }
			newPerewozka.Redact(index);
            newPerewozka.ShowDialog();
            button2_Click(sender, e);
		}

		private void button5_Click(object sender, EventArgs e)
        {
			int index = -1;
            foreach (ListViewItem c in listView1.Items)
			{
				if (c.Checked)
				{
					index = c.Index;
				}
			}
			newPerewozka.perewozka.RemoveAt(index);
            button2_Click(sender, e);
		}
	}
}