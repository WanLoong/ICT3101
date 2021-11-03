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
    public class UsingCalculatorMusafeatureSteps
    {
        private Calculator _calculator;
        private double _result;
        private Exception _actualException;
        public UsingCalculatorMusafeatureSteps(Calculator _calculator) // use it as ctor parameter
        {
            this._calculator = _calculator;
        }

        [When(@"I enter the failure intensity decay ""(.*)"" and and the initial failure intensity ""(.*)"" and the average number of failures ""(.*)""")]
        public void WhenIEnterTheFailureIntensityDecayAndAndTheInitialFailureIntensityAndTheAverageNumberOfFailures(double p0, int p1, int p2)
        {
            _result = _calculator.CalculateCurrentFailureIntensityUsingMusa(p0, p1, p2);
        }

        [When(@"I enter the failure intensity decay ""(.*)"" and and the initial failure intensity ""(.*)"" and the average number of failures ""(.*)"" and the number of cpu Hours ""(.*)""")]
        public void WhenIEnterTheFailureIntensityDecayAndAndTheInitialFailureIntensityAndTheAverageNumberOfFailuresAndTheNumberOfCpuHours(double p0, int p1, int p2, int p3)
        {
            _result = _calculator.CalculateNumberOfExpectedFailureUsingMusa(p0, p1, p2, p3);
        }

        [Then(@"the result of failure intensity is ""(.*)""")]
        public void ThenTheResultOfFailureIntensityIs(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the result of expected failure is ""(.*)""")]
        public void ThenTheResultOfExpectedFailureIs(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
