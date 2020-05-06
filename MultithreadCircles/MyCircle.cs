using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadCircles
{
    public class MyCircle
    {
        public double r = 1;
        public double rDelta = 1;
        public int growthDelayMax = 0;
        public int growthDelay = 0;
        public Color color = Color.Black;    
        public int lifeTime = 0;
        public int maxLifeTime = 100;
        public PointF pos = new PointF(0, 0);
        public bool toBeDeleted = false;

        public SizeF GetSize { get => new SizeF((float)r, (float)r); }

        public MyCircle() { }

        public MyCircle(double _rDelta, PointF _pos, Color _color, int _maxLifeTime, int _growthDelayMax)
        {
            rDelta = _rDelta;
            growthDelayMax = _growthDelayMax;
            color = _color;
            maxLifeTime = _maxLifeTime;
            pos = _pos;
        }

        public void Update()
        {
            if (toBeDeleted)
                return;

            if (lifeTime < maxLifeTime)
            {
                lifeTime += 1;
                if (growthDelay >= growthDelayMax)
                {
                    r += rDelta;
                    pos.X -= (float)rDelta / 2;
                    pos.Y -= (float)rDelta / 2;
                    growthDelay = 0;
                }
                else
                {
                    growthDelay++;
                }           
            }
            else
            {
                toBeDeleted = true;
            }
        }
    }
}
