using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_System.Tools.Storage
{
    internal class process
    {
        public int Number { get; set; }
        public int Size { get; set; }
        public int Time { get; set; }
        public process(int _Number, int _Size, int _Time)
        {
            Number = _Number;
            Size = _Size;
            Time = _Time;
        }
    }
}
