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

        public void FristLevel_Click(object sender, EventArgs e)
        {
            FirstLevel firstLevel = new FirstLevel();
            firstLevel.Show(this);
            Hide();
        }

        private void SecondLevel_Click(object sender, EventArgs e)
        {
            SecondLevel secondLevel = new SecondLevel();
            secondLevel.Show(this);
            Hide();
        }

        private void ThirsLevel_Click(object sender, EventArgs e)
        {
            ThirdLevel thirdLevel = new ThirdLevel();
            thirdLevel.Show(this);
            Hide();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("сАФОНОВ мАКСИМ","Об авторе", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
