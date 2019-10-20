using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Alex.Classes
{
    static class GlobalApp
    {
        private static string _globalVar = "";
        
        public static bool IsChanged { get; set; }


        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }


}
