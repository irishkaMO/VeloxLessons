using System;
using System.Text;
using System.Diagnostics;

namespace MyProgram
{
   public class Program 
    {
        delegate void PatientAction();

        private static void NotCorrect()
        {
            Console.WriteLine("Введено некоректное значение. Попробуйте ещё раз!");
        }

        private static void GoodBy()
        {
            Console.WriteLine("До свидания!");
            Console.Read();
            Process.GetCurrentProcess().Kill();
        }

        static void Main(string[] args)
        {
            OperationceWithPatient operationPatient = new OperationceWithPatient();

            string operations = null;
            Console.OutputEncoding = Encoding.UTF8;

            PatientAction action;

            do
            {
                Console.WriteLine("Выберите действие (Добавдение нового пациента-1, Удаление пациента-2, Вывод списка пациентов-3, Для выхода нажмите 0):");

                action = NotCorrect;

                operations = Console.ReadLine();

                if (operations == "0")
                {
                    action = GoodBy;
                }

                if (operations == "1")
                {
                    action = operationPatient.AddPatient;
                }

                if (operations == "2")
                {
                    action = operationPatient.DeletePatient;
                }

                if (operations == "3")
                {
                    action = operationPatient.WriteTotalList;
                }

                action();

            } while (operations != "0");

            Console.ReadKey();
        }
    }
}
