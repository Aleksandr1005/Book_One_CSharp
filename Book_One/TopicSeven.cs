using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_One
{
    class TaskSevenOne
    {
        public static string Add(string str)
        {
            string one = "";
            for (int i = 0; i < str.Length; i++)
            {
                one += str[i] + " ";
            }
            return one;
        }
    }

    class TaskSevenTwo
    {
        public static string Split(string str)
        {
            string _str = str;
            str += " ";
            for (int i = 0; i < _str.Length; i++)
            {
                str += _str[_str.Length - 1 - i];
            }
            return str;
        }
    }

    class TaskSevenThree
    {
        public static bool srav(string one, string two)
        {
            char[] ch = one.ToCharArray();
            char[] ch2 = two.ToCharArray();

            if (one.Length == two.Length)
            {
                for (int i = 0; i < one.Length; i++)
                {
                    if ((int)ch[i] == (int)ch2[i] || (int)ch[i] - (int)ch2[i] == 1 || (int)ch[i] - (int)ch2[i] == -1)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }

    class TaskSevenFour
    {
        public static bool srav(string one, string two)
        {
            char[] ch = one.ToCharArray();
            char[] ch2 = two.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = 0; j < ch.Length; j++)
                {
                    if (ch[i] > ch[j])
                    {
                        char c = ch[j];
                        ch[j] = ch[i];
                        ch[i] = c;
                    }
                }
            }

            for (int i = 0; i < ch2.Length; i++)
            {
                for (int j = 0; j < ch2.Length; j++)
                {
                    if (ch2[i] > ch2[j])
                    {
                        char c = ch2[j];
                        ch2[j] = ch2[i];
                        ch2[i] = c;
                    }
                }
            }

            if (one.Length == two.Length)
            {
                for (int i = 0; i < one.Length; i++)
                {
                    if ((int)ch[i] == (int)ch2[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }

    class TaskSevenFive
    {
        public static int[] seach(string str, char ch)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    count++;
                }
            }
            int[] ints;
            if (count > 0)
            {
                ints = new int[count];
                count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ch)
                    {
                        ints[count] = i;
                        count++;
                    }
                }
            }
            else
            {
                ints = new int[1];
                ints[0] = -1;
            }
            return ints;
        }
    }

    class TaskSevenSix
    {
        public static char[] chars(string str)
        {
            char[] ch = str.ToLower().Replace(" ", "").Distinct().ToArray();
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = 0; j < ch.Length; j++)
                {
                    if (ch[i] < ch[j])
                    {
                        char c = ch[j];
                        ch[j] = ch[i];
                        ch[i] = c;
                    }
                }
            }
            return ch;
        }
    }

    class TaskSevenSeven
    {
        public static string subString(string str, int start, int number)
        {
            string s = "";
            for (int i = 0; i < number; i++)
            {
                s += str[start];
                start++;
            }
            return s;
        }
    }

    class TaskSevenEight
    {
        private static string _str = "";

        public TaskSevenEight(string str)
        {
            _str = str;
        }

        public static string insert(string str, int position)
        {
            _str = _str.Insert(position, str);
            String str1 = _str.ToString();
            return str1;
        }
    }

    class TaskSevenNine
    {
        static string _str;
        static int _int;

        public TaskSevenNine(string str, int i)
        {
            _str = str;
            _int = i;
        }

        public static string[] split()
        {
            string[] strs = new string[_str.Length / _int + 1];
            int count = 1;
            int _count = 0;
            String str = _str.ToString();
            for (int i = 0; i < _str.Length; i++)
            {
                strs[_count] += str[i];
                if (count == _int)
                {
                    count = 0;
                    _count++;
                }
                count++;
            }

            return strs;
        }
    }

    class TaskSevenTen
    {
        static int[] ints = new int[10];

        public TaskSevenTen()
        {
            Random rnd = new Random();
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(0, 10);
            }
        }
        public static string strWithInt()
        {
            string str = "Цифровой массив: ";
            for (int i = 0; i < ints.Length; i++)
            {
                str += ints[i] + " ";
            }
            str += "\nКоличество элементов: " + ints.Length;
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            str += "\nСреднее значение: " + (float)sum / (float)ints.Length;
            return str;
        }
    }
    public class TopicSeven
    {
        private string _res;
        public TopicSeven()
        {
            _res = Interaction.InputBox("Выберите номер задания(1-10)", "Тема 7. Выбор задания");
            switch (_res)
            {
                case "1":
                    One();
                    break;
                case "2":
                    Two();
                    break;
                case "3":
                    Three();
                    break;
                case "4":
                    Four();
                    break;
                case "5":
                    Five();
                    break;
                case "6":
                    Six();
                    break;
                case "7":
                    Seven();
                    break;
                case "8":
                    Eight();
                    break;
                case "9":
                    Nine();
                    break;
                case "10":
                    Ten();
                    break;
                default:
                    MessageBox.Show("Введен неверный номер задания", "Ошибка");
                    break;
            }
        }
        private static void One()
        {
            string txt = TaskSevenOne.Add("Hello");
            MessageBox.Show(txt, "Задание 1");
        }
        private static void Two()
        {
            string txt2;
            string txt = "Изначальная строка: ";
            txt2 = TaskSevenTwo.Split("Hello");
            for (int i = 0; i < txt2.Length / 2; i++)
            {
                txt += txt2[i];
            }
            txt += "\nИзмененная строка: ";
            for (int i = txt2.Length / 2; i < txt2.Length; i++)
            {
                txt += txt2[i];
            }
            MessageBox.Show(txt, "Задание 2");
        }
        private static void Three()
        {
            bool three = TaskSevenThree.srav("Тесто", "Теста");
            if (three)
            {
                MessageBox.Show("Строки равны", "Задание 3");
            }
            else
            {
                MessageBox.Show("Строки не равны", "Задание 3");
            }
        }
        private static void Four()
        {
            bool four = TaskSevenFour.srav("Тесто", "отсеG");
            MessageBox.Show(four ? "Строки равны" : "Строки не равны", "Задание 4");
        }
        private static void Five()
        {
            int[] ints = TaskSevenFive.seach("СтрокаСтрока", 'а');
            if (ints[0] == -1)
            {
                MessageBox.Show("Символов нет", "Задание 5");
            }
            else
            {
                string txt = "";
                for (int i = 0; i < ints.Length; i++)
                {
                    txt += ints[i] + " ";
                }
                MessageBox.Show("Найдены позиции символа: " + txt, "Задание 5");
            }
        }
        private static void Six()
        {
            char[] ch = TaskSevenSix.chars("Данное слово");
            string txt = "";
            for (int i = 0; i < ch.Length; i++)
            {
                txt += ch[i] + " ";
            }
            MessageBox.Show("Символы в строке: " + txt, "Задание 6");
        }
        private static void Seven()
        {
            string txt = TaskSevenSeven.subString("СТрокаСтрока", 2, 3);
            MessageBox.Show("Новая строка: " + txt, "Задание 7");
        }
        private static void Eight()
        {
            TaskSevenEight taskEight = new TaskSevenEight("Тестовая строка");
            string str = TaskSevenEight.insert("не ", 9);
            MessageBox.Show("Новая строка: " + str, "Задание 8");
        }
        private static void Nine()
        {
            TaskSevenNine taskNine = new TaskSevenNine("Тестовая строка", 3);
            string[] str = TaskSevenNine.split();
            string txt = "";
            for (int i = 0; i < str.Length; i++)
            {
                txt += str[i] + " ";
            }
            MessageBox.Show("Новый массив: " + txt, "Задание 9");
        }
        private static void Ten()
        {
            TaskSevenTen taskTen = new TaskSevenTen();
            string txt = TaskSevenTen.strWithInt();
            MessageBox.Show(txt, "Задание 10");
        }
    }
}
