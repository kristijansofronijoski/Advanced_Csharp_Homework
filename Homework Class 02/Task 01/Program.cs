/*
 Task 1
Write a program to create an interface Searchable with a method Search(string word) that searches for a given keyword in a text document. 
Create two classes Document and WebPage that implement the Searchable interface and provide their own implementations of the Search() method.
 */

using Task_01;
using Task_01.Interfaces;

class Program
{
   
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        ISearchable doc = new Document("Reflex are found with varying levels of complexity in organisms with a nervous system. " +
            "A reflex occurs via neural pathways in the nervous system called reflex arcs. A stimulus initiates a neural signal, which is carried to a synapse.");
        ISearchable web = new WebPage("<html><body>Welcome to the reflex masage studio</body></html>");

        string searchWord = "Reflex";

        if (doc.Search(searchWord))
        {
            Console.WriteLine($"The word '{searchWord}' was found in the document.");
        }
        else
        {
            Console.WriteLine($"The word '{searchWord}' was not found in the document.");
        }

        if (web.Search(searchWord))
        {
            Console.WriteLine($"The word '{searchWord}' was found in the webpage.");
        }
        else
        {
            Console.WriteLine($"The word '{searchWord}' was not found in the webpage.");
        }
    }
}