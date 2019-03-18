using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Func(double val);

    public class FunctionsContainer
    {
        Dictionary<string, Func> dict = new Dictionary<string, Func>();
        public Func this[string funcName]
        {
            get
            {
                if (!dict.ContainsKey(funcName))
                {
                    dict[funcName] = x => x;
                }
                return dict[funcName];
            }

            set
            {
                dict[funcName] = value;
            }
        }
    }
}
