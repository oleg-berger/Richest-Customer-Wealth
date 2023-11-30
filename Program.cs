static int sumArray()
{
    Console.Write("Enter how much money you have ");
    string inputStr1 = Convert.ToString(Console.ReadLine());

    string[] inputArray1 = inputStr1.Split(' ');
    


    int[] account1 = new int[inputArray1.Length];
    int sumAccount = 0;

    for(int i = 0; i < inputArray1.Length; i++)
    {
        account1[i] = Convert.ToInt32(inputArray1[i]);
        sumAccount += account1[i]; 
    }
    return(sumAccount);
}

int user1 = sumArray();
int user2 = sumArray();



if (user1 == user2)
{
    Console.WriteLine("Both are equally rich");
}
else if (user1 > user2)
{
    Console.WriteLine($"user 1 is richer than user 2. He has weaalth = {user1}");
}
else if (user2 > user1)
{
    Console.WriteLine($"user 2 is richer than user 1. He has weaalth = {user2}");
}


