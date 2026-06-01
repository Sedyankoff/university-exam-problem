using System;
using System.Collections.Generic;
using System.Text;
using UniversityExam_2301321042_SI_3_kurs.Strategy;

namespace UniversityExam_2301321042_SI_3_kurs.Models;

public class Student : IStudent
{
    private readonly IArrivalStrategy _arrivalStrategy;

    public string Name { get; }

    public Student(
        string name,
        IArrivalStrategy arrivalStrategy)
    {
        Name = name;
        _arrivalStrategy = arrivalStrategy;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Студент: {Name}");
        _arrivalStrategy.Arrive();
    }
}