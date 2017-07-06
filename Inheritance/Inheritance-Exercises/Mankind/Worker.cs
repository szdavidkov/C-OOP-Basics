using System;
using System.Text;
using System.Text.RegularExpressions;

public class Worker : Human
{
    private double hoursPerDay;
    private double weekSalary;

    public Worker(string firstName, string lastName, double weekSalary, double hoursPerDay)
        :base( firstName, lastName)
    {
        this.HoursPerDay = hoursPerDay;
        this.WeekSalary = weekSalary;
    }


    public virtual double HoursPerDay
    {
        get { return this.hoursPerDay; }
        set
        {
            
            if (value < 1 && value > 12)
            {
                throw  new ArgumentException("Expected value mismatch! Argument: hoursPerDay");
            }
            this.hoursPerDay = value;
        }
    }

    public virtual double WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    double SalaryPerHour => WeekSalary / (HoursPerDay * 5);

    public override string ToString()
    {
        return $"\nFirst Name: {FirstName}" +
               $"\nLast Name: {LastName}" +
               $"\nWeek Salary: {WeekSalary:F2}" +
               $"\nHours per day: {HoursPerDay:F2}" +
               $"\nSalary per hour: {SalaryPerHour:F2}";
    }
}

