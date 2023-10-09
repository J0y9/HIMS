namespace HIMS;



class Program
    {
        //static List<string> patients = new List<string>();
        //static List<string> doctors = new List<string>();
        //static List<string> monitoredPatients = new List<string>();

        static void Main()
        {
            HIMS.Start();


        //Console.WriteLine("Hospital Information Management System (HIMS)");

        //while (true)
        //{
        //    Console.WriteLine("\nMenu:");
        //    Console.WriteLine("1. Add Patient");
        //    Console.WriteLine("2. Add Doctor");
        //    Console.WriteLine("3. Monitor Patient");
        //    Console.WriteLine("4. Test Patient");
        //    Console.WriteLine("5. Exit");
        //    Console.Write("Select an option: ");

        //    if (int.TryParse(Console.ReadLine(), out int choice))
        //    {
        //        switch (choice)
        //        {
        //            case 1:
        //                AddPatient();
        //                break;
        //            case 2:
        //                AddDoctor();
        //                break;
        //            case 3:
        //                MonitorPatient();
        //                break;
        //            case 4:
        //                TestPatient();
        //                break;
        //            case 5:
        //                Environment.Exit(0);
        //                break;
        //            default:
        //                Console.WriteLine("Invalid choice. Please try again.");
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid option.");
        //    }
        //}
    }

        //static void AddPatient()
        //{
        //    Console.Write("\nEnter Patient Name: ");
        //    string patientName = Console.ReadLine();
        //    patients.Add(patientName);
        //    Console.WriteLine($"Patient '{patientName}' added successfully.");
        //}

        //static void AddDoctor()
        //{
        //    Console.Write("\nEnter Doctor Name: ");
        //    string doctorName = Console.ReadLine();
        //    doctors.Add(doctorName);
        //    Console.WriteLine($"Doctor '{doctorName}' added successfully.");
        //}

        //static void MonitorPatient()
        //{
        //    Console.WriteLine("\nSelect a patient to monitor:");

        //    for (int i = 0; i < patients.Count; i++)
        //    {
        //        Console.WriteLine($"{i + 1}. {patients[i]}");
        //    }

        //    if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= patients.Count)
        //    {
        //        string selectedPatient = patients[choice - 1];
        //        monitoredPatients.Add(selectedPatient);
        //        Console.WriteLine($"Patient '{selectedPatient}' is now being monitored.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid choice. Please try again.");
        //    }
        //}

        //static void TestPatient()
        //{
        //    Console.WriteLine("\nSelect a patient to test:");

        //    for (int i = 0; i < patients.Count; i++)
        //    {
        //        Console.WriteLine($"{i + 1}. {patients[i]}");
        //    }

        //    if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= patients.Count)
        //    {
        //        string selectedPatient = patients[choice - 1];
        //        Console.WriteLine($"Testing patient: {selectedPatient}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid choice. Please try again.");
        //    }
        //}
    }
