using System;
using System.Drawing;
using System.Windows.Forms;

namespace Neth_Mobiles_Management_System.BaseClass
{
    public class DraggableForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public DraggableForm()
        {
            this.MouseDown += new MouseEventHandler(mouseDown_Event);
            this.MouseMove += new MouseEventHandler(mouseMove_Event);
            this.MouseUp += new MouseEventHandler(mouseUp_Event);
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
