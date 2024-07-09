using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DatingSimulator
{
    
    internal class Person
    {
       
        public string Name { get; private set; }
        public string PersonalityType { get; private set; }
        public string Description { get; private set; }
        public int Age { get; private set; }
        public bool ShowsAge { get; private set; }

        public int Points { get; private set; }
        int _pointsOnAnswer = 10;
        public Person(string name, string personalityType, string description, int age, bool showsAge)
        {
            Name = name;
            PersonalityType = personalityType;
            Description = description;
            Age = age;
            ShowsAge = showsAge;
            Points = 0;
        }
        public Person() { }

        public void ShowInfo(List<Person> people)
        {
            foreach (var person in people)
            {

                Console.WriteLine($"Name: {person.Name}");
                if (ShowsAge == true) Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Personality type: {person.PersonalityType}");
                if (ShowsAge == false) Console.WriteLine("This person decided to not show their age");
            }
        }


        internal void getDateInfo()
        {
            
            Console.WriteLine($"Here is the information your match decided to share: Their name: {Name}, Age: {Age}, Description: {Description}");
            
         
        }

        public void getPoints()
        {
            Points += _pointsOnAnswer;
        }
        internal void loosePoints()
        {
            Points -= _pointsOnAnswer;
        }
    }
    }

           
  

