namespace TddProjekt
{
    public class CalcTest
    {
        [Fact]
        public void AddTwoNumbers()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var result = calc.Add(2, 3);

            //Assert
            Assert.Equal(5, result);

        }

        [Fact]
        public void SubTwoNumbers()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var result = calc.Sub(10, 5);

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void DivideTwoNumbers()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var result = calc.Divide(10, 2);

            //Assert
            Assert.Equal(5, result);

        }

        [Fact]
        public void ModuloTwoNumbers()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var result = calc.Mod(7, 2);

            //Assert
            Assert.Equal(1, result);

        }

        [Fact]
        public void MultiplyTwoNumbers()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var result = calc.Multiply(2, 5);

            //Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void StringReturned()
        {
            //Arrange
            var str = new Calculator();

            //Act
            var result = str.Text("hello world");

            //Assert
            Assert.Equal("hello world", result);

        }



    }
}