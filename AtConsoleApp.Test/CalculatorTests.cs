using Xunit;
using AtClassLibrary;

namespace AtConsoleApp.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_2integer_values_Pass_Test()
        {
            int expected = 5;
            int actual = Calculator.Add(3, 2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_2float_Values_Pass_Test()
        {
            decimal expected = 35.9M;
            decimal actual = Calculator.Add(12.4M, 23.5M);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_2_string_values_Pass_Test()
        {
            string expected = "naeemashfaq";
            string actual = Calculator.Add("naeem", "ashfaq");
            Assert.Equal(expected, actual);
        }

        
    }
}
