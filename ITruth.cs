namespace FizzBuzzSOLID
{
    public interface ITruth
    {
        /// <summary>
        /// Метод проверящий соответствует соответствует ли num истине по заданному условию
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool isTruth(int num);
    }
}