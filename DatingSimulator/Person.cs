using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        int _extraPoints = 20;

        public int reset{  get; private set; }
        public Person(string name, string personalityType, string description, int age,  bool showsAge)
        {
            Name = name;
            PersonalityType = personalityType;
            Description = description;
            Age = age;
            ShowsAge = showsAge;
            Points = 0;
            reset = Points - Points;
            
            
        }
        public Person() { }

        public void PersonMenu(List <Person> people) 
        {
            ShowInfo(people);
        }
        public void ShowInfo(List<Person> people)
        {
            foreach (var person in people)
            {

                Console.WriteLine($"Name: {person.Name}");
                
                Console.WriteLine($"Personality type: {person.PersonalityType}");
                if (ShowsAge == false) Console.WriteLine("This person decided to not show their age");
            }
        }


        internal void getDateInfo()
        {
            
            Console.WriteLine($"Here is the information your match decided to share: Their name: {Name}, Description: {Description}");
            if (ShowsAge == true) Console.WriteLine($"Age: {Age}");
            if (ShowsAge == false) Console.WriteLine("This person decided to not show their age");
            



        }

       internal void getPoints()
        {
            Points += _pointsOnAnswer;
            Console.WriteLine("Points gained!");
        }
        internal void loosePoints()
        {
            Points -= _pointsOnAnswer;
            Console.WriteLine("Points lost.");
        }
        internal void extraPoints()
        {
            Points += _extraPoints;
            Console.WriteLine("Extra points gained!");
        }

       

        public void holdHands()
        {
            if (Points < 30)
            {
                Console.WriteLine($"{Name} seems a bit confused. Maybe try building up your relationship first");


            }
            else
            {

                Console.WriteLine($"Blushing a bit, {Name} takes your hand");
                getPoints();
            }
        }

    
    }
    }

           
  

