using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpRecap
{
    class Program
    {

        static void DoSomethig(dynamic param)
        {
            Console.WriteLine(param.firstProperty); //discouraged
        }

        static void Main(string[] args)
        {
            var anonymousType = new { firstProperty = "first", secondProperty=2,thirdproperty=true};
            Console.WriteLine(anonymousType.GetType());
            Console.WriteLine(anonymousType.secondProperty.ToString());
            DoSomethig(anonymousType);

            Console.WriteLine();

            IList<AnonymousLinqStudent> AnonymousLinqStudentList = new List<AnonymousLinqStudent>() {
                        new AnonymousLinqStudent() { StudentID = 1, StudentName = "John", age = 18 },
                        new AnonymousLinqStudent() { StudentID = 2, StudentName = "Steve",  age = 21 },
                        new AnonymousLinqStudent() { StudentID = 3, StudentName = "Bill",  age = 18 },
                        new AnonymousLinqStudent() { StudentID = 4, StudentName = "Ram" , age = 20  },
                        new AnonymousLinqStudent() { StudentID = 5, StudentName = "Ron" , age = 21 }
                    };

            var studentNamesID = from s in AnonymousLinqStudentList
                               select new
                               {
                                   StudentID = s.StudentID,
                                   StudentName = s.StudentName
                               };

            foreach(var student in studentNamesID)
                Console.WriteLine(student);

            Console.WriteLine();

            int x = 8;
            int y = 8;

            var result = x < y ? "x is less than y" : x > y ? "x is greater than y" : "x equals y";
            Console.WriteLine(result);

        }
    }
}
