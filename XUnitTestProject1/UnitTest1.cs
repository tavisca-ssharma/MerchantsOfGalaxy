using System;
using Xunit;
using FluentAssertions;
using MerchantsOfGalaxy;
namespace XUnitTestProject1
{
    public class MOGTest
    {
        Class1 mog;
        public MOGTest()
        {
            mog = new Class1();
        }
        [Fact]
        public void IsubtractionVX()
        {
            string input = "IV";
            string outputexpected = "4";
            string output = Finaloutput(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void IsubtractionLCDM()
        {
            string input = "ID";
            string outputexpected = "Incorrect Format";
            string output = Finaloutput(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void XsubtractionLC()
        {
            string input = "XC";
            string outputexpected = "40";
            string output = Finaloutput(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void XsubtractionIVDM()
        {
            string input = "XM";
            string outputexpected = "Incorrect Format";
            string output = Finaloutput(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void CsubtractionDM()
        {
            string input = "CD";
            string outputexpected = "50";
            string output = Finaloutput(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void CsubtractionIVXL()
        {
            string input = "CX";
            string outputexpected = "Incorrect Format";
            string output = Finaloutput(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void VLDsubtraction()
        {
            string input = "VX";
            string outputexpected = "Incorrect Format";
            string output = Finaloutput(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void SmallLargeSubtraction()
        {
            string input = "IX";
            string outputexpected = "9";
            string output = Finaloutput(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void IXCMRepetition()
        {
            string input = "III";
            string outputexpected = "3";
            string output = Finaloutput(input);
            Assert.Equal(output, outputexpected);
        }

        [Fact]
        public void DLVRepetition()
        {
            string input = "DDD";
            string outputexpected = "Incorrect Format";
            string output = Finaloutput(input);
            Assert.Equal(output, outputexpected);
        }

        public string FinalOutput(string input)
        {
            char[] A = input.ToCharArray();
            string output = "";
            for (int i = 0; i < A.Length; i++)
            {
                output = mog.SendKeyPress(A[i]);
            }
            return output;
        }
    }
}
