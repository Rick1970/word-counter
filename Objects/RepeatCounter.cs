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



    public string CountRepeats()
    {
      string result = "1";
      string result2 = "No Match.";
      string userInput1 = this.GetStringToSearch();
      string userInput2 = this.GetSearchWord();

      if (userInput1 == userInput2)
      {
        return result;
      }
      else
      {
        return result2;
      }

    }

}
}
