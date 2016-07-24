// using System.Collections.Generic;
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
      public void T5_RepeatCounterAbIsNoMatch_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("a", "b");
        // assert
        Assert.Equal(0 ,newRepeatCounter.CountRepeats());

      }
      [Fact]
      public void T6_RepeatCounterAAIs1_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("a", "a");
        // assert
        Assert.Equal(1 ,newRepeatCounter.CountRepeats());
      }
      [Fact]
      public void T7_RepeatCounterCatDogNoMatch_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("cat", "dog");
        // assert
        Assert.Equal(0 ,newRepeatCounter.CountRepeats());
      }
      [Fact]
      public void T8_RepeatCounterCatCatIs1_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("cat", "cat");
        // assert
        Assert.Equal(1 ,newRepeatCounter.CountRepeats());
      }
      [Fact]
      public void T9_RepeatCounterAaToAIs2_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("a a", "a");
        // assert
        Assert.Equal(2 ,newRepeatCounter.CountRepeats());
      }
      [Fact]
      public void T10_RepeatCounterAbAToAIs2_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("a b a", "a");
        // assert
        Assert.Equal(2 ,newRepeatCounter.CountRepeats());
      }
      [Fact]
      public void T11_RepeatCounterCatCatToCatIs2_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("cat cat", "cat");
        // assert
        Assert.Equal(2 ,newRepeatCounter.CountRepeats());
      }
    }
  }
