using System;
using Xunit;
using FluentAssertions;
using MerchantsOfGalaxy;
namespace Merchant
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
            int outputexpected = 4;
            int output = moga.RomanToDecimal("IV");
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void IsubtractionLCDM()
        {
            string input = "ID";
            int outputexpected = -1;
            int output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void XsubtractionLC()
        {
            string input = "XC";
            int outputexpected = 90;
            int output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void XsubtractionIVDM()
        {
            string input = "XM";
            int outputexpected = -1;
            int output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void CsubtractionDM()
        {
            string input = "CD";
            int outputexpected = 400;
            int output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void VLDsubtraction()
        {
            string input = "VX";
            int outputexpected = -1;
            int output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void SmallLargeSubtraction()
        {
            string input = "IX";
            int outputexpected = 9;
            int output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void IXCMRepetition()
        {
            string input = "III";
            int outputexpected = 3;
            int output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void DLVRepetition()
        {
            string input = "DDD";
            int outputexpected = -1;
            int output = mog.RomanToDecimal(input);
            Assert.Equal(output, outputexpected);
        }
    }
}
