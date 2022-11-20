using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter the Character");
    char ch=Convert.ToChar(Console.ReadLine());
    if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u')
    {
        Console.WriteLine("vowel");
    }else{
        Console.WriteLine("Consonant");
    }
  }
}