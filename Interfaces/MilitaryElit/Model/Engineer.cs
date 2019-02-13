using MilitaryElit.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Model
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string firstName, string lastName, int id, decimal salary, Corps corps)
            : base(firstName, lastName, id, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public ICollection<IRepair> Repairs
        {
            get;
            set;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n Corps: {this.Corps}\n Repairs:\n{(this.Repairs.Count == 0 ? "" : "\n  ")}" +
                $"{string.Join("\n", this.Repairs)}";
        }
    }
}
