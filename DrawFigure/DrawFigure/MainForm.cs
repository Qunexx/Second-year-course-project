using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;

using MyFigures;   // Сделать доступными классы из пространства имен MyFigures

namespace DrawFigure
{
    public partial class MainForm : Form
    {
        //Объявления графических объектов
        private ColorPoint point = null;
        private Circle circle = null;
        private Ellipse ellipse = null;
        private Line line = null;
        private Triangle triangle = null;
        private MyFigures.Rectangle rectangle = null;
        private EllipseInRectangle ellipseInRectangle = null;
        private List<EllipseInRectangle> ellipseInRectangleList = new List<EllipseInRectangle>();
        private List<Circle> circleList = new List<Circle>();
        int NumberObjellipseInRectangle;
        int NumberObjCircle;
        //GraphicsPath path = new GraphicsPath();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Создание графических объектов
            point = new ColorPoint();
            circle = new Circle();
            ellipse = new Ellipse();
            line = new Line();
            triangle = new Triangle();
            rectangle = new MyFigures.Rectangle();

            ellipseInRectangle = new EllipseInRectangle();

            //Стартовые значения для элементов ввода координат            
            numericX1.Value = 10;
            numericY1.Value = 10;
            numericX2.Value = 50;
            numericY2.Value = 40;
            numericX3.Value = 100;
            numericY3.Value = 200;
            numericDX.Value = 300;
            numericDY.Value = 200;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)  //Очистка поля рисования
        {
            panelDraw.Invalidate();
        }

        private void buttonInitAll_Click(object sender, EventArgs e)  //Инициализация всех оюъектов
        {
            point.Init(50, 50, Color.Black, panelDraw);
            circle.Init(200, 200, 100, Color.Red, panelDraw);
            ellipse.Init(300, 200, 100, 200, Color.Violet, panelDraw);
            line.Init(50, 100, 100, 200, Color.Green, panelDraw);
            triangle.Init(50, 75, 40, 95, 100, 120, Color.Blue, panelDraw);
            rectangle.Init(40, 50, 100, 200, Color.Coral, panelDraw);
            ellipseInRectangle.Init(40, 50, 100, 200, Color.Coral, panelDraw);
        }

        private void buttonDrawAll_Click(object sender, EventArgs e)  //Рисование всех объектов
        {
            point.Draw();
            circle.Draw();
            ellipse.Draw();
            line.Draw();
            triangle.Draw();
            rectangle.Draw();
            ellipseInRectangle.Draw();
        }

        private void buttonMoveAll_Click(object sender, EventArgs e)  //Перемещение всех объектов
        {
            point.Move(100, 100);
            circle.Move(300, 300);
            ellipse.Move(400, 200);
            line.Move(300, 200);
            triangle.Move(56, 120);
            rectangle.Move(100, 200);
            ellipseInRectangle.Move(100, 320);
        }

