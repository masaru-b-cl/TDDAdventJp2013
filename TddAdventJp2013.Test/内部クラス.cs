using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddAdventJp2013.Test
{
  public class 内部クラス
  {
    [TestClass]
    public class Aがa1の場合
    {
      [TestMethod]
      public void Bがb1ならばc1となる()
      {
      }

      [TestMethod]
      public void Bがb2ならばc2となる()
      {
      }
    }

    [TestClass]
    public class Aがa2の場合
    {
      [TestMethod]
      public void Bがb1ならばc3となる()
      {
      }
    }
  }
}
