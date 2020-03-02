using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak1;

namespace LeetSpeak1.Tests
{
  [TestClass]
  public class TranslationTests
  {
    [TestMethod]
    public void WordTranslate_Changeeto3_3()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Translation testTranslator = new Translation();
      Assert.AreEqual('3', testTranslator.WordTranslate('e'));
    }
    [TestMethod]
    public void WordTranslate_Changeoto0_0()
    {
      Translation testTranslator = new Translation();
      Assert.AreEqual('0', testTranslator.WordTranslate('o'));
    }
    [TestMethod]
    public void WordTranslate_ChangeLto1_1()
    {
      Translation testTranslator = new Translation();
      Assert.AreEqual('1', testTranslator.WordTranslate('L'));
    }
    [TestMethod]
    public void WordTranslate_ChangeIto1_1()
    {
      Translation testTranslator = new Translation();
      Assert.AreEqual('1', testTranslator.WordTranslate('I'));
    }
    [TestMethod]
    public void WordTranslate_Changetto7_7()
    {
      Translation testTranslator = new Translation();
      Assert.AreEqual('7', testTranslator.WordTranslate('t'));
    }
    [TestMethod]
    public void WordTranslate_Changestoz_z()
    {
      Translation testTranslator = new Translation();
      Assert.AreEqual('z', testTranslator.WordTranslate('s'));
    }
    [TestMethod]
    public void SentenceBreak_BreaksHelloToArray_Array()
    {
      Translation testTranslator = new Translation();
      char[] letters = {'h','e','l','l','o'};
      CollectionAssert.AreEqual(letters, testTranslator.SentenceBreak("hello"));
    }
    [TestMethod]
    public void SentenceTranslate_ReturnsTranslatedString_TranslatedString()
    {
      Translation testTranslator = new Translation();

      char[] letters = testTranslator.SentenceBreak("Someone said hows it going?");
      Assert.AreEqual("S0m30n3 said h0wz i7 g0ing?", testTranslator.SentenceTranslate(letters));
    }
  }
}