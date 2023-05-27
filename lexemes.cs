using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace coursework_TAiFYA
{
    public class lexemes
    {
        public enum Symbol // перечисление возможных встречаемых символов(буквы, литералы, разделитель, пробел и другие)
        {
            Letter,
            Liters,
            Separator,
            Space,
            Other
        }
        public enum TypeLexeme // Перичесление типов литералов 
        {
            I,
            L,
            R
        }

        private List<string> separators_list = new List<string>() // список всех возможных разделителей(смотри на свою прогу)
        {
            "+", "-", "*", "/", "=", "=", ":", ";", ".", ",", "(", ")", "<", ">"
        };

        private Symbol GetSymbol(char symbol) // Проверка на принадлежность к типу встречаемых символов 
        {
            if (char.IsLetter(symbol))
            {
                return Symbol.Letter;
            }
            else if (char.IsDigit(symbol))
            {
                return Symbol.Liters;
            }
            else if (separators_list.Contains(symbol.ToString()))
            {
                return Symbol.Separator;
            }
            else if (symbol == ' ')
            {
                return Symbol.Space;
            }
            return Symbol.Other;
        }

        public List<Tuple<string, TypeLexeme>> Check(string text) // метод проверки лексем, чтобы задать тип лексеме, котреж хранящий в себе строку и тип лексемы
        {
            text = text.Replace('\n', ' '); //Все переходы на новую сторчку заменяем на пробелы

            List<Tuple<string, TypeLexeme>> lexems = new List<Tuple<string, TypeLexeme>>(); // кортеж, которых хранит в себе 2 аргумента: строку и тип лексемы(первая таблица)
            string buffer = ""; // буффер, в который будут записываться по символьно символы
            TypeLexeme tl = TypeLexeme.I;

            if (text.Length == 0) // обычная проверка на пустой текст
            {
                throw new Exception("Текстовое поле пустое!"); // вывод ошибки   
            }

            for (int i = 0; i < text.Length; i++) // проход по всей длине текста
            {
			
                if (tl == TypeLexeme.I && buffer.Length > 8) // проверка на длину индинтификатора (не больше 8 символов)
                {
                    throw new Exception("Длина идентификатора превысила 8 символов"); // вывод ошибки
                }

                switch (GetSymbol(text[i])) // получаем символ
                {
                    case Symbol.Letter:

                        if (buffer == "") // если буфер пустой идем дальше посимвольно(записываем встречаемый символ)
                        {
                            tl = TypeLexeme.I;
                            buffer += text[i];
                            break;
                        }

                        switch (tl)
                        {
                            case TypeLexeme.I: //если встрелась буква, то дальше в буффер добавляем под одному символу
                                buffer += text[i];
								break;

							case TypeLexeme.L: // название переменных не может начинаться с цифр и ошибка об этом(то есть, индификатор не может начинаться с цифры - это литерал)
								throw new Exception("Наименование не может начинаться с цифр");

                            case TypeLexeme.R: // если следующим символом оказался разделитель
                                lexems.Add(new Tuple<string, TypeLexeme>(buffer, tl)); //добавляем полученное слово в список лексем и задаем тип индификатор
                                buffer = text[i].ToString(); // вроде обнуляется буффер и записывается символ, который встретился(получается разделитель дальше реализация будет в case Separator) 
                                tl = TypeLexeme.I; //задается тип лексемы
                                break;
                        }
                        break;

                    case Symbol.Liters: // литерал

                        if (buffer == "") // если буффер пустой, добавляем символ
                        {
                            tl = TypeLexeme.L;
                            buffer += text[i];
                            break;
                        }

                        switch (tl)
                        {
                            case TypeLexeme.I: //если встретилась буква, то дальше в буффер добавляем под одному символу
                                buffer += text[i];
                                break;

                            case TypeLexeme.L://если встретилась буква, то дальше в буффер добавляем под одному символу
                                buffer += text[i];
                                break;

                            case TypeLexeme.R: // аналогично с 91-94 строки
                                lexems.Add(new Tuple<string, TypeLexeme>(buffer, tl));
                                buffer = text[i].ToString();
                                tl = TypeLexeme.L;
                                break;
                        }
                        break;

                    case Symbol.Separator: //разделитель

                        if (buffer == "") // аналогично всему прошлому подобному
                        {
                            tl = TypeLexeme.R;
                            buffer += text[i];
                            break;
                        }

                        switch (tl)
                        {
                            case TypeLexeme.I: // тут вроде если после разделителя встретилась буква, то добавляем разделитель в список
                                lexems.Add(new Tuple<string, TypeLexeme>(buffer, tl));
                                buffer = text[i].ToString(); // вроде обнуляется буффер и записывается символ, который встретился после
                                tl = TypeLexeme.R; //задается тип лексемы
                                break;

                            case TypeLexeme.L: // а тут как на 137 строке, но если встретилась цифра
                                lexems.Add(new Tuple<string, TypeLexeme>(buffer, tl));
                                buffer = text[i].ToString();// вроде обнуляется буффер и записывается символ, который встретился после
                                tl = TypeLexeme.R; //задается тип лексемы
                                break;

                            case TypeLexeme.R:
                                if (buffer.Length > 1)// (счет с 0 идет) если после добавление одного раздетиля добавляется еще один, затем еще один то выводится ошибка.
                                { // в моем pascal допускается длина 2 символа, например :=, в твоем случаем смотри по коду. Если только одинарные, то > 0 ставишь
                                    throw new Exception("Длина разделителя не может превышать два символа");
                                }
                                buffer += text[i]; //добавляем второй разделитель и задаем тип лексеме
                                tl = TypeLexeme.R;
                                break;
                        }
                        break;

                    case Symbol.Space: // пробел
                        if (buffer.Length == 0) // если длина буффера ноль, то обычный выход
                        {
                            break;
                        }
                        lexems.Add(new Tuple<string, TypeLexeme>(buffer, tl)); // добавленные символы до пробела задаются типом лексемы и добавляется в список
                        buffer = ""; // обнуляем буффер
                        break;

                    case Symbol.Other: // другие символе не допустимы, например %(можешь поставить в текст и убедиться)
                        throw new Exception("Недопустимые символы в программе");
                }
            }

            switch (tl) // тут происходит добавление в список с типом последнего символа текста(можешь убрать и убедиться, что последний символ не добавляется в таблицу)
            {
                case TypeLexeme.I:
                    lexems.Add(new Tuple<string, TypeLexeme>(buffer, TypeLexeme.I));
                    break;

                case TypeLexeme.L:
                    lexems.Add(new Tuple<string, TypeLexeme>(buffer, TypeLexeme.L));
                    break;

                case TypeLexeme.R:
                    lexems.Add(new Tuple<string, TypeLexeme>(buffer, TypeLexeme.R));
                    break;
            }

            return lexems;
        }
    }
}
