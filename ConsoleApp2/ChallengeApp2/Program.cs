using ChallengeApp2;

Employee employee1 = new Employee("Daniel", "XYZ", 31);
Employee employee2 = new Employee("Natalia", "XYZ", 29);
Employee employee3 = new Employee("Krzysztof", "XYZ", 35);

employee1.AddGrade(3);
employee1.AddGrade(1);
employee1.AddGrade(8);
employee1.AddGrade(4);
employee1.AddGrade(6);

employee2.AddGrade(7);
employee2.AddGrade(6);
employee2.AddGrade(1);
employee2.AddGrade(10);
employee2.AddGrade(8);

employee3.AddGrade(2);
employee3.AddGrade(9);
employee3.AddGrade(5);
employee3.AddGrade(3);
employee3.AddGrade(8);

List<Employee> users = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        maxResult = user.Result;
        userWithMaxResult = user;
    }
}

Console.WriteLine("Pracownik z najwyzsza ocena to: " + userWithMaxResult.Name + " " + userWithMaxResult.Surname + ", lat: " + userWithMaxResult.Age);
Console.WriteLine("Wynik: " + userWithMaxResult.Result);

//User user1 = new User("Daniel", "sds");

//user1.AddScore(5);
//user1.AddScore(6);
//var result = user1.Result;
//Console.WriteLine(result);