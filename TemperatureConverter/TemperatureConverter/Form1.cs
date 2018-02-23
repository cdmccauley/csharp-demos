using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton senderObject = sender as RadioButton;

            if (senderObject != null)
                switch (senderObject.Name)
                {
                    case "fahrenheitRadioButton":
                        outputLabel.Text = String.Format("{0}", 
                            Math.Round((9M / 5M) * Decimal.Parse(inputTextBox.Text) + 32M, 2));
                        break;
                    case "celsiusRadioButton":
                        outputLabel.Text = String.Format("{0}", 
                            Math.Round((5M / 9M) * (Decimal.Parse(inputTextBox.Text) - 32M), 2));
                        break;
                    default:
                        break;
                }
        }
    }
}
