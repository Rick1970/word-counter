using System.Collections.Generic;
using Xunit;
using System;

namespace WordCounter.Objects
{
  public class RepeatCounterTest : IDisposable
  {
    public void Dispose()
    {
      RepeatCounter.DeleteAll();
    }

      [Fact]
      public void T1_RepeatCounterGetA_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("a");
        // act
        string testCounter = newRepeatCounter.GetWord();
        // assert
        Assert.Equal("a", testCounter);
      }
      [Fact]
      public void T2_RepeatCounterGetCat_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("cat");
        // act
        string testCounter = newRepeatCounter.GetWord();
        // assert
        Assert.Equal("cat", testCounter);
      }
      [Fact]
      public void T3_RepeatCounterSetA_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("b");
        newRepeatCounter.SetWord("a");
        // act
        string testCounter = newRepeatCounter.GetWord();
        // assert
        Assert.Equal("a", testCounter);
      }
      [Fact]
      public void T4_RepeatCounterSetCat_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("add");
        newRepeatCounter.SetWord("cat");
        // act
        string testCounter = newRepeatCounter.GetWord();
        // assert
        Assert.Equal("cat", testCounter);
      }
      [Fact]
      public void T5_RepeatCounterSaveA_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("a");
        newRepeatCounter.Save();
        // act
        List<RepeatCounter> newItem = RepeatCounter.GetAll();
        // assert
        Assert.Equal(newRepeatCounter, newItem[0]);
      }
      [Fact]
      public void T6_RepeatCounterSaveCat_true()
      {
        // arrange
        RepeatCounter newRepeatCounter = new RepeatCounter("cat");
        newRepeatCounter.Save();
        // act
        List<RepeatCounter> newItem = RepeatCounter.GetAll();
        // assert
        Assert.Equal(newRepeatCounter, newItem[0]);
      }
      [Fact]
      public void T7_RepeatCounterSaveAInput1And2_true()
      {
        // arrange
        RepeatCounter newRepeatCounter1 = new RepeatCounter("a");
        newRepeatCounter1.Save();
        RepeatCounter newRepeatCounter2 = new RepeatCounter("b");
        newRepeatCounter2.Save();

        // act
        List<RepeatCounter> newItem = RepeatCounter.GetAll();
        // assert
        Assert.Equal(newRepeatCounter1, newItem[0]);
        Assert.Equal(newRepeatCounter2, newItem[1]);
      }
      [Fact]
      public void T8_RepeatCounterCompareAToAEquals1_true()
      {
        // arrange
        RepeatCounter newRepeatCounter1 = new RepeatCounter("a");
        newRepeatCounter1.Save();
        RepeatCounter newRepeatCounter2 = new RepeatCounter("a");
        newRepeatCounter2.Save();

        // act
        string result = RepeatCounter.CountRepeats(newRepeatCounter1, newRepeatCounter2);
        // assert
        Assert.Equal("1", result);
      }
      [Fact]
      public void T9_RepeatCounterCompareCatToCatEquals1_true()
      {
        // arrange
        RepeatCounter newRepeatCounter1 = new RepeatCounter("cat");
        newRepeatCounter1.Save();
        RepeatCounter newRepeatCounter2 = new RepeatCounter("cat");
        newRepeatCounter2.Save();

        // act
        string result = RepeatCounter.CountRepeats(newRepeatCounter1, newRepeatCounter2);
        // assert
        Assert.Equal("1", result);
      }
      [Fact]
      public void T10_RepeatCounterCompareCatToDogEquals0_true()
      {
        // arrange
        RepeatCounter newRepeatCounter1 = new RepeatCounter("cat");
        newRepeatCounter1.Save();
        RepeatCounter newRepeatCounter2 = new RepeatCounter("dog");
        newRepeatCounter2.Save();

        // act
        string result = RepeatCounter.CountRepeats(newRepeatCounter1, newRepeatCounter2);
        // assert
        Assert.Equal("No Match.", result);
      }
      [Fact]
      public void T11_RepeatCounterCompareCatCatToCatEquals2_true()
      {
        // arrange
        RepeatCounter newRepeatCounter1 = new RepeatCounter("cat");
        newRepeatCounter1.Save();
        RepeatCounter newRepeatCounter2 = new RepeatCounter("cat");
        newRepeatCounter2.Save();

        // act
        string result = RepeatCounter.CountRepeats(newRepeatCounter1, newRepeatCounter2);
        // assert
        Assert.Equal("1", result);
      }
    }
  }
