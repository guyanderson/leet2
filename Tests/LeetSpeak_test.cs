using Nancy;
using Xunit;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeetSpeak.Objects
{
  public class LeetSpeakTest
  {
    [Fact]
    public void IsCharE_ForLeetSpeak_true()
    {
      char c = 'e';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal(true, newLeetSpeak.IsCharE(c));
    }
    [Fact]
    public void IsCharE_ForLeetSpeak_false()
    {
      char c = 'z';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal(false, newLeetSpeak.IsCharE(c));
    }
    [Fact]
    public void IsCharO_ForLeetSpeak_true()
    {
      char c = 'o';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal(true, newLeetSpeak.IsCharO(c));
    }
    [Fact]
    public void IsCharO_ForLeetSpeak_false()
    {
      char c = 'z';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal(false, newLeetSpeak.IsCharO(c));
    }
    [Fact]
    public void IsCharI_ForLeetSpeak_true()
    {
      char c = 'I';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal(true, newLeetSpeak.IsCharI(c));
    }
    [Fact]
    public void IsCharI_ForLeetSpeak_false()
    {
      char c = 'i';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal(false, newLeetSpeak.IsCharI(c));
    }
    [Fact]
    public void IsCharT_ForLeetSpeak_true()
    {
      char c = 'T';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal(true, newLeetSpeak.IsCharT(c));
    }
    [Fact]
    public void IsCharT_ForLeetSpeak_false()
    {
      char c = 'z';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal(false, newLeetSpeak.IsCharT(c));
    }
    [Fact]
    public void IsCharS_ForLeetSpeak_true()
    {
      char c = 's';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal(true, newLeetSpeak.IsCharS(c));
    }
    [Fact]
    public void IsCharS_ForLeetSpeak_false()
    {
      char c = 'z';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal(false, newLeetSpeak.IsCharS(c));
    }
    [Fact]
    public void Convert_ForLeetSpeak_true()
    {
      char c = 'e';
      LeetSpeak newLeetSpeak = new LeetSpeak("");
      Assert.Equal('3', newLeetSpeak.Convert(c));

      c = 'o';
      Assert.Equal('0', newLeetSpeak.Convert(c));

      c = 'I';
      Assert.Equal('1', newLeetSpeak.Convert(c));

      c = 't';
      Assert.Equal('7', newLeetSpeak.Convert(c));

      c = 's';
      Assert.Equal('z', newLeetSpeak.Convert(c));

      c = 'a';
      Assert.Equal('a', newLeetSpeak.Convert(c));
    }
  }
}
