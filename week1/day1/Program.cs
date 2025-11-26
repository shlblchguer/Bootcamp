/*
 
 // See https://aka.ms/new-console-template for more information

 // exrcice 1
 Console.WriteLine("Welcome to C# Programming");

 // exrcice 2
 string name="souhail"; 
 int age=30;
 Console.WriteLine("my name is "+ name + " and i am "+ age + " years old");

 // exercice 3 
 int num1=4; 
 int num2=5;
 int sum=num1+num2;
 Console.WriteLine(sum);

 // exercice 4
 int userAge=19;
 if (userAge >= 18)
 {
     Console.WriteLine("Access Granted");
 }
 else
 {
     Console.WriteLine("Access Denied");
 }

 // exercice 5
 int h=10;

 while( h >= 1)
     {
         Console.WriteLine( h );
         h--; 
     }
     Console.WriteLine("Liftoff!");

 //  exercice 6
 static void SayHello(string name)

     {
         Console.WriteLine("Hello," + name + "!");
     }

   SayHello("souhail");
   SayHello("amine");
  SayHello("khadija");

  // execrice 7
  for ( int i=1; i<= 10; i++ )
  if (i%2==0)
  {
     Console.WriteLine("number is " + i + " even"  );
  }
 else
     {
         Console.WriteLine("number is " + i + " odd"  );
     }

 // exrcice 8
 Console.Write("Enter tempature in celsuis:");
 string input = Console.ReadLine();
 double Celsius= double.Parse(input);
 double Fahrenheit=Celsius * 9/5 + 32;
 Console.WriteLine("Tempture in Fahrenheit " + Fahrenheit+ "°F" );

 // exercice 9

 int a=10; 
 int b=30; 
 int z; 
 z=a;
 a=b;
 b=z;
//  Console.WriteLine( z);
 Console.WriteLine($"{a}, {z}, {b}");
//  Console.WriteLine( a);

 // exercice 10
 Console.Write("Enter number:");
 string x= Console.ReadLine();
 int incon= int.Parse(x);
 for (int e=1; e<=10; e++)
 {
     int result=e*incon;
     Console.WriteLine($"{e} * {incon} = {result}");
 } 
**/
 // fizzbuzz
 Console.Write("Enter Number");
 string input= Console.ReadLine();
 int f= int.Parse(input);

 if ( f%3==0 && f%5==0 ) 
 {
     Console.WriteLine("FizzBuzz");
 }
 else if( f%5==0)
 {
     Console.WriteLine("Buzz");
 }
 else if( f%3==0)
 {
     Console.WriteLine("Fizz");
 }
 else
 {
     Console.WriteLine("undefind");
 }

