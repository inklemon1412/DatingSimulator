/*
 Oppgave, Dating Simulator:
Lage en person class.
Kunne Legge inn info oim deg selv.
Legge til info om personene.
Lage en liste med Personer og kanskje bruke random for å få tilfeldig person du møter.
Lage en logikk på relasjonsteller for å sjekke om du matcher med noen. F.eks: Egen klasse eller lignende?
Eventuelt lage mulighet for samtale mellom personene, kanskje du kan spørre de om interesser også dukker de opp i en form for dialog.


Bygge ut så mye du ønsker videre, men husk å starte smått, bruke det du har lært igjennom emne, og bruke både parametere, tenke objektorientering, bruke  { get; private set; }.

*/
using DatingSimulator;
Profile profile = new Profile();
Person person = new Person();

MainMenu();
void MainMenu()
{
    while (true)
    {
        Console.WriteLine("Welcome to the dating sim. ");
        Console.WriteLine("press 1 to make your profile");
        Console.WriteLine("press 2 to see available people"); //ha en eventuell choice der man kan søke etter personlighetstype

        var userInput = Console.ReadLine();
        if (userInput == "1")
        {
            profile.ProfileMenu(profile);
        }
        
       
     
    }
}