        private void buttonInitFigure_Click(object sender, EventArgs e)
        {

            buttonMoveFigure.Enabled = false;
            buttonDrawFigure.Enabled = false;
            int X1, X2, X3;
            int Y1, Y2, Y3;

            if (radioButtonPoint.Checked)  //Поиск выбранной фигуры
            {
                //if (point != null)
                //{
                point = new ColorPoint();
                X1 = (int)numericX1.Value;
                    Y1 = (int)numericY1.Value;
                    point.Init(X1, Y1, Color.Red, panelDraw);
                //}
            }
            else if (radioButtonCircle.Checked)
            {
                //if (circle != null)
                //{
                    circle = new Circle();
                    X1 = (int)numericX1.Value;
                    Y1 = (int)numericY1.Value;
                    X2 = (int)numericX2.Value;
                    circle.Init(X1, Y1, X2, Color.Violet, panelDraw);
                //}
            }
            else if (radioButtonEllipse.Checked)
            {
                //if (ellipse != null)
                //{
                ellipse = new Ellipse();
                X1 = (int)numericX1.Value;
                    Y1 = (int)numericY1.Value;
                    X2 = (int)numericX2.Value;
                    Y2 = (int)numericY2.Value;
                    ellipse.Init(X1, Y1, X2, Y2, Color.Blue, panelDraw);
                //}
            }
            else if (radioButtonLine.Checked)
            {
                //if (line != null)
                //{
                line = new Line();
                X1 = (int)numericX1.Value;
                    Y1 = (int)numericY1.Value;
                    X2 = (int)numericX2.Value;
                    Y2 = (int)numericY2.Value;
                    line.Init(X1, Y1, X2, Y2, Color.Black, panelDraw);
                //}
            }
            else if (radioButtonTriangle.Checked)
            {
                //if (triangle != null)
                //{
                triangle = new Triangle();
                X1 = (int)numericX1.Value;
                    Y1 = (int)numericY1.Value;
                    X2 = (int)numericX2.Value;
                    Y2 = (int)numericY2.Value;
                    X3 = (int)numericX3.Value;
                    Y3 = (int)numericY3.Value;
                    triangle.Init(X1, Y1, X2, Y2, X3, Y3, Color.Red, panelDraw);
                //}
            }
            else if (radioButtonRectangle.Checked)
            {
                //if (rectangle != null)
                //{
                rectangle = new MyFigures.Rectangle();
                X1 = (int)numericX1.Value;
                    Y1 = (int)numericY1.Value;
                    X2 = (int)numericX2.Value;
                    Y2 = (int)numericY2.Value;
                    rectangle.Init(X1, Y1, X2, Y2, Color.Blue, panelDraw);
                //}
            }
            else if (radioButtonEnvelope.Checked)
            {
                //if (ellipseInRectangle != null)
                //{


                ellipseInRectangle = new EllipseInRectangle();
                X1 = (int)numericX1.Value;
                Y1 = (int)numericY1.Value;
                X2 = (int)numericX2.Value;
                Y2 = (int)numericY2.Value;
                ellipseInRectangle.Init(X1, Y1, X2, Y2, Color.Black, panelDraw);
                //}
            }
            else
            {
                MessageBox.Show("Укажите тип фигуры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            buttonMoveFigure.Enabled = true;
            buttonDrawFigure.Enabled = true;
        }

        private void buttonDrawFigure_Click(object sender, EventArgs e)
        {
            if (radioButtonPoint.Checked)
            {
                if (point != null)
                {
                    point.Draw();
                }
            }
            else if (radioButtonCircle.Checked)
            {
                if (circle != null)
                {
                    circle.Draw();
                    circleList.Add(circle);
                }
            }
            else if (radioButtonEllipse.Checked)
            {
                if (ellipse != null)
                {
                    ellipse.Draw();
                }
            }
            else if (radioButtonLine.Checked)
            {
                if (line != null)
                {
                    line.Draw();
                }
            }
            else if (radioButtonTriangle.Checked)
            {
                if (triangle != null)
                {
                    triangle.Draw();
                }
            }
            else if (radioButtonRectangle.Checked)
            {
                if (rectangle != null)
                {
                    rectangle.Draw();
                }
            }
            else if (radioButtonEnvelope.Checked)
            {
                if (ellipseInRectangle != null)
                {
                    ellipseInRectangle.Draw();
                    ellipseInRectangleList.Add(ellipseInRectangle);
                  //textBox1.Text = ellipseInRectangleList.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Укажите тип фигуры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonMoveFigure_Click(object sender, EventArgs e)
        {
            int newX = (int)numericDX.Value;
            int newY = (int)numericDY.Value;

            if (radioButtonPoint.Checked)
            {
                if (point != null)
                {
                    point.Move(newX, newY);
                }
            }
            else if (radioButtonCircle.Checked)
            {
                if (circle != null)
                {
                    circle.Move(newX, newY);
                }
            }
            else if (radioButtonEllipse.Checked)
            {
                if (ellipse != null)
                {
                    ellipse.Move(newX, newY);
                }
            }
            else if (radioButtonLine.Checked)
            {
                if (line != null)
                {
                    line.Move(newX, newY);
                }
            }
            else if (radioButtonTriangle.Checked)
            {
                if (triangle != null)
                {
                    triangle.Move(newX, newY);
                }
            }
            else if (radioButtonRectangle.Checked)
            {
                if (rectangle != null)
                {
                    rectangle.Move(newX, newY);
                }
            }
            else if (radioButtonEnvelope.Checked)
            {
                if (ellipseInRectangle != null)
                {
                    ellipseInRectangle.Move(newX, newY);
                }
            }
            else
            {
                MessageBox.Show("Укажите тип фигуры!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool flagForMoving = false;
        private int CoordX, CoordY;
        private string id;
        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = $"Координаты мыши: {e.Location.ToString()}";
            if (flagForMoving == true && id == "ellipseInRectangle")
            {
                ellipseInRectangleList[NumberObjellipseInRectangle].Move(e.X - CoordX, e.Y - CoordY);
            }
            else if (flagForMoving == true && id == "circle")
            {

                circle.Move(e.X - CoordX, e.Y - CoordY);
            }
            else if (flagForMoving == true && id == "ellipse")
            {
                ellipse.Move(e.X - CoordX, e.Y - CoordY);
            }
            else if (flagForMoving == true && id == "triangle")
            {
                if (e.Y > triangle.returnY())
                {
                    triangle.Move(e.X - CoordX, e.Y - CoordY);
                }
                else if (e.Y < triangle.returnY())
                {
                    triangle.Move(e.X + CoordX, e.Y + CoordY);
                }
                else triangle.Move(e.X, e.Y);
            }
            else if (flagForMoving == true && id == "rectangle")
            {
                rectangle.Move(e.X - CoordX, e.Y - CoordY);
            }
            else if (flagForMoving == true && id == "line")
            {
                line.Move(e.X /*- CoordX/20*/, e.Y /*- CoordY/20*/);
            }
            else if (flagForMoving == true && id == "point")
            {
                point.Move(e.X - CoordX, e.Y - CoordY);
            }

            

        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {

            List<Point> location; 
            
            if (flagForMoving == false) // check ellipseInRectangle
            {
                for (int i = 0; i < ellipseInRectangleList.Count; i++)
                    foreach (Point points in ellipseInRectangleList[i].Location)
                        if (e.Location == points)
                            {
                                NumberObjellipseInRectangle = i;
                                id = "ellipseInRectangle";
                                CoordX = Math.Abs(points.X - ellipseInRectangleList[NumberObjellipseInRectangle].returnX());
                                CoordY = Math.Abs(points.Y - ellipseInRectangleList[NumberObjellipseInRectangle].returnY());
                                flagForMoving = true;
                                return;
                            }
            }

            if (flagForMoving == false) // check circle
            {
                if (circle != null)
                {
                    Point center = circle.Center();
                    int radius = circle.ReturnRadius() / 2;
                    if (Math.Pow(e.X - center.X, 2) + Math.Pow(e.Y - center.Y, 2) <= Math.Pow(radius, 2))
                    {
                        CoordX = Math.Abs(circle.returnX() - e.X);
                        CoordY = Math.Abs(circle.returnY() - e.Y);
                        id = "circle";
                        flagForMoving = true;
                        return;
                    }
                }
            }

            if (flagForMoving == false) // check ellipse
            {
                if (ellipse != null)
                {
                    Point center = ellipse.Center();
                    int a = ellipse.ReturnRadius() / 2;
                    int b = ellipse.ReturnB()/2;
                    
                    if (Math.Pow(e.X - center.X,2)/(a*a) + Math.Pow(e.Y - center.Y, 2) / (b * b) <= 1)
                    {
                        CoordX = Math.Abs(ellipse.returnX() - e.X);
                        CoordY = Math.Abs(ellipse.returnY() - e.Y);
                        id = "ellipse";
                        flagForMoving = true;
                        return;
                    }
                }
            }

            if (flagForMoving == false) // check triangle
            {
                if (triangle != null)
                {
                    int point1 = (triangle.Point1.X - e.X) * (triangle.Point2.Y - triangle.Point1.Y) - (triangle.Point2.X - triangle.Point1.X) * (triangle.Point1.Y - e.Y);
                    int point2 = (triangle.Point2.X - e.X) * (triangle.Point3.Y - triangle.Point2.Y) - (triangle.Point3.X - triangle.Point2.X) * (triangle.Point2.Y - e.Y);
                    int point3 = (triangle.Point3.X - e.X) * (triangle.Point1.Y - triangle.Point3.Y) - (triangle.Point1.X - triangle.Point3.X) * (triangle.Point3.Y - e.Y);
                    if ((point1 >= 0 && point2 >= 0 && point3 >= 0) || (point1 <= 0 && point2 <=0 && point3 <= 0))
                    {
                        CoordX = Math.Abs(triangle.returnX() - e.X);
                        CoordY = Math.Abs(triangle.returnY() - e.Y);
                        id = "triangle";
                        flagForMoving = true;
                        return;
                    }
                }
            }

            if (flagForMoving == false) // check rectangle
            {
                if (rectangle != null)
                {
                    if (e.Y >= rectangle.returnY() && e.Y <= rectangle.returnY() + rectangle.ReturnHeight() && e.X >= rectangle.returnX() && e.X <= rectangle.returnX() + rectangle.ReturnWidth())
                    {
                        CoordX = Math.Abs(rectangle.returnX() - e.X);
                        CoordY = Math.Abs(rectangle.returnY() - e.Y);
                        id = "rectangle";
                        flagForMoving = true;
                        return;
                    }

                }
            }

            if (flagForMoving == false) // check point
            {
                if (point != null)
                {
                    if (Math.Pow(e.X - (point.returnX() + 2.5), 2) + Math.Pow(e.Y - (point.returnY() + 2.5), 2) <= Math.Pow(2.5, 2))
                    {
                        CoordX = Math.Abs(point.returnX() - e.X);
                        CoordY = Math.Abs(point.returnY() - e.Y);
                        id = "point";
                        flagForMoving = true;
                        return;
                    }
                }
            }

            if (flagForMoving == false) // check line
            {
                if (line != null)
                {
                    
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        if (Math.Abs((e.X - line.PointStart().X+i) * (line.PointEnd().Y - line.PointStart().Y) - (e.Y - line.PointStart().Y+j) * (line.PointEnd().X - line.PointStart().X)) < 1e-10)
                        {
                            CoordX = Math.Abs(e.X - line.PointStart().X);
                            CoordY = Math.Abs(e.Y - line.PointStart().Y);
                            id = "line";
                            flagForMoving = true;
                            return;
                        }
                    }
                }
            }

           

            

           

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
           flagForMoving = false;
        }

    }
}
