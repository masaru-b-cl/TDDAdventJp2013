using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddAdventJp2013.Test
{
  [TestClass]
  public class カテゴリー
  {
    [TestCategory("Aがa1の場合")]
    [TestMethod]
    public void Bがb1ならばc1となる()
    {
    }

    [TestCategory("Aがa1の場合")]
    [TestMethod]
    public void Bがb2ならばc2となる()
    {
    }
    
    [TestCategory("Aがa2の場合")]
    [TestMethod]
    public void Bがb1ならばc3となる()
    {
    }
  }
}
