using System.Collections.Generic;
using Xunit;
using System;

namespace WordCounter.Objects
{
  public class RepeatCounterTest
  {
    // public void Dispose()
    // {
    //   RepeatCounter.DeleteAll();
    // }

      [Fact]
      public void T1_RepeatCounterGetAa_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("a", "a");
        // act
        string testCounter1 = newRepeatCounter.GetStringToSearch();
        string testCounter2 = newRepeatCounter.GetSearchWord();
        // assert
        Assert.Equal("a" ,testCounter1);
        Assert.Equal("a", testCounter2);
      }
      [Fact]
      public void T2_RepeatCounterGetCatCat_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("cat", "cat");
        // act
        string testCounter1 = newRepeatCounter.GetStringToSearch();
        string testCounter2 = newRepeatCounter.GetSearchWord();
        // assert
        Assert.Equal("cat" ,testCounter1);
        Assert.Equal("cat", testCounter2);
      }
      [Fact]
      public void T3_RepeatCounterSetAa_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("b", "b");
        newRepeatCounter.SetStringToSearch("a");
        newRepeatCounter.SetSearchWord("a");
        // act
        string testCounter1 = newRepeatCounter.GetStringToSearch();
        string testCounter2 = newRepeatCounter.GetSearchWord();
        // assert
        Assert.Equal("a" ,testCounter1);
        Assert.Equal("a", testCounter2);
      }

      [Fact]
      public void T4_RepeatCounterSetCatcata_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("a", "a");
        newRepeatCounter.SetStringToSearch("cat");
        newRepeatCounter.SetSearchWord("cat");
        // act
        string testCounter1 = newRepeatCounter.GetStringToSearch();
        string testCounter2 = newRepeatCounter.GetSearchWord();
        // assert
        Assert.Equal("cat" ,testCounter1);
        Assert.Equal("cat", testCounter2);
      }



      [Fact]
      public void T5_RepeatCounterAbIs0_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("cat", "dog");


        // assert
        Assert.Equal("1" ,newRepeatCounter.CountRepeats());

      }
      // [Fact]
      // public void T9_RepeatCounterCompareCatToCatEquals1_true()
      // {
      //   // arrange
      //   RepeatCounter newRepeatCounter1 = new RepeatCounter("cat");
      //   newRepeatCounter1.Save();
      //   RepeatCounter newRepeatCounter2 = new RepeatCounter("cat");
      //   newRepeatCounter2.Save();
      //
      //   // act
      //   string result = RepeatCounter.CountRepeats(newRepeatCounter1, newRepeatCounter2);
      //   // assert
      //   Assert.Equal("1", result);
      // }
      // [Fact]
      // public void T10_RepeatCounterCompareCatToDogEquals0_true()
      // {
      //   // arrange
      //   RepeatCounter newRepeatCounter1 = new RepeatCounter("cat");
      //   newRepeatCounter1.Save();
      //   RepeatCounter newRepeatCounter2 = new RepeatCounter("dog");
      //   newRepeatCounter2.Save();
      //
      //   // act
      //   string result = RepeatCounter.CountRepeats(newRepeatCounter1, newRepeatCounter2);
      //   // assert
      //   Assert.Equal("No Match.", result);
      // }
      // [Fact]
      // public void T11_RepeatCounterCompareCatCatToCatEquals2_true()
      // {
      //   // arrange
      //   RepeatCounter newRepeatCounter1 = new RepeatCounter("cat");
      //   newRepeatCounter1.Save();
      //   RepeatCounter newRepeatCounter2 = new RepeatCounter("dog");
      //   newRepeatCounter2.Save();
      //
      //
      //   // act
      //   string result = RepeatCounter.CountRepeats(newRepeatCounter1, newRepeatCounter2);
      //   // assert
      //   Assert.Equal("1", result);
      //   Console.WriteLine(newRepeatCounter1 );
      //   Console.WriteLine(newRepeatCounter2);
      // }
    }
  }
