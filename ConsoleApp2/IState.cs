using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IState
    {
        void Digit(string key);
        void Equal();
        void Operation(string key);
        string Screen();
    }
}
