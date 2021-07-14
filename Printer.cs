using System;

 namespace FizzBuzzSOLID
{
    /// <summary>
    /// Служит для печати тэга.
    /// </summary>
    public class Printer
    {
        private readonly Tag _tag;

        /// <summary>
        /// Инициализиурет тэг для печати
        /// </summary>
        /// <param name="tag"></param>
        public Printer(Tag tag)
        {
            _tag = tag;
        }

        public void Print()
        {
            Console.WriteLine(_tag);
        }
    }
}