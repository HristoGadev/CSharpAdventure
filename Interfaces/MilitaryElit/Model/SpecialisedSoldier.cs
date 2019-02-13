using MilitaryElit.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Model
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string firstName, string lastName, int id, decimal salary, Corps corps)
            : base(firstName, lastName, id, salary)
        {
            this.Corps = corps;
        }

        public Corps Corps { get; }
    }
}
