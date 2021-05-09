using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterCode_V._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitMainMen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SortAlgButton_Click(object sender, EventArgs e)
        {
            SortingAlgorithmPage SortPage = new SortingAlgorithmPage();
            SortPage.Show();
            this.Hide();
        }
    }
}
