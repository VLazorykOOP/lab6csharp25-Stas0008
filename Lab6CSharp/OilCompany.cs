using System.Data;
using static System.Console;

public interface IOilInfo
{
    double production { get; }
    int employees { get; }
}

public class OilCompany : Company, IOilInfo, IComparable<OilCompany>
{
    private string location;

    public double production { get; }
    public int employees { get; }

    public OilCompany(string name, string location, double production, int employees) : base(name)
    {
        this.location = location;
        this.production = production;
        this.employees = employees;
    }

    public OilCompany() : base()
    {
        this.location = "Default location oil company";
        this.production = 100.0;
        this.employees = 100;
    }

    public OilCompany(OilCompany oilCompany) : base(oilCompany.GetName())
    {
        this.location = oilCompany.location;
        this.production = oilCompany.production;
        this.employees = oilCompany.employees;
    }

    public override void Show()
    {
        base.Show();
        WriteLine($"Location of oil company: {location}, production: {production} tons, employees: {employees}.");
    }

    public int CompareTo(OilCompany? other)
    {
        if (other == null) return 1;
        return this.production.CompareTo(other.production);
    }
}
