﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public interface IList<T> : IEnumerable<T>
    {
        int Count { get; }
        T this[int index] { get; set; }

        void Add(T value);
        void Clear();
        bool Contains(T value);
        int IndexOf(T value);
        void Insert(int index, T value);
        void Remove(T value);
        void RemoveAt(int index);
        IList<T> subList(int fromIndex, int toIndex);
        void Save(string path, int type, int realization, bool mutable);
    }
}
