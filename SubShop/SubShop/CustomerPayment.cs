using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubShop
{
    class CustomerPayment
    {
        // properties
        public string CardNumber { get; private set; }

        public string CardExpiration { get; private set; }

        public string CardCVV { get; private set; }

        public Dictionary<String, TextBox> GuiRefs { get; private set; }

        // constructor
        public CustomerPayment()
        {
            GuiRefs = new Dictionary<string, TextBox>();
        }

        // methods
        public void ValidateCardNumber()
        {

        }
    }
}
