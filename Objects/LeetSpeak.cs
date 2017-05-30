using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeetSpeak.Objects
{
  public class LeetSpeak
  {
    private char[] _userString;
    public char[] _newString;

    public LeetSpeak(string userSentence)
    {
      _userString = userSentence.ToCharArray();
    }

    public char[] ChangeToLeetSpeak(string userString)
    {
      for(int toCheck = 0; toCheck <= _userString.Length; toCheck++)
      {
        if(IsCharE(toCheck))
        {
          _userString[toCheck] = '3';
          _newString.Add(_userString[toCheck]);
        }
      }
    }

    public bool IsCharE(int toCheck)
    {
      return _userString[toCheck] == 'e';
    }
    public bool IsCharO()
    {
      return _userString[toCheck] == 'o';
    }
    public bool IsCharI()
    {
      return _userString[toCheck] == 'I';
    }
    public bool IsCharT()
    {
      return _userString[toCheck] == 't';
    }
    public bool IsCharS()
    {
      return _userString[toCheck] == 's';
    }
  }

}
