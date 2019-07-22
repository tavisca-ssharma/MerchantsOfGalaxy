using System;
using Xunit;
using FluentAssertions;
using MerchantsOfGalaxy;
namespace XUnitTestProject1
{
    public class MOGTest
    {
        Galaxy mog;
        public MOGTest()
        {
            mog = new Galaxy();
        }
        [Fact]
        public void IsubtractionVX()
        {
            var moga = new Galaxy();
            string input = "IV";
            string outputexpected = "4";
            string output = moga.RomanToDecimal("IV");
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void IsubtractionLCDM()
        {
            string input = "ID";
            string outputexpected = "Incorrect Format";
            string output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void XsubtractionLC()
        {
            string input = "XC";
            string outputexpected = "90";
            string output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void XsubtractionIVDM()
        {
            string input = "XM";
            string outputexpected = "Incorrect Format";
            string output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void CsubtractionDM()
        {
            string input = "CD";
            string outputexpected = "400";
            string output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void VLDsubtraction()
        {
            string input = "VX";
            string outputexpected = "Incorrect Format";
            string output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void SmallLargeSubtraction()
        {
            string input = "IX";
            string outputexpected = "9";
            string output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void IXCMRepetition()
        {
            string input = "III";
            string outputexpected = "3";
            string output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void DLVRepetition()
        {
            string input = "DDD";
            string outputexpected = "Incorrect Format";
            string output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }
    }
}
