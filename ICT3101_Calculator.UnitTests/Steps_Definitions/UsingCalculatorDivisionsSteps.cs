using ICT3101;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Steps_Definitions
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorDivisionsSteps(Calculator _calculator) // use it as ctor parameter
        {
            this._calculator = _calculator;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {

        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" int othe calculator and press divide")]
        public void WhenIHaveEnteredAndIntOtheCalculatorAndPressDivide(double p0, double p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division results should be ""(.*)""")]
        public void ThenTheDivisionResultsShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division results should be positive infinity")]
        public void ThenTheDivisionResultsShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }

    }
}
