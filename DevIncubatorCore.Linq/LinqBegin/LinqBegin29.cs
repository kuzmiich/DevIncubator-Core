using System;
using System.Linq;

namespace DevIncubatorCore.Linq.LinqBegin
{
    public class LinqBegin29 : ITask
    {
        public void RunTask()
        {
            var d = 2;
            var k = 6;
            var enumerable = Enumerable.Range(1, 15);
            var moreThenDEnumerable = enumerable.TakeWhile(el => el < d);
            var skipBeforeKEnumerable = enumerable.Skip(k);
            
            var result = moreThenDEnumerable.Union(skipBeforeKEnumerable)
                    .Distinct()
                    .OrderByDescending(_ => _);
            
            Console.WriteLine(string.Join(' ', result));
        }
    }
}