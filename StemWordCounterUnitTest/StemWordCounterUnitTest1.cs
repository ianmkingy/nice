using Microsoft.VisualStudio.TestTools.UnitTesting;
using StemWordCounter;

namespace StemWordCounter.Tests
{
    [TestClass()]
    public class StemWordCounterUnitTest1
    {
        [TestMethod()]
        [DataRow("following", "follow")]
        [DataRow("flow", "flow")]
        [DataRow("classification", "class")]
        [DataRow("class", "class")]
        [DataRow("flower", "flower")]
        [DataRow("friend", "friend")]
        [DataRow("friendly", "friend")]
        [DataRow("classes", "class")]
        [DataRow("friends", "friend")]
        [DataRow("friendlier", "friend")]
        [DataRow("friendlies", "friend")]
        [DataRow("classify", "class")]
        [DataRow("flowery", "flower")]
        [DataRow("flowers", "flower")]
        [DataRow("flows", "flow")]

        public void WordStemTest(string input, string expected)
        {
           Stem ostem = new Stem();
           string res = ostem.WordStem(input);
           Assert.AreEqual(res,expected);

        }


        [TestMethod()]
        [DataRow("following", "1")]
        [DataRow("flow", "2")]
        [DataRow("classification", "3")]
        [DataRow("class", "3")]
        [DataRow("flower", "3")]
        [DataRow("friend", "5")]
        [DataRow("friendly", "5")]
        [DataRow("classes", "3")]

        public void CountStemsTest(string input, string expected)
        {
            Stem ostem = new Stem();
            string res = ostem.CountStems("Friends are friendlier friendlies that are friendly and classify the friendly classification class. Flowery flowers flow through following the flower flows.", input).ToString();
            Assert.AreEqual(res, expected);

        }

    }
}


