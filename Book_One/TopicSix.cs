using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_One
{
    class TaskSixOne
    {
        private char _char;
        private string txt = "";
        public char pole(char symb)
        {
            _char = symb;
            return _char;
        }
        public int code(char symb)
        {
            return symb;
        }
        public string code_pole(char symb)
        {
            _char = symb;
            txt += _char + " " + (int)symb;
            return txt;
        }
    }

    class TaskSixTwo
    {
        public TaskSixTwo(char start, char two)
        {
            string txt = "Последовательность: ";
            for (char i = start; i <= two; i++)
            {
                txt += i + " ";
            }
            MessageBox.Show(txt, "Задание 2");
        }
    }

    class TaskSixThree
    {
        public string txt = "";

        public TaskSixThree()
        {
            txt += "Аргументов нет";
            MessageBox.Show(txt, "Задание 3");
        }

        public TaskSixThree(int one)
        {
            txt += "Аргумент: " + one;
            MessageBox.Show(txt, "Задание 3");
        }

        public TaskSixThree(int one, int two)
        {
            txt += "Аргументы: " + one + " " + two;
            MessageBox.Show(txt, "Задание 3");
        }
    }

    class TaskSixFour
    {
        public char _char;
        public int _int;
        public string _txt;
        public TaskSixFour(char c, int i)
        {
            _txt += "Символ: " + c + "\nЧисло: " + i;
            MessageBox.Show(_txt, "Задание 4");
        }
        public TaskSixFour(double d)
        {
            string txt = " " + (d - (int)d);
            _txt += "Изначальное число: " + d + "\nСимвольная часть: " + (int)d + "\nЧисловая часть: " + txt[3] + txt[4];
            MessageBox.Show(_txt, "Задание 4");
        }
    }

    class TaskSixFive
    {
        private int _int;
        public string txt = "";
        public TaskSixFive(int i)
        {
            if (TaskSixFive.Сompar(i))
            {
                _int = i;
            }
            else
            {
                _int = 100;
            }
            txt += "Конструктор:" + "\nЧисло: " + _int;
            MessageBox.Show(txt, "Задание 5");
        }
        public void Quare(int i)
        {
            if (TaskSixFive.Сompar(i))
            {
                _int = i;
            }
            else
            {
                _int = 100;
            }
            txt = "";
            txt += "С аргументом: " + "\nЧисло: " + _int;
            MessageBox.Show(txt, "Задание 5");
        }

        public void Quare()
        {
            _int = 0;
            txt = "";
            txt += "Без аргументов: " + "\nЧисло: " + _int;
            MessageBox.Show(txt, "Задание 5");
        }
        static bool Сompar(int i)
        {
            if (i > 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class TaskSixSix
    {
        private int _max;
        private int _min;

        public TaskSixSix(int max, int min)
        {
            if (max > min)
            {
                _max = max;
                _min = min;
            }
            else
            {
                _max = min;
                _min = max;
            }
            write(_max, _min);
        }

        public void Quare(int max, int min)
        {
            if (max > min)
            {
                _max = max;
                _min = min;
            }
            else
            {
                _max = min;
                _min = max;
            }
            write(_max, _min);
        }
        public void Quare(int i)
        {
            MessageBox.Show("Значение поля: " + i, "Задание 6");
        }
        static void write(int max, int min)
        {
            string txt = "";
            txt += "Максимальное: " + max + "\nМинимальное: " + min;
            MessageBox.Show(txt, "Задание 6");
        }
    }

    class TaskSixSeven
    {
        private int _int;
        private string _string;
        public void Quare(char c)
        {
            MessageBox.Show("Символ: " + c, "Задание 7");
        }
        public void Quare(string s)
        {
            MessageBox.Show("Строка: " + s, "Задание 7");
        }
        public void Quare(char[] c)
        {
            if (c.Length == 1)
            {
                MessageBox.Show("В массиве 1 символ: " + c[0], "Задание 7");
            }
            else
            {
                string txt = "";
                for (int i = 0; i < c.Length; i++)
                {
                    txt += c[i];
                }
                MessageBox.Show("Строка из символов: " + txt, "Задание 7");
            }
        }
    }

    class TaskSixEight
    {
        private static int _int = 0;
        public static void Show()
        {
            MessageBox.Show("Значение поля: " + _int, "Задание 8");
            _int += 1;
            MessageBox.Show("Новое значние поля: " + _int, "Задание 8");
        }
    }

    class TaskSixNine
    {
        public static int Max(params int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }

        public static int Min(params int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }

        public static int Sred(params int[] a)
        {
            int sr = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sr += a[i];
            }
            sr = sr / a.Length;
            return sr;
        }
    }

    class TaskSixTen
    {
        private int n = 100;

        public static float cos(int x)
        {
            float sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += (float)Math.Pow(-1, i) * (float)Math.Pow(x, 2 * i) / fact(2 * i);
            }
            sum = 1 - sum;
            return sum;
        }

        public static float sh(int x)
        {
            float sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += (float)Math.Pow(x, 2 * i + 1) / fact(2 * i + 1);
            }
            return sum;
        }

        public static float ch(int x)
        {
            float sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += (float)Math.Pow(x, 2 * i) / fact(2 * i);
            }
            sum += 1;
            return sum;
        }
        static float fact(int a)
        {
            int sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            return (float)sum;
        }
    }

    public class TopicSix
    {
        private string _res;
        public TopicSix()
        {
            _res = Interaction.InputBox("Выберите номер задания(1-10)", "Тема 6. Выбор задания");
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
            TaskSixOne task = new TaskSixOne();
            char pole = task.pole('A');
            int code = task.code('A');
            string code_pole = task.code_pole('A');
            string txt = "Метод pole: " + pole + "\nМетод code: " + code + "\nМетод code_pole: " + code_pole;
            MessageBox.Show(txt, "Задание 1");
        }
        private static void Two()
        {
            TaskSixTwo taskTwo = new TaskSixTwo('C', 'F');
        }
        private static void Three()
        {
            TaskSixOne taskThree = new TaskSixOne();
            TaskSixThree taskThree1 = new TaskSixThree(8);
            TaskSixThree taskThree2 = new TaskSixThree(9, 19);
        }
        private static void Four()
        {
            TaskSixFour taskFour = new TaskSixFour('A', 10);
            TaskSixFour taskFour1 = new TaskSixFour(65.4531);
        }
        private static void Five()
        {
            TaskSixFive taskFive = new TaskSixFive(10);
            taskFive.Quare();
            taskFive.Quare(500);
        }
        private static void Six()
        {
            TaskSixSix taskSix = new TaskSixSix(15, 25);
            taskSix.Quare(7);
            taskSix.Quare(90, 8);
        }
        private static void Seven()
        {
            char[] c = new char[5] { 'h', 'e', 'l', 'l', 'o' };
            char[] c1 = new char[1] { 'v' };
            TaskSixSeven taskSeven = new TaskSixSeven();
            taskSeven.Quare('c');
            taskSeven.Quare("Hello world!");
            taskSeven.Quare(c);
            taskSeven.Quare(c1);
        }
        private static void Eight()
        {
            TaskSixEight.Show();
        }
        private static void Nine()
        {
            int[] mas = new int[6] { 1, 2, 3, 4, 5, 1 };
            int max = TaskSixNine.Max(1, 2, 3, 4, 10, 2, 3);
            int min = TaskSixNine.Min(1, 2, 3, 4, 10, 0, 3);
            int sr = TaskSixNine.Sred(1, 2, 3, 4, 10, 2, 3);
            string txt = "Максимальное значение(набор чисел): " + max;
            txt += "\nМинимальное значение(набор чисел): " + min;
            txt += "\nСреднее значение(набор чисел): " + sr;
            max = TaskSixNine.Max(mas);
            min = TaskSixNine.Min(mas);
            sr = TaskSixNine.Sred(mas);
            txt += "\nМаксимальное значение(массив): " + max;
            txt += "\nМинимальное значение(массив): " + min;
            txt += "\nСреднее значение(массив): " + sr;
            MessageBox.Show(txt, "Задание 9");
        }
        private static void Ten()
        {
            string txt = "";
            float cos = TaskSixTen.cos(60);
            float sh = TaskSixTen.sh(60);
            float ch = TaskSixTen.ch(60);
            txt += "Косинус: " + cos;
            txt += "\nГиперболический синус: " + sh;
            txt += "\nГиперболический косинус: " + ch;
            MessageBox.Show(txt, "Задание 10");
        }
    }
}
