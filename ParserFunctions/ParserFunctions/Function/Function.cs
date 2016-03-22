using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ParserFunctions
{
    class Function
    {
        string sfunc; // входная строка;
        List<float> fta; // массив значений функции;

        public Function(string s)
        {
            this.sfunc = s.Replace(" ", "").Replace('.',','); // Удаляем пробелы из строки и заменяем . на ,;
        }
        public float Parse(string s, decimal x = 0) // Вычисляем значение фунции в строке при заданом x;
        {
                s = s.Replace("x", x + "").Replace(" ", "").Replace('.', ','); ; // Заменяем строку x на значение переменной  x, удаляем пробелы из строки и заменяем . на ,;
                s = RoundBrackets(s); // Вычисляем значения в скобках;
                s = Pow(s);  //Вычисляем степень числа;
                s = TriFunction(s); // Вычисляем значение тригонометрческих функций;
                s = Composition(s); // Умножаем;
                s = Sum(s); // Суммируем;
                return float.Parse(s); // Возвращаем значение;
        }
        public List<float> FunctionToArray(decimal dx, decimal minx, decimal maxx) // Формируем массив значений фунции;
        {
            fta = new List<float>();
            for (decimal i = minx; i < maxx; i+=dx)
            {
                fta.Add(Parse(sfunc, i));
            }
            return fta;
        }        
        private string RoundBrackets(string s) // Вычисляем значение в скобках;
        {
            if(!s.Contains('(')) // Если скобок нет - пропускаем;
                return s;
            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] == '(') // Если нашли открывающую скобку; 
                {
                    int j = 1;
                    while (true)
                    {

                        if (s[i + j] == ')') // Если следующая скобка закрывающаяся;
                        {
                            s = s.Remove(i, j + 1).Insert(i, Parse(s.Substring(i + 1, j - 1)) + ""); // Вырезаем то, что в ней, вычисляем значение, заменяем вместе со скобкой на значение;
                            break;
                        }
                        if(s[i+j] == '(') // Если следующая скобка открывающаяся, ищем закрывающуюся для нее;
                        {
                            i += j;
                        }
                        j++;
                    }
                }
            }
            return RoundBrackets(s); // Рекурсия до тех пор, пока все скобки не закончаться;
        }
        private string Sum(string s) // Суммирование;
        {

            if (s.Contains("-+") || s.Contains("+-") || s.Contains("++") || s.Contains("--")) // Замена идущих подряд знаков;
                s = Remove(s);
            for (int i = 1; i < s.Length; i++) // i начинается с 1, чтобы не включать знак перед числом
            {
                if ((s[i] == '+' || s[i] == '-'))
                {
                    s = MathematicFunctions(s, i); // Если s[i] знак + или - передаем его индекс в  MathematicFunctions и вычиляем;
                    return Sum(s); // Рекурсия до тех пор пока есть + или -;
                }

            }
            return s;
        }
        private string TriFunction(string s) // Обработка тригонометрических функций;
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(0, i).Contains("sin"))
                {
                    s = MathematicFunctions(s, i - 1, "sin");
                    return TriFunction(s);
                }
                if (s.Substring(0, i).Contains("cos"))
                {
                    s = MathematicFunctions(s, i - 1, "cos");
                    return TriFunction(s);
                }
                if (s.Substring(0, i).Contains("ctg"))
                {
                    s = MathematicFunctions(s, i - 1, "ctg");
                    return TriFunction(s);
                }
                if (s.Substring(0, i).Contains("tg"))
                {
                    s = MathematicFunctions(s, i- 1, "tg");
                    return TriFunction(s);
                }
            }
            return s;
        }
        private string Remove(string s) // Рекурсивный метод, с помощью которого избавляемся от идущих друг за другом знаков;
        {
            s = s.Replace("-+", "-").Replace("+-", "-").Replace("++", "+").Replace("--", "+");
            if (s.Contains("-+") || s.Contains("+-") || s.Contains("++") || s.Contains("--"))
                return Remove(s);
            return s;
        }
        private string Composition(string s) // Метод аналогичный Sum();
        {
            for (int i = 1; i < s.Length; i++) // i начинается с 1, чтобы не включать знак перед числом;
            {
                if (s[i] == '*' || s[i] == '/')
                {
                    s = MathematicFunctions(s, i);
                    return Composition(s);
                }
            }
            return s;
        }

        private string Pow(string s) // Метод аналогичный Sum();
        {
            for (int i = 1; i < s.Length; i++) // i начинается с 1, чтобы не включать знак перед числом;
            {
                if (s[i] == '^')
                {
                    s = MathematicFunctions(s, i);
                    return Pow(s);
                }
            }
            return s;
        }

        private decimal AfterPossition(string s, int possition)
        {
            decimal temp = 0;
            for (int i = 1; i < s.Length - possition; i++) // Обработка симвmолов после знака и запись в темпб;
            {
                if (i == 1 && ((s[i + possition] == '-') || (s[i + possition] == '+')))
                    i++;
                if (char.IsNumber(s[i + possition]) || s[i + possition] == ',') // Сравнение со знаками, чтобы не захватить знак после числа;
                {

                    temp = Convert.ToDecimal(s.Substring(possition + 1, i));
                }
                else
                {
                    break;
                }

            }
            return temp;
        }

        private decimal BeforePossition(string s, int possition)
        {
            decimal temp = 0; // Число после знака;
            int n = 1;
            for (int i = possition - 1; i >= 0; i--) // Обработка символов до знака и запись в темпа;
            {
                if (char.IsNumber(s[i]) || s[i] == ',' || (i == 0 && ((s[i] == '-') || (s[i] == '+')))) // Если число или разделитель , то увеличиваем n;
                {
                    n++;
                    temp = Convert.ToDecimal(s.Substring(i, n - 1));
                }
                else
                {
                    break;
                }
            }
            return temp;
        }

        private string MathematicFunctions(string s, int possition, string trifunction = "") // Вычисление 
        {

            decimal tempa = BeforePossition(s, possition); // Число перед знаком;
            decimal tempb = AfterPossition(s, possition); // Число после знака;

            int startpossition = possition - tempa.ToString().Length; // Начальная позиция для удаления подстроки;
            int count = tempa.ToString().Length + tempb.ToString().Length + 1; // Число символов удаляемых в строке;


            switch (trifunction)
            {
                case "sin":
                    return s.Remove(possition - 2, 3 + tempb.ToString().Length).Insert(possition - 2, Convert.ToDecimal(Math.Sin((double)tempb / 180 * Math.PI)) + "");
                case "cos":
                    return s.Remove(possition - 2, 3 + tempb.ToString().Length).Insert(possition - 2, Convert.ToDecimal(Math.Cos((double)tempb / 180 * Math.PI)) + "");
                case "tg":
                    return s.Remove(possition - 1, 2 + tempb.ToString().Length).Insert(possition - 1, Convert.ToDecimal(Math.Tan((double)tempb / 180 * Math.PI)) + "");
                case "ctg":
                    return s.Remove(possition - 2, 3 + tempb.ToString().Length).Insert(possition - 2, Convert.ToDecimal(1/(Math.Tan((double)tempb / 180 * Math.PI))) + "");

            }

            switch (s[possition]) // Удаление вычисленной подстроки и вставка на ее место числа;
            {
                case '+':
                    return s.Remove(startpossition, count).Insert(startpossition, (tempa + tempb) + "");
                case '-':
                    return s.Remove(startpossition, count).Insert(startpossition, (tempa - tempb) + "");
                case '*':
                    return s.Remove(startpossition, count).Insert(startpossition, (tempa * tempb) + "");
                case '/':
                    return s.Remove(startpossition, count).Insert(startpossition, (tempa / tempb) + "");
                case '^':
                    return s.Remove(startpossition, count).Insert(startpossition, (Convert.ToDecimal(Math.Pow((double)tempa,(double)tempb)) + ""));
                default:
                    return string.Empty;
            }
        }
    }
}
