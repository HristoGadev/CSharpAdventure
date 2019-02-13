using MilitaryElit.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.Model
{
    public class Private:Soldier,IPrivate
    {
        private decimal salary;

        public Private(string firstName,string lastName,int id, decimal salary)
            :base(firstName,lastName,id)
        {
            Salary = salary;
        }

        public decimal Salary
        {
            get => salary;
            private set => salary = value;
        }
        public override string ToString()
        {
            return base.ToString()+$"Salary: {this.Salary:f2}"; 
        }
    }
}
