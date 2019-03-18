using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private Func funcToCalc;
        private string name;
        private string type = "Single";
        public event EventHandler<double> OnCalculate;


        public SingleMission(Func func, string missionName)
        {
            funcToCalc = func;
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

        public double Calculate(double value)
        {
            double x = funcToCalc(value);
            OnCalculate?.Invoke(this, x);
            return x;
        }
    }
}
