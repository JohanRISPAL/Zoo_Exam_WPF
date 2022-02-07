namespace Model;

public class LoadAnimals
{
    public IEnumerable<Animal> Animals { get; set; }

    public LoadAnimals()
    {
        Platypus platypus1 = new Platypus("Perry", false, 40);
        Platypus platypus2 = new Platypus("Bernard", false, 25);
        Platypus platypus3 = new Platypus("José", false, 30);
        Platypus platypus4 = new Platypus("Edouard", true, 10);

        Pony pony1 = new Pony("Rainbow Dash", true, "multicolor");
        Pony pony2 = new Pony("Apple Jack", false, "yellow");
        Pony pony3 = new Pony("Fluttershy", true, "pink");
        Pony pony4 = new Pony("Pinkie Pie", true, "dark pink");
        Pony pony5 = new Pony("Twilight Sparkle", false, "purple");
        Pony pony6 = new Pony("Rarity", false , "dark purple");

        Licorn licorn1 = new Licorn("Cheval avec une corne", false, 18);

        List<Animal> animals = new List<Animal>();
        
        animals.Add(platypus1);
        animals.Add(platypus2);
        animals.Add(platypus3);
        animals.Add(platypus4);
        
        animals.Add(pony1);
        animals.Add(pony2);
        animals.Add(pony3);
        animals.Add(pony4);
        animals.Add(pony5);
        animals.Add(pony6);
        
        animals.Add(licorn1);

        Animals = animals.AsEnumerable();
    }
}