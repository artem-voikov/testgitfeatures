using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IRepository<T>
    {
        public T Get(int id);
        public bool Create(T t);
    }
}
