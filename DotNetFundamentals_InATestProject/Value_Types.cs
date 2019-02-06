using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Value_Types
    {

        public void ValueTypes() //examples of variable types
        {
            char character = '2';
            bool isLightOn = true;
            bool hasLegs = false;

            //Numbers
            byte byteMin = 0;
            byte byteMax = 255;

            short shortMin = -32768;
            short shortMax = 32767;

            int intMin = -24789798;
            int intMax = 23987897;

            long longerNumber = 48789787980;

            float floatNumber = 2.345f;

            double doubleExample = 3.434534354335d;

            decimal decimalExample = 3.80897897879890m; //used with most money calculations.

            int? nullValue = null;

            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1978, 12, 31); //YMD
        }

        public void Declaration() //declaring 10 different vars.
        {
            int thisIsANumber;
            byte smallNumber;
            double trolldouble;
            string helloWorld;
            long bignumber;
            decimal money;
            DateTime gamingTime;
            bool isItGamingTime;
            char funWord;
            short shortNum;
        }

        public void Declaration_Then_Initialization() //declaring then initializing them.
        {
            int thisIsANumber;
            thisIsANumber = 1337;
            byte smallNumber;
            smallNumber = 2;
            double trolldouble;
            trolldouble = 6.9d;
            string helloWorld;
            helloWorld = "hey what's up";
            long bignumber;
            bignumber = 9999999999999999;
            decimal money;
            money = 1.0099881m;
            DateTime gamingTime;
            gamingTime = DateTime.Now;
            bool isItGamingTime;
            isItGamingTime = true;
            char funWord;
            funWord = 'N';
            short shortNum;
            shortNum = 25;
        }

        public void Declaration_And_Initialization()
        {
            int thisIsANumber = 1337;
            byte smallNumber = 2;
            double trolldouble = 6.9d;
            string helloWorld = "hey what's up";
            long bignumber = 9999999999999999;
            decimal money = 1.0099881m;
            DateTime gamingTime = DateTime.Now;
            bool isItGamingTime = true;
            char funWord = 'N';
            short shortNum = 25;
        }
    }
}
