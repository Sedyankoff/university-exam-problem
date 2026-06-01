using UniversityExam_2301321042_SI_3_kurs.Decorator;
using UniversityExam_2301321042_SI_3_kurs.Factory;
using UniversityExam_2301321042_SI_3_kurs.Models;
using UniversityExam_2301321042_SI_3_kurs.Singleton;
using UniversityExam_2301321042_SI_3_kurs.Strategy;

University.Instance.StartExam();

Console.WriteLine();

IStudent firstStudent = new Student(
    "Иван",
    StudentType.Wunderkind,
    new JumpRunningStrategy());

firstStudent = new HyperFocusDecorator(firstStudent);

University.Instance.ConductExamFor(firstStudent);

Console.WriteLine();

IStudent secondStudent = new Student(
    "Петър",
    StudentType.FitnessManiac,
    new TeleportationStrategy());

secondStudent = new FastWritingDecorator(secondStudent);

University.Instance.ConductExamFor(secondStudent);

Console.WriteLine();

IStudent thirdStudent = new Student(
    "Георги",
    StudentType.Kalitko,
    new BusSleepingStrategy());

thirdStudent = new TelepathyDecorator(thirdStudent);

University.Instance.ConductExamFor(thirdStudent);

Console.WriteLine();
Console.WriteLine("Контролното приключи.");