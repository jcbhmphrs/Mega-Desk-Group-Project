using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Desk_Group_Project
{
    public class DeskQuote
    {
        public DateTime Date { get; set; }
        public string CustomerName { get; set; }
        public string RushOrder { get; set; }
        public Desk Desk { get; set; }
        public string Price { get; set; }


        public DeskQuote(Desk desk, string customerName, string rushOrder, DateTime timeOfCreation)
        {
            Desk = desk;
            CustomerName = customerName;
            RushOrder = rushOrder;
            Date = timeOfCreation;
            GetPrice();
        }

        public decimal[] GetPrice()
        {
            const decimal BASE_COST = 200.00M;
            const decimal PRICE_PER_INCH = 1.00M;
            const decimal DRAWER_COST = 50.00M;
            

            decimal[] breakDown = new decimal[6];
            int rushIndex = (Desk.Width * Desk.Depth) < 1000 ? 0 : (Desk.Width * Desk.Depth) < 2000 ? 1 : 2;
            decimal SACost = (Desk.Width * Desk.Depth) > 1000 ? ((Desk.Width * Desk.Depth) - 1000) * PRICE_PER_INCH : 0;

            //base cost
            breakDown[0] = BASE_COST;
            //cost for drawers
            breakDown[1] = (Desk.DrawerCount * DRAWER_COST);
            //cost for desk materials 
            breakDown[2] = materialCost[Desk.Material];
            //cost for shipping
            breakDown[3] = shippingCost[RushOrder][rushIndex];
            //extra surface area cost
            breakDown[4] = SACost;
            //total price
            breakDown[5] = breakDown.Sum();

            Price = breakDown[5].ToString();

            return breakDown;
        }

        private Dictionary<string, decimal> materialCost = new Dictionary<string, decimal>()
        {
            {"Oak",      200},
            {"Laminate", 100},
            {"Pine",     50},
            {"Rosewood", 300},
            {"Veneer",   125}
        };

        private Dictionary<string, decimal[]> shippingCost = new Dictionary<string, decimal[]>()
        {
            {"3 Days", new decimal[] {60,70,80} },
            {"5 Days", new decimal[] {40,50,60} },
            {"7 Days", new decimal[] {30,35,40} },
            {"No Rush (14 Days)", new decimal[] {0,0,0} },
        };




    }
}
