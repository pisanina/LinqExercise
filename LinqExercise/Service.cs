using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{
    class Service
    {
        public void DoSomething()
        {
            List<Company> companies = new List<Company>();
            companies.Add(new Company { id = 1, name = "A", numberOfEmployess = 2000 });
            companies.Add(new Company { id = 2, name = "B", numberOfEmployess = 1000 });
            companies.Add(new Company { id = 3, name = "C", numberOfEmployess = 2500 });
            companies.Add(new Company { id = 4, name = "D", numberOfEmployess = 3400 });
            companies.Add(new Company { id = 5, name = "E", numberOfEmployess = 1200 });
            companies.Add(new Company { id = 6, name = "F", numberOfEmployess = 2100 });
            companies.Add(new Company { id = 7, name = "G", numberOfEmployess = 2400 });
            companies.Add(new Company { id = 8, name = "H", numberOfEmployess = 1050 });
            companies.Add(new Company { id = 9, name = "I", numberOfEmployess = 1100 });
            companies.Add(new Company { id = 10, name = "J", numberOfEmployess = 1900 });

            var CzyJestFirmaZWiekszaLiczbaPracownikowNiz3000 = OldAny(companies);
            //upewnij sie, ze rezultat to true;
            


        }


        public bool OldAny(List<Company> c)
        {
            //zaimplementuj tutaj petle for lub foreach na liscie firm 'c' 
            //by zwracala true jesli jest choc jedna firma ktora ma wiecej pracownikow niz 3000
            //false jesli tak nie jest
            throw new NotImplementedException();
        }
    }
}
