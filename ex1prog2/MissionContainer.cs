using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    //public delegate for the events.
    public delegate double Func(double val);

    public class FunctionsContainer
    {
       
        Dictionary<string, Func> dict = new Dictionary<string, Func>();

        //indexer.
        public Func this[string funcName]
        {
            get
            {
                //if func does'nt exist, add her as afunction returns the val as is.
                if (!dict.ContainsKey(funcName))
                {
                    dict[funcName] = val => val;
                }
                return dict[funcName];
            }

            set
            {
                dict[funcName] = value;
            }
        }

        public IList<string> getAllMissions()
        {
            return dict.Keys.ToList();
        }
    }
}
