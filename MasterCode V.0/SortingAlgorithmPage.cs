using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MasterCode_V._0
{
    public partial class SortingAlgorithmPage : Form
    {
        public SortingAlgorithmPage()
        {
            InitializeComponent();
        }

        private void ExitSortAlg_Click(object sender, EventArgs e)
        {
            MainMenu MMenu = new MainMenu();
            MMenu.Show();
            this.Close();

        }
    }
}
