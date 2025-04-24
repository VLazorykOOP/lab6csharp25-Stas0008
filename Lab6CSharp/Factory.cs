using System.Data;
using static System.Console;

public interface IFactoryInfo
{
    int employees { get; }
}

public class Factory : Company, IFactoryInfo, IComparable<Factory>
{
    private string type;

    public int employees { get; }

    public Factory(string name, string type, int employees) : base(name)
    {
        this.type = type;
        this.employees = employees;
    }

    public Factory() : base()
    {
        this.type = "Default type factory";
        this.employees = 100;
    }

    public Factory(Factory factory) : base(factory.GetName())
    {
        this.type = factory.type;
        this.employees = factory.employees;
    }

    public override void Show()
    {
        base.Show();
        WriteLine($"Type of factory: {type}, employees: {employees}");
    }

    public int CompareTo(Factory? other)
    {
        if (other == null) return 1;
        return this.employees.CompareTo(other.employees);
    }

    public new IEnumerator<Company> GetEnumerator()
    {
        yield return this;
    }
}
