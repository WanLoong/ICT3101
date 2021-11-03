using ICT3101;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Steps_Definitions
{

    [Binding]

    public class UsingCalculatorAdditionsSteps
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorAdditionsSteps(Calculator calculator)
        {
            this._calculator = calculator;
        }

        //[Given(@"I have a calculator")]
        //public void GivenIHaveACalculator()
        //{

        //}

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
