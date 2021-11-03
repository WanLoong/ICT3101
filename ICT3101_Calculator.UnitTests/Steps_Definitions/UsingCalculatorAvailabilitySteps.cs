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

    public class UsingCalculatorAvailabilitySteps
    {
        private Calculator _calculator;
        private double _result;
        private Exception _actualException;

        public UsingCalculatorAvailabilitySteps(Calculator _calculator) // use it as ctor parameter
        {
            this._calculator = _calculator;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double p0, double p1)
        {
            try
            {
                _result = _calculator.CalculateMTBF(p0, p1);
            }
            catch (Exception ex)
            {
                _actualException = ex;
            }

        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {

            try
            {
                _result = _calculator.CalculateAvailability(p0, p1);

            }
            catch (Exception ex)
            {
                _actualException = ex;
            }
        }



        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {

            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"Then the error '(.*)' should be raised")]
        public void ThenThenTheErrorShouldBeRaised(string p0)
        {
            Assert.AreEqual(p0, _actualException.Message);
        }
    }
}
