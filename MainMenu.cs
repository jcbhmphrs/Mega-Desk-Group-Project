using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using System.IO;

namespace Mega_Desk_Group_Project
{
    public partial class MainMenu : Form
    {
        public List<DeskQuote> deskQuoteList = new List<DeskQuote>();


        public MainMenu()
        {
            InitializeComponent();
            var savedQuotes = File.ReadAllLines("AllQuotes.json");
            foreach (var quote in savedQuotes)
            {
                DeskQuote quoteObj = JsonConvert.DeserializeObject<DeskQuote>(quote);
                deskQuoteList.Add(quoteObj);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote(this);
            addQuote.Show();
            this.Hide();
        }




        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes(this, deskQuoteList);
            viewAllQuotes.Show();
            this.Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes(this, deskQuoteList);
            searchQuotes.Show();
            this.Hide();
        }
    }
}
