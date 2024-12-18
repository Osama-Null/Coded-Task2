Console.Write("Language? [en/es/fr/tr/ru] "); string lan = Console.ReadLine();

if (lan == "en")
{
    Console.Write("Enter your name: "); string name = Console.ReadLine();
    Console.WriteLine("Hello " + name);
}

else if (lan == "es")
{
    Console.Write("Introduce tu nombre: "); string name = Console.ReadLine();
    Console.WriteLine("Hola " + name);
}

else if (lan == "fr")
{
    Console.Write("Entrez votre nom: "); string name = Console.ReadLine();
    Console.WriteLine("Bonjour " + name);
}

else if (lan == "tr")
{
    Console.Write("Adınızı girin: "); string name = Console.ReadLine();
    Console.WriteLine("Merhaba " + name);
}

else if (lan == "ru")
{
    Console.Write("Введите свое имя: "); string name = Console.ReadLine();
    Console.WriteLine("Привет " + name);
}

else Console.WriteLine("Invalid input!");
Console.WriteLine("______________________");

//__________________________________________
Console.Write("Enter first number: "); float num1 = float.Parse(Console.ReadLine());
Console.Write("Enter second number: "); float num2 = float.Parse(Console.ReadLine());

if (num1 > num2) Console.WriteLine("The biger number is: " + num1);

else if (num2 > num1) Console.WriteLine("The bigger number is: " + num1);

else Console.WriteLine("Invalid input!");
Console.WriteLine("______________________");

//__________________________________________
Console.Write("Enter your grade: "); float grade = float.Parse(Console.ReadLine());

if (grade > 100) Console.WriteLine("Ivalid Input!");
else if (grade >= 80 && grade < 100) Console.WriteLine("You got A!");
else if (grade >= 70 && grade < 80) Console.WriteLine("You got B!");
else if (grade >= 60 && grade < 70) Console.WriteLine("You got C!");
else if (grade >= 50 && grade < 60) Console.WriteLine("You got D!");
else if (grade >= 0 && grade < 50) Console.WriteLine("You got F!");
else if (grade < 0) Console.WriteLine("Ivalid Input!");
