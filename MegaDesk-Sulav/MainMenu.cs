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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            var addQuote = new AddQuote(this);
            addQuote.Show();
            this.Hide();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            var viewQuote = new ViewAllQuotes(this);
            viewQuote.Show();
            this.Hide();

        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuote = new SearchQuotes(this);
            searchQuote.Show();
            this.Hide();
        }
    }
}
