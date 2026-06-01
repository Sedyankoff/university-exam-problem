using System;
using System.Collections.Generic;
using System.Text;
using UniversityExam_2301321042_SI_3_kurs.Models;

namespace UniversityExam_2301321042_SI_3_kurs.Factory;

public static class ExamTaskFactory
{
    public static IExamTask Create(StudentType studentType)
    {
        return studentType switch
        {
            StudentType.Wunderkind => new FunTask(),
            StudentType.FitnessManiac => new ConfusingTask(),
            StudentType.Kalitko => new EasyTask(),
            _ => throw new ArgumentException("Непознат тип студент.")
        };
    }
}