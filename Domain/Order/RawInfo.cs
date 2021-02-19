using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Order
{
    public class RawInfo
    {
        private int workDays;        
        private List<int> elementValue;
        private int identification;
        private DateTime date;

        public int Identification { get => identification; set => identification = value; }
        public DateTime Date { get => date; set => date = value; }
        public int WorkDays { get => workDays; set => workDays = value; }        
        public List<int> ElementValue { get => elementValue; set => elementValue = value; }
    }
}
