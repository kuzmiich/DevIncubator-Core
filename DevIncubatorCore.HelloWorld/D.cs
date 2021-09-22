using System;

namespace DevIncubatorCore.HelloWorld
{
    internal class D : ITask
    {
        public void RunTask()
        {
            var a = "default";
            var b = 21;
            var c = 34.432;

            var stringHashCode = a.GetHashCode();
            var intHashCode = b.GetHashCode();
            var doubleHashCode = c.GetHashCode();

            Console.WriteLine(
                $"String hash code - {stringHashCode}, int hash code - {intHashCode}, double hash code - {doubleHashCode}");
        }
    }
}