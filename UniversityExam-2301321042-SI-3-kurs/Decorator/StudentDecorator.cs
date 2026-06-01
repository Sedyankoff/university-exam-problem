using System;
using System.Collections.Generic;
using System.Text;
using UniversityExam_2301321042_SI_3_kurs.Models;

namespace UniversityExam_2301321042_SI_3_kurs.Decorator;

public abstract class StudentDecorator : IStudent
{
    protected readonly IStudent Student;

    public string Name => Student.Name;

    protected StudentDecorator(IStudent student)
    {
        Student = student;
    }

    public virtual void ShowInfo()
    {
        Student.ShowInfo();
    }
}