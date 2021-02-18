using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Audit
    {
        private int identification;
        private DateTime date;

        public int Identification { get => identification; set => identification = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
