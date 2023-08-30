using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFigures
{
    class EllipseInRectangle : Rectangle // 4й вариант, класс эллипс в прямоугольнинке
    {

        public List<Point> Location => GetLocation();

        public void Init(int _initX, int _initY, int _initW, int _initH, Color color, Control control)
        {
            base.Init(_initX, _initY, color, control);
            fWidth = _initW;
            fHeight = _initH;
        }

        public override void Draw()
        {
            int dotCenterX = fX + fWidth / 2;
            int dotCenterY = fY + fHeight / 2;
            fGraph.DrawRectangle(new Pen(fColor), fX, fY, fWidth, fHeight);
            fGraph.DrawEllipse(new Pen(fColor), this.fX, this.fY, fWidth, fHeight);  
            
        }


        public override void Hide()
        {
            int dotCenterX = fX + fWidth / 2;
            int dotCenterY = fY + fHeight / 2;
            fGraph.DrawRectangle(new Pen(fBackColor), fX, fY, fWidth, fHeight);
            fGraph.DrawEllipse(new Pen(fBackColor), fX, fY, fWidth, fHeight);
        }

        public List<Point> GetLocation()
        {
            Point leftUpCorner = new Point(fX, fY);
            Point _leftUpCorner = new Point(fX, fY);
            Point rightDownCorner = new Point(fX+fWidth, fY+fHeight);
            List<Point> location = new List<Point>();

            while (leftUpCorner != rightDownCorner)
            {
                while (leftUpCorner.Y != rightDownCorner.Y)
                {
                    location.Add(new Point(leftUpCorner.X, leftUpCorner.Y));
                    leftUpCorner.Y++;
                }

                if (leftUpCorner.Y == rightDownCorner.Y && leftUpCorner.X != rightDownCorner.X)
                {
                    leftUpCorner.X++;
                    leftUpCorner.Y = _leftUpCorner.Y;
                }
            }

            return location;
        }


    }
}
