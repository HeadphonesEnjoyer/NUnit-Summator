using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [SetUp]
    public void Setup()
    {
            Console.WriteLine("Test call " + DateTime.Now);
    }

        [Test]

        public void Test_Summator_SumTwoPositiveNumbers()
        {
            var nums = new int[] { 1, 2, };
            var actual = Summator.Sum(nums);
            var expected = 3;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99, };
            var actual = Summator.Sum(nums);
            var expected = -100;
            Assert.AreEqual(expected, actual);

        }
        [Order(1)]
        [Test]
        public void Test_Summator_OneNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);
            var expected = 6;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_Summator_ZeroNumber()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);
            var expected = 0;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_Summator_BigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000 };
            var actual = Summator.Sum(nums);
            var expected = 6000000000;
            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void Test_Summator_SumThreePositiveNumbers()
        {
            //Arrange
            var nums = new int[] { 1, 2, 88 };
            var expected = 91;

            //Act
            var actual = Summator.Sum(nums);

            //Assert
            Assert.AreEqual(expected, actual);

            //Assert.That(expected, Is.EqualTo(actual));
        }
        [Category("High")]
        [Test]
        public void Test_Summator_Assertions()
        {
            //assert boolean conditions
            Assert.That(9 == 9);

            // Range assertions
            double percentage = 99.95;
            Assert.That(percentage, Is.InRange(80, 100));

            Assert.That("A very random string of text", Does.Contain("text"));

            //regex
            string date = "7/11/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));

            Assert.That(() => "abc"[45], Throws.TypeOf<IndexOutOfRangeException>());
            Assert.That(() => "abc"[45], Throws.InstanceOf<Exception>());

            Assert.That(new int[] { 4, 5, 6 }, Has.Member(5));

            var percentages = new int[] { 10, 30, 50, 100 };
            Assert.That(percentages, Is.All.InRange(0, 100));

            //   Assert.That(percentage, Is.EqualTo(100), "Post this message");

        }
        [Test]

            public void Test_Summator_AverageTwoPositiveNumbers()
            {
                var nums = new int[] { 3, 5 };
                var actual = Summator.Average(nums);
                var expected = 4;
                Assert.AreEqual(expected, actual);
            }
        [Category("Sanity")]
        [Test]

        public void Test_Summator_Average_Two_Fractions()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Average(nums);
            var expected = 1.5;
            Assert.AreEqual(expected, actual);
        }


    }
}

