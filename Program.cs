// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("Hello, World!");

string firstFriend = "Manderly";
string secondFriend = "Jenna";
Console.WriteLine($"Hello {firstFriend} and {secondFriend}");

Console.WriteLine($"{firstFriend}'s name has {firstFriend.Length} letters.");
Console.WriteLine($"{secondFriend}'s name has {secondFriend.Length} letters.");

string greeting = "     Hello There!     ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");


string sayHello = "Hello World?";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Hola");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToLower());
Console.WriteLine(sayHello.ToUpper());

string songLyrics = "Moonbeam, icecream, dancing at the movies";
Console.WriteLine(songLyrics.Contains("Moonbeam"));
Console.WriteLine(songLyrics.Contains("Blue jeans"));

//Challenge

Console.WriteLine(songLyrics.StartsWith("Moonbeam"));
Console.WriteLine(songLyrics.StartsWith("movies"));

Console.WriteLine(songLyrics.EndsWith("movies"));
Console.WriteLine(songLyrics.EndsWith("Moonbeam"));