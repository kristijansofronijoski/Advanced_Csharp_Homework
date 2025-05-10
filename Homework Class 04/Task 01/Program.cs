/* 
 Task 1
Create class PrintInConsole that will have multiple methods to print in console. Print(), PrintCollection().
Make this methods to be valid for more that one type and reuse the implenetation (hint: make them generic);
 */

using Task_01;


List<int> numbers = new List<int> (){ 1, 2, 3, 4, 5 };
List<string> strings = new List<string>() { "Hello", "World" };

//PrintInConsole<int>.Print(numbers);
//PrintInConsole<string>.Print(strings);
//PrintInConsole<int>.PrintCollection(numbers);
//PrintInConsole<string>.PrintCollection(strings);

PrintInConsole<int> intHelper = new PrintInConsole<int>();
PrintInConsole<string> stringHelper = new PrintInConsole<string>();
intHelper.Print(numbers);
stringHelper.Print(strings);