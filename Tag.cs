namespace FizzBuzzSOLID
{
    /// <summary>
    /// Тег-правила
    /// </summary>
    public class Tag
    {
        public string Value { get; private set; }
        
        /// <summary>
        /// Конструктор класса принимающий значение тэга
        /// </summary>
        /// <param name="value"> тэг</param>
        public Tag(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}