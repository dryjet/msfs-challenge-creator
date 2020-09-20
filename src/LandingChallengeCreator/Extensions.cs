using System;
using System.Collections.Generic;

namespace LandingChallengeCreator
{
    static class Extensions
    {
        public static string GetSeason(DateTime date, bool ofSouthernHemisphere)
        {
            var dict = new Dictionary<int, string>()
            {
                [0] = "Spring",
                [1] = "Summer",
                [2] = "Fall",
                [3] = "Winter"
            };
            int hemisphereConst = (ofSouthernHemisphere ? 2 : 0);
            Func<int, int> getReturn = (northern) =>
            {
                return (northern + hemisphereConst) % 4;
            };
            float value = (float)date.Month + date.Day / 100f;  // <month>.<day(2 digit)>
            if (value < 3.21 || value >= 12.22) return dict[getReturn(3)];    // 3: Winter
            if (value < 6.21) return dict[getReturn(0)];  // 0: Spring
            if (value < 9.23) return dict[getReturn(1)];  // 1: Summer
            return dict[getReturn(2)];    // 2: Autumn
        }

        public static List<Mission> GetSeededData()
        {
            return new List<Mission>()
            {
                new Mission()
                {
                    Approach = "RNAV 05R NATOS",
                    ICAO = "EDDL",
                    RunwayNumber ="05",
                    RunwayDesignator = "R",
                    Heading = "053",
                    Latitude = "N051° 11' 29.48\"",
                    Longitude= "E006° 34' 04.52\""
                },
                new Mission()
                {
                    Approach = "RNAV 08L MAGAT",
                    ICAO = "EDDM",
                    RunwayNumber ="08",
                    RunwayDesignator = "L",
                    Altitude = "+05000.00",
                    Heading = "080",
                    Latitude = "N048° 20' 29.48\"",
                    Longitude= "E011° 29' 47.18\""
                },
                new Mission()
                {
                    Approach = "RNAV 08R BEGEN",
                    ICAO = "EDDM",
                    RunwayNumber ="08",
                    RunwayDesignator = "R",
                    Altitude = "+05000.00",
                    Heading = "080",
                    Latitude = "N048° 19' 10.32\"",
                    Longitude= "E011° 28' 53.40\""
                },
                new Mission()
                {
                    Approach = "ILS NDB 7 WPY",
                    ICAO = "EGNT",
                    RunwayNumber ="07",
                    RunwayDesignator = "",
                    Altitude = "+02200.00",
                    Heading = "066",
                    Latitude = "N054° 57' 56.13\"",
                    Longitude= "W001° 57' 38.17\""
                }
            };
        }
    }
}