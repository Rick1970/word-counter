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
    public static List<RepeatCounter> GetAll()
    {
      return _instances;
    }
    public static void DeleteAll()
    {
      _instances.Clear();
    }
    public static string CountRepeats(RepeatCounter input1, RepeatCounter input2)
    {
      string practice = "1";


      if (input1.GetWord() == input2.GetWord())
      {
        return practice;
      }
      else
      {
        return "Not a Match";
      }
    }
}
}
