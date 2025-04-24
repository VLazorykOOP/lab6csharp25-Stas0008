using System.Collections;
using System.Data;
using static System.Console;


public abstract class Company : IEnumerable<Company>
{
    private String name;

    public string GetName() => name;

    public Company(String name) {
        this.name = name;
    }

    public Company() {
    this.name = "Default name company";
    }

    public Company(Company company) {
    this.name = company.name;
    }

    public virtual void Show() {
        WriteLine("Company name: " + name);
    }

    public IEnumerator<Company> GetEnumerator()
    {
        yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}