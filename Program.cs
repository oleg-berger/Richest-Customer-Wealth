static int sumArray()
{
    Console.Write("Enter how much money you have ");
    string inputStr = Convert.ToString(Console.ReadLine());

    string[] inputArray = inputStr.Split(' ');
    


    int[] account = new int[inputArray.Length];
    int sumAccount = 0;

    for(int i = 0; i < inputArray.Length; i++)
    {
        account[i] = Convert.ToInt32(inputArray[i]);
        sumAccount += account[i]; 
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



