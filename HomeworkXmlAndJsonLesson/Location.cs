using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkXmlAndJsonLesson
{
    public class Location
    {
        private string name;
        private string country;
        private string region;
        private string lat;
        private string lon;
        private string timezone_id;
        private DateTime localtime;
        private int localtime_epoch;
        private string uts_offset;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        public string Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        public string Lon
        {
            get { return lon; }
            set { lon = value; }
        }
        public string TimezoneId
        {
            get { return timezone_id; }
            set { timezone_id = value; }
        }
        public DateTime LocalTime
        {
            get { return localtime; }
            set { localtime = value; }
        }
        public int LocalTimeEpoch
        {
            get { return localtime_epoch; }
            set { localtime_epoch = value; }
        }
        public string UtsOffSet
        {
            get { return uts_offset; }
            set { uts_offset = value; }
        }




    }
}
