using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityExam_2301321042_SI_3_kurs.Strategy;

public class TeleportationStrategy : IArrivalStrategy
{
    public void Arrive()
    {
        Console.WriteLine("Пристига чрез телепортация.");
    }
}