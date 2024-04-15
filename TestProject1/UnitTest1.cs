using ClassLibrary1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void Test2()
        {
            TestowaKlasa t = new TestowaKlasa();
            var x = t.TestowaFunkcja(1);
            Assert.Equal(0, x);
        }
    }
}