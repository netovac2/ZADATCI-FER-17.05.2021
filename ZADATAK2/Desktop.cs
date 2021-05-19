using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK2
{
    class Desktop:Computer
    {
        public double CaseHeight { get; set; }

        public Desktop(string model, string manufacturer, string operatingSystem, double caseHeight)
            : base(model, manufacturer, operatingSystem)
        {
            CaseHeight = caseHeight;
        }

        public override string GetComputerType()
        {
            return "Desktop computer";
        }

        public override int CalculatePortabilityScore()
        {
            int portabilityScore1 =(int) (5+(CaseHeight / 30));
            {
                return portabilityScore1;
            }
        }

        public override string GetModel()
        {
            return Model;
        }

        public override int GetBatteryCapacity()
        {
            return 0;
        }

    }
}
