
using ClassSamples.Entities;

/* Employee employee = new Employee(101, "Yash", "Gandhi");

Console.WriteLine(employee.Fullname());   

Console.WriteLine(employee.CalculateExpense(100)); */

//Lambda expressions
/*var mymethod = (int number1, int number2) => { return number1 + number2; };
var mymethod1 = (int number1, int number2) => number1 + number2;
var mymethod2 = () => Console.WriteLine("Something...");
Console.WriteLine(mymethod(1, 2));*/

SalesEmployee salesEmployee = new SalesEmployee(101, "Yash", "Gandhi");

salesEmployee.HighExpenseValue += HighExpenseAlarm; //this is binding syntax
//Lambda
salesEmployee.HighExpenseValue += value => Console.WriteLine($"The expense value {value}, is higher than expected...");

var expenseValue = salesEmployee.CalculateExpense(100);

Console.WriteLine(expenseValue);

void HighExpenseAlarm(double value)
{
    Console.WriteLine($"The expense value {value}, is higher than expected...");
}