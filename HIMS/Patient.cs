using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS
{
    public class Patient
    {
        public string Name { get; set; }

        public Patient(string name)
        {
            Name = name;
        }
        public static void AddPatient()
        {
            Console.Write("\nEnter Patient Name: ");
            string patientName = Console.ReadLine();
            HIMS.Patients.Add(new Patient(patientName));
            Console.WriteLine($"Patient '{patientName}' added successfully.");
        }
        public static void MonitorPatient()
        {
            Console.WriteLine("\nSelect a patient to monitor:");

            for (int i = 0; i < HIMS.Patients.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {HIMS.Patients[i].Name}");
            }

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= HIMS.Patients.Count)
            {
                var selectedPatient = HIMS.Patients[choice - 1];
                HIMS.MonitoredPatients.Add(selectedPatient);
                Console.WriteLine($"Patient '{selectedPatient.Name}' is now being monitored.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
        public static void TestPatient()
        {
            Console.WriteLine("\nSelect a patient to test:");

            for (int i = 0; i < HIMS.Patients.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {HIMS.Patients[i].Name}");
            }

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= HIMS.Patients.Count)
            {
                var selectedPatient = HIMS.Patients[choice - 1];
                HIMS.TestedPatients.Add(selectedPatient);

                Console.WriteLine($"Testing patient: {selectedPatient.Name}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}