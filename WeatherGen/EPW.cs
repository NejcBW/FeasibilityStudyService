using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace WeatherGen
{
    public class EPW
    {
        public Location Location { get; set; }
        public List<Record> Data { get; set; }

        public void SetLocation(string filePath)
        {
            string[] epwRaw = GetLines(filePath);

            Location = GetLocation(epwRaw);

            Data = GetData(epwRaw);
        }

        private readonly CultureInfo cul = new CultureInfo("en-US");

        private string[] GetLines(string filePath)
        {
            // Declare a string array that will be used as
            // a buffer during csv file parsing
            // Each csv file line is one string
            string[] lines;

            // Open csv file and load it into lines variable
            try
            {
                lines = System.IO.File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message, ex);
            }

            return lines;

        }

        private Location GetLocation(string[] epwRaw)
        {
            var location = new Location();

            // Parsing LOCATION header into a string array
            string[] fields = epwRaw[0].Split(',');

            // Initialising location properties
            location.City = fields[1];
            location.StateProvReg = fields[2];
            location.Country = fields[3];
            location.Source = fields[4];
            location.WMO = fields[5];
            location.Latitude = double.Parse(fields[6], cul);
            location.Longitude = double.Parse(fields[7], cul);
            location.TimeZone = double.Parse(fields[8], cul);
            location.Elevation = double.Parse(fields[9], cul);

            return location;
        }

        private List<Record> GetData(string[] epwRaw)
        {
            int headerLength = 8;
            var data = new List<Record>();


            for (int i = headerLength; i < headerLength + 8760; i++)
            {
                var record = new Record();
                //DateTime currentHour = startDate.AddHours(i - headerLength);

                // Parse current line i into a string array
                string[] fields = epwRaw[i].Split(',');

                // Create a Record object from the string array

                //record.Time = currentHour;
                record.Id = i - headerLength;
                record.DryBulb = double.Parse(fields[6], cul);
                record.DewPoint = double.Parse(fields[7], cul);
                record.RelHum = double.Parse(fields[8], cul);
                record.Pressure = double.Parse(fields[9], cul);

                // Append the Record object to the data object
                data.Add(record);
            }

            return data;
        }
    }
}
