using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        //list of fancs to apply on given value.
        private IList<Func> funcsToCalc;
        private string name;
        private string type = "Composed";
        public event EventHandler<double> OnCalculate;

        /*constructor*/
        public ComposedMission(string missionName)
        {
            funcsToCalc = new List<Func>();
            name = missionName;
        }

        /*property Name*/
        public string Name
        {
            get
            {
                return name;
            }
        }

        /*property Type*/
        public string Type
        {
            get
            {
                return type;
            }
        }

        /*adding funcs to apply to the list of funcs*/
        public ComposedMission Add(Func func)
        {
            funcsToCalc.Add(func);
            //enable to concatenate the method.
            return this;
        }

        /*override interface Imission*/
        public double Calculate(double value)
        {
            double val = value;
            //activate all funcs by order.
            foreach (var f in funcsToCalc)
            {
                val = f(val);
            }
            //raise the event with the calculated val.
            OnCalculate?.Invoke(this, val);
            return val;
        }

    }
}
