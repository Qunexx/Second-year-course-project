using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MyFigures    //Пространство имен MyFigures содержит все разработанные классы графических фигур
{
    public class Location  //Родительский класс Location описывает положение центра фигур-наследников и их общие методы
    {
        protected int fX { get; set; }
        protected int fY { get; set; }        

        public void Init(int _initX, int _initY)
        {            
            fX = _initX;
            fY = _initY;            
        }

        public virtual void Move(int _newX, int _newY)
        {
            Hide();
            fX = _newX;
            fY = _newY;
            Draw();
        }

        public virtual void Hide() { }

        public virtual void Draw() { }
        public virtual int returnX()
        {
            return fX;
        }
        public virtual int returnY()
        {
            return fY;
        }
    }

    public class ColorPoint : Location  //Класс "Цветная точка" - наследник класса Location
    {
        protected Color fColor { get; set; }        //Поле "Цвет"
        protected Control fControl { get; set; }    //Поле - поверхность для рисования
        protected Color fBackColor;                 //Цвет подложки (для "стирания" фигуры)
        protected Graphics fGraph;                  //Поле - "художник" - объект, имеющий методы для рисования фигур

        public void Init(int _initX, int _initY, Color _color, Control _control)
        {
            base.Init(_initX, _initY);
            fControl = _control;
            fBackColor = fControl.BackColor;
            fGraph = fControl.CreateGraphics();
            fColor = _color;            
        }

        public override void Hide()  //Метод, перекрывающий метод родительского класса
        {
            fGraph.FillEllipse(new SolidBrush(fBackColor), fX, fY, 5, 5);  //Стереть - нарисовать цветом подложки
        }

        public override void Draw()
        {
            fGraph.FillEllipse(new SolidBrush(fColor), fX, fY, 5, 5);
        }
        
        
    }

    public class Circle : ColorPoint  //Класс "Окружность"
    {
        protected int fRadius1 { get; set; }

        public int ReturnRadius()
        {
            return fRadius1;
        }

        private Point ReturnEnd1()
        {
            Point End1 = new Point(fX, fY + fRadius1/2);
            return End1;
        }

        private Point ReturnEnd2()
        {
            Point End2 = new Point(fX+fRadius1, fY + fRadius1/2);
            return End2;
        }

        public virtual Point Center()
        {
            Point End1 = ReturnEnd1();
            Point End2 = ReturnEnd2();
            Point Center = new Point((End1.X + End2.X) / 2, (End1.Y + End2.Y) / 2);
            return Center;
            
        }

        public void Init(int _initX, int _initY, int _initR, Color _initColor, Control _initControl)
        {
            base.Init(_initX, _initY, _initColor, _initControl);
            fRadius1 = _initR;                        
        }

        public override void Hide()
        {
            fGraph.DrawEllipse(new Pen(fBackColor), fX, fY, fRadius1, fRadius1);
        }

        public override void Draw()
        {
            fGraph.DrawEllipse(new Pen(fColor), fX, fY, fRadius1, fRadius1);
        }
       
    }

    public class Ellipse : Circle  //Класс "Эллипс"
    {
        protected int fRadius2 { get; set; }

        public int ReturnB()
        {
            return fRadius2;
        }


        public override Point Center()
        {
            return new Point(fX + fRadius1 / 2, fY + fRadius2 / 2);
        }

        public void Init(int _initX, int _initY, int _initR, int _initR2, Color _initColor, Control _initControl)
        {
            base.Init(_initX, _initY, _initR, _initColor, _initControl);
            fRadius2 = _initR2;
        }

        public override void Hide()
        {
            fGraph.DrawEllipse(new Pen(fBackColor), fX, fY, fRadius1, fRadius2);
        }

        public override void Draw()
        {
            fGraph.DrawEllipse(new Pen(fColor), fX, fY, fRadius1, fRadius2);
        }

        public List<Point> GetLocation()
        {
            int dotCenterX = fX + fRadius1 / 2;
            int dotCenterY = fY + fRadius2 / 2;
            int UpDotCenterX = dotCenterX;
            int UpDotCenterY = dotCenterY;
            int DownDotCenterX = dotCenterX;
            int DownDotCenterY = dotCenterY;
            List<Point> location = new List<Point>();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    location.Add(new Point(UpDotCenterX + i, UpDotCenterY + j));
                }
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    location.Add(new Point(UpDotCenterX - i, UpDotCenterY - j));
                }
            }
            return location;
        }

    }

    public class Line : ColorPoint    //Класс "Линия"
    {
        //Первая точка линии - начало линии
        protected int fX1 { get; set; }
        protected int fY1 { get; set; }

        //Вторая точка линии - конец линии
        protected int fX2 { get; set; }
        protected int fY2 { get; set; }

        public Point PointStart ()
        {
            return new Point(fX1, fY1);
        }
        public Point PointEnd()
        {
            return new Point(fX2, fY2);
        }

        public void Init(int _initX, int _initY, int X1, int Y1, Color color, Control control)
        {
            base.Init(_initX, _initY, color, control);
            fX1 = _initX;
            fY1 = _initY;
            fX2 = X1 + Math.Abs(X1 - _initX);
            fY2 = Y1 + Math.Abs(Y1 - _initY);
        }

        public override void Hide()
        {
            fGraph.DrawLine(new Pen(fBackColor), fX1, fY1, fX2, fY2);
        }

        public override void Draw()
        {
            int DX, DY; //Половины длины линии по осям координат            

            //Вычисляем половины длины линии по осям координат (Координаты центра уже другие)
            DX = (fX2 - fX1) / 2;
            DY = (fY2 - fY1) / 2;

            //Вычисляем координаты начала и конца линии
            fX1 = fX - DX;
            fY1 = fY - DY;
            fX2 = fX + DX;
            fY2 = fY + DY;

            fGraph.DrawLine(new Pen(fColor), fX1, fY1, fX2, fY2);
        }

        public List<Point> GetLocation()
        {
            List<Point> location = new List<Point>();
            if (fX1>fX2)
            {
                for(int i = 0; fX1!=fX2; i++)
                {
                    location.Add(new Point(fX1 - i, fY1));
                    fX1--;
                }
            }
            else if (fX1 < fX2)
                {
                    for (int i = 0; fX1 != fX2; i++)
                    {
                        location.Add(new Point(fX1 + i, fY1));
                        fX1++;
                    }
                }

            if (fY1 > fY2)
            {
                for (int i = 0; fY1 != fY2; i++)
                {
                    location.Add(new Point(fX1, fY1-i));
                    fY1--;
                }
            }
            else if (fY1 < fY2)
            {
                for (int i = 0; fY1 != fY2; i++)
                {
                    location.Add(new Point(fX1, fY1+i));
                    fY1++;
                }
            }

            return location;

        }

    }

    public class Triangle : Line    //Класс "Треугольник"
    {
        //Третья вершина треугольника
        /*protected int fX3 { get; set; }
        protected int fY3 { get; set; }*/

        private int fX3, fY3;
        public Point Point1 => ReturnPoint1();
        public Point Point2 => ReturnPoint2();
        public Point Point3 => ReturnPoint3();

        public Point ReturnPoint1()
        {
            return new Point(fX1, fY1);
        }

        public Point ReturnPoint2()
        {
            return new Point(fX2, fY2);
        }

        public Point ReturnPoint3()
        {
            return new Point(fX3, fY3);
        }

        public void Init(int X1, int Y1, int X2, int Y2, int X3, int Y3, Color color, Control control) {
            //Вычисление координат центра масс треугольника - центр треугольника
            fX = (X1 + X2 + X3) / 3;
            fY = (Y1 + Y2 + Y3) / 3;
            fX1 = X1;   fY1 = Y1;
            fX2 = X2;   fY2 = Y2;
            fX3 = X3;   fY3 = Y3;
            base.Init(fX, fY, color, control);
        }

        public override void Hide() {
            //int DX, DY;
            PointF[] fPoint = new PointF[3];
            
            fPoint[0] = new PointF(fX1, fY1);
            fPoint[1] = new PointF(fX2, fY2);
            fPoint[2] = new PointF(fX3, fY3);
            //Для рисования фигуры используем метод рисования многоугольника - Polygon
            fGraph.DrawPolygon(new Pen(fBackColor), fPoint);
        }

        public override void Draw()
        {
            int DX, DY;
            PointF[] fPoint = new PointF[3];
            //Центр треугольника уже м.б. перемещен 
            //Вычисление сдвигов координат прежнего центра масс треугольника
            DX = fX - ((fX1 + fX2 + fX3) / 3);
            DY = fY - ((fY1 + fY2 + fY3) / 3);
            //Сдигаем все точки треугольника
            fX1 = fX1 + DX;
            fY1 = fY1 + DY;
            fX2 = fX2 + DX;
            fY2 = fY2 + DY;
            fX3 = fX3 + DX;
            fY3 = fY3 + DY;

            fPoint[0] = new PointF(fX1, fY1);
            fPoint[1] = new PointF(fX2, fY2);
            fPoint[2] = new PointF(fX3, fY3);

            fGraph.DrawPolygon(new Pen(fColor), fPoint);
        }
    }

    public class Rectangle : Triangle   //Класс "Прямоугольник"
    {
        protected int fWidth { get; set; }
        protected int fHeight { get; set; }

        public int ReturnWidth()
        {
            return fWidth;
        }

        public int ReturnHeight()
        {
            return fHeight;
        }
        public void Init(int _initX, int _initY, int _initW, int _initH, Color color, Control control)
        {
            base.Init(_initX, _initY, color, control);
            fWidth = _initW;
            fHeight = _initH;
        }

   

        public override void Hide()
        {
            fGraph.DrawRectangle(new Pen(fBackColor), fX, fY, fWidth, fHeight);
        }

        public override void Draw()
        {
            fGraph.DrawRectangle(new Pen(fColor), fX, fY, fWidth, fHeight);
        }
    }
    
}
