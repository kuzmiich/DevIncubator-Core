using System;

namespace DevIncubatorCore.Methods
{
    class FullName : ITask
    {
        private string GetFullName(string firstName = "", string surname = "", string lastName = "")
        {
            return $"{firstName} {surname} {lastName}";
        }
        public void RunTask()
        {
            var firstName = "Vasily";
            var surname = "McGregor";
            var lastName = "Ivanov";

            Console.WriteLine(GetFullName(firstName, surname, lastName));
        }
    }
}
