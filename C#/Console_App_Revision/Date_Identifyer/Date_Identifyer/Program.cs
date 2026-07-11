while (true)
{
    int dayParsed;
    while (true)
    {
        Console.WriteLine("Enter a day of the month: ");
        try
        {
            dayParsed = int.Parse(Console.ReadLine().Trim());
            break;
        }
        catch
        {
            Console.WriteLine("Invalid input try again");
            continue;
        }
    }
    int monthParsed;
    while (true)
    {
        Console.WriteLine("Enter a month of the year: ");
        try
        {
            monthParsed = int.Parse(Console.ReadLine().Trim());
            break;
        }
        catch
        {
            Console.WriteLine("Invalid input try again");
            continue;
        }
    }
    int yearParsed;
    while (true)
    {
        Console.WriteLine("Enter a year: ");
        Console.WriteLine("Enter a month of the year: ");
        try
        {
            yearParsed = int.Parse(Console.ReadLine().Trim());
            break;
        }
        catch
        {
            Console.WriteLine("Invalid input try again");
            continue;
        }
    }
    DateTime inputDate;
    try
    {
        inputDate = new DateTime(yearParsed, monthParsed, dayParsed);
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex.Message);
        Console.WriteLine("Try again");
        continue;
    }
    Console.WriteLine(inputDate);


    if (inputDate.DayOfWeek != DayOfWeek.Saturday && inputDate.DayOfWeek != DayOfWeek.Sunday)
    {
        Console.WriteLine($"It is a {inputDate.DayOfWeek}, so it is a working day :((((");
    }
    else
    {
        Console.WriteLine($"It is a {inputDate.DayOfWeek}, so you can party :))))))");
    }
    string input;
    while (true)
    {
        Console.WriteLine("Would you like to check out another date? (Y/N)");
        input = Console.ReadLine().ToLower();
        if (input == "y" || input == "n")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, try again");
            continue;
        }
    }

    if (input == "y")
    {
        Console.Clear();
        continue;
    }
    else
    {
        break;
    }
}