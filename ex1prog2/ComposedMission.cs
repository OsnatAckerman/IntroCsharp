using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private IList<Func> funcsToCalc;
        private string name;
        private string type = "Composed";
        public event EventHandler<double> OnCalculate;


        public ComposedMission(string missionName)
        {
            funcsToCalc = new List<Func>();
            name = missionName;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public ComposedMission Add(Func func)
        {
            funcsToCalc.Add(func);
            return this;
        }

        public double Calculate(double value)
        {
            double val = value;
            foreach (var f in funcsToCalc)
            {
                val = f(val);
            }
            OnCalculate?.Invoke(this, val);
            return val;
        }

    }
}
