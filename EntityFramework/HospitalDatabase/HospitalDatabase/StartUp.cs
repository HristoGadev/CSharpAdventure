using HospitalDatabaseData;
using P01_HospitalDatabase.Initializer;
using System;

namespace HospitalDatabase 
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using (HospitalContext context = new HospitalContext())
            {
                DatabaseInitializer.InitialSeed(context);
            }
        }
    }
}
