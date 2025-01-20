using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Body_System.Tools.Storage
{
    public class StorageUnit
    {
        public int Data;
        public StorageUnit? Next;
        public int empty;
        process? UnitP;
        public StorageUnit(int data)
        {
            this.Data = data;
            this.Next = null;
            this.empty = 1;
            this.UnitP = null;
        }
        public StorageUnit()
        {
            Data = 0;
            Next = null;
        }
        void Pull(process _process)
        {
            if (this.empty == 1)
            {
                if (_process.Size == this.Data)
                {
                    this.UnitP = _process;
                    empty = 0;
                }
                else
                {
                    throw new Exception("process ile depolama yeri uyumsuz.");
                }
            }
            else
            {
                throw new Exception("bu unit dolu.");
            }
            return;
        }
        public void WorkFinish()
        {
            if (this.UnitP != null)
            {
                if (this.UnitP.Time == 0)
                {
                    this.UnitP = null;
                    this.empty = 1;
                }
                else
                {
                    throw new Exception("process daha işini bitirmemiş.");
                }
            }
            else
            {
                throw new Exception("unit zaten boş process yok");
            }
            return;
        }
    }
}
