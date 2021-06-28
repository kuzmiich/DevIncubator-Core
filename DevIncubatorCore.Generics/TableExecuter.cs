using DevIncubatorCore.Generics.Components.TableWriter;
using System;
using System.Collections.Generic;

namespace DevIncubatorCore.Generics
{
    class TableExecuter : ITask
    {
        public void RunTask()
        {
            var id = 0;
            var users = new List<User>() {};

            Console.Write("Input user count: ");
            var count = Extractor.GetInt32(Console.ReadLine());
            while (id < count)
            {
                Console.Write("Input user name: ");
                var name = Console.ReadLine();
                Console.Write("Input user surname: ");
                var surname = Console.ReadLine();
                Console.Write("Input user age: ");
                var age = Extractor.GetInt32(Console.ReadLine());

                users.Add(new User()
                {
                    Id = id,
                    Name = name,
                    Surname = surname,
                    Age = age
                });
                id++;
            }
            var table = new Table<User>(users);
            Console.WriteLine(table.ToString());
        }
    }
}
