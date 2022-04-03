using System;
using System.Collections.Generic;
using System.Text;

namespace _040422
{
    internal class Meeting
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Name { get; set; }


        public string ShowInfo()
        {
            return $"Full Name: {this.Name} - FromDate: {this.FromDate} - ToDate: {this.ToDate}";
        }


    }
}
