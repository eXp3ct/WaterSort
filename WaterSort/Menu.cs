using System;
using System.Windows.Forms;

namespace WaterSort
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void FristLevel_Click(object sender, EventArgs e)
        {
            FirstLevel firstLevel = new FirstLevel();
            firstLevel.Show(this);
            Hide();
        }
    }
}
