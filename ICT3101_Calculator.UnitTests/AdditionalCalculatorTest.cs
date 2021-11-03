using ICT3101;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator.UnitTests
{
    class AdditionalCalculatorTest
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("C:\\Users\\WenLong\\source\\repos\\ICT3101\\ICT3101\\MagicNumbers.txt")).Returns(new string[5] { "-10", "0", "1", "2", "3" });
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(-3)]
        public void GenMagicNum_WhenGivenNegativeValue_ResultsEquals0(double input)
        {

            Assert.That(() => _calculator.GenMaigcNum(input, _mockFileReader.Object), Is.EqualTo(0));
        }

        [Test]
        [TestCase(0)]
        public void GenMagicNum_WhenGivenIndex0_ResultsEquals20(double input)
        {
            Assert.That(() => _calculator.GenMaigcNum(input, _mockFileReader.Object), Is.EqualTo(20));
        }

        [Test]
        [TestCase(1)]
        public void GenMagicNum_WhenGivenIndex1_ResultsEquals0(double input)
        {
            Assert.That(() => _calculator.GenMaigcNum(input, _mockFileReader.Object), Is.EqualTo(0));
        }

        [Test]
        [TestCase(2)]
        public void GenMagicNum_WhenGivenIndex2_ResultsEqualNeg2(double input)
        {
            Assert.That(() => _calculator.GenMaigcNum(input, _mockFileReader.Object), Is.EqualTo(2));
        }
    }
}
