using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeetSpeak.Objects
{
  public class LeetSpeak
  {
    private string _toCheck;
    public LeetSpeak(string userSentence)
    {
      _toCheck = userSentence;
    }

    public bool IsCharE(char c)
    {
      return c == 'e' || c == 'E';
    }
    public bool IsCharO(char c)
    {
      return c == 'o' || c == 'O';
    }
    public bool IsCharI(char c)
    {
      return c == 'I';
    }
    public bool IsCharT(char c)
    {
      return c == 't' || c == 'T';
    }
    public bool IsCharS(char c)
    {
      return c == 's' || c == 'S';
    }
    public char Convert(char c)
    {
      if(IsCharE(c))
      {
        return '3';
      }
      else if(IsCharO(c))
      {
        return '0';
      }
      else if(IsCharI(c))
      {
        return '1';
      }
      else if(IsCharT(c))
      {
        return '7';
      }
      else if(IsCharS(c))
      {
        return 'z';
      }
      else return c;
    }
  }
}
