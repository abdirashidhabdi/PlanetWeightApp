using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetWeights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetWeights.Tests
{
    [TestClass()]
    public class PlanetWeightTests
    {
        //private readonly object planetWeightTest;

        private PlanetWeight planetTest;
        [TestInitialize]
        public void testInit()
        {
            this.planetTest = new PlanetWeight();
        }

        [TestMethod()]
        public void weightOnPlanetMercuryTest()
        {
            //Arrange
            //PlanetWeight planetTest = new PlanetWeight();
            this.planetTest.weight = 100;
            this.planetTest.planet = Planets.mercury;
            int userWeight = 100;
            double planetWeight = 0.38;
            double expectedResult = userWeight * planetWeight;

            //Act
            double actualResult = this.planetTest.weightOnPlanet;

            //Asert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void weightOnPlanetVenusTest()
        {
            //Arrange
            this.planetTest.weight = 100;
            this.planetTest.planet = Planets.venus;
            int userWeight = 100;
            double planetWeight = 0.91;
            double expectedResult = userWeight * planetWeight;

            //Act
            double actualResult = this.planetTest.weightOnPlanet;

            //Asert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void weightOnMoonTest()
        {
            //Arrange
            this.planetTest.weight = 100;
            this.planetTest.planet = Planets.moon;
            int userWeight = 100;
            double planetWeight = 1.62;
            double expectedResult = userWeight * planetWeight;

            //Act
            double actualResult = this.planetTest.weightOnPlanet;

            //Asert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void weightOnPlanetMarsTest()
        {
            //Arrange
            this.planetTest.weight = 100;
            this.planetTest.planet = Planets.mars;
            int userWeight = 100;
            double planetWeight = 0.38;
            double expectedResult = userWeight * planetWeight;

            //Act
            double actualResult = this.planetTest.weightOnPlanet;

            //Asert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void weightOnPlanetJupiterTest()
        {
            //Arrange
            this.planetTest.weight = 100;
            this.planetTest.planet = Planets.jupiter;
            int userWeight = 100;
            double planetWeight = 2.34;
            double expectedResult = userWeight * planetWeight;

            //Act
            double actualResult = this.planetTest.weightOnPlanet;

            //Asert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void weightOnPlanetSaturnTest()
        {
            //Arrange
            this.planetTest.weight = 100;
            this.planetTest.planet = Planets.saturn;
            int userWeight = 100;
            double planetWeight = 0.93;
            double expectedResult = userWeight * planetWeight;

            //Act
            double actualResult = this.planetTest.weightOnPlanet;

            //Asert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void weightOnPlanetUranusTest()
        {
            //Arrange
            this.planetTest.weight = 100;
            this.planetTest.planet = Planets.uranus;
            int userWeight = 100;
            double planetWeight = 0.92;
            double expectedResult = userWeight * planetWeight;

            //Act
            double actualResult = this.planetTest.weightOnPlanet;

            //Asert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void weightOnPlanetNeptuneTest()
        {
            //Arrange
            this.planetTest.weight = 100;
            this.planetTest.planet = Planets.neptune;
            int userWeight = 100;
            double planetWeight = 1.12;
            double expectedResult = userWeight * planetWeight;

            //Act
            double actualResult = this.planetTest.weightOnPlanet;

            //Asert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void weightOnPlanetPlutoTest()
        {
            //Arrange
            this.planetTest.weight = 100;
            this.planetTest.planet = Planets.pluto;
            int userWeight = 100;
            double planetWeight = 0.06;
            double expectedResult = userWeight * planetWeight;

            //Act
            double actualResult = this.planetTest.weightOnPlanet;

            //Asert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}