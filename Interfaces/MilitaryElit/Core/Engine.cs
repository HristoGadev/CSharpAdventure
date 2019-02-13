using MilitaryElit.Contracts;
using MilitaryElit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MilitaryElit.Enums;

namespace MilitaryElit.Core
{
    public class Engine
    {
        private ICollection<ISoldier> soldiers;
        private ISoldier soldier;

        public Engine()
        {
            this.soldiers = new List<ISoldier>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                var inputArgs = input.Split();
                var type = inputArgs[0];
                var id = int.Parse(inputArgs[1]);
                var firstName = inputArgs[2];
                var lastName = inputArgs[3];


                if (type == "Private")
                {
                    var salary = decimal.Parse(inputArgs[4]);
                    soldier = GetPrivateSoldier(id, firstName, lastName, salary);
                }
                else if (type == "LieutenantGeneral")
                {
                    var salary = decimal.Parse(inputArgs[4]);
                    soldier = GetlieutenantGeneral(id, firstName, lastName, salary, inputArgs);
                }
                else if (type == "Engineer")
                {
                    var salary = decimal.Parse(inputArgs[4]);
                    soldier = GetEngineer(id, firstName, lastName, salary, inputArgs);
                }
                else if (type == "Commando")
                {
                    var salary = decimal.Parse(inputArgs[4]);
                    soldier = GetCommando(id, firstName, lastName, salary, inputArgs);
                }
                else if (type == "Spy")
                {
                    var codeNumber =int.Parse(inputArgs[4]);
                    soldier = GetSpy(id, firstName, lastName,codeNumber);
                }
                if (soldier != null)
                {
                    this.soldiers.Add(soldier);
                }

                input = Console.ReadLine();
            }
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private ISoldier GetSpy(int id, string firstName, string lastName, int codeNumber)
        {
            ISpy spy = new Spy(firstName, lastName, id, codeNumber);
            return spy;
        }

        private ISoldier GetCommando(int id, string firstName, string lastName, decimal salary, string[] inputArgs)
        {
            var corpsAsString = inputArgs[5];
            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }
            ICommando commando = new Commando(firstName, lastName, id, salary, corps);
            for (int i = 6 ; i < inputArgs.Length; i+=2)
            {
                var codeName = inputArgs[i];
                var stateAsString = inputArgs[i + 1];
                if (!Enum.TryParse(stateAsString, out State state))
                {
                    continue;
                }
                IMission mission = new Mission(codeName, state);
                commando.Missions.Add(mission);
            }
            return commando;
        }

        private ISoldier GetEngineer(int id, string firstName, string lastName, decimal salary, string[] inputArgs)
        {
            var corpsAsString = inputArgs[5];
            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }

            IEngineer engineer = new Engineer(firstName, lastName, id, salary, corps);

            for (int i = 6; i < inputArgs.Length; i+=2)
            {
                var partName = inputArgs[i];
                var workedHours = int.Parse(inputArgs[i + 1]);

                IRepair repair = new Repair(partName, workedHours);
                engineer.Repairs.Add(repair);
            }
            return engineer;
        }

        private ISoldier GetlieutenantGeneral(int id, string firstName, string lastName, decimal salary, string[] inputArgs)
        {
            ILieutenantGeneral lieutenant = new LeutenantGeneral(firstName, lastName, id, salary);

            for (int i = 5; i < inputArgs.Length; i++)
            {
                var privateId = int.Parse(inputArgs[i]);
                IPrivate privateSoldier = (IPrivate)this.soldiers.FirstOrDefault(x => x.Id == privateId);
                lieutenant.Privates.Add(privateSoldier);
            }
            return lieutenant;
        }

        private ISoldier GetPrivateSoldier(int id, string firstName, string lastName, decimal salary)
        {
            IPrivate privateSoldier = new Private(firstName, lastName, id, salary);
            return privateSoldier;
        }
    }
}
