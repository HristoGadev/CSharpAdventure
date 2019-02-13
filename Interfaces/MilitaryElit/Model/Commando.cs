using MilitaryElit.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Model
{
    public class Commando : SpecialisedSoldier, ICommando

    {
        public Commando(string firstName, string lastName, int id, decimal salary, Corps corps) 
            : base(firstName, lastName, id, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public ICollection<IMission> Missions
        {
            get ;
            set;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCorps: {this.Corps}\nMissions:{(this.Missions.Count==0? "" : "\n  ")}" +
                $"{string.Join("\n", this.Missions)}";
        }
    }
}
