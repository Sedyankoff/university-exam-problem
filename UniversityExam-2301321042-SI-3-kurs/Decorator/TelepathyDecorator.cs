using System;
using System.Collections.Generic;
using System.Text;
using UniversityExam_2301321042_SI_3_kurs.Models;

namespace UniversityExam_2301321042_SI_3_kurs.Decorator;

public class TelepathyDecorator : StudentDecorator
{
    public TelepathyDecorator(IStudent student)
        : base(student)
    {
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Получава суперсила: телепатия.");
    }
}