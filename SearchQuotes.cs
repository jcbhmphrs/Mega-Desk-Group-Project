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
    public partial class SearchQuotes : Form
    {
        private MainMenu _mainMenu { get; set; }
        private List<DeskQuote> _quoteList { get; set; }
        private List<DeskQuote> _sortedList { get; set; }

        public SearchQuotes(MainMenu mainMenu, List<DeskQuote> quoteList)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            _quoteList = quoteList;
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Location = this.Location;
            _mainMenu.Show();
        }

        private void searchQuotesSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*if (_sortedList.Count != 0) 
            {
                //clear our sorted list
                _sortedList.Clear();
            }*/

            // Convert to string.
            string keyWord = searchQuotesSelect.Text.ToString();

            //grab each quote from the master list and add it to the sorted list
            if (keyWord != null)
            {
                    foreach (DeskQuote quote in _quoteList)
                    {
                        if  (quote.Desk.Material == keyWord)
                        {
                            _sortedList.Add(quote);
                        }
                    }

                searchQuotesSelect.DataSource = _sortedList;
            }

            else 
            {
                searchQuotesSelect.DataSource = _quoteList;
            }

        }   

    }
}
