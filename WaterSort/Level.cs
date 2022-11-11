using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WaterSort
{
    public interface ILevel
    {
        void AddDragLogic();

        void label_MouseDown(object sender, MouseEventArgs e);

        void label_DragEnter(object sender, DragEventArgs e);

        void label_DragDrop(object sender, DragEventArgs e);

        //List<Water> AllDrops(List<Water> blueDrops, List<Water> greenDrops);
        List<Water> AllDrops(params List<Water>[] drops);

        void InitializeDrops(List<Water> drops, Color dropsColor);

        void FillDrops(List<Water> drops, GroupBox[] flasks);

        void ExitButton_Click(object sender, EventArgs e);

        void CheckFilledFlask();

        void CheckWin();

        void WinGame();

        void QuitGame();
    }
}
