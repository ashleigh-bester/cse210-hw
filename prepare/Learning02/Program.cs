using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Wild and Free";
        job1._jobTitle = "Wildlife Rehabilitation Volunteer";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "#CleanTanks";
        job2._jobTitle = "Admin Assistant/Assistant Trainer";
        job2._startYear = 2022;
        job2._endYear = 2024;
        
        Resume resume = new Resume();
        resume._name = "Ashleigh Bester";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}