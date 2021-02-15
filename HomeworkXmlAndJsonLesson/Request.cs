using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkXmlAndJsonLesson
{
    public class Request
    {
        private string type;
        private string query;
        private string language;
        private string unit;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Query
        {
            get { return query; }
            set { query = value; }
        }
        public string Language
        {
            get { return language; }
            set { language = value; }
        }
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
    }
}
