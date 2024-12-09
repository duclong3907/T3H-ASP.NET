﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class TupleEx
    {
        public (int a, string b) TupleExam()
        {
            return (1, "Nguyen Van A");
        }
    }

    //T: là kiểu dữ liệu truyền vào. Kiểu T này động và có thể tái sử dụng Class này
    public class  DataStore<T>
    {
        public T Data { get; set; }
    }

    public class DataStore2<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }

}
