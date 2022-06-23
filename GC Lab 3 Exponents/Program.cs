bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Enter an integer");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine("Number\t" + "Squared\t" + "Cubed");

    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(i + "\t" + squared(i) +"\t" + cubed(i));

    }

    static int squared(int num)
    {
        int squared = num * num;
        return squared;
    }

    static int cubed(int num)
    {
        int cubed = num * num * num;
        return cubed;
    }


    Console.WriteLine("Would you like to continue? y/n");
    string loopChoice = Console.ReadLine();
    if (loopChoice.ToLower().Trim() == "n")
    {
        runProgram = false;
    }
}