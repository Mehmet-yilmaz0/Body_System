﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        //add metodu ona verilen boyut değerini yeni bir unite atayıp bu uniti deponun en sonuna ekler.
        public StorageUnit Add(int boyut)
        {
            StorageUnit NewUnit = new StorageUnit();
            NewUnit = this._head;
            if (_head == null)
            {
                throw new Exception("depolama alani acilmamis");
            }
            else if (_head.Next == null)
            { 
                _head.Next = new StorageUnit(boyut);
                return _head;
            }
            while(NewUnit.Next != null)
            {
                //boş olan yeri buluyor
                NewUnit = NewUnit.Next;
            }
            NewUnit.Next = new StorageUnit(boyut);
            return this._head;
        }
        //içine gönderilen storage unitte bölünmüş ama içerisindeki iş bitmiş parçaları temizleyip bütünler.
        public StorageUnit RebuildCleaner(ref StorageUnit unit)
        {
            StorageUnit UN = unit.Next;
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
                        unit.Next = RebuildCleaner(ref UN);
                        return unit;
                    }
                }
                
                unit.Next=RebuildCleaner(ref UN);
                
                return unit;
            }
        }
        //quick cut metodu içine gönderdiğiniz storage unitin depolamasını ikiye bölüp iki farklı storage unite ayırır.
        void QuickCut(ref StorageUnit temp)
        {
            StorageUnit yeni = new StorageUnit();
            yeni.Data = temp.Data / 2;
            temp.Data = temp.Data / 2;
            yeni.Next = temp.Next;
            temp.Next = yeni;
        }

    }
}
