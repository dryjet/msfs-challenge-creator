using System;
using System.Collections.Generic;

namespace LandingChallengeCreator
{
    public class Mission
    {
        public string Plane { get; set; } = "Airbus A320 Neo Asobo";
        public string ICAO { get; set; } = "";
        public string Approach { get; set; } = "New approach";
        public string RunwayNumber { get; set; } = "11";
        public string RunwayDesignator { get; set; } = "L";
        public DateTime DateOfFlight { get; set; } = new DateTime(2018, 1, 1).AddDays(232).AddHours(14);
        public string Latitude { get; set; } = "N000° 00' 00.00\"";
        public string Longitude { get; set; } = "E000° 00' 00.00\"";
        public string Altitude { get; set; } = "+05000.00";
        public string Heading { get; set; } = "111";
        public string Airspeed { get; set; } = "145";
        public string Flaps { get; set; } = "100";
        public int WindDirection { get; set; } = 120;
        public int WindSpeed { get; set; } = 5;

        public override string ToString()
        {
            return $"{this.ICAO} - {this.Approach}";
        }

        public string Replace(string template)
        {
            //+001265.00
            var dec = decimal.Parse(this.Altitude
                .Replace("ft", "")
                .Replace("+", "")
                .Replace(".00", ""));
            var altitude = string.Format("{0:000000.00}", dec);
            var altStr = $"+{altitude.Replace(",", ".")}";

            var map = new Dictionary<string, string>()
            {
                ["Mission.Plane"] = this.Plane,
                ["Mission.ICAO"] = this.ICAO,
                ["Mission.RunwayNumber"] = this.RunwayNumber.ToString(),
                ["Mission.RunwayDesignator"] = this.RunwayDesignator,

                ["Mission.DateOfFlight.Season"] = Extensions.GetSeason(this.DateOfFlight, false),
                ["Mission.DateOfFlight.Year"] = this.DateOfFlight.Year.ToString(),
                ["Mission.DateOfFlight.Day"] = this.DateOfFlight.DayOfYear.ToString(),
                ["Mission.DateOfFlight.Hours"] = this.DateOfFlight.Hour.ToString(),

                ["Mission.Latitude"] = this.Latitude,
                ["Mission.Longitude"] = this.Longitude,
                ["Mission.Altitude"] = altStr,
                ["Mission.Heading"] = this.Heading.Replace("°", ""),
                ["Mission.Airspeed"] = this.Airspeed.Replace("kts", ""),
                ["Mission.Flaps"] = this.Flaps.Replace("%", ""),
            };


            foreach (var kvp in map)
            {
                template = template.Replace($"${{{kvp.Key}}}", kvp.Value);
            }

            return template;
        }
    }
}