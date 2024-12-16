using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Body_System.Tools.Storage
{
    internal class StorageUnit
    {
        public int Data;
        public StorageUnit? Next;
        public int empty;
        public StorageUnit(int data)
        {
            Data = data;
            Next = null;
            empty = 1;
        }
        public StorageUnit()
        {
            Data = 0;
            Next = null;
        }
    }
}
