using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WaterSort
{
    public partial class ThirdLevel : Form, ILevel
    {
        private const int DropsColors = 5;

        private const int DropsBlueCount = 4;
        private const int DropsGreenCount = 4;
        private const int DropsYellowCount = 4;
        private const int DropsRedCount = 4;
        private const int DropsBlackCount = 4;

        private const int FlasksCount = 8;

        private List<Water> _dropsBlue = new List<Water>(DropsBlueCount);
        private List<Water> _dropsGreen = new List<Water>(DropsGreenCount);
        private List<Water> _dropsYellow = new List<Water>(DropsGreenCount);
        private List<Water> _dropsRed = new List<Water>(DropsRedCount);
        private List<Water> _dropsBlack = new List<Water>(DropsBlackCount);
        private List<Water> _allDrops = new List<Water>(DropsGreenCount + DropsBlueCount + DropsYellowCount +
            DropsRedCount + DropsBlackCount);

        private List<Water>[] _allDropsArray = new List<Water>[DropsColors];

        private GroupBox[] _flasks;

        private bool _flaskFilledWithBlueDrops;
        private bool _flaskFilledWithGreenDrops;
        private bool _flaskFilledWithYellowDrops;
        private bool _flaskFilledWithRedDrops;
        private bool _flaskFilledWithBlackDrops;

        private Stopwatch _stopwatch = new Stopwatch();

        public ThirdLevel()
        {
            InitializeComponent();

            _stopwatch.Start();

            _flasks = new GroupBox[FlasksCount] { Flask1, Flask2, Flask3, Flask4, Flask5, Flask6,
                Flask7 , Flask8};

            InitializeDrops(_dropsBlue, Color.Blue);
            InitializeDrops(_dropsGreen, Color.Green);
            InitializeDrops(_dropsYellow, Color.Yellow);
            InitializeDrops(_dropsRed, Color.Red);
            InitializeDrops(_dropsBlack, Color.Black);

            _allDropsArray[0] = _dropsBlue;
            _allDropsArray[1] = _dropsGreen;
            _allDropsArray[2] = _dropsYellow;
            _allDropsArray[3] = _dropsRed;
            _allDropsArray[4] = _dropsBlack;

            _allDrops = AllDrops(_allDropsArray);

            FillDrops(_allDrops, _flasks);

            AddDragLogic();
        }

        public void AddDragLogic()
        {
            foreach (var drop in _allDrops)
                drop.Drop.MouseDown += new MouseEventHandler(label_MouseDown);

            foreach (var flask in _flasks)
            {
                flask.AllowDrop = true;
                flask.DragEnter += new DragEventHandler(label_DragEnter);
                flask.DragDrop += new DragEventHandler(label_DragDrop);
            }
        }

        public List<Water> AllDrops(params List<Water>[] drops)
        {
            List<Water> result = new List<Water>();

            foreach (var drop in drops)
                result.AddRange(drop);

            return result;
        }

        public void CheckWin()
        {
            if (_flaskFilledWithBlueDrops && _flaskFilledWithGreenDrops && _flaskFilledWithYellowDrops && 
                _flaskFilledWithRedDrops && _flaskFilledWithBlackDrops)
                WinGame();
        }

        public void WinGame()
        {
            _stopwatch.Stop();
            TimeSpan timeSpan = _stopwatch.Elapsed;
            MessageBox.Show("Вы выиграли за: " + timeSpan.Seconds.ToString() + " секунд", "Победа",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Owner.Show();
            Close();
        }

        public void CheckFilledFlask()
        {
            foreach (var flask in _flasks)
            {
                List<Water> dropInFlask = new List<Water>(4);

                foreach (var drop in _allDrops)
                    if (flask.Controls.Contains(drop.Drop))
                        dropInFlask.Add(drop);

                int blueDropsInFlask = dropInFlask.Where(drop => drop.Drop.BackColor == Color.Blue).Count();
                if (blueDropsInFlask == 4)
                    _flaskFilledWithBlueDrops = true;
                int greenDropsInFlask = dropInFlask.Where(drop => drop.Drop.BackColor == Color.Green).Count();
                if(greenDropsInFlask == 4)
                    _flaskFilledWithGreenDrops = true;
                int yellowDropsInFlask = dropInFlask.Where(drop => drop.Drop.BackColor == Color.Yellow).Count();
                if (yellowDropsInFlask == 4)
                    _flaskFilledWithYellowDrops = true;
                int redDropsInFlask = dropInFlask.Where(drop => drop.Drop.BackColor == Color.Red).Count();
                if (redDropsInFlask == 4)
                    _flaskFilledWithRedDrops = true;
                int blackDropsInFlask = dropInFlask.Where(drop => drop.Drop.BackColor == Color.Black).Count();
                if (blackDropsInFlask == 4)
                    _flaskFilledWithBlackDrops = true;
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            QuitGame();
        }

        public void QuitGame()
        {
            Owner.Close();
            Close();
        }

        public void FillDrops(List<Water> drops, GroupBox[] flasks)
        {
            Random random = new Random();

            foreach (var water in drops)
            {
                var randomFlask = random.Next(0, FlasksCount);
                if (flasks[randomFlask].Controls.Count < 4)
                    flasks[randomFlask].Controls.Add(water.Drop);
                else
                    continue;
            }
        }

        public void InitializeDrops(List<Water> drops, Color dropsColor)
        {
            for (int i = 0; i < drops.Capacity; i++)
            {
                Water water = new Water(dropsColor);
                drops.Add(water);
            }
        }

        public void label_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.Label", false))
            {
                var label = (Label)e.Data.GetData("System.Windows.Forms.Label");
                GroupBox flask = sender as GroupBox;
                if (flask.Controls.Count < 4)
                    flask.Controls.Add(label);
                else
                    return;
            }

            CheckFilledFlask();
            CheckWin();

        }

        public void label_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        public void label_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            //label.DoDragDrop(sender, DragDropEffects.Move);
            GroupBox flask;
            if (label.Parent.Name == nameof(Flask1) || label.Parent.Name == nameof(Flask2) ||
                label.Parent.Name == nameof(Flask3) || label.Parent.Name == nameof(Flask4) ||
                label.Parent.Name == nameof(Flask5) || label.Parent.Name == nameof(Flask6) ||
                label.Parent.Name == nameof(Flask7) || label.Parent.Name == nameof(Flask8))
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
                    }
                    else
                    {
                        break;
                    }
                }
                label.DoDragDrop(label, DragDropEffects.Move);
            }

        }
    }
}
