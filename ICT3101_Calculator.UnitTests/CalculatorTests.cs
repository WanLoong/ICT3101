using ICT3101;
using NUnit.Framework;

namespace ICT3101_Calculator.CalculatorTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        IFileReader iFileReader;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            iFileReader = new FileReader();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        /*
         Question 14 
         */

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            double result = _calculator.Subtract(20, 10);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
        {
            double result = _calculator.Multiply(20, 10);
            Assert.That(result, Is.EqualTo(200));
        }


        [Test]
        public void Divide_WhenDivdingTwoNumbers_ResultEqualToDivision()
        {
            double result = _calculator.Divide(20, 10);
            Assert.That(result, Is.EqualTo(2));
        }

        /* 
         Question 15 
         */
        //[Test]
        //public void Divide_WithZerosAsInputs_ResultThrowArgumentException()
        //{
        //    Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        //}

        [Test]
        public void Divide_WithZerosAsInputs_ResultEqualsTo1()
        {
            Assert.That(() => _calculator.Divide(0, 0), Is.EqualTo(1));
        }


        /* 
        Question 15
        */

        [Test]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {

            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0)]

        public void Factorial_WithZerosAsInput_ResultEqualTo1(double n)
        {
            Assert.That(() => _calculator.Factorial(n), Is.EqualTo(1));
        }

        [Test]
        [TestCase(1)]

        public void Factorial_WithOneAsInput_ResultEqualTo1(double n)
        {
            Assert.That(() => _calculator.Factorial(n), Is.EqualTo(1));
        }

        [Test]
        [TestCase(2)]

        public void Factorial_WithTwoAsInput_ResultEqualTo2(double n)
        {
            Assert.That(() => _calculator.Factorial(n), Is.EqualTo(2));
        }


        [Test]
        [TestCase(5)]

        public void Factorial_withPositiveIntAsInput_ResultEqualTo120(double n)
        {
            Assert.That(() => _calculator.Factorial(n), Is.EqualTo(120));
        }



        [Test]
        [TestCase(-1)]
        public void Factorial_withNegativeDigitAsInputs_ResultThrowArgumentException(double n)
        {

            Assert.That(() => _calculator.Factorial(n), Throws.ArgumentException);

        }


        [Test]
        [TestCase(2, 5)]
        public void CalculateAreaOfTriangle_GivenTwoNumbers_ResultEqualsToFive(double length, double height)
        {

            Assert.That(() => _calculator.cal_tri_area(length, height), Is.EqualTo(5));

        }

        [Test]
        [TestCase(-2, 5)]
        public void CalculateAreaOfTriangle_GivenNegativeNumber_ResultThrowArgumentException(double length, double height)
        {
            Assert.That(() => _calculator.cal_tri_area(length, height), Throws.ArgumentException);
        }


        [Test]
        [TestCase(0, 5)]
        [TestCase(5, 0)]
        [TestCase(0, 0)]
        public void CalculateAreaOfTriangle_GivenZeroAsInput_ResultThrowArgumentException(double length, double height)
        {
            Assert.That(() => _calculator.cal_tri_area(length, height), Throws.ArgumentException);
        }


        [Test]
        [TestCase(4)]
        public void CalculateRadiusOfCicle_GivenTwoNumbers_ResultEqualsTo51(double radius)
        {

            Assert.That(() => _calculator.cal_circle_area(radius), Is.EqualTo(51));

        }


        [Test]
        [TestCase(-4)]
        public void CalculateRadiusOfCicle_GivenNegativeNumber_ResultThrowArgumentException(double radius)
        {

            Assert.That(() => _calculator.cal_circle_area(radius), Throws.ArgumentException);

        }

        [Test]
        [TestCase(0)]
        public void CalculateRadiusOfCicle_GivenZeroAsInput_ResultThrowArgumentException(double radius)
        {

            Assert.That(() => _calculator.cal_circle_area(radius), Throws.ArgumentException);

        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

        [Test]
        [TestCase(-3)]
        public void GenMagicNum_WhenGivenNegativeValue_ResultsEquals0(double input)
        {

            Assert.That(() => _calculator.GenMaigcNum(input, iFileReader), Is.EqualTo(0));
        }

        [Test]
        [TestCase(0)]
        public void GenMagicNum_WhenGivenIndex0_ResultsEquals20(double input)
        {
            Assert.That(() => _calculator.GenMaigcNum(input, iFileReader), Is.EqualTo(20));
        }

        [Test]
        [TestCase(1)]
        public void GenMagicNum_WhenGivenIndex1_ResultsEquals0(double input)
        {
            Assert.That(() => _calculator.GenMaigcNum(input, iFileReader), Is.EqualTo(0));
        }

        [Test]
        [TestCase(2)]
        public void GenMagicNum_WhenGivenIndex2_ResultsEqualNeg2(double input)
        {
            Assert.That(() => _calculator.GenMaigcNum(input, iFileReader), Is.EqualTo(2));
        }


    }
}