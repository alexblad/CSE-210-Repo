/*
CREATE A PROGRAM THAT TO REPRESENT A RESUME OR JOB HISTORY FOR SOMEONE LIKE ME
    There should be 2 classes, Job and Resume
        1. Design the classes
        2. Start the project(verify that every is working with the development environment)
        3. Create the Job class
        4. Test the Job Class
        5. Add a Display method to the Job class
        6. Create the Resume class
        7. Test Resume class
        8. Add a display method to the Resume class


*/

using System;

class Program
{
    static void Main(string[] args)
    {
    //Creates and instance of the Job class
      Job job1 = new Job();
      job1._jobTitle = "Software Engineer";
      job1._companyName = "Microsoft";
      job1._startYear = 1998;
      job1._endYear = 2008;


    //Creates and instance of the Job class
      Job job2 = new Job();
      job2._jobTitle = "Software Architect";
      job2._companyName = "Apple";
      job2._startYear = 2010;
      job2._endYear = 2015;

      //Console.WriteLine(job1._companyName);
      //Console.WriteLine(job2._companyName);
    
    //Calls the DisplayInfo() function for each the specified Job class
      //job1.DisplayInfo();
      //job2.DisplayInfo();

      Resume resume1 = new Resume();
      resume1._name = "Alexander Blad";

      resume1._jobs.Add(job1);
      resume1._jobs.Add(job2);

      
      //Displays the job title of the first ._jobs in the list
      //Console.WriteLine(resume1._jobs[0]._jobTitle);

      resume1.DisplayInfo();
    }
}