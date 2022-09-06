/*
 * Opgaver til 2. Semester IT-Arkitetur, C# intro, Lektiecafé
 * OPGAVE SÆT 2
 */

// Her i feltet under, tester du din kode. Bare slet "//" foran Console.WriteLine for at prøve din kode af i consolen.

////////////////////////////////////////////////////////  TESTS  ////////////////////////////////////////////////////////


//(dette er bare personer vi tester koden af på)
Person person1 = new Person("William", "Kruse", 4239, 1998, "STX", false, false); 
Person person2 = new Person("Mette", "Frederiksen", -100000, 1970, "STX", false, false);
Person person3 = new Person("Lars", "Løkke", 42390, 1964, "HHX", true, true);
Person[] personliste1 = new Person[] { person1, person2, person3 }; // Her laver vi så et array med de 3 personer


// opgave 1 test:
// Console.WriteLine(person1.FindAlder());


//opgave 2 test:
// her udskriver vi fornavnet på den ældste person i consollen
// Console.WriteLine(FindÆldste(personliste1).Fornavn);


// opgave 3 test:
// Console.WriteLine(FormueSum(personliste1));


// opgave 4 test:
foreach(var person in personliste1)
{
    //Console.WriteLine(person.RamtBunden());
}


//opgave 5 test:
//Console.WriteLine(person1.Bankoverførsel(10000));
//Console.WriteLine(person2.Bankoverførsel(-100));

// opgave 6 test:
//Console.WriteLine("Før testen er arrayet så langt: " + personliste1.Length); 
//Console.WriteLine("Nu er det så langt: " + FjernPerson("Lars", personliste1).Length);




////////////////////////////////////////////////////////  OPGAVER  ////////////////////////////////////////////////////////

// Opgave 1
// Nederst her i filen har jeg lavet en klasse "Person". Kig på den og forstå hvad sådan en klasse kan indeholde.
// Lav en ny metode/funktion INDE I KLASSEN Person, kaldet "FindAlder". Den returnere personens alder(vi går ud fra at personen har haft fødsselsdag i 2022).



// Opgave 2
// Nu skal vi bruge vores nye "FindAlder" metode til at finde den ældste person i et array af personer.
// Arrayet hedder "personliste1" og kan findes oppe i tests.
// Brug "FindAlder" til at færdiggøre denne funktion, den tager et array af personer som input parameter og skal returnere den ældste af personerne.

static Person FindÆldste(Person[] personer)
{
    //Skriv din kode her! (tip, brug et foreach loop)
    return personer[1]; 
};



//Opgave 3
// Lav denne funktion "FormueSum" færdig. Den tager igen et array af personer som input og skal returnere den samlede formue af alle personer i listen.
// Vi genbruger personliste1 fra sidste opgave.
static int FormueSum(Person[] personer)
{
    //Skriv din kode her
    return 123;
};



// Opgave 4
// Lav en funktion INDE I KLASSEN "Person", kaldet "RamtBunden", der returnere "true" hvis personen både er arbejdsløs og single. (Single = true, Arbejdsløs = true)



// Opgave 5
// Lave en funktion INDE I KLASSEN "Person", kaldet "Bankoverførsel", der tager en int som input parameter og tilføjer den int til personenens formue.
// Derefter skal den returnere den nye formue.
// Hvis formuen bliver under 100.000 skal funktionen skrive "BROKE" i consollen.



// Opgave 6
// Lav denne funktion "FjernPerson" færdig. Den skal tage en string og et Person array som input.
// Den skal returnere et nyt array hvor personer i array'et med endten et Fornavn eller Efternavn der matcher input stringen bliver fjernet.
static Person[] FjernPerson(string navn, Person[] personer)
{
    //Skriv din kode her
    return personer;
}



// Opgave 7
// Lav en helt ny klasse kaldet "Bog"
// Klassen skal kunne holde informationer om disse ting: Navn, Forfatter, Udgivelsesår, Antal sider.
// Derudover skal du også lave en constructor til denne bog-klasse.
// Det ville være smart at lave den helt nederst her i filen.



// Opgave 8
// Lav en funktion i den nye bog-klasse der kan regne ud hvor mange timer det tager at læse bogen.
// Den skal tage en enkelt input parameter, det skal være en int. Denne int er hvor mange sider man kan læse i timen.
// Den skal returnere en int, altså hvor mange timer det tager at læse bogen.
// Lav et nyt bog-object og test selv koden.



// Opgave 9
// Udvid funktionen fra opgave 8 så den også skriver i consollen hvor mange hele dage det ville svare til. Brug kommetal (floats/doubles).
// Test selv koden igen ved at kalde funktionen.


public class Person
{
    //properties
    public string Fornavn { get; set; }
    public string Efternavn { get; set; }
    public int Formue { get; set; }
    public int Fødselsår { get; set; }
    public string Uddanelse { get; set; }
    public bool Single { get; set; }
    public bool Arbejdsløs { get; set; }

    //constructor
    public Person(string fornavn, string efternavn, int formue, int fødselsår, string uddanelse, bool single, bool arbejdsløs)
    {
        this.Fornavn = fornavn;
        this.Efternavn = efternavn;
        this.Formue = formue;
        this.Fødselsår = fødselsår;
        this.Uddanelse = uddanelse;
        this.Single = single;
        this.Arbejdsløs = arbejdsløs;

    }
    //Sådan her laver man en funktion i en klasse. Dette eksempel tjekker om personen hedder William.
    public bool HedderWilliam()
    {
        if(Fornavn == "William")
        {
            return true;
        }
        return false;
    }
  
}