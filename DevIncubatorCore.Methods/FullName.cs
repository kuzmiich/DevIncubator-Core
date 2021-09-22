using System;

namespace DevIncubatorCore.Methods
{
    internal class FullName : ITask
    {
        public void RunTask()
        {
            var firstName = "Vasily";
            var surname = "McGregor";
            var lastName = "Ivanov";

            Console.WriteLine(GetFullName(firstName, surname, lastName));
        }

        private static string GetFullName(string firstName = "", string surname = "", string lastName = "")
        {
            return $"{firstName} {surname} {lastName}";
        }
    }
}