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
    public void SetWord(newInput1)
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
}
}
