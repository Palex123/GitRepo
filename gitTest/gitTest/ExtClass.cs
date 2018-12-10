using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitTest
{
    public static class ExtClass
    {
        public static string Ext(this int a)
        {
            return a.ToString();
        }
    }
}
