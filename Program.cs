using System.Threading.Tasks;
using System.Collections.Generic; //must be imported to use a dictionary, array, or list
using System; //imports common namespace called Sytem
//using directive lets us use the namespace without needing to qualify its use when using one of its members 
//without this naming shortcut, every time Console is used, it would need to be preceeded by System and a period
namespace CatWorx.BadgeMaker //namespaces used to organize and provide a level of separation in code like modules in Node.js
{ //everything inside these braces is interpreted as members of that namespace
class Program
{
// Update the method return type

static List<Employee> GetEmployees()
{
List<Employee> employees = new List<Employee>();
while(true) 
{
  // Move the initial prompt inside the loop, so it repeats for each employee
  Console.WriteLine("Enter first name (leave empty to exit): ");

  // change input to firstName
  string firstName = Console.ReadLine() ?? "";
  if (firstName == "") 
  {
    break;
  }

  // add a Console.ReadLine() for each value
  Console.Write("Enter last name: ");
  string lastName = Console.ReadLine() ?? "";
Console.Write("Enter ID: ");
  int id = Int32.Parse(Console.ReadLine() ?? "");
  Console.Write("Enter Photo URL:");
  string photoUrl = Console.ReadLine() ?? "";
  Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
  employees.Add(currentEmployee);
  }

  return employees;
}
// Change the type of the employees parameter

static void PrintEmployees(List<Employee> employees)  {
for (int i = 0; i < employees.Count; i++) 
{
  string template = "{0,-10}\t{1,-20}\t{2}";
  Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
}
  }

async static Task Main(string[] args)
{
    List<Employee> employees = GetEmployees();
    Util.PrintEmployees(employees);
    Util.MakeCSV(employees);
    await Util.MakeBadges(employees);
}
}
}

//Namespaces: containers that have members, a member can be another nexted namespace, a method, or a class
//System: parto of the .NET framework, a collection of commonly used methods, data types,
//and data structures, which are the essential building blocks of a C# app
//.NET 6.0 has implicit usings, which are turned on by default which automatically adds certain 
//using directives based on the project type
//Main() method is the entry point of the application, it is invoked when the program runs
//In order for Main() to be reorganized as the program's entry point, this syntax guidelines
//must be followed: 1. Main() must be nested in a class 2. There can only be one entry 
//point to a program 3. the keyword 'void' signifies that the return of this executable 
//method will be void 4. the keyword 'static' implies that the scope of this method is at 
//the class level, not the object level, and can thus be invoked without having to
//first create a new class instance, so the Main() method can be run as soon as the program
//runs
//syntax: static void Main (string[] args)
//run the app with 'dotnet run' in terminal
//strings must be declared with "" in C#
//int type used for integers and float for decimals 
//writing a decimal with no suffix is by default type double, using an F suffix converts the literal to a float
//GetType() can be used to identify the data type of a variable
//'bool' is the boolean data type
//Convert class from System namespace ToInt32(), ToInt16(), or ToInt64