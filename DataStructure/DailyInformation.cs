using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInfo
{
    public class DailyInformation
    {
        public double BodyTemperature
        {
            get;
            set;
        }
        public bool HubeiTravelStatus
        {
            get;
            set;
        }
        public bool UnderTheWeather
        {
            get;
            set;
        }
        public DailyInformation(double bodyTemperature, bool hubeiTravelStatus, bool underTheWeather)
        {
            BodyTemperature = bodyTemperature;
            HubeiTravelStatus = hubeiTravelStatus;
            UnderTheWeather = underTheWeather;
        }
        public override string ToString()
        {
            return BodyTemperature.ToString()+","+HubeiTravelStatus.ToString() + "," + UnderTheWeather.ToString();
        }
    }
}
