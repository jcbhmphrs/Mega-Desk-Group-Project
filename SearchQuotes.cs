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
        private List<DeskQuote> _sortedList = new List<DeskQuote>();


        public SearchQuotes(MainMenu mainMenu, List<DeskQuote> quoteList)
        {
            InitializeComponent();
            Location = mainMenu.Location;
            _mainMenu = mainMenu;
            _quoteList = quoteList;
            dispQuotesBox.DataSource = _quoteList;
        }


        private void searchQuotesSelect_DropDownClosed(object sender, EventArgs e)
        {
            //clear our datasource
            dispQuotesBox.DataSource = null;
            //clear our previous selected list
            _sortedList.Clear();


            // FOR CHRIS --  Try Catch on null selections very specific maybe never used line of code


            // Convert to string.
            string keyword = filterSelection.SelectedItem.ToString();

            //grab each quote from the master list and add it to the sorted list
            
            foreach (DeskQuote quote in _quoteList)
            {
                if (quote.Desk.Material == keyword)
                {
                    _sortedList.Add(quote);
                }
             }
       
             dispQuotesBox.DataSource = _sortedList;         
        }



        private void dispQuotesBox_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            DeskQuote focusedObj = dispQuotesBox.DataSource == _sortedList ? _sortedList[e.RowIndex] : _quoteList[e.RowIndex];
            DisplayQuote displayQuote = new DisplayQuote(_mainMenu, this, focusedObj);
            displayQuote.Show();
            this.Hide();
        }


        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Location = this.Location;
            _mainMenu.Show();
        }
    }
}
