using GoodsAuction.Control;
using System;

namespace GoodsAuction
{
    class Program
    {
        static void Main(string[] args)
        {
           StartupController s = new StartupController(); //create the startcontroller
           s.initiate();
        }
    }
}
