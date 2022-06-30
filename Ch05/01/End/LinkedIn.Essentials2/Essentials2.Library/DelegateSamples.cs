using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Library
{
    public static class DelegateSamples
    {
        public delegate void Del(string input);

        public static void PassMeWork(Del work)
        {
            work("delegates");
        }
    }
}
