using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityExam_2301321042_SI_3_kurs.Models;

public interface IStudent
{
    string Name { get; }

    StudentType Type { get; }

    void ShowInfo();
}