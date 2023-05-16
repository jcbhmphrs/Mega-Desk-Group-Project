using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Mega_Desk_Group_Project
{
    public partial class AddQuote : Form
    {
        private MainMenu _mainMenu;
        

        public AddQuote(MainMenu mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            this.Location = mainMenu.Location;                    
        }


        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk(deskMaterial.Text, int.Parse(deskWidth.Text), int.Parse(deskDepth.Text), int.Parse(deskDrawerCount.Text));
            DeskQuote deskQuote = new DeskQuote(desk, customerName.Text.ToUpper(), rushOrder.Text);

            //add object to list
            _mainMenu.deskQuoteList.Add(deskQuote);

            //Save DeskQuote to Json file
            SaveToJson(deskQuote);
            
            DisplayQuote displayQuote = new DisplayQuote(_mainMenu, this, deskQuote);
            displayQuote.Show();
            this.Hide();
        }




        public void SaveToJson(DeskQuote deskQuote)
        {        
            using (StreamWriter file = new StreamWriter("AllQuotes.json"))
            {
                foreach(DeskQuote quote in _mainMenu.deskQuoteList)
                {
                    var serializedQuote = JsonConvert.SerializeObject(quote);
                    file.WriteLine(serializedQuote);
                }
            }
        }




        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void customerName_Enter(object sender, EventArgs e)
        {
            if(customerName.Text != null)
            {
                int stringLength = customerName.Text.Length;
                customerName.SelectionLength = stringLength;
            }
        }

    }
}
