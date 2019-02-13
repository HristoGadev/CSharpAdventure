using MilitaryElit.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Model
{
    public class Repair : IRepair
    {
        private string partName;
        private int workedHours;

        public Repair(string partName, int workedHours)
        {
            PartName = partName;
            WorkedHours = workedHours;
        }

        public string PartName
        {
            get => partName;
            private set => partName = value;
        }
        public int WorkedHours
        {
            get => workedHours;
            private set => workedHours = value;
        }
        public override string ToString()
        {
            return $"Part Name: {this.PartName } Hours Worked: {this.WorkedHours }";
        }
    }
}
