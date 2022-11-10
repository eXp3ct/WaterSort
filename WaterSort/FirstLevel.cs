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

            AddDragLogic();
            
        }
        private void AddDragLogic()
        {
            foreach (var drop in _allDrops)
                drop.Drop.MouseDown += new MouseEventHandler(label_MouseDown);

            foreach(var flask in _flasks)
            {
                flask.AllowDrop = true;
                flask.DragEnter += new DragEventHandler(label_DragEnter);
                flask.DragDrop += new DragEventHandler(label_DragDrop);
            }
                
        }
        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            //CountLabelsInFlask();

            Label label = sender as Label;
            //label.DoDragDrop(sender, DragDropEffects.Move);
            GroupBox flask;
            if (label.Parent.Name == nameof(Flask1) || label.Parent.Name == nameof(Flask2) ||
                label.Parent.Name == nameof(Flask3) || label.Parent.Name == nameof(Flask4))
            {
                flask = (GroupBox)label.Parent;

                List<Water> dropInFlask = new List<Water>(4);

                foreach (var drop in _allDrops)
                {
                    if (flask.Controls.Contains(drop.Drop))
                    {
                        dropInFlask.Add(drop);
                    }
                }

                for (int i = 0; i < dropInFlask.Count - 1; i++)
                {
                    if (dropInFlask[i].Drop.BackColor == dropInFlask[i + 1].Drop.BackColor)
                    {
                        dropInFlask[i].Drop.DoDragDrop(dropInFlask[i].Drop, DragDropEffects.Move);
                        dropInFlask[i + 1].Drop.DoDragDrop(dropInFlask[i + 1].Drop, DragDropEffects.Move);

                        //MessageBox.Show("Drag Two");
                    }
                    else
                    {
                        break;
                        
                        //MessageBox.Show("Drag One");
                    }
                }
                label.DoDragDrop(label, DragDropEffects.Move);
            }

            
            /*_allDrops[0].Drop.DoDragDrop(_allDrops[0].Drop, DragDropEffects.Move);
            _allDrops[1].Drop.DoDragDrop(_allDrops[1].Drop, DragDropEffects.Move);*/



        }
        private void CountLabelsInFlask()
        {
            foreach (var flask in _flasks)
            {
                List<Water> dropInFlask = new List<Water>(4);

                foreach (var drop in _allDrops)
                {
                    if (flask.Controls.Contains(drop.Drop))
                    {
                        dropInFlask.Add(drop);
                    }
                }
                
                for(int i = 0; i < dropInFlask.Count-1; i++)
                {
                    if (dropInFlask[i].Drop.BackColor == dropInFlask[i + 1].Drop.BackColor)
                    {
                        dropInFlask[i].Drop.DoDragDrop(dropInFlask[i].Drop, DragDropEffects.Move);
                        dropInFlask[i+1].Drop.DoDragDrop(dropInFlask[i+1].Drop, DragDropEffects.Move);
                    }
                    else
                    {
                        dropInFlask[i].Drop.DoDragDrop(dropInFlask[i].Drop, DragDropEffects.Move);
                    }
                }

                //MessageBox.Show(string.Format("{0} | {1} | {2} | {3}", indices[0], indices[1], indices[2], indices[3]));
            }
        }

        private void label_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void label_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent("System.Windows.Forms.Label", false))
            {
                var label = (Label)e.Data.GetData("System.Windows.Forms.Label");
                GroupBox flask = sender as GroupBox;
                flask.Controls.Add(label);

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

            

            //MessageBox.Show(groupBox.Controls.GetChildIndex(_dropsBlue[0].Drop).ToString() +
            //groupBox.Controls.GetChildIndex(_dropsBlue[1].Drop).ToString());



        }
    }
}
