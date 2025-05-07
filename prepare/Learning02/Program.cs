using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtitle = "janitor";
        job1._company = "BYU-I";
        job1._startyear = "2021";
        job1._endyear = "2023";

        Job job2 = new Job();
        job2._jobtitle = "software engineer";
        job2._company = "Google";
        job2._startyear = "2019";
        job2._endyear = "2024";

        Resume myResume = new Resume();
        myResume._name = "John baker";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}
