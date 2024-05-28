namespace UsTicketServ.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Additional_WhenCalled_ReturnsSumOfArguments()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Additional(1, 2);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Subtraction_WhenCalled_ReturnsDifferenceOfArguments()
        {
           
            Calculator calculator = new Calculator();

            
            int result = calculator.Subtraction(10, 4);

            
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Miltiplication_WhenCalled_ReturnsProductOfArguments()
        {
            
            Calculator calculator = new Calculator();

            
            int result = calculator.Miltiplication(2, 3);

           
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Division_WhenCalled_ReturnsQuotientOfArguments()
        {
           
            Calculator calculator = new Calculator();

            
            int result = calculator.Division(8, 4);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Division_DivideByZero_ThrowsException()
        {
            
            Calculator calculator = new Calculator();

           
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}