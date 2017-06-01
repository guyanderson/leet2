using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeetSpeak.Objects
{
  public class LeetSpeak
  {
// variable / constructor / public methods /private Methods

// variable for user entry into constructor: property
    private string _toCheck;
// object
    public LeetSpeak(string toCheck)
    {
      _toCheck = toCheck;
    }
// Methods
    public string Convert()
    {
      string result = ""; //create empty string to retur result to
      char[] charArray = _toCheck.ToCharArray(); // create array to hold _toCheck after .ToCharArray has ran
      for(int i = 0; i < charArray.Length; i++ ) {
        result += Convert(charArray[i]); //index through all chars in array, assigning chars to result
      }
      return result; //returns result
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
