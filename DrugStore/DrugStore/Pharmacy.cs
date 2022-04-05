using System;
using System.Collections.Generic;
using System.Text;

namespace DrugStore
{
    class Pharmacy
    {

        public Pharmacy()
        {
            _id++;
            UnikalId = _id;
        }


        private Drug[] _drugs = new Drug[0];
        private int _id;

        public static int UnikalId { get; set; }
        public string Name { get; set; }
        public Drug[] Drugs { get; }

        public override string ToString()
        {
            return $"Id: {_id}, Name: {Name}";
        }

        public void AddDrug(Drug drug)
        {
            Array.Resize(ref _drugs, _drugs.Length + 1);
            _drugs[_drugs.Length - 1] = drug;
        }

        public void DrugList()
        {
            foreach (var item in _drugs)
            {
                Console.WriteLine(item);
            }
        }

        public void SaleDrug(string name, int count, double money)
        {
            bool check = false;
            foreach (var item in _drugs)
            {

                if (item.Count > count)
                {
                    if (item.Price <= money)
                    {
                        if (item.Name == name)
                        {
                            item.Count -= count;
                            check = true;
                            Console.WriteLine("Satis bas verdi");
                            Console.WriteLine(item.ToString());
                        }
                    }
                }
            }
            if (!check)
            {
                Console.WriteLine("Satis bas vermedi");
            }
        }
    }
}
