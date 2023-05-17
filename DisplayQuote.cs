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
    public partial class DisplayQuote : Form
    {
        MainMenu _mainMenu { get; set; }    
        AddQuote _addQuote { get; set; }
        ViewAllQuotes _viewAllQuotes { get; set; }
        Form _parentForm { get; set; }
        Desk _desk { get; set; }
        string _rushOrder { get; set; }


        public DisplayQuote(MainMenu mainmenu, Form parentForm, DeskQuote deskQuote)
        {
            InitializeComponent();
            this.Location = parentForm.Location;
            _mainMenu = mainmenu;
            _desk = deskQuote.Desk;
            _addQuote = parentForm as AddQuote;
            _viewAllQuotes = parentForm as ViewAllQuotes;
            dispCustomerName.Text = deskQuote.CustomerName;
            _rushOrder = deskQuote.RushOrder;
            decimal[] breakDown = deskQuote.GetPrice();
            _parentForm = parentForm;

            dispDate.Text = DateTime.Now.ToShortDateString();
            dispBaseCost.Text = $"${breakDown[0].ToString()}";
            dispDrawersCost.Text = $"${breakDown[1].ToString()}";
            dispMaterialCost.Text = $"${breakDown[2].ToString()}";
            dispDeliveryCost.Text = $"${breakDown[3].ToString()}";
            dispExtraSACost.Text = $"${breakDown[4].ToString()}";
            dispTotalCost.Text = $"${breakDown[5].ToString()}";
        }

        

       

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Location = this.Location;
            _parentForm.Location = this.Location;
            if(_parentForm is ViewAllQuotes)
            {                      
                _parentForm.Show();
                return;
            }
            _mainMenu.Show();
            _parentForm.Close();
        }
    }
}
