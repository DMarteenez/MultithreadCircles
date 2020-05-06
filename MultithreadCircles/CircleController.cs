using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MultithreadCircles
{
    public class CircleController
    {
        private static int minTicksTillNewCircle = 10;
        private static int maxTicksTillNewCircle = 50;

        public List<MyCircle> circles = new List<MyCircle>();
        public List<Task> tasks = new List<Task>();
        Random rand = new Random();
        int ticksTillNewCircle = 0;
        public bool tickEnabled = false;
        
        FormControl formControl;

        public CircleController(FormControl _formControl)
        {
            formControl = _formControl;
        }

        public void Tick()
        {
            if (tickEnabled)
            {
                if ((ticksTillNewCircle <= 0) && (circles.Count < formControl.numericUpDownCount.Value))
                {
                    int maxPosX = formControl.formGraphic.Size.Width;
                    int maxPosY = formControl.formGraphic.Size.Height;

                    int growSpeed = rand.Next(0, 2);

                    circles.Add(new MyCircle(
                        growSpeed == 1 ? rand.Next(1, 3) : 1,
                        new PointF(rand.Next(10, maxPosX - 30), rand.Next(10, maxPosY - 30)),
                        Color.FromArgb(255, rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)),
                        rand.Next(
                            (int)formControl.numericUpDownMinLife.Value * (1000 / formControl.formGraphic.timer1.Interval),
                            (int)formControl.numericUpDownMaxLife.Value * (1000 / formControl.formGraphic.timer1.Interval)),
                        growSpeed == 1 ? 0 : rand.Next(1, 3)
                        ));

                    ticksTillNewCircle = rand.Next(minTicksTillNewCircle, maxTicksTillNewCircle);
                }
                else
                {
                    ticksTillNewCircle--;
                }

                formControl.label2.Text = circles.Count().ToString();

                if (circles.Any())
                {
                    tasks.Clear();
                    Task task;
                    foreach (var c in circles)
                    {
                        task = new Task(() => c.Update());
                        tasks.Add(task);
                        task.Start();
                    }
                    Task.WaitAll(tasks.ToArray());
                    
                }
            }
        }

        public void Draw(PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            RectangleF rect = new RectangleF();


            foreach (var c in circles)
            {
                if (c.toBeDeleted)
                {
                    pen.Color = c.color;
                    rect.Size = c.GetSize;
                    rect.Location = c.pos;
                    e.Graphics.DrawEllipse(pen, rect);
                }
                else
                {
                    brush.Color = c.color;
                    rect.Size = c.GetSize;
                    rect.Location = c.pos;
                    e.Graphics.FillEllipse(brush, rect);
                }    
            }

            DeleteMaked();
        }

        public void DeleteMaked()
        {
            circles.RemoveAll(x => x.toBeDeleted == true);
        }
    }
}
