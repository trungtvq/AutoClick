//#define AUTOFARMPT
//#define FULLASSET
//#define BOSSCLANTHUONG
#define SATNHAN
//#define RUNFU
//#define LOWHP
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
    public partial class Form1 : Form
    {
        static Controller controler;
        Thread CheckScreenPlayThread;
        DataSharing _DataSharing;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            _DataSharing = new DataSharing();
            controler = new Controller(_DataSharing);

            AddObject();

            timer.Tick += new EventHandler(ChangeScreen); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = 100;              // Timer will tick evert second
            timer.Enabled = true;                       // Enable the timer
            timer.Start();
        }
        public void AddObject()
        {
            String[] p = { "RT", "LT", "RB", "LB" };
            int num = 0;
            ObjectDetectByColor o;

#if (FULLASSET)
            //full asset
            controler.AddObjectDetectByColor(1617, 67, 20, 81, 60, 10, 2, "fullAss");
            o = (ObjectDetectByColor)controler.detecterList[num++];
            o.AddAction(1617, 67, 2000);
            o.AddAction(1632, 514, 8000);
            o.AddAction(1813, 517, 3000);
            o.AddAction(1518, 387, 4000);
            o.AddAction(1421, 370, 5000);
            o.AddAction(1859, 56, 4000);
            //full asset Left Top
            controler.AddObjectDetectByColor(1617 - 960, 67, 20, 81, 60, 10, 2, "fullAssLeftTop");
            o = (ObjectDetectByColor)controler.detecterList[num++];
            o.AddAction(o.x, o.y, 2000);
            o.AddAction(1632 - 960, 514, 8000);
            o.AddAction(1813 - 960, 517, 3000);
            o.AddAction(1518 - 960, 387, 4000);
            o.AddAction(1421 - 960, 370, 5000);
            o.AddAction(1859 - 960, 56, 4000);
            //full asset Left Bot
            controler.AddObjectDetectByColor(1617 - 960, 67 + 548, 20, 81, 60, 10, 2, "fullAssLeftTop");
            o = (ObjectDetectByColor)controler.detecterList[num++];
            o.AddAction(o.x, o.y, 2000);
            o.AddAction(1632 - 960, 514 + 548, 8000);
            o.AddAction(1813 - 960, 517 + 548, 3000);
            o.AddAction(1518 - 960, 387 + 548, 4000);
            o.AddAction(1421 - 960, 370 + 548, 5000);
            o.AddAction(1859 - 960, 56 + 548, 4000);
            //full asset Right Bot
            controler.AddObjectDetectByColor(1617, 67 + 548, 20, 81, 60, 10, 2, "fullAssLeftTop");
            o = (ObjectDetectByColor)controler.detecterList[num++];
            o.AddAction(o.x, o.y, 2000);
            o.AddAction(1632, 514 + 548, 8000);
            o.AddAction(1813, 517 + 548, 3000);
            o.AddAction(1518, 387 + 548, 4000);
            o.AddAction(1421, 370 + 548, 5000);
            o.AddAction(1859, 56 + 548, 4000);
#endif


#if (BOSSCLANTHUONG)
            controler.AddObjectDetectByColor(1766, 312, 255, 232, 214, 20, 6, "dieAuto");
            o = (ObjectDetectByColor)controler.detecterList[num++];
            //live

            o.AddAction(1787, 356, 10000);
            AddOpenMap("RT", ref o, 4000);
            //location of map
            o.AddAction(1300, 324, 4000);
            o.AddAction(1856, 58, 2000);
            //auto
            o.AddAction(1636, 467, 7000);
#endif

#if (SATNHAN)
            foreach (string s in p)
            {
                AddDetectDIE(s);
                o = (ObjectDetectByColor)controler.detecterList[num++];
                AddRestore(s, ref o, 0);
                AddXofRestore(s, ref o, 5000);
                AddOpenMap(s, ref o, 3000);
                AddLocationCustom(s, 1343, 343, ref o, 6000);
                AddCloseMap(s, ref o, 1000);
                AddAutoButtonMap(s, ref o, 15000);
            }


#endif
#if (LOWHP)
            foreach (string s in p)
            {
                AddDetectLowHP(s);
                o = (ObjectDetectByColor)controler.detecterList[num++];
                AddMenuScreenPlay(s, ref o, 100);
                AddClanInMenu(s, ref o, 3000);
                AddSanhClanInClanMenu(s, ref o, 3000);
                AddLeaveSanhClan(s, ref o, 12000);
                AddAutoButtonMap(s, ref o, 12000);
            }

#endif
#if (RUNFU)
            foreach (string s in p)
            {
                AddDetectRunFu(s);
                o = (ObjectDetectByColor)controler.detecterList[num++];
                AddLocationCustom(s, 1066, 195, ref o, 0);
            }
#endif

            CheckScreenPlayThread = new Thread(new ThreadStart(controler.CheckPixel));
            CheckScreenPlayThread.Start();
        }
        void AddDetectRunFu(string pos)
        {
            switch (pos)
            {
                case "RT":
                    controler.AddObjectDetectByColor(971, 231, 68, 27, 125, 30, 6, "FuRT");
                    break;
                case "LT":
                    controler.AddObjectDetectByColor(971 - 960, 231, 68, 27, 125, 30, 6, "FuLT");
                    break;
                case "RB":
                    controler.AddObjectDetectByColor(971, 231 + 548, 68, 27, 125, 30, 6, "FuRB");
                    break;
                case "LB":
                    controler.AddObjectDetectByColor(971 - 960, 231 + 548, 68, 27, 125, 30, 6, "FuLB");
                    break;
            }
        }
        void AddLocationCustom(string pos, int x, int y, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(x, y, deplay);
                    break;
                case "LT":
                    o.AddAction(x - 960, y, deplay);
                    break;
                case "RB":
                    o.AddAction(x, y + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(x - 960, y + 548, deplay);
                    break;
            }
        }
        void AddSatNhanDamLay(string pos, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(1311, 181, deplay);
                    break;
                case "LT":
                    o.AddAction(1311 - 960, 181, deplay);
                    break;
                case "RB":
                    o.AddAction(1311, 181 + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(1311 - 960, 181 + 548, deplay);
                    break;
            }
        }
        void AddDetectLowHP(string pos)
        {
            switch (pos)
            {
                case "RT":
                    controler.AddObjectDetectByColor(1097, 47, 30, 30, 30, 20, 6, "LowRT");
                    break;
                case "LT":
                    controler.AddObjectDetectByColor(1097 - 960, 47, 30, 30, 30, 20, 6, "LowLT");
                    break;
                case "RB":
                    controler.AddObjectDetectByColor(1097, 47 + 548, 30, 30, 30, 20, 6, "LowRB");
                    break;
                case "LB":
                    controler.AddObjectDetectByColor(1097 - 960, 47 + 548, 30, 30, 30, 20, 6, "LowLB");
                    break;
            }
        }
        void AddMenuScreenPlay(string pos, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(1577, 54, deplay);
                    break;
                case "LT":
                    o.AddAction(1577 - 960, 54, deplay);
                    break;
                case "RB":
                    o.AddAction(1577, 54 + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(1577 - 960, 54 + 548, deplay);
                    break;
            }
        }

        void AddClanInMenu(string pos, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(1366, 508, deplay);
                    break;
                case "LT":
                    o.AddAction(1366 - 960, 508, deplay);
                    break;
                case "RB":
                    o.AddAction(1366, 508 + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(1366 - 960, 508 + 548, deplay);
                    break;
            }
        }

        void AddSanhClanInClanMenu(string pos, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(1246, 422, deplay);
                    break;
                case "LT":
                    o.AddAction(1246 - 960, 422, deplay);
                    break;
                case "RB":
                    o.AddAction(1246, 422 + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(1246 - 960, 422 + 548, deplay);
                    break;
            }
        }

        void AddLeaveSanhClan(string pos, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(1575, 94, deplay);
                    break;
                case "LT":
                    o.AddAction(1575 - 960, 94, deplay);
                    break;
                case "RB":
                    o.AddAction(1575, 94 + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(1575 - 960, 94 + 548, deplay);
                    break;
            }
        }
        void AddDetectDIE(string pos)
        {
            switch (pos)
            {
                case "RT":
                    controler.AddObjectDetectByColor(1766, 359, 253, 213, 173, 20, 6, "dieRT");
                    break;
                case "LT":
                    controler.AddObjectDetectByColor(1766 - 960, 359, 253, 213, 173, 20, 6, "dieLT");
                    break;
                case "RB":
                    controler.AddObjectDetectByColor(1766, 359 + 548, 253, 213, 173, 20, 6, "dieRB");
                    break;
                case "LB":
                    controler.AddObjectDetectByColor(1766 - 960, 359 + 548, 253, 213, 173, 20, 6, "dieLB");
                    break;
            }
        }
        void AddXofRestore(string pos, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(1851, 214, deplay);
                    break;
                case "LT":
                    o.AddAction(1851 - 960, 214, deplay);
                    break;
                case "RB":
                    o.AddAction(1851, 214 + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(1851 - 960, 214 + 548, deplay);
                    break;
            }
        }
        void AddRestore(string pos, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(1775, 298, deplay);
                    break;
                case "LT":
                    o.AddAction(1775 - 960, 298, deplay);
                    break;
                case "RB":
                    o.AddAction(1775, 298 + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(1775 - 960, 298 + 548, deplay);
                    break;
            }
        }
        void AddOpenMap(string pos, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(1856, 104, deplay);
                    break;
                case "LT":
                    o.AddAction(1856 - 960, 104, deplay);
                    break;
                case "RB":
                    o.AddAction(1856, 104 + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(1856 - 960, 104 + 548, deplay);
                    break;
            }
        }
        void AddCloseMap(string pos, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(1856, 60, deplay);
                    break;
                case "LT":
                    o.AddAction(1856 - 960, 60, deplay);
                    break;
                case "RB":
                    o.AddAction(1856, 60 + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(1856 - 960, 60 + 548, deplay);
                    break;
            }
        }
        void AddAutoButtonMap(string pos, ref ObjectDetectByColor o, int deplay)
        {
            switch (pos)
            {
                case "RT":
                    o.AddAction(1636, 467, deplay);
                    break;
                case "LT":
                    o.AddAction(1636 - 960, 467, deplay);
                    break;
                case "RB":
                    o.AddAction(1636, 467 + 548, deplay);
                    break;
                case "LB":
                    o.AddAction(1636 - 960, 467 + 548, deplay);
                    break;
            }
        }
        void AddActionRestoreHP(ref ObjectDetectByColor o, int x, int y)
        {
            /////RESTORE HP form screen play
            //menu
            o.AddAction(1575 + x, 51 + y, 1000);
            //Duageeon
            o.AddAction(1132 + x, 505 + y, 3000);
            //dungeon thuong
            o.AddAction(1143 + x, 410 + y, 3000);
            //dungeon tinh anh
            o.AddAction(1444 + x, 326 + y, 3000);
            //vào
            o.AddAction(1759 + x, 495 + y, 4000);
            //confirm vào
            o.AddAction(1499 + x, 384 + y, 2000);
            //out
            o.AddAction(1577 + x, 100 + y, 9000);
            //confirm out
            o.AddAction(1504 + x, 367 + y, 2000);
            //out to screen play
            o.AddAction(1854 + x, 52 + y, 7000);
            ////////////////////
        }
        void ChangeScreen(object sender, EventArgs e)
        {
            if (txtX1.Text != "" & txtY2.Text != "")
            {
                _DataSharing.x1 = Int32.Parse(txtX1.Text);
                _DataSharing.y1 = Int32.Parse(txtY1.Text);
            }
            else
            {
                _DataSharing.x1 = 0;
                _DataSharing.y2 = 0;

            }
            if (txtX2.Text != "" & txtY2.Text != "")
            {
                _DataSharing.x2 = Int32.Parse(txtX2.Text);
                _DataSharing.y2 = Int32.Parse(txtY2.Text);
            }
            else
            {
                _DataSharing.x2 = 0;
                _DataSharing.y2 = 0;
            }



            lb1.Text = "Red: " + _DataSharing.R;
            lb2.Text = "Blue: " + _DataSharing.B;
            lb3.Text = "Green: " + _DataSharing.G;
            lbX.Text = "X: " + _DataSharing.x;
            lbY.Text = "Y: " + _DataSharing.y;
            lbR1.Text = _DataSharing.R1.ToString();
            lbR2.Text = _DataSharing.R2.ToString();
            lbG1.Text = _DataSharing.G1.ToString();
            lbG2.Text = _DataSharing.G2.ToString();
            lbB1.Text = _DataSharing.B1.ToString();
            lbB2.Text = _DataSharing.B2.ToString();


            lbEvent.Text = _DataSharing.EventName;

        }
        private void btn1_Click(object sender, EventArgs e)
        {

            if (btn1.Text == "Start")
            {
                _DataSharing.IsRunning = true;
                btn1.Text = "Stop";
            }
            else
            {
                _DataSharing.IsRunning = false;
                btn1.Text = "Start";
            }
        }
        private void btnAutoSell_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "Start")
            {
                return;
            }
            if (lbAutoSell.Text == "Stopped")
            {
                lbAutoSell.Text = "Running";
            }
            else
            {
                lbAutoSell.Text = "Stopped";
            }
        }

        private void btnFarmIn_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "Start")
            {
                return;
            }

            if (lbFarmIn.Text == "Stopped")
            {
                lbFarmIn.Text = "Running";
                //_DataSharing.objActive.g
            }
            else
            {
                lbFarmIn.Text = "Stopped";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }



}
