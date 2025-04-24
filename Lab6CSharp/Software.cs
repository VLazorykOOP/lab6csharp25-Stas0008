using System;

interface IProgramSoftware : IComparable<IProgramSoftware>
{
    string Name { get; set; }
    string Manufacturer { get; set; }

    void PrintInformation();
    bool CanBeUsed();
}

class Free : IProgramSoftware
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }

    public Free(string name, string manufacturer)
    {
        Name = name;
        Manufacturer = manufacturer;
    }

    public void PrintInformation()
    {
        Console.WriteLine($"[Free] Name: {Name}, Manufacturer: {Manufacturer}");
    }

    public bool CanBeUsed() => true;

    public int CompareTo(IProgramSoftware? other)
    {
        return string.Compare(Name, other?.Name, StringComparison.Ordinal);
    }
}

class Shareware : IProgramSoftware
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public DateTime DateInstall { get; set; }
    public int FreeTrialPeriod { get; set; }

    public Shareware(string name, string manufacturer, DateTime dateInstall, int period)
    {
        if (period < 0)
            throw new InvalidSoftwareDataException("Free trial period dont have a negative.");

        Name = name;
        Manufacturer = manufacturer;
        DateInstall = dateInstall;
        FreeTrialPeriod = period;
    }

    public void PrintInformation()
    {
        Console.WriteLine($"[Shareware] Name: {Name}, Manufacturer: {Manufacturer}, Installed: {DateInstall.ToShortDateString()}, Trial: {FreeTrialPeriod} days");
    }

    public bool CanBeUsed() => DateTime.Now <= DateInstall.AddDays(FreeTrialPeriod);

    public int CompareTo(IProgramSoftware? other)
    {
        return string.Compare(Name, other?.Name, StringComparison.Ordinal);
    }
}

class Commercial : IProgramSoftware
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public DateTime DateInstall { get; set; }
    public int ShelfLife { get; set; }

    public Commercial(string name, string manufacturer, decimal price, DateTime dateInstall, int shelfLife)
    {
        if (price < 0)
            throw new InvalidSoftwareDataException("Price dont have a negative.");

        if (shelfLife < 0)
            throw new InvalidSoftwareDataException("Shelf life dont have a negative.");

        Name = name;
        Manufacturer = manufacturer;
        Price = price;
        DateInstall = dateInstall;
        ShelfLife = shelfLife;
    }

    public void PrintInformation()
    {
        Console.WriteLine($"[Commercial] Name: {Name}, Manufacturer: {Manufacturer}, Price: {Price}$, Installed: {DateInstall.ToShortDateString()}, Valid for: {ShelfLife} days");
    }

    public bool CanBeUsed() => DateTime.Now <= DateInstall.AddDays(ShelfLife);

    public int CompareTo(IProgramSoftware? other)
    {
        return string.Compare(Name, other?.Name, StringComparison.Ordinal);
    }
}

