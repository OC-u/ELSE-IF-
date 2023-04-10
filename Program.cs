
int x;
int y;
int z;
int sum;
int average;
string name;
string grade;

    Console.WriteLine("Ënter the first marks");
    x = System.Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second marks");
    y = System.Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the third marks");
    z = System.Convert.ToInt32(Console.ReadLine());
    sum = (x + y + z);
    Console.WriteLine("The sum is");
    Console.WriteLine(sum);
    average = (sum / 3);
    Console.WriteLine("The average is");
    Console.WriteLine(average);
     name = ("Mourine");
     Console.WriteLine("Student name is");
      Console.WriteLine(name);
     


if (average <= 50)
{

 grade = ("Your grade is F");
   Console.WriteLine("You have failed, please repeat the course");
}
else if (average <= 70)
{
 grade = ("Your grade is C");
   Console.WriteLine(grade); 
   Console.WriteLine("You have tried");
}
else
{
    grade = ("Your garde is A");
    Console.WriteLine (grade);
    Console.WriteLine("Mourine, You have passed,Bravo!!!!");

}




     
     






