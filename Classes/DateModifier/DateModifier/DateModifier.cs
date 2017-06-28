using System;
using System.Globalization;

public class DateModifier
{
    private string firstDate;
    private string secondDate;

    public string FirstDate
    {
        get { return firstDate; }
        set { this.firstDate = value; }
    }

    public string SecondDate
    {
        get { return secondDate; }
        set { this.secondDate = value; }
    }

    public DateModifier(string firstDate, string secondDate)
    {
        this.FirstDate = firstDate;
        this.SecondDate = secondDate;
    }

    public double CalculateDifference()
    {
        var date1 = DateTime.ParseExact(FirstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        var date2 = DateTime.ParseExact(SecondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

        return Math.Abs((date2 - date1).TotalDays);
    }


}

