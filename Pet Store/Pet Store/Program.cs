using Pet_Store;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<PlayerCharacter>();
for (int i = 0; i < numberOfRecords; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var myClass = new PlayerCharacter();

	Console.WriteLine("Enter the value for ");
	myClass.PlayerName = Console.ReadLine();

	recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()
