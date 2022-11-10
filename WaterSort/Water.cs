using System;
using System.Drawing;
using System.Windows.Forms;
namespace WaterSort
{
    public class Water
    {
        public Label Drop;

        private Color _color;
        

        public Water(Color color)
        { 
            _color= color;

            Drop = InitializeDrop(_color);

        }

        private Label InitializeDrop(Color color)
        {
            Label result = new Label() 
            {
                Text = "",
                BackColor = color,
                Anchor= AnchorStyles.Bottom,
                Size= new Size(50, 50),
                Dock= DockStyle.Bottom
            };

            return result;
        }
        private void Do()
        {

        }
    }
}
