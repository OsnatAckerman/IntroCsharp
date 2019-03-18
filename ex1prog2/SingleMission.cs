using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /*derived from Imission*/
    public class SingleMission : IMission
    {
        private Func funcToCalc;
        private string name;
        private string type = "Single";
        public event EventHandler<double> OnCalculate;

        /*constructor*/
        public SingleMission(Func func, string missionName)
        {
            funcToCalc = func;
            name = missionName;
        }

        /*properties*/
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

        /*override*/
        public double Calculate(double value)
        {
            double x = funcToCalc(value);
            //raise the event.
            OnCalculate?.Invoke(this, x);
            return x;
        }
    }
}
