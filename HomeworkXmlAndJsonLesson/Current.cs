using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkXmlAndJsonLesson
{
    public class Current
    {
        private TimeSpan observation_time;
        private int temperature;
        private int weather_code;
        private List<string> weather_icons;
        private List<string> weather_descriptions;
        private int wind_speed;
        private int wind_degree;
        private int pressure;
        private int precip;
        private int humidity;
        private int cloudcover;
        private int feelslike;
        private int uv_index;
        private int visibility;
        private bool is_day;

        public TimeSpan Observation_time
        {
            get { return observation_time; }
            set { observation_time = value; }
        }
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public int Weather_code
        {
            get { return weather_code; }
            set { weather_code = value; }
        }
        public List<string> Weather_icons
        {
            get { return weather_icons; }
            set { weather_icons = value; }
        }
        public List<string> Weather_descriptions
        {
            get { return weather_descriptions; }
            set { weather_descriptions = value; }
        }
        public int Wind_speed
        {
            get { return wind_speed; }
            set { wind_speed = value; }
        }
        public int Wind_degree
        {
            get { return wind_degree; }
            set { wind_degree = value; }
        }
        public int Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        public int Precip
        {
            get { return precip; }
            set { precip = value; }
        }
        public int Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
        public int Cloudcover
        {
            get { return cloudcover; }
            set { cloudcover = value; }
        }
        public int Feelslike
        {
            get { return feelslike; }
            set { feelslike = value; }
        }
        public int Uv_index
        {
            get { return uv_index; }
            set { uv_index = value; }
        }
        public int Visibility
        {
            get { return visibility; }
            set { visibility = value; }
        }
        public bool Is_day
        {
            get { return is_day; }
            set { is_day = value; }
        }





    }
}
