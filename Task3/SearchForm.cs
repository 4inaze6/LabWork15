using System;
using System.Windows.Forms;

namespace Task3
{
    public partial class SearchForm: Form
    {
        public Action <string, string> action;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            action(searchTextBox.Text, replaceTextBox.Text);
        }
    }
}
