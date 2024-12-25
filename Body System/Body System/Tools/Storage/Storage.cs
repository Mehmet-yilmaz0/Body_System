using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_System.Tools.Storage
{
    public class Storage
    {
        [Required]
        private StorageUnit _head;
        public Storage(int boyut)
        {
            _head = new StorageUnit(boyut);
            _head.Next = null;
        }

        public StorageUnit Add(int boyut)
        {
            StorageUnit temp = new StorageUnit();
            temp = this._head;
            if (_head == null)
            {
                throw new Exception("depolama alani acilmamis");
            }
            else if (_head.Next == null)
            { 
                _head.Next = new StorageUnit(boyut);
                return _head;
            }
            while(temp.Next != null)
            {
                //boş olan yeri buluyor
                temp = temp.Next;
            }
            temp.Next = new StorageUnit(boyut);
            return this._head;
        }

        public StorageUnit RebuildCleaner(ref StorageUnit unit)
        {
            if (unit == null)
            {
                throw new Exception("depolama alani acilmamis");
            }
            else if(unit.Next == null)
            {
                return unit;
            }
            else
            {
                if (unit.empty == 1 && unit.Next.empty == 1)
                {
                    if (unit.Data == unit.Next.Data)
                    {
                        unit.Data *= 2;
                        if(unit.Next.Next != null)
                        {
                            unit.Next = unit.Next.Next;
                        }
                        unit.Next = RebuildCleaner(ref unit);
                        return unit;
                    }
                }
                unit = unit.Next;
                RebuildCleaner(ref unit);
                return unit;
            }
        } 
    }
}
