using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WaterSort
{
    public partial class FirstLevel : Form
    {
        private const int DropsBlueCount = 4;
        private const int DropsGreenCount = 4;
        private const int FlasksCount = 4;

        private List<Water> _dropsBlue = new List<Water>(DropsBlueCount);
        private List<Water> _dropsGreen = new List<Water>(DropsGreenCount);
        private List<Water> _allDrops = new List<Water>(DropsGreenCount + DropsBlueCount);

        private GroupBox[] _flasks;
        public FirstLevel()
        {
            InitializeComponent();

            _flasks = new GroupBox[] { Flask1, Flask2, Flask3, Flask4, };

            InitializeDrops(_dropsBlue, Color.Blue);
            InitializeDrops(_dropsGreen, Color.Green);

            _allDrops = AllDrops(_dropsBlue, _dropsGreen);

            FillDrops(_allDrops, DropsBlueCount + DropsGreenCount, _flasks);

            Drag();
        }
        private void Drag()
        {
            foreach (var drop in _allDrops)
                drop.Drop.MouseDown += new MouseEventHandler(label_MouseDown);

            foreach(var flask in _flasks)
            {
                flask.AllowDrop = true;
                flask.DragEnter += new DragEventHandler(label_DragEnter);
                flask.DragDrop += new DragEventHandler(label_DragDrop);
            }
                

            /*label1.MouseDown += new MouseEventHandler(label_MouseDown);
            _flasks[0].AllowDrop = true;
            _flasks[0].DragEnter += new DragEventHandler(label_DragEnter);
            _flasks[0].DragDrop += new DragEventHandler(label_DragDrop);*/
        }
        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            Label label= sender as Label;
            label.DoDragDrop(sender, DragDropEffects.Move);
        }
        private void label_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void label_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.Label", true))
            {
                var label = (Label)e.Data.GetData("System.Windows.Forms.Label");
                label.Visible = true;
                GroupBox groupBox = sender as GroupBox;
                groupBox.Controls.Add(label);

            }
        }
        private List<Water> AllDrops(List<Water> blueDrops, List<Water> greenDrops)
        {
            List<Water> result = new List<Water>();

            result.AddRange(blueDrops);
            result.AddRange(greenDrops);

            return result;
        }
        private void InitializeDrops(List<Water> drops, Color dropsColor)
        {
            for(int i = 0; i < drops.Capacity; i++)
            {
                Water water = new Water(dropsColor);
                drops.Add(water);
            }
        }
        private void FillDrops(List<Water> drops, int dropsCount, GroupBox[] flasks)
        {
            
            Random random = new Random();

            foreach(var water in drops)
            {
                var randomFlask = random.Next(0, FlasksCount);
                if (flasks[randomFlask].Controls.Count < 4)
                    flasks[randomFlask].Controls.Add(water.Drop);
                else
                    continue;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Owner.Close();
            Close();
        }

        private void FirstLevel_Load(object sender, EventArgs e)
        {

        }

        private void FlaskCount(object sender, EventArgs e)
        {
            GroupBox groupBox = sender as GroupBox;
            MessageBox.Show(groupBox.Controls.Count.ToString());
            //Do();
        }
    }
}
