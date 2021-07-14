namespace FizzBuzzSOLID
{
    /// <summary>
    /// Правило для проверки числа num на деление без остатка на число divisor
    /// </summary>
    public class DivCondition : ITruth
    {
        private readonly int _divisor;

        public DivCondition(int divisor)
        {
            _divisor = divisor;
        }

        public bool isTruth(int num)
        {
            return num % _divisor == 0;
        }
    }
}