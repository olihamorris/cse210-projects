using System;

class Program
{
    static void Main(string[] args)
    {
        // First job
        Job job1 = new Job();
        job1._jobTitle = "Registered Nurse";
        job1._company = "St. Mary's Children Hospital";
        job1._startYear = 2015;
        job1._endYear = 2019;

        // Second job
        Job job2 = new Job();
        job2._jobTitle = "Clinical Coordinator";
        job2._company = "HealthFirst Clinic";
        job2._startYear = 2020;
        job2._endYear = 2024;

        // Create resume and add jobs
        Resume myResume = new Resume();
        myResume._name = "Amina Yusuf";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();
    }
}