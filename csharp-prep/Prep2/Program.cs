using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("What is your grade percentage? ");
    string grade = Console.ReadLine();
    int percent = int.Parse(grade);
    string letter = "";

    if (percent >= 90)
    {
      if (percent < 93)
      {
        letter = "A-";
      }
      else
      {
        letter = "A";
      }
    }

    else if (percent >= 80)
    {
      if (percent >= 87)
      {
        letter = "B+";
      }
      else if (percent < 83)
      {
        letter = "B-";
      }
    else
      {
        letter = "B";
      }
    }

    else if (percent >= 70)
    {
      if (percent >= 77)
      {
        letter = "C+";
      }
      else if (percent < 73)
      {
        letter = "C-";
      }
      else
      {
        letter = "C";
      }
    }

    else if (percent >= 60)
    {
      if (percent >= 67)
      {
        letter = "D+";
      }
      else if (percent < 63)
      {
        letter = "D-";
      }
      else
      {
        letter = "D";
      }
    }

    else
    {
      letter = "F";
    }

    Console.WriteLine(letter);
    
    if (percent >= 70)
    {
      Console.WriteLine("Congrats! You passed!");
    }
    else
    {
      Console.WriteLine("Sorry, you failed.");
    }
  }
}