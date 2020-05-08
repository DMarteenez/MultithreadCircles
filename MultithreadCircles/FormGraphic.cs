using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultithreadCircles
{
    public partial class FormGraphic : Form
    {
        bool dr = false;
        FormControl formControl;

        public FormGraphic(FormControl _formControl)
        {
            InitializeComponent();
            formControl = _formControl;
        }

        private void FormGraphic_Paint(object sender, PaintEventArgs e)
        {
            if (dr)
            {
                if(!formControl.checkBoxHide.Checked)
                    formControl.circleController.Draw(e);
            }
            else
            {
                dr = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(formControl.numericUpDownMinLife.Value > formControl.numericUpDownMaxLife.Value)
            {
                formControl.numericUpDownMinLife.Value = formControl.numericUpDownMaxLife.Value;
            }

            formControl.circleController.Tick();

            Invalidate();
        }

        private void FormGraphic_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FormGraphic_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                formControl.WindowState = FormWindowState.Minimized;
            }
            if (WindowState == FormWindowState.Normal)
            {
                formControl.WindowState = FormWindowState.Normal;
            }
        }
    }
}
