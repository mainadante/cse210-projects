using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job
        {
            _jobTitle = "Software Engineer",
            _company= "Apple",
            _startYear = 2019,
            _endYear = 2022

        };
        

        Job job2 = new Job
        {
            _jobTitle = "Manager",
            _company= "Microsoft",
            _startYear = 2022,
            _endYear = 2023

        };

            
        Resume myResume = new Resume
        {
            _name = "Maina Dante"

        };

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

    }


}
