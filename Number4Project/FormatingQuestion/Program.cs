using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //Part 1
        string receiptionName = "Alice";
        DateTime eventDate = new DateTime(2025, 1, 15);
        string formatDate = eventDate.ToString("MMMM dd yyyy", new System.Globalization.CultureInfo("en-US"));

        TimeSpan currentTime = new TimeSpan(9, 0, 0);
        string formattedTime = currentTime.ToString(@"hh\:mm");
        string morning = "AM";
        string notification = $"Hello, {receiptionName}! You're invited to our team meeting on {formatDate}. The event starts at {formattedTime} {morning}";
        Console.WriteLine(notification);

        //Part 2
        string customerName = "John Doe";
        int orderID = 123456;
        string tShirt = "T-Shirt";
        string jean = "Jean";
        int numberOfTShirt = 2;
        int numberOfJean = 3;
        notification = $"Dear {customerName}, your order (ID:{orderID}) has been confirmed. You're purchased: {numberOfTShirt}x{tShirt}, {numberOfJean}x{jean}";
        Console.WriteLine(notification);

        //Part 3
        string taskName = "Complete Project Proposal";
        DateTime dueDate = new DateTime(2025, 5, 10);
        formatDate = dueDate.ToString("MMMM dd yyyy", new System.Globalization.CultureInfo("en-US"));
        string priorityLevel = "High";
        string reminder = $"{taskName} is due on {formatDate}. Priority: {priorityLevel}";
        Console.WriteLine(reminder);

        //Part 4
        string eventTitle = "Team Meeting";
        string location = "Coference room A";
        TimeSpan startTime = new TimeSpan(10, 0, 0);
        formattedTime = startTime.ToString(@"hh\:mm");
        morning = "AM";
        reminder = $"{eventTitle} at {location} start at {formattedTime} {morning}";
        Console.WriteLine(reminder);

        //Part 5
        string flightNumber = "ABC123";
        string departureAirport = "JFK National Airport";
        TimeSpan scheduledTime = new TimeSpan(8, 30, 00);
        formattedTime = scheduledTime.ToString(@"hh\:mm");
        morning = "AM";
        notification = $"Flight {flightNumber} departing from {departureAirport} is scheduled for {formattedTime} {morning}";
        Console.WriteLine(notification);

        //Part 6
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        string message = $"Hello, {name}! Welcome to our messaging app";
        Console.WriteLine(message);

        //Part 7
        string characterName = "Legolas";
        string characterClass = "Archer";
        Console.WriteLine($"{characterName} the {characterClass}");

        //Part 8
        Console.WriteLine("Please enter the time of song:");
        int playTime = int.Parse(Console.ReadLine());
        int minute = playTime / 60;
        int second = playTime % 60;
        string songDuration = $"{minute} minute {second} second";
        Console.WriteLine(songDuration);

        //Part 9
        Console.WriteLine("Please enter the serving size(0~5): ");
        int servingSize = int.Parse(Console.ReadLine());
        Console.WriteLine($"Serving size: {servingSize,5}");

        //Part 10
        Console.WriteLine("Enter the account balance: ");
        float accountBalance = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine($"Account Balance: {accountBalance.ToString("F2", CultureInfo.InvariantCulture)}");

        //Part 11
        Console.WriteLine("Enter the ticket price: ");
        decimal ticketPrice = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Enter the discount percentage: ");
        decimal discountPercent = int.Parse(Console.ReadLine());
        decimal discountAmount = ticketPrice * discountPercent / 100;
        decimal discountPrice = ticketPrice - discountAmount;
        Console.WriteLine($"Discount price: {discountPrice.ToString("F2", CultureInfo.InvariantCulture)}");

        //Part 12
        Console.WriteLine("Enter the player score: ");
        int playerScore = int.Parse(Console.ReadLine());
        Console.WriteLine($"Player score: {playerScore,8}");

        //Part 13
        Console.WriteLine("Enter a series of number separated by spaces: ");
        string numberInput = Console.ReadLine();
        string[] numberString = numberInput.Split(' ');
        int[] number = new int[5];

        for(int i = 0; i < 5; i++)
        {
            number[i] = int.Parse(numberString[i], CultureInfo.InvariantCulture);
        }
        int sum = 0;
        foreach(int num in number){
            sum += num;
        }
        double average = (float)sum/5;
        Console.WriteLine($"Average number: {average}");


        //Part 14
        Console.WriteLine("Enter temperatures for 3 days separated by spaces:");
        string input = Console.ReadLine();
        string[] temperatureStrings = input.Split(' ');
        float[] temperatures = new float[3];
        for (int i = 0; i < 3; i++)
        {
            temperatures[i] = float.Parse(temperatureStrings[i], CultureInfo.InvariantCulture);
        }

        float sumOfTemp = 0;
        foreach (float temp in temperatures)
        {
            sumOfTemp += temp;
        }
        float averageTemperature = sumOfTemp / 3;

        Console.WriteLine($"Average Temperature: {averageTemperature,6:F1}");

        //Part 15
        Console.WriteLine("Enter the number of step taken: ");
        int stepTaken = int.Parse(Console.ReadLine());
        Console.WriteLine($"Player score: {stepTaken,6}");
    }
}