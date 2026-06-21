using GenericSample;

//1. Generics taking only int, bool, char....
GenericList<int> numbers = new GenericList<int>(5);
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

GenericList<char> characters = new GenericList<char>(5);
characters.Add('Y');
characters.Add('A');
characters.Add('S');
characters.Add('H');

//2. Generics taking only reference
GenericRerence<Employee> employees = new GenericRerence<Employee>(5);
employees.Add(new Employee("Yash"));
employees.Add(new Employee("Sunil"));

Console.WriteLine(employees.Current.Name);

//3. Generics taking both int,bool,char... and reference
GenericCombined<int> number1 = new GenericCombined<int>(1);
number1.Add(1);

GenericCombined<Employee> Employee1 = new GenericCombined<Employee>(1);
Employee1.Add(new Employee("Elon Musk"));

Console.WriteLine(numbers.Current);
Console.WriteLine(numbers[2]);
numbers[1] = 10;
Console.WriteLine(numbers[1]);

//Dictionaries
Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "item1");



