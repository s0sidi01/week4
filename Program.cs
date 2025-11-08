int[] age = { 20, 30, 60 };

for (int i = 0; i < age.Length; i++)
{
    if (age[i] == 20)
    {
        Console.WriteLine("you're broke");
    }
    else if (age[i] == 30)
    {
        Console.WriteLine("you're somehow a little less broke");
    }
    else if (age[i] == 60)
    {
        Console.WriteLine("you're probably chilling");
    }
    else
    {
        Console.WriteLine("age is not on the list");
    }
}
