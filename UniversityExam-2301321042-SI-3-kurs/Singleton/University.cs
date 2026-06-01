using System;
using System.Collections.Generic;
using System.Text;

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
}