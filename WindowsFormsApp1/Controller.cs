using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Threading;
namespace WindowsFormsApp1
{

    class Controller
    {
        //data sharing between 2 thread
        DataSharing DtSharing;
        //list of object, such as "tui do" 
        public List<Detecter> detecterList = new List<Detecter>();
        Thread RunActionThread;
        //Constructor
        public Controller(DataSharing _dataSharing)
        {
            DtSharing = _dataSharing;
        }


        //use library to get cur
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);


        //use library no ide
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        Bitmap screenPixel = new Bitmap(3, 3, PixelFormat.Format32bppArgb);





        public void AddObjectDetectByColor(int x, int y, int r, int b, int g, int Range, int _timeCheck, string _Name)
        {
            detecterList.Add(new ObjectDetectByColor(Color.FromArgb(r, g, b), Range, x, y, _timeCheck, _Name));



        }


        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }
            return screenPixel.GetPixel(0, 0);
        }

        //check all of object in list, if it was legal => call run
        public void Detecting()
        {
            foreach (Detecter obj in detecterList)
            {
                Point point = new Point(obj.x, obj.y);
                if (obj is ObjectDetectByColor)
                {
                    ObjectDetectByColor o = (ObjectDetectByColor)obj;
                    if (!o.IsActive)
                    {
                        continue;
                    }
                    int i;
                    for (i = 0; i < o.TimeCheck; i++)
                    {
                        if (!o.isCorrect(GetColorAt(point)))
                        {
                            break;
                        }
                        Thread.Sleep(100);
                    }
                    if (i == o.TimeCheck)
                    {
                        o.IsActive = false;
                        RunActionThread = new Thread(new ThreadStart(o.RunAction));
                        RunActionThread.Start();
                    }
                }
            }
        }

        //independence thread run this function
        public void CheckPixel()
        {
            while (true)
            {
                while (DtSharing.IsRunning)
                {
                    //get location of pointer and show info in form
                    Point cursor = new Point();
                    GetCursorPos(ref cursor);
                    var c = GetColorAt(cursor);


                    UpdateData(cursor, c, GetColorAt(new Point(DtSharing.x1, DtSharing.y1)), GetColorAt(new Point(DtSharing.x2, DtSharing.y2)));

                    //perform check object in screen
                    Detecting();
                }
            }
        }


        //update DataSharing to show info in main thread (form)
        public void UpdateData(Point _point, Color _color, Color _color1, Color _color2)
        {
            DtSharing.x = _point.X;
            DtSharing.y = _point.Y;

            DtSharing.R = _color.R;
            DtSharing.B = _color.B;
            DtSharing.G = _color.G;
            DtSharing.R1 = _color1.R;
            DtSharing.B1 = _color1.B;
            DtSharing.G1 = _color1.G;
            DtSharing.R2 = _color2.R;
            DtSharing.B2 = _color2.B;
            DtSharing.G2 = _color2.G;
        }

    }
}
