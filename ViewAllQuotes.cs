using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk_Group_Project
{
    public partial class ViewAllQuotes : Form
    {
        private MainMenu _mainMenu { get; set; }
        private List<DeskQuote> _quoteList { get; set; }
        public ViewAllQuotes(MainMenu mainMenu, List<DeskQuote> quoteList)
        {
            InitializeComponent();
            this.Location = mainMenu.Location;
            _mainMenu = mainMenu;
            _quoteList = quoteList;
            //dispAllQuotesBox.DataSource = _quoteList;
            SetUpDisplay(_quoteList);
        }

        private void SetUpDisplay(List<DeskQuote> quoteList) 
        {
            // Create a loop that pulls the info from
            // each object of the list.
            foreach (DeskQuote quote in quoteList) 
            {
                // Compile the object data into string.
                string fullQuote = $"{quote.Date.ToShortDateString()} {quote.CustomerName} | Width = {quote.Desk.Width} Depth = {quote.Desk.Depth} Drawers = {quote.Desk.DrawerCount} | ${quote.Price}";
                
                dispAllQuotesBox.Items.Add(fullQuote);
            }
        }

   


        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Location = this.Location;
            _mainMenu.Show();
        }
    }
}
