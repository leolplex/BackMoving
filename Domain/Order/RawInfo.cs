using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Order
{
    public class RawInfo
    {
        private int workDays;        
        private List<int> elementValue;

        public int WorkDays { get => workDays; set => workDays = value; }        
        public List<int> ElementValue { get => elementValue; set => elementValue = value; }
    }
}
