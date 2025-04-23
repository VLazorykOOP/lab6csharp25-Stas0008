using System.Data;
using static System.Console;

public interface IInsuranceInfo
{
    double commission { get; }
}

public class InsuranceCompany : Company, IInsuranceInfo, IComparable<InsuranceCompany>
{
    private string type;

    public double commission { get; }

    public InsuranceCompany(string name, string type, double commission) : base(name)
    {
        this.type = type;
        this.commission = commission;
    }

    public InsuranceCompany() : base()
    {
        this.type = "Default type insurance";
        this.commission = 10.0;
    }

    public InsuranceCompany(InsuranceCompany insuranceCompany) : base(insuranceCompany.GetName())
    {
        this.type = insuranceCompany.type;
        this.commission = insuranceCompany.commission;
    }

    public override void Show()
    {
        base.Show();
        WriteLine($"Type of insurance: {type}, commission: {commission:P2} .");
    }

    public int CompareTo(InsuranceCompany? other)
    {
        if (other == null) return 1;
        return this.commission.CompareTo(other.commission);
    }
}
