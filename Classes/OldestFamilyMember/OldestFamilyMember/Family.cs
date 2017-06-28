using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> people;

    public Family()
    {
        People = new List<Person>();
    }
    public List<Person> People
    {
        get { return this.people; }
        set { this.people = value; }
    }

    public void AddMember(Person member)
    {
        this.People.Add(member);
    }

    public Person GetOldestMember()
    {
        return People.OrderByDescending(x => x.age).FirstOrDefault();
    }
    public List<Person> SelectedPersons()
    {
        return this.People.Where(x => x.age > 30).OrderBy(x => x.name).ToList();
    }
}

