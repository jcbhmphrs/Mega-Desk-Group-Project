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
            Location = mainMenu.Location;
            _mainMenu = mainMenu;
            _quoteList = quoteList;
            dispQuotesBox.DataSource = _quoteList;
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Location = Location;
            _mainMenu.Show();
        }      

        private void dispQuotesBox_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DeskQuote focusedObj = _quoteList[e.RowIndex];
            DisplayQuote displayQuote = new DisplayQuote(_mainMenu, this, focusedObj);
            displayQuote.Show();
            Hide();
        }
    }
}
