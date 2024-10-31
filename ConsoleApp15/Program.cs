class Program
{
    static void Main()
    {

        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];


        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element " + (i + 1) + ": ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter an index (0 to " + (array.Length - 1) + "): ");
        int index = int.Parse(Console.ReadLine());


        if (index >= 0 && index < array.Length)
        {

            int number = array[index];

            int sum = SumOfDigits(number);


            Console.WriteLine("The sum " + index + " (number: " + number + ") is: " + sum);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }



    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;

        }
        return sum;
    }
}






