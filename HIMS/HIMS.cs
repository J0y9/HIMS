using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS
{
    public class HIMS
    {
        public static List<Patient> Patients = new();
        public static List<Patient> MonitoredPatients = new();
        public static List<Patient> TestedPatients = new();
        public static List<Doctor> Doctors = new();
    public static void Start()
    {
        Console.WriteLine("Hospital Information Management System (HIMS)");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. Add Doctor");
            Console.WriteLine("3. Monitor Patient");
            Console.WriteLine("4. Test Patient");
            Console.WriteLine("5. Show Tested Patients");
            Console.WriteLine("6. Show Monitored Patients");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Patient.AddPatient();
                        break;
                    case 2:
                        Doctor.AddDoctor();
                        break;
                    case 3:
                        Patient.MonitorPatient();
                        break;
                    case 4:
                        Patient.TestPatient();
                        break;
                    case 5:
                        ShowTestedPatients();
                        break;
                    case 6:
                        ShowMonitoredPatients();
                        break;
                        case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }
        }
        }

    public static void ShowMonitoredPatients()
    {
        if (MonitoredPatients.Count > 0)
        {
            for (int i = 0; i < MonitoredPatients.Count; i++)
            {
                Console.WriteLine($"{i+1}. {MonitoredPatients[i].Name}");
            }
        }
        else
        {
            Console.WriteLine("There's no Monitored Patients");
        }
    }
    public static void ShowTestedPatients()
    {
        if (TestedPatients.Count > 0)
        {
            for (int i = 0; i < TestedPatients.Count; i++)
            {
                Console.WriteLine($"{i+1}. {TestedPatients[i].Name}");
            }
        }
        else
        {
            Console.WriteLine("There's no Tested Patients");
        }
    }
    }

}