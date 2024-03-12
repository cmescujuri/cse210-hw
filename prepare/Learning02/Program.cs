using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1994;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2012;
        job2._endYear = 2024;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Cassie Escujuri";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}