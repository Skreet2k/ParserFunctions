using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace ParserFunctions
{
    class Graph // график функции
    {
        PictureBox pb;
        public Pen graphPen;
        public Graph(PictureBox pb)
        {
            this.pb = pb;
            this.graphPen  = new Pen(Color.Blue, 2);
        }
        public void DrawArray(List<float> function) // Построение графика на picturebox;
        {
            Bitmap img;
            if (pb.Image == null) // Проверка на заполненность картинки;
            {
                img = new Bitmap(pb.Width, pb.Height);
            }
            else
            {
                img = new Bitmap(pb.Image);
            }
            Graphics g = Graphics.FromImage(img);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float dx = pb.Width / (function.Count-1); //Вычислем приращение x;
            float j = 0;
            for (int i = 0; i < function.Count-1; i++)
            {
                g.DrawLine(graphPen, new PointF(j, pb.Height*(-function[i] / function.Max() + 1)), new PointF(j + dx, pb.Height*(-function[i + 1]/function.Max() + 1))); // Заполняем точками g и нормируем по оси y;
                j += dx;
            }
            g.DrawString(function.Max() + "", new Font("Arial", 12), new SolidBrush(Color.Black), new PointF(0, 0)); // Макс значение y;
            g.DrawString("0", new Font("Arial", 12), new SolidBrush(Color.Black), new PointF(0, pb.Height-20)); // 0;
            g.DrawString(function.Count*dx + "", new Font("Arial", 12), new SolidBrush(Color.Black), new PointF(pb.Width-50, pb.Height-20)); // Макс значение x;
            pb.Image = img;
        }  
        
        public void DrawGrid()
        {
            Bitmap img;
            if (pb.Image == null)
            {
                 img = new Bitmap(pb.Width, pb.Height);
            }
            else
            {
                 img = new Bitmap(pb.Image);
            }
            Graphics g = Graphics.FromImage(img);
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Gray, 1);
            for (int i = 1; i < pb.Width; i+=20)
            {
                g.DrawLine(pen, new PointF(0, pb.Height - i), new PointF(pb.Width, pb.Height - i));
                g.DrawLine(pen, new PointF(i, 0), new PointF(i,pb.Height));
            }
            pb.Image = img;
        }

    }
}
