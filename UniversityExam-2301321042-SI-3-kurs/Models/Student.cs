using System;
using System.Collections.Generic;
using System.Text;
using UniversityExam_2301321042_SI_3_kurs.Strategy;

namespace UniversityExam_2301321042_SI_3_kurs.Models;

public class Student : IStudent
{
    private readonly IArrivalStrategy _arrivalStrategy;

    public string Name { get; }

    public StudentType Type { get; }

    public Student(
        string name,
        StudentType type,
        IArrivalStrategy arrivalStrategy)
    {
        Name = name;
        Type = type;
        _arrivalStrategy = arrivalStrategy;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Студент: {Name}");
        Console.WriteLine($"Тип студент: {GetTypeName()}");
        _arrivalStrategy.Arrive();
    }

    private string GetTypeName()
    {
        return Type switch
        {
            StudentType.Wunderkind => "вундеркинд",
            StudentType.FitnessManiac => "фитнес маниак",
            StudentType.Kalitko => "калитко",
            _ => "неизвестен"
        };
    }
}