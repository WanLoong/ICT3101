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
    public class UsingCalculatorBasicReliabilitySteps
    {

        private Calculator _calculator;
        private double _result;


        public UsingCalculatorBasicReliabilitySteps(Calculator _calculator) // use it as ctor parameter
        {
            this._calculator = _calculator;
        }


        [When(@"the initial failure intensity ""(.*)"" and the average number of failures ""(.*)"" and the total number of failure over infinite time ""(.*)"" and calculate current failure intensity")]
        public void WhenTheInitialFailureIntensityAndTheAverageNumberOfFailuresAndTheTotalNumberOfFailureOverInfiniteTimeAndCalculateCurrentFailureIntensity(int p0, int p1, int p2)
        {
            _result = _calculator.CalculateCurrentIntensity(p0, p1, p2);
        }

        [When(@"the initial failure intensity ""(.*)""and the average number of failures ""(.*)"" and  the total number of failure over infinite time ""(.*)"" and number of CPU Hours ""(.*)"" calculate the numbers of failures")]
        public void WhenTheInitialFailureIntensityAndTheAverageNumberOfFailuresAndTheTotalNumberOfFailureOverInfiniteTimeAndNumberOfCPUHoursCalculateTheNumbersOfFailures(int p0, int p1, int p2, int p3)
        {
            _result = _calculator.CalculateAverageNoOfFailures(p0, p1, p2, p3);
        }



        [Then(@"the current failure intensity should be ""(.*)""")]
        public void ThenTheCurrentFailureIntensityShouldBe(int p0)
        {

            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the number of failures experienced should be ""(.*)""")]
        public void ThenTheNumberOfFailuresExperiencedShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }


    }
}
