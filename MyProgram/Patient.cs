using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace MyProgram
{
    public class Patient
    {

        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string mrn;
        private string phone1;
        private string phone2;
        private string mail;
        private string ohipnamber;
        private string versionCode;
        private string dateOfExpirity;
        private string city;
        private string note;
        public static string GenerateRandomString(int max)
        {
            Random rnd = new Random();
            int l = Convert.ToInt32(rnd.NextDouble() * max);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < l; i++)
            {
                builder.Append((int)rnd.Next(1, 100));  
            }
            return builder.ToString();
        }

        public string FirstName
        {
            get
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                firstName = textInfo.ToTitleCase(this.firstName);
                return firstName;
            }
            set
            {
                do
                {
                    firstName = value;
                    if (firstName == "")
                    {
                        Console.WriteLine("Это обязательное поле!!!Введите имя пациента!!!: ");
                        firstName = Console.ReadLine();
                    }

                } while (firstName == "");
            }
        }
        public string LastName
        {
            get
            {
                //если ввели данные фамилии с маленькой, то отдаем с большой
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;
                lastName = textInfo.ToTitleCase(this.lastName);
                return lastName;
            }
            set
            {  // делаем проверку введенной фамилии пациента, если ничего не ввели, просим ввести пока не введут хоть что-то
                do
                {
                    lastName = value;
                    if (lastName == "")
                    {
                        Console.WriteLine("Это обязательное поле!!!Введите фамилию!!!: ");
                        lastName = Console.ReadLine();
                    }

                } while (lastName=="");
                
            }
        }
        public string Mail { get; set;}

        public string Note { get; set; }
        
        public string City { get; set; }

        public string DateOfExpirity{ get; set; }

        public string VersionCode { get; set; }
       
        public string OhipNumber
        {
            get
            {
                return ohipnamber;
            }
            set
            {   
                ohipnamber = value;
                if (ohipnamber.Length != 10)
                {
                    Console.WriteLine("wrong card number entered! Card number must be 10 digits. Enter the correct card:");
                    
                    ohipnamber = Console.ReadLine(); 
                }

            }
        }
        public string Phone2 { get; set; }
        
        public string Phone1 { get; set; }


        public string Mrn
        {
            get { return mrn; }
            set
            {  //если не ввели мрн то он генерируется автоматически
                mrn = value;
                if (mrn == "")
                {
                    mrn = GenerateRandomString(5);
                }
               
            }
        }

        public string DateOfBirth { get; set; }


    }
}

