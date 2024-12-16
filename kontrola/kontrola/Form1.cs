using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string poruka = "Odaberite Yes / No / Cancel";

            string naslov = "Naslovna linija Dijaloga za poruke";

            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;

            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);
            switch (rez)

            {

                case DialogResult.Yes:

                    richTextBox1.Text = "Izabrali ste dugme YES";

                    break;

                case DialogResult.No:

                    richTextBox1.Text = "Izabrali ste dugme NO";

                    break;

                case DialogResult.Cancel:

                    richTextBox1.Text = "Izabrali ste dugme Cancel";

                    break;

            }
        }
    }
}
