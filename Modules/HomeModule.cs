using Nancy;
using System;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post["/results"] = _ =>{
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["string-input"], Request.Form["word-input"]);
        return View["/result.cshtml", newRepeatCounter];

      };
}
}
}
