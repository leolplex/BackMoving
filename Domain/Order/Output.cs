using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Order
{
    public class Output
    {
        private string caseDay;
        private int numberMaxTravels;

        public string CaseDay { get => caseDay; set => caseDay = value; }
        public int NumberMaxTravels { get => numberMaxTravels; set => numberMaxTravels = value; }
    }
}
