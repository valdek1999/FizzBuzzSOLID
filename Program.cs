using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace FizzBuzzSOLID
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numTags = new TagNumRulesCollection(new TagNumRule[]
            {
                new TagNumRule(new Tag("FizzBuzz"), new AndStrategy(new[] {new DivCondition(3), new DivCondition(5)})),
                new TagNumRule(new Tag("Fizz"), new AndStrategy(new[] {new DivCondition(3),})),
                new TagNumRule(new Tag("Buzz"), new AndStrategy(new[] {new DivCondition(5),}))
            });
            
            for (int i = 0; i < 100; i++)
            {
                new Printer(numTags.FindOfTag(i)).Print();
            }


        }
    }
}