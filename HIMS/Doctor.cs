using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS
{
    public class Doctor
    {
        public string Name { get; set; }

        public Doctor(string name)
        {
            Name = name;
        }
        public static void AddDoctor()
        {
            Console.Write("\nEnter Doctor Name: ");
            string doctorName = Console.ReadLine();
            HIMS.Doctors.Add(new Doctor(doctorName));
            Console.WriteLine($"Doctor '{doctorName}' added successfully.");
        }
    }
}
