using fantasyGameCharacters;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<PlayerCharacter>();
for (int i = 0; i < numberOfRecords; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var myClass = new PlayerCharacter();

	Console.WriteLine("Enter your real life name");
	myClass.PlayerName = Console.ReadLine();

    Console.WriteLine("Enter the name for your fantasy character");
    myClass.characterName = Console.ReadLine();

    Console.WriteLine("Enter the class your character has (e.g., Warrior, Mage, etc.)");
    myClass.characterClass = Console.ReadLine();

    Console.WriteLine("Enter true if your character is magical, false if your character is not");
    bool isMagicValue;
    if (bool.TryParse(Console.ReadLine(), out isMagicValue))
    {
        myClass.isMagic = isMagicValue;
    }

    Console.WriteLine("Enter how many health points your character has");
    int hpValue;
    if (int.TryParse(Console.ReadLine(), out hpValue))
    { 
        myClass.HealthPoints = hpValue;
    }

    recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()
foreach (var character in recordList)
{ 
Console.WriteLine($"Player Name: {character.PlayerName}, Character Name: {character.characterName}, Character Class: {character.characterClass}, Is Magic: {character.isMagic}, Health Points: {character.HealthPoints}");
}

