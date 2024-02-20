using ConsoleApp2.Models;
using System.Data.SqlTypes;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1
            /*List<int> numbers = new List<int> { 1, 2, 3, 44564, 5, 6, 7, 8, 9, 10 };
            int i = 0;

            var res = numbers.Where(x => { i ++; return i >= 4 && i <= 6; }).ToList();

            foreach (int x in res)
            {
                Console.WriteLine(x);
            }*/

          

            List<ProgrammingLanguage> programmingLanguages = new List<ProgrammingLanguage>
            {
                new ProgrammingLanguage{Id = 1,Name = "C#"},
                new ProgrammingLanguage{Id = 2,Name = "C++"},
                new ProgrammingLanguage{Id = 3,Name = "Java"},
                new ProgrammingLanguage{Id = 3,Name = ""},
            };

            List<Accountant> accountants = new List<Accountant>
            {
                new Accountant{Id = 1,Name = "Abdulla",ProgrammingLanguageId = 1},
                new Accountant{Id = 2,Name = "Bobur",ProgrammingLanguageId = 1},
                new Accountant{Id = 3,Name = "Sherzod",ProgrammingLanguageId = 2},
                new Accountant{Id = 4,Name = "Qobil",ProgrammingLanguageId = 2},
                new Accountant{Id = 5,Name = "Alisher",ProgrammingLanguageId = 3},
                new Accountant{Id = 6,Name = "Qosim",ProgrammingLanguageId = 4}

            };

            // Task2
            var AccountantLanguages = accountants
                .Join(programmingLanguages,
                      acc => acc.ProgrammingLanguageId,
                      prl => prl.Id,
                      (acc, prl) => new { AccountantId = acc.Id, AccountantName = acc.Name, LanguageName = prl.Name });

            /*foreach(var x in AccountantLanguages)
            {
                if(x.LanguageName  != "")
                {
                    Console.WriteLine(x.AccountantId + "--->" + x.AccountantName +"--->" + x.LanguageName);
                }
            }*/

            foreach(var x in AccountantLanguages)
            {
                if(x.LanguageName == "C#")
                {
                    Console.WriteLine(x.AccountantId + "--->" + x.AccountantName + "--->" + x.LanguageName);
                }
            }
        }
    }
}