/* 
 Task 1
Create class User that will have 3 properties Id, Name, Age.
Create static class UserDatabase that will contain a list of Users (create couple of users and add them to the list). 
Create method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result.
 */


using Task_01;

Console.WriteLine("Search by Id:");
List<User> usersById = UserDatabase.SearchById(1);
foreach (var user in usersById)
{
    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
}