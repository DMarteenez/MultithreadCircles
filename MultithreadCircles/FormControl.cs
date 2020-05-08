using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace MultithreadCircles
{    
    public partial class FormControl : Form
    {
        public FormGraphic formGraphic;
        public CircleController circleController;

        public FormControl()
        {
            InitializeComponent();

            circleController = new CircleController(this);
        }

        private void FormControl_Load(object sender, EventArgs e)
        {
            formGraphic = new FormGraphic(this);
            formGraphic.Location = new Point(Location.X + 250, Location.Y);
            formGraphic.Show();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            circleController.tickEnabled = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            formGraphic.Close();
            Close();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            circleController.tickEnabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            circleController.circles.Clear();
        }

        private void FormControl_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                formGraphic.WindowState = FormWindowState.Minimized;
                buttonPause_Click(sender, e);
            }

            if (WindowState == FormWindowState.Normal)
            {
                formGraphic.WindowState = FormWindowState.Normal;
                buttonRun_Click(sender, e);
            }
        }
    }
}
