using System;
namespace CsharpIntermediateLevel
{
    class StudentAge
    {
       public DateTime BirthDay { get; set; }
       public int Age
        {
            get
            {
                var timeSpam = DateTime.Today - BirthDay;
                var years = timeSpam.Days / 365;
                return years;
            }
        }


    }
}
