using MilitaryElit.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Model
{
    public class Spy : Soldier, ISpy
    {
        private int codeNumber;
        public Spy(string firstName, string lastName, int id, int codeNumber)
            : base(firstName, lastName, id)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber
        {
            get => codeNumber;
            private set => codeNumber = value;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n{this.CodeNumber}";
        }
    }
}
