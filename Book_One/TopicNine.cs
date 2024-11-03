using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_One
{
    class TopicNineOne
    {
        private char _char;
        public TopicNineOne (char c)
        {
            _char = c;
        }
        public char range
        {
            get { return _char; }
            set
            {
                if (value >= 'A' && value <= 'Z') { _char=value; }
            }
        }
    }

    class TopicNineTwo
    {
        private int _int;
        private int[] ints;
        private string str = "";
        public TopicNineTwo(int @int, int[] ints)
        {
            _int = @int;
            this.ints = ints;
        }

        public string replace
        {
            get
            {
                str = "";
                for(int i = 0; i < ints.Length; i++)
                {
                    str += ints[i];
                }
                return str;
            }
            set
            {
                ints[_int] = int.Parse(value);
            }
        }

    }
    class TopicNineThree
    {
        private int[] ints;
        private int summa = 0;
        public TopicNineThree(int[] ints)
        {
            this.ints = ints;
        }

        public string sum
        {
            get
            {
                for(int i = 0; i < ints.Length; i++)
                {
                    summa += ints[i];
                }
                return summa.ToString();
            }
        }
    }
    class TopicNineFour
    {
        private int _int;
        private string _str;
        public int write
        {
            set
            {
                _int = value;
                _str = Convert.ToString(value, 8);
            }
        }
        public string read
        {
            get
            {
                return _str;
            }
        }
    }
    class TopicNineFive
    {
        private static int _int = -1;
        public int query
        {
            get
            {
                _int += 2;
                return _int;
            }
        }
        public int step
        {
            set
            {
                _int = -1;
                _int += (value - 1) * 2;
            }
        }
    }
    class TopicNineSix
    {
        private int[] ints;
        public TopicNineSix(int @int)
        {
            ints = new int[@int];
            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = i;
            }
        }
        public int this[int index]
        {
            set
            {
                ints[index] = value;
            }
            get
            {
                return ints[index];
            }
        }
        public string str()
        {
            string txt = "";
            for (int i = 0; i < ints.Length; i++)
            {
                txt += ints[i];
            }
            return txt;
        }
    }
    class TopicNineSeven
    {
        private int _int;
        private string str;
        private char[] chars;
        public TopicNineSeven(int @int)
        {
            _int = @int;
            str = Convert.ToString(_int, 2);
            chars = new char[str.Length];
            chars = str.ToCharArray();
        }

        public char this[int index]
        {
            get
            {
                return chars[index];
            }
        }
    }
    class TopicNineEight
    {
        private int _int;
        private int[] ints;
        private int count = 0;
        public TopicNineEight(int @int)
        {
            _int = @int;
        }
        public int this[int index]
        {
            set
            {
                int a = _int;
                while(_int > 0)
                {
                    _int /= 10;
                    count++;
                }
                _int = a;
                ints = new int[count];
                for(int i = 0; i < count; i++)
                {
                    ints[i] = _int % 10;
                    _int /= 10;
                }
                ints[index] = value;
                for(int i = 0; i < count; i++)
                {
                    _int += ints[i] * (int)Math.Pow(10, i);
                }
            }
        }
        public int a()
        {
            return _int;
        }
    }
    class TopicNineNine
    {
        private int[,] _ints;
        private static int max;
        public TopicNineNine(int[,] @ints)
        {
            _ints = @ints;
        }
        public int this[int a, int b]
        {
            set
            {
                _ints[a,b] = value;
            }
        }
        public int this[int index]
        {
            get
            {
                max = _ints[index, 0];
                for(int i = 0; i < _ints.GetLength(1); i++)
                {
                    if(_ints[index,i] > max)
                    {
                        max = _ints[index,i];
                    }
                }
                return max;
            }
        }
    }
    class TopicNineTen
    {
        private string[] _str;
        public TopicNineTen(string[] @str)
        {
            _str = @str;
        }

        public string this[int index]
        {
            set
            {
                _str[index] = value;
            }
        }
        public string this[int a, int b]
        {
            set
            {
                char[] ch = _str[a].ToCharArray();
                while(b >  ch.Length)
                {
                    b = b - ch.Length;
                }
                ch[b] = Convert.ToChar(value);
                _str[a] = "";
                for(int i = 0; i < ch.Length; i++)
                {
                    _str[a] += ch[i];
                }
            }
        }
    }
    public class TopicNine
    {
        private string _res;
        public TopicNine()
        {
            _res = Interaction.InputBox("Выберите номер задания(1-10)", "Тема 9. Выбор задания");
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
            TopicNineOne one = new TopicNineOne('B');
            one.range = 'B';
            MessageBox.Show("Символ входит в диопозон от A до Z\nСимвол: " + one.range, "Задание 1");
            one.range = 'k';
            MessageBox.Show("Символ не входит в диопозон от A до Z\nПрошлый символ: " + one.range, "Задание 1");
        }
        private static void Two()
        {
            int[] ints = new int[6] { 1, 2, 3, 4, 5, 6 };
            TopicNineTwo two = new TopicNineTwo(3, ints);
            MessageBox.Show("Массив чисел: " + two.replace, "Задание 2");
            two.replace = "0";
            MessageBox.Show("Новый массив чисел: " + two.replace, "Задание 2");
        }
        private static void Three()
        {
            int[] ints = new int[5] { 1, 2, 3, 4, 5};
            TopicNineThree three = new TopicNineThree(ints);
            MessageBox.Show("Сумма чисел: " + three.sum, "Задание 3");
        }
        private static void Four()
        {
            TopicNineFour four = new TopicNineFour();
            four.write = 10;
            MessageBox.Show("Число в 8 системе: " + four.read, "Задание 4");
        }
        private static void Five()
        {
            TopicNineFive five = new TopicNineFive();
            string str = "Первое число: " + five.query + "\n";
            str += "Второе число: " + five.query + "\n";
            five.step = 5;
            str += "Третье число: " + five.query + "\n";
            str += "Четвертое число: " + five.query + "\n";
            MessageBox.Show(str, "Задание 5");
        }
        private static void Six()
        {
            TopicNineSix six = new TopicNineSix(5);
            string str = "Массив: " + six.str() + "\n";
            six[2] = 9;
            str += "Массив: " + six.str() + "\n";
            str += "Один из элементов: " + six[2] + "\n";
            MessageBox.Show(str, "Задание 6");
        }
        private static void Seven()
        {
            TopicNineSeven seven = new TopicNineSeven(120);
            MessageBox.Show("Число: 120\n2 бит числа: " + seven[1], "Задание 7");
        }
        private static void Eight()
        {
            int _int = 12345;
            TopicNineEight eight = new TopicNineEight(_int);
            eight[2] = _int % 10;
            string str = "Изначальное число: " + _int + "\n";
            str += "Новое число: " + eight.a();
            MessageBox.Show(str, "Задание 8");
        }
        private static void Nine()
        {
            int[,] ints = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 1 }, { 3, 3, 2 } };
            TopicNineNine nine = new TopicNineNine(ints);
            string str = "Изначальный массив:\n";
            for(int i = 0; i < ints.GetLength(0); i++)
            {
                for(int j = 0; j < ints.GetLength(1); j++)
                {
                    str += ints[i, j] + " ";
                }
                str += "\n";
            }
            str += "Поменяли символ [1,1] на 7:\n";
            nine[1, 1] = 7;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    str += ints[i, j] + " ";
                }
                str += "\n";
            }
            str += "Нашли максимальный элемент в 3:\n" + nine[2];
            MessageBox.Show(str, "Задание 9");
        }
        private static void Ten()
        {
            string[] str = { "Привет", "мой", "мир" };
            TopicNineTen ten = new TopicNineTen(str);
            string str2 = "Изначальная массив слов: ";
            for(int i = 0; i < str.Length; i++)
            {
                str2 += str[i] + " ";
            }
            str2 += "\nЗаменили последение слово:\n";
            ten[2] = "мир!";
            for (int i = 0; i < str.Length; i++)
            {
                str2 += str[i] + " ";
            }
            ten[2, 0] = "M";
            str2 += "\nЗаменили символ в 3 слова:\n";
            for (int i = 0; i < str.Length; i++)
            {
                str2 += str[i] + " ";
            }
            MessageBox.Show(str2, "Задание 10");
        }
    }
}
