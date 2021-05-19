using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Sulav
{
    public partial class AddQuote : Form
    {
        private Form _MainMenu;
      
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _MainMenu = mainMenu;

            this.numericDepth.Minimum = Desk.MIN_DEPTH;
            this.numericDepth.Maximum = Desk.MIN_DEPTH;

            this.numericWidth.Minimum = Desk.MIN_WIDTH;
            this.numericWidth.Maximum = Desk.MAX_WIDTH;

            this.numericDrawer.Minimum = Desk.MIN_DESK_DRAWERS;
            this.numericDrawer.Maximum = Desk.MAX_DESK_DRAWERS;


        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
            this.Hide();
        }

        private void exitAddQuote_Click(object sender, EventArgs e)
        {
            //((MainMenu)this.Tag).Show();
            _MainMenu.Show();
            this.Hide();
        }
    }
}
