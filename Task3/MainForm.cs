using System;
using System.Windows.Forms;

namespace Task3
{
    public partial class MainForm : SearchForm
    { 
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "MainForm";
        }

        private void replacingButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.action = (search, replace) => mainTextBox.Text = mainTextBox.Text.Replace(search, replace);
            searchForm.ShowDialog();
        }
    }
}
