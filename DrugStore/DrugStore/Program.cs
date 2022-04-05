using System;

namespace DrugStore
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeDrug typeDrug1 = new TypeDrug
            {
                TypeName = "Agri kesici"
            };

            TypeDrug typeDrug2 = new TypeDrug
            {
                TypeName = "Vitamin"
            };

            Drug drug1 = new Drug
            {
                Name = "Spazmagon",
                Count = 2,
                Price = 1.2,
                Type = typeDrug1
            };

            Drug drug2 = new Drug
            {
                Name = "B12",
                Count = 3,
                Price = 2.2,
                Type = typeDrug2
            };

            Pharmacy pharmacy1 = new Pharmacy { 
            Name = "Zeferan"
            };

            pharmacy1.AddDrug(drug1);
            pharmacy1.AddDrug(drug2);

            Console.WriteLine("Aptekde olan dermanlar haqda melumatlar:");
            pharmacy1.DrugList();

            pharmacy1.SaleDrug("Spazmagon", 1, 6);
            pharmacy1.SaleDrug("B12", 2, 6);

            pharmacy1.ToString();
            Console.WriteLine("====================");
            Console.WriteLine("Aptekde qalan dermanlar haqda melumatlar:");
            pharmacy1.DrugList();
        }
    }
}
