using System.Data;
using static System.Console;

static void Task1()
{
    Company[] companies = new Company[]
        {
            new InsuranceCompany("InSureCo", "USA", 0.12),
            new InsuranceCompany("SafeLife", "Canada", 0.10),
            new OilCompany("PetroMax", "USA", 7.8, 500),
            new OilCompany("British petrolium", "Great Britain", 5.5, 340),
            new Factory("AutoMakers", "Germany", 1200),
            new Factory("TechManufact", "China", 3000),
        };
        
        WriteLine("Original order:");
        foreach (var company in companies)
        {
            company.Show();
            WriteLine();
        }
        Array.Sort(companies, (a, b) =>
        {
            return a switch
            {
                OilCompany oc1 when b is OilCompany oc2 => oc1.CompareTo(oc2),
                InsuranceCompany ic1 when b is InsuranceCompany ic2 => ic1.CompareTo(ic2),
                Factory f1 when b is Factory f2 => f1.CompareTo(f2),
                _ => 0
            };
        });
        
        WriteLine("Sorted companies by their specific CompareTo implementations:");
        foreach (var company in companies)
        {
            company.Show();
            WriteLine();
        }
}

static void Task2()
{
    IProgramSoftware[] softwares = new IProgramSoftware[]
        {
            new Free("Notepad++", "Don Ho"),
            new Shareware("WinRAR", "Rarlab", DateTime.Now.AddDays(-10), 40),
            new Shareware("SomeTrialApp", "Trial Inc.", DateTime.Now.AddDays(-60), 30),
            new Commercial("MS Office", "Microsoft", 199.99m, DateTime.Now.AddDays(-15), 365),
            new Commercial("Photoshop", "Adobe", 250.00m, DateTime.Now.AddDays(-400), 365)
        };

        Console.WriteLine("All software:");
        foreach (var sw in softwares)
        {
            sw.PrintInformation();
        }

        Console.WriteLine("\nUsable software:");
        foreach (var sw in softwares)
        {
            if (sw.CanBeUsed())
                sw.PrintInformation();
        }

        Console.WriteLine("\nSorted by name:");
        Array.Sort(softwares);
        foreach (var sw in softwares)
        {
            sw.PrintInformation();
        }
}

static void Task3()
{
    
}

static void Task4()
{

}

Task2();