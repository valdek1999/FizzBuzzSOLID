using System.Collections;
using System.Collections.Generic;

 namespace FizzBuzzSOLID
{
    public class AndStrategy : ITruth
    {
        private readonly IEnumerable<ITruth> _conditions;

        public AndStrategy(IEnumerable<ITruth> conditions)
        {
            _conditions = conditions;
        }

        public bool isTruth(int num)
        {
            foreach (var condition in _conditions)
                if (!condition.isTruth(num))
                    return false;
            return true;
        }
    }
}