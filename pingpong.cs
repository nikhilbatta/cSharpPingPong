using System;
using System.Collections.Generic;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter any number");
    string number = Console.ReadLine();
    int yourNumber = Convert.ToInt16(number);
    for (int i = 0; i < yourNumber; i++)
    {
      if(i % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      if(i % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      if(i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("Ping-Pong");
      }
      else{
        Console.WriteLine(i);
      }
    }
  }
}
