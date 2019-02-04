using System;
using System.Linq;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            using(var context = new DataModel.EFcontext())
            {
                var todos = context.todos.ToList();
                foreach(var todo in todos)
                {
                    Console.WriteLine(todo.TaskId);
                    Console.WriteLine(todo.TaskName);
                }
                Console.ReadLine();
            }
        }
    }
}
