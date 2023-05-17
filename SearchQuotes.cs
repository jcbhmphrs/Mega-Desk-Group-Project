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
        public SearchQuotes(MainMenu mainMenu, List<DeskQuote> quoteList)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            _quoteList = quoteList;

        }
    }
}
