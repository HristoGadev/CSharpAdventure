using MilitaryElit.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Model
{
    public class LeutenantGeneral : Private, ILieutenantGeneral
    {
        public LeutenantGeneral(string firstName, string lastName, int id, decimal salary)
            : base(firstName, lastName, id, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public ICollection<IPrivate> Privates
        {
            get;
            set;
        }
        public override string ToString()
        {
            return base.ToString() + "\nPrivates:\n" + $"{string.Join("\n", Privates)}";
        }
    }
}
