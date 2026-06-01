using System;
using System.Collections.Generic;
using System.Text;
using UniversityExam_2301321042_SI_3_kurs.Factory;
using UniversityExam_2301321042_SI_3_kurs.Models;

namespace UniversityExam_2301321042_SI_3_kurs.Singleton;

public sealed class University
{
    private static readonly University _instance = new();

    public static University Instance => _instance;

    private University()
    {
    }

    public void StartExam()
    {
        Console.WriteLine("Контролното започва.");
    }

    public void ConductExamFor(IStudent student)
    {
        student.ShowInfo();

        var examTask = ExamTaskFactory.Create(student.Type);

        Console.WriteLine(examTask.Description);
    }
}