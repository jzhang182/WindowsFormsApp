using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInfo
{
    public class Employee
    {
        public string Gin
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public Dictionary<DateTime, DailyInformation> StatusRecordDict
        {
            get;
            set;
        }
        public Employee(string gin, string name, Dictionary<DateTime, DailyInformation> statusRecordDict)
        {
            Gin = gin;
            Name = name;
            StatusRecordDict = statusRecordDict;
        }

        public override string ToString()
        {
            return "Gin:" + Gin + "," + "Name:" + Name;
        }
    }
}
