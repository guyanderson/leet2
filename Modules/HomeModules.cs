using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeetSpeak.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        LeetSpeak newLeetSpeak = new LeetSpeak(Request.Form["userInput"]);
        return View["result.cshtml", newLeetSpeak];
      };
    }
  }
}
