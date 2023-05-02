using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Applebee's";
        job1._jobTitle = "Waiter";
        job1._startYear = 2008;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._company = "Walmart";
        job2._jobTitle = "Cashier";
        job2._startYear = 2017;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._name = "Jacob Peterson";

        resume.DisplayResume();
    }
}