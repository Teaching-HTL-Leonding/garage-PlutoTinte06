using Garage.Logic;

int parkingSpotNumber = 0;
string licensePlate = "";
DateTime entryDate;
DateTime exitDate;
decimal costs = 0;
GarageClass garage = new GarageClass();

Console.WriteLine("What do you want to do?");
Console.WriteLine("1) Enter a car entry");
Console.WriteLine("2) Enter a car exit");
Console.WriteLine("3) Generate report");
Console.WriteLine("4) Exit");

int num;
do
{
    Console.Write("Your selection: ");
    num = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    switch (num)
    {
        case 1:
            Console.Write("Enter parking spot number: ");
            parkingSpotNumber = int.Parse(Console.ReadLine()!);
            if (garage.IsOccupied(parkingSpotNumber))
            {
                Console.WriteLine("Parking spot is occupied");
            }
            else
            {
                Console.Write("Enter license plate: ");
                licensePlate = Console.ReadLine()!;
                Console.Write("Enter entry date: ");
                entryDate = DateTime.Parse(Console.ReadLine()!);
                garage.TryOccupy(parkingSpotNumber, licensePlate, entryDate);
            }
            break;
        case 2:
            Console.Write("Enter parking spot number: ");
            parkingSpotNumber = int.Parse(Console.ReadLine()!);
            if (garage.IsOccupied(parkingSpotNumber) == false)
            {
                Console.WriteLine("Parking spot is not occupied");
            }
            else
            {
                Console.Write("Enter exit date: ");
                exitDate = DateTime.Parse(Console.ReadLine()!);
                garage.TryExit(parkingSpotNumber, exitDate, out costs);
            }
            break;
        case 3:
            garage.GenerateReport();
            break;
        case 4:
            Console.WriteLine("Good bye!");
            break;
        default:
            break;
    }

    Console.WriteLine();
}
while (num != 4);
