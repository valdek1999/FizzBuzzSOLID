# FizzBuzzSOLID
Классическое приложение FizzBuzz построенное по принципам SOLID на С#

![image](https://user-images.githubusercontent.com/17438672/125670357-1dd23e8c-56c3-4d30-97ef-6a7d23bf13e5.png)

Основными сущностями является класс Tag.cs, который может принимать в себя значения "Fizz", "Buzz", "FizzBuzz".Данный класс можно привязать к определённому правилу - к классам DivCondition и AndStrategy, реализующие проверку деления числа на "div" без остатка. Класс Printer - печатает на консоль, полученные тэги. 
С помощью этих классов можно реализовать другие, различные правила, и вывести по ним свои теги.


Пример использования FizzBuzzSolid на консоли:

            //Создаем коллекцию тегов привязанных к определённым правилам.
            var numTags = new TagNumRulesCollection(new TagNumRule[]
            {
                new TagNumRule(new Tag("FizzBuzz"), new AndStrategy(new[] {new DivCondition(3), new DivCondition(5)})),
                new TagNumRule(new Tag("Fizz"), new AndStrategy(new[] {new DivCondition(3),})),
                new TagNumRule(new Tag("Buzz"), new AndStrategy(new[] {new DivCondition(5),}))
            });
            
            //Проверяем к какому тегу относится число i.
            //Если i соответствуют одному из первых правил в коллекции, то соответствующий тэг печатается на консоль.
            for (int i = 0; i < 100; i++)
            {
                new Printer(numTags.FindOfTag(i)).Print();
            }
