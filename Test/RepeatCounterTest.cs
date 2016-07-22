using System.Collections.Generic;
using Xunit;
using System;

namespace WordCounter.Objects
{
  public class PlayerTest : IDisposable
  {
    public void Dispose()
    {
      Player.DeleteAll();
    }
    public class RepeatCounterTest
    {

    }
  }
}
