using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DatingSimulator
{

    internal class Profile
    {
        public List<Person> people { get; private set; }
        public Random Random = new Random();
        public Person dateable;

        public string userName { get; private set; }
        public int userAge;
        public string _userPersonality;
        private User user;

        public Profile()
        {
            people = new List<Person>()
            {

                    new Person("Alex", "Shy", "I like quiet and peaceful places. I'd love to go hang out in a park or something", 23, false),
                    new Person("Rose", "Shy", "I love nature. Sitting on a bench and listening to the birds chirp is my favourite thing", 22, true),
                    new Person("Myers", "Shy", "The less people there are, the better. Besides, I'd like to be able to spend more time with you only", 27, false),
                   
                    new Person("Ryan", "Bold", "A true partyanimal. Take me to a festival and I'll show you a good time ;)", 29, true),
                    new Person("Mack", "Bold", "Let me take care of our first dinner together :)", 27, true),
                    new Person("Riley", "Bold", "I need some excitement in my life. Take me to it?", 24, true),

                    new Person("Angel", "Flirty", "Sometimes I get called the opposite of a saint ;) Let's go on a fun date and maybe you'll find out why", 26, true),
                    new Person("Skye", "Flirty", "I like long walks on the beach... And maybe in your house as well...", 28, false),
                    new Person("Jen", "Flirty", "Did it hurt when you fell down from heaven? Because I can give a mean backmassage :3", 27, true),
            };

        }

        public void ProfileMenu(Profile profile)
        {
            while (true)
            {
                Console.WriteLine("Welcome, user! What is your name?");
                var userName = Console.ReadLine();
                Console.WriteLine("What is your age");
                var userAge = Console.ReadLine();
                Console.WriteLine("What's your personality type?");

                Console.WriteLine("Choose one of these three personality types: \r\n 1) Awkward. \r\n 2) Adventurous. \r\n 3) Romantic");
                var userPersonality = Console.ReadLine();
                var userInput = Console.ReadLine();

                

                if (userPersonality == "1")
                {
                    _userPersonality = "Awkward";
                    dateable = GetRandomPerson("Shy");
                }
                else if (userPersonality == "2")
                {
                    _userPersonality = "Adventurous";
                    dateable = GetRandomPerson("Bold");
                }
                else if (userPersonality == "3")
                {
                    _userPersonality = "Romantic";
                    dateable = GetRandomPerson("Flirty");
                }

                
               else
                {
                    Console.WriteLine("no match found");
                    
                    
                    
                }
                MatchSystem(userName, _userPersonality, dateable, user, profile);

            }


            void MatchSystem(string? userName, string? _userPersonality, Person dateable, User user, Profile profile)
            {
                bool _matched = false;
                bool _inMenu = true;
                while (_inMenu)
                {
                    Console.WriteLine($"Welcome to the match system {userName} We will now try and find matches based on your personality type");
                    Console.WriteLine("Matching...");
                    Thread.Sleep(800);
                    Console.WriteLine("Matching...");
                    Thread.Sleep(800);
                 //   dateable.resetPoints();


                    if (_userPersonality == "Adventurous")
                    {
                        Console.WriteLine($"You've matched with {dateable.Name}");
                        _matched = true;
                    }
                    if (_userPersonality == "Awkward")
                    {
                        Console.WriteLine($"You've matched with {dateable.Name}");
                        _matched = true;
                    }
                    if (_userPersonality == "Romantic")
                    {
                        Console.WriteLine($"You've matched with {dateable.Name}");
                        _matched = true;
                    }


                    while (_matched)
                    {
                        Console.WriteLine($"Congrats on the match! Would you like to see more information on {dateable.Name} before going on a date? y for yes, g for go on date, n for no - return to profile maker");
                        var userInput = Console.ReadLine();
                        if (userInput == "y")
                        {
                            dateable.getDateInfo();



                        }
                        if (userInput == "n")
                        {
                            return;
                        }
                        if (userInput == "g")
                        {
                            goOnDate(userName, dateable, user, profile);
                        }
                        

                    }

                }
            }
        }



        public void goOnDate(string? userName, Person dateable, User user, Profile profile)
        {
            var date = new DatePlaces();
            date.DatePlaceMenu(userName, dateable, profile);
        }

        public Person GetRandomPerson(string personalityType)
        {
            var possibleDateables = people.Where(person => person.PersonalityType == personalityType).ToList();
            var index = Random.Next(0, possibleDateables.Count);
            return possibleDateables[index];
        }

      
    }
}
    
// velg fra en liste med personlighetstrekk, få forskjellige matches basert på hvilken personlighet du har valgt
// f.eks _chosenpersonality = string, litt som chosenpokemon fra codealong oppgaven
// se matches i denne klassen


// sånn typ: "welcome user! what is your name"
// - skriv navn her, 
// - "what personality type best describes you?"
// - skriv inn en av de godkjente personlighetstypene
// "what is your age?"
// - skriv inn alder.
// "Your name: {_chosenName}, personality type: {_chosenPersonality}, age: {_chosenAge}. Is this correct?"