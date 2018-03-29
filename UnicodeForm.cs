using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // loop through letters A-Z which aree 65 to 90 respectively in Unicode 
            for (Counter = 65; Counter <= 90; Counter++) ;
            // Convert the value in unicode to the letter 
            UnicodeCharacter = char.ConvertFromUtf32(Counter);
            //  display the letter withg iit's respective unicode value in the unicode 
            lstUnicode.Items.Add(UnicodeCharacter + " -> " + Counter);

        }
    }
}
