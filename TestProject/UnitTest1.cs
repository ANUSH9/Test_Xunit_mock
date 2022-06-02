using Xunit;
using System;
using dll_file;
using NUnit.Framework;


using Moq;

namespace TestProject
{
    public class UnitTest1
    {
        [SetUp]
        public void beforetest()
        {
            var a = 10;
            var b = 50;
            Console.WriteLine("before");
        }

        [Fact]
        public void Test_add()
        {
            var a = 10;
            var b = 20;
            var result = class1.add(a, b);
            Xunit.Assert.Equal(30, result);
        }
        [Fact]
        public void Test_sub()
        {
            var a = 50;
            var b = 10;

            Xunit.Assert.Equal(40, class1.sub(a, b)); 
        }
        [Fact]
        public void Test_Iadd()
        {
            var cat = new Mock<IDog>();
            cat.Setup(obj => obj.addition(2, 4)).Returns(6);
            Xunit.Assert.Equal(6, cat.Object.addition(2, 4));
            
        }
        [Fact]
        public void Test_div()
        {
            var cat = new Mock<IDog>();
            cat.Setup(obj => obj.divide(10, 50)).Returns(.2);
            Xunit.Assert.Equal(.2, cat.Object.divide(10, 50));

        }
        [Fact]
        public void Test_Isub()
        {
            var cat = new Mock<IDog>();
            cat.Setup(obj => obj.subtract(50, 10)).Returns(40);
            Xunit.Assert.Equal(40, cat.Object.subtract(50, 10));

        }
        [Fact]
        public void Test_Imul()
        {
            var cat = new Mock<IDog>();
            cat.Setup(obj => obj.multiply(5, 7)).Returns(35);
            Xunit.Assert.Equal(35, cat.Object.multiply(5, 7));

        }

    }
}