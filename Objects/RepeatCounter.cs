using System;
using System.Linq;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _searchString;
    private string _searchWord;



    public RepeatCounter(string searchString, string searchWord)
    {
      _searchString = searchString;
      _searchWord = searchWord;
    }
    public string GetStringToSearch()
    {
      return _searchString;
    }
    public void SetStringToSearch(string newsearchString)
    {
      _searchString = newsearchString;
    }
    public string GetSearchWord()
    {
      return _searchWord;
    }
    public void SetSearchWord(string newSearchWord)
    {
      _searchWord = newSearchWord;
    }
    // public static void DeleteAll()
    //    {
    //      _searchString.Clear();
    //      _searchWord.Clear();
    //    }


    public int CountRepeats()
   {
     string test1 = this.GetSearchWord();
     string[] test2 = this.GetStringToSearch().Split(' ');

     int counter = 0;

     foreach (string word in test2)
     {
       if (test1 == word)
       {
         counter++;
       }
     }
     return counter;
   }
 }
}
