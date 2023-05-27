using System;
using System.Collections.Generic;
using static coursework_TAiFYA.lexemes;


namespace coursework_TAiFYA
{
    public class lemexeClass
    {
        public readonly List<string> keywords = new List<string>() // неизменяемый список ключевых слов(по коду своему)
        {
            "var", "begin", "integer", "repeat", "until", "end" , "or"
        };

        public readonly List<string> separators_list = new List<string>()// аналогично с ключевыми словами
        {
            "+", "-", "*", "/", ":=", "=", ":", ";", ".", ",", "(", ")", "<", ">"
        };

        public readonly List<string> identifiers = new List<string>(); // список для идинтификаторов 
        public readonly List<string> literals = new List<string>(); // для литератолов 

        public List<Tuple<string, int>> Classify(List<Tuple<string, TypeLexeme>> lexemes) // метод классификации ТСС таблица
        {
            List<Tuple<string, int>> result = new List<Tuple<string, int>>(); // список куда все будет добавляться, котреж 2 аргмента строка и номер по спикску


            foreach (var lexem in lexemes)
            {
                string lexemStr = lexem.Item1; // тип лексемы ТТС таблица 1
                TypeLexeme lexemType = lexem.Item2; // ее номер в списке ТСС таблица 1

                switch (lexemType)
                {
                    case TypeLexeme.I: // индификатор 
                        if (keywords.Contains(lexemStr)) // если встречаемая лексма содержится в списке ключевых слов
                        {
                            result.Add(new Tuple<string, int>("Ключевое слово", keywords.IndexOf(lexemStr))); // то добавляем в результ. список с номером в списке
                        }
                        else // иначе лексемы нет в списке ключевых слов то это индификатор другой(т.к ключевые слова и переменные(вроде) это все индификаторы) 
                        {
                            if (!identifiers.Contains(lexemStr))// если не содержит встречаемая лексема то
                            {
                                identifiers.Add(lexemStr);// добавляем в спискок индификаторов
                            }

                            result.Add(new Tuple<string, int>("Индификаторы", identifiers.IndexOf(lexemStr)));// если есть то доблавляем в рез. списпок так же с номером по порядку.
                        }

                        break;

                    case TypeLexeme.L: // литерал
                        if (!literals.Contains(lexemStr)) // если в списке литерала нет такого встерчаемой лексемы
                        {
                            literals.Add(lexemStr);// то добавляем
                        }

                        result.Add(new Tuple<string, int>("Литерал", literals.IndexOf(lexemStr)));// если есть просто встерчаемую лексему добавляем в спискок и ее место в списке
                        break;

                    case TypeLexeme.R: // разделитель
                        if (separators_list.Contains(lexemStr)) // проверка содержит ли список встречаемую лексему 
                        {
                            result.Add(new Tuple<string, int>("Разделитель", separators_list.IndexOf(lexemStr)));// если да, добавляет в список с номером в списке
                        }
                        break;
                }
            }

            return result;
        }
    }
}
