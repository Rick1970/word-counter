using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
{
    private string _word;
    private static List<RepeatCounter> _instances = new List<RepeatCounter> {};

    public RepeatCounter(string input1)
    {
      _word = input1;
    }
    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string newInput1)
    {
      _word = newInput1;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static List<RepeatCounter>GetAll()
    {
      return _instances;
    }
    public static void DeleteAll()
    {
      _instances.Clear();
    }


    public static string CountRepeats(RepeatCounter input1, RepeatCounter input2)
    {
      int result = 0;
      string result2 = "No Match.";
      List<RepeatCounter> compare = RepeatCounter.GetAll();
      string compare1 = compare.ToString();
      string compare2 = input2.GetWord();
      Console.WriteLine(compare1);
      Console.WriteLine(compare2);

      foreach (var test in compare1)
      {

      if (compare2 == compare1)
      {
        result += 1;
      }
      else
      {
        return result2;
      }

    }
    return null;
}
}
}
