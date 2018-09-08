using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    abstract class Detecter
    {
        public int x { get; set; }
        public int y { get; set; }

    }
    struct PointClick
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Deplay { get; set; }
        public PointClick(int _x, int _y, int _deplay)
        {
            X = _x;
            Y = _y;
            Deplay = _deplay;
        }

    }
    class ObjectDetectByColor : Detecter
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02; private const int MOUSEEVENTF_LEFTUP = 0x04;
        public Color ColorObject { get; set; }
        public int Range { get; set; }

        public string NameObject { get; set; }

        public bool IsActive { get; set; }
        public List<PointClick> ListPoint { get; set; }
        public List<int> ListDeplay { get; set; }
        public int TimeCheck { get; set; }


        public ObjectDetectByColor(Color _color, int _range, int _x, int _y, int _time, string _Name)
        {
            ColorObject = _color;
            Range = _range;
            x = _x; y = _y;
            ListPoint = new List<PointClick>();

            TimeCheck = _time;
            NameObject = _Name;
            IsActive = true;
        }
        public bool isCorrect(Color _color)
        {
            return Equals(_color);
        }
        public void AddAction(int _x, int _y, int _deplay)
        {
            ListPoint.Add(new PointClick(_x, _y, _deplay));
        }
        public void RunAction()
        {
            foreach (var o in ListPoint) { Thread.Sleep(o.Deplay); RaiseAMouseClick(o.X, o.Y); }
            IsActive = true;
        }
        public void RunActionWithCondition()
        {
            foreach (var o in ListPoint) { Thread.Sleep(o.Deplay); RaiseAMouseClick(o.X, o.Y); }
            IsActive = true;
        }
        public void RaiseAMouseClick(int x, int y)
        {
            SetCursorPos(x, y);
            Application.DoEvents(); mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }
        public bool Equals(Color x)
        {
            try
            {
                Color _color = (Color)x;
                if (_color.R < (ColorObject.R - Range) || _color.R > (ColorObject.R + Range))
                {
                    return false;
                }
                else if (_color.B < (ColorObject.B - Range) || _color.B > (ColorObject.B + Range))
                {
                    return false;
                }
                else if (_color.G < (ColorObject.G - Range) || _color.G > (ColorObject.G + Range))
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return 1;
        }
    }
    class Rectangle : Detecter { public override bool Equals(Object _rectangle) { return true; } public override int GetHashCode() { return 2; } }
}
