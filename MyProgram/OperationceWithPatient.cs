using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    public class OperationceWithPatient : Patient
    {
        List<Patient> TotalPatientList = new List<Patient>();

        public Patient GetPatientInfo()
        {
            Patient patient = new Patient();
            Console.WriteLine("Введите имя пациента:");
            patient.FirstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию пациента:");
            patient.LastName = Console.ReadLine();
            Console.WriteLine("Введите дату рождения пациента:");
            patient.DateOfBirth = Console.ReadLine();
            Console.WriteLine("Введите mrn, иначе он будет сгенирирован автоматически : ");
            patient.Mrn = Console.ReadLine();
            Console.WriteLine("Введите номер телефона пациента:");
            patient.Phone1 = Console.ReadLine();
            Console.WriteLine("Введите дополнительный номер телефона пациента:");
            patient.Phone2 = Console.ReadLine();
            Console.WriteLine("Введите город и адрес проживания пациента:");
            patient.City = Console.ReadLine();
            Console.WriteLine("Введите электронную почту пациента:");
            patient.Mail = Console.ReadLine();
            Console.WriteLine("Введите Ohip карту пациента:");
            patient.OhipNumber = Console.ReadLine();
            Console.WriteLine("Введите version code :");
            patient.VersionCode = Console.ReadLine();
            Console.WriteLine("Введите дату окончания срока действия карты:");
            patient.DateOfExpirity = Console.ReadLine();

            return patient;
        }

        public Patient GetPatientInfoForDelete()
        {
            Patient deletePatient = new Patient();
            Console.WriteLine("Введите имя пациента которого Вы хотите удалить:");
            deletePatient.FirstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию пациента которого Вы хотите удалить:");
            deletePatient.LastName = Console.ReadLine();
            Console.WriteLine("Введите дату рождения пациента которого Вы хотите удалить:");
            deletePatient.DateOfBirth = Console.ReadLine();

            return deletePatient;
        }

        public void AddPatient()
        {
            Patient patient = GetPatientInfo();
            TotalPatientList.Add(patient);
            WriteTotalList();
        }

        public void DeletePatient()
        {
            int before = TotalPatientList.Count();

            Patient deletePatient = GetPatientInfoForDelete();
           
            foreach (Patient row in TotalPatientList)
            {
                if (deletePatient.FirstName == row.FirstName && deletePatient.LastName == row.LastName &&
                    deletePatient.DateOfBirth == row.DateOfBirth)
                {
                    TotalPatientList.Remove(row);
                    Console.WriteLine("Пациент" + " " + deletePatient.LastName + " " + deletePatient.FirstName + " " + "был удалён");
                    if (TotalPatientList.Count > 0)
                    {
                        WriteTotalList(); 
                    }
                   
                }
            }

            if (TotalPatientList.Count == before)
            {
                Console.WriteLine("Нет такого пациента в базе!!");
            }
        }

        public void WriteTotalList()
        {
            foreach (Patient row in TotalPatientList)
            {
                Console.WriteLine(row.FirstName + " " + "|" + " " + row.LastName + " " + "|" 
                                  +" " + row.DateOfBirth + " " + "|" + " " +row.Mrn + " " + "|" + " " + row.OhipNumber
                                  + " " + "|" + " " +row.Phone1
                                  + " " + "|" + " " +row.Phone2 + " " + "|" + " " +row.City + " " + "|" + " " +row.Mail);
                Console.ReadLine();
            }
        }
    }
}
