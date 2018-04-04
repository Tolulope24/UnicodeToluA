using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tolulope Adebayo
 * Created on: 04-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 UniCode
 * This program takes the CAPITAL letters from A to Z along with the corresponding Unicode value and place each in a listbox
*/
namespace UnicodeToluA
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare Variables 
            string UnicodeCharacter;
            int Counter;
            // Clear all Items from the list box
            this.lstUnicode.Items.Clear();
            // Create a For Loop to convert each number 
            for (Counter = 65; Counter <= 91; Counter++) 
            {
                // Convert the value in unicode letter
                UnicodeCharacter = char.ConvertFromUtf32(Counter);
                //Add the letters to the values to the list box
               lstUnicode.Items.Add(UnicodeCharacter + " -> " + Counter);
            }
            

        }
    }
}
