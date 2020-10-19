using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Infrastructure
{
    public interface ILogger
    {
        public void Write(Level level, string message);
    }
}
