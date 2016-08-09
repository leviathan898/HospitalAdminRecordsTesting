using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using andyCheung_B8IT117;

namespace andyCheung_B8IT11_Test
{
    [TestClass]
    public class MethodsTest
    {
        [TestMethod]
        public void AddStaffTest()
        {
            //arrange
            //classes by default are internal to their own namespace, must make PeopleList public and reference
            PeopleList pl = new PeopleList();

            //act
            //pass invalid ID parameter to AddStaff method
            string actual = pl.AddStaff("string", "string", "string", "string", "string", "string", "-1");

            //assert
            string expected = "Data added.";//expected answer if the AddStaff method is successful

            //check if expected answer is equal to the actual answer
            Assert.AreEqual(expected, actual);//test designed to fail
        }

        [TestMethod]
        public void AddPatientTest()
        {
            //arrange
            //classes by default are internal to their own namespace, must make PeopleList public and reference
            PeopleList pl = new PeopleList();

            //act
            //valid ID but empty fields
            string actual = pl.AddPatient("", "", "", "", "", "", "5");

            //assert
            string expected = "Error: Please fill in all fields with correct entries.";//expected answer if the AddPatient method is false, either because of invalid ID or empty form fields

            //check if expected answer is equal to the actual
            Assert.AreEqual(expected, actual);//test designed to succeed
        }

        [TestMethod]
        public void SearchTest()
        {
            //arrange
            //classes by default are internal to their own namespace, must make PeopleList public and reference
            PeopleList pl = new PeopleList();
            Patient matchedPatient = new Patient();
            string actual;
            bool failed;

            //act
            //call method, pass parameter of null ID, return actual message and failed variables
            pl.SearchPatients("", out matchedPatient, out actual, out failed);

            //assert
            string expected = "ID not found.";

            Assert.AreEqual(expected, actual);//test designed to succeed

        }
    }
}
