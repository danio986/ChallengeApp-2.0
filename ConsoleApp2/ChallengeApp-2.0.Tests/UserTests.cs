namespace ChallengeApp2.Tests
{
    public class Tests
    {
        [Test]
        public void CheckSumGradesOfEmployee()
        {
            // arrange
            var employee = new Employee("Daniel", "aaaa", 20);
            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(-15);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(0, result);
        }
    }
}