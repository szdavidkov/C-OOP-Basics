﻿using System;
using System.Text;
using System.Text.RegularExpressions;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName,string lastName,string facultyNumber)
        :base( firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    private string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (IsNumberInvalid(value))
                throw new ArgumentException("Invalid faculty number!");
            facultyNumber = value;
        }
    }
    private static bool IsNumberInvalid(string value)
    {
        var numberPattern = @"^([0-9a-zA-Z]{5,10})$";
        var regex = new Regex(numberPattern);
        var match = regex.Match(value);
        if (match.Success)
            return false;
        return true;
    }

    public override string ToString()
    {
        return $"\nFirst Name: {FirstName}" +
               $"\nLast Name: {LastName}" +
               $"\nFaculty number: {FacultyNumber}";
    }
}

