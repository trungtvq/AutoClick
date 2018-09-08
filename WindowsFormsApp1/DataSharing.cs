using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    class DataSharing
    {
        public bool IsRunning { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int R { get; set; }
        public int B { get; set; }
        public int G { get; set; }

        public int x1 { get; set; }
        public int y1 { get; set; }
        public int R1 { get; set; }
        public int B1 { get; set; }
        public int G1 { get; set; }

        public int x2 { get; set; }
        public int y2 { get; set; }
        public int R2 { get; set; }
        public int B2 { get; set; }
        public int G2 { get; set; }


        public string EventName { get; set; }




        public DataSharing()
        {
            IsRunning = false;
        }

    }
}
