using System.Collections;
using System.Collections.Generic;

namespace FizzBuzzSOLID
{
    /// <summary>
    /// Интерфейс правила
    /// </summary>
    internal interface Rule
    {
        /// <summary>
        /// Метод проверяющий проходит ли значение по заданному правилу
        /// </summary>
        /// <param name="num">Значение, которое будет проверятся по правилу</param>
        /// <returns>Возвращает истину если проверка правила успешна</returns>
        public bool isSuccess(int num);
    }

    /// <summary>
    /// Класс который содержит тэг привязанный к определенному правилу или стратегии
    /// </summary>
    public class TagNumRule : Rule
    {
        private readonly ITruth _strategy;
        public Tag Tag { get; private set; }

        /// <summary>
        /// Инициализируем экземпляр класса TagNumRule, в котором тег привязывается к определённому правилу или стратегии
        /// </summary>
        /// <param name="tag">Тэг</param>
        /// <param name="strategy">Правило или стратегия реализованная интерфейсом ITruf</param>
        public TagNumRule(Tag tag, ITruth strategy)
        {
            Tag = tag;
            _strategy = strategy;
        }

        public bool isSuccess(int num)
        {
            return _strategy.isTruth(num);
        }
        
    }

    /// <summary>
    /// Класс содержащий в себе коллекцию тэгов соотносящихся с правилом
    /// </summary>
    public class TagNumRulesCollection: IEnumerable
    {
        private IEnumerable<TagNumRule> _tagNumRules;
        /// <summary>
        /// Конструктор с коллекцией правил в котором важен порядок
        /// </summary>
        /// <param name="tagNumRules"></param>
        public TagNumRulesCollection(IEnumerable<TagNumRule> tagNumRules)
        {
            _tagNumRules = tagNumRules;
        }
        /// <summary>
        /// Ищет первый выполняемый тэг по коллекции правил
        /// </summary>
        /// <param name="num">Число которое проходит проверку по правилу</param>
        /// <returns> Выводит первый выполняемый тэг по правилу</returns>
        public Tag FindOfTag(int num)
        {
            foreach (var rule in _tagNumRules)
            {
                if (rule.isSuccess(num))
                    return rule.Tag;
            }

            return new Tag(num.ToString());
        }

        public IEnumerator GetEnumerator()
        {
            return _tagNumRules.GetEnumerator();
        }
    }
}