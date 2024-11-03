using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_One
{
    class TaskEightOne
    {
        public int _int;
        public static TaskEightOne operator++(TaskEightOne obj)
        {
            obj._int = obj._int + 1;
            return obj;
        }
        public static TaskEightOne operator --(TaskEightOne obj)
        {
            obj._int = obj._int - 1;
            return obj;
        }
        public static TaskEightOne operator -(TaskEightOne obj, int i)
        {
            obj._int = obj._int - i;
            return obj;
        }
        public static TaskEightOne operator -(int i, TaskEightOne obj)
        {
            obj._int = obj._int - i;
            return obj;
        }
        public static TaskEightOne operator +(TaskEightOne obj, int i)
        {
            obj._int = obj._int + i;
            return obj;
        }
        public static TaskEightOne operator +(int i, TaskEightOne obj)
        {
            obj._int = obj._int + i;
            return obj;
        }
        public TaskEightOne(int i)
        {
            _int = i;
        }
    }

    class TaskEightTwo
    {
        public int[] _int = new int[] { };
        public TaskEightTwo(int i)
        {
            _int = new int[i];
            for(int j = 0; j < i; j++)
            {
                _int[j] = 0;
            }
        }

        public static string operator~(TaskEightTwo two)
        {
            string txt = "";
            for(int i = 0; i < two._int.Length; i++)
            {
                txt += two._int[i] + " ";
            }
            return txt;
        }
        public static TaskEightTwo operator ++(TaskEightTwo two)
        {
            TaskEightTwo taskEightTwo = new TaskEightTwo(two._int.Length + 1);
            for (int i = 0; i < taskEightTwo._int.Length; i++)
            {
                taskEightTwo._int[i] = 0;
            }
            return taskEightTwo;
        }
        public static TaskEightTwo operator --(TaskEightTwo two)
        {
            TaskEightTwo taskEightTwo = new TaskEightTwo(two._int.Length - 1);
            for (int i = 0; i < taskEightTwo._int.Length; i++)
            {
                taskEightTwo._int[i] = 0;
            }
            return taskEightTwo;
        }
        public static TaskEightTwo operator +(TaskEightTwo two, int i)
        {
            TaskEightTwo taskEightTwo = new TaskEightTwo(two._int.Length + 1);
            for (int j = 0; j < taskEightTwo._int.Length; j++)
            {
                taskEightTwo._int[j] = 0;
            }
            taskEightTwo._int[taskEightTwo._int.Length - 1] = i;
            return taskEightTwo;
        }
        public static TaskEightTwo operator +(int i, TaskEightTwo two)
        {
            TaskEightTwo taskEightTwo = new TaskEightTwo(two._int.Length + 1);
            for (int j = 0; j < taskEightTwo._int.Length; j++)
            {
                taskEightTwo._int[j] = 0;
            }
            taskEightTwo._int[0] = i;
            return taskEightTwo;
        }
        public static TaskEightTwo operator +(TaskEightTwo two, TaskEightTwo two1)
        {
            TaskEightTwo taskEightTwo = new TaskEightTwo(two._int.Length + two1._int.Length);
            for (int j = 0; j < taskEightTwo._int.Length; j++)
            {
                taskEightTwo._int[j] = 0;
            }
            return taskEightTwo;
        }
    }

    class TaskEightThree
    {
        public int _int;
        public int _int2;

        public TaskEightThree(int one, int two)
        {
            _int = one;
            _int2 = two;
        }

        public static bool operator <(TaskEightThree one, TaskEightThree two)
        {
            if(Math.Pow(one._int2, 2) + Math.Pow(one._int2, 2) < Math.Pow(two._int2, 2) + Math.Pow(two._int2, 2))
            {
                return true;
            }
            return false;
        }
        public static bool operator >(TaskEightThree one, TaskEightThree two)
        {
            if (Math.Pow(one._int2, 2) + Math.Pow(one._int2, 2) > Math.Pow(two._int2, 2) + Math.Pow(two._int2, 2))
            {
                return true;
            }
            return false;
        }
    }

    class TaskEightFour
    {
        public int _int;
        public string _string;
        public TaskEightFour(int @int, string @string)
        {
            _int = @int;
            _string = @string;
        }
        public static bool operator >(TaskEightFour one, TaskEightFour two)
        {
            if (one._string.Length > two._string.Length)
            {
                return true;
            }
            else return false;
        }
        public static bool operator <(TaskEightFour one, TaskEightFour two)
        {
            if (one._string.Length < two._string.Length)
            {
                return true;
            }
            else return false;
        }
        public static bool operator >=(TaskEightFour one, TaskEightFour two)
        {
            if (one._int >= two._int)
            {
                return true;
            }
            else return false;
        }
        public static bool operator <=(TaskEightFour one, TaskEightFour two)
        {
            if (one._int <= two._int)
            {
                return true;
            }
            else return false;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(TaskEightFour one, TaskEightFour two)
        {
            if (one._int == two._int && one._string == two._string)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(TaskEightFour one, TaskEightFour two)
        {
            if (one._int != two._int && one._string != two._string)
            {
                return true;
            }
            else return false;
        }

    }

    class TaskEightFive
    {
        public int _int;
        public char _char;
        public TaskEightFive(int @int, char @char)
        {
            _int = @int;
            _char = @char;
        }
        public static bool operator true(TaskEightFive one)
        {
            if (one._int - (int)one._char < 10 || (int)one._char - one._int < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(TaskEightFive one)
        {
            if (one._int - (int)one._char > 10 || (int)one._char - one._int > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class TaskEightSix
    {
        public int _int;
        public TaskEightSix(int @int)
        {
            _int = @int;
        }
        public static TaskEightSix operator| (TaskEightSix one , TaskEightSix two)
        {
            if (one) return one;
            else return two;
        }
        public static TaskEightSix operator &(TaskEightSix one, TaskEightSix two)
        {
            if (one) return two;
            else return one;
        }
        public static bool operator true(TaskEightSix one)
        {
            if (one._int == 2 || one._int == 3 || one._int == 5 || one._int == 7) {
                return true;
            }
            else { return false; }
        }
        public static bool operator false(TaskEightSix one)
        {
           if (one._int < 1 || one._int > 10)
           {
                return false;
           }
           else
           {
                return true;
           }
        }

    }

    class TaskEightSeven
    {
        public string _string;
        public TaskEightSeven(string @string)
        {
            _string = @string;
        }
        public static implicit operator int(TaskEightSeven obj)
        {
            return obj._string.Length;
        }
        public static implicit operator char(TaskEightSeven obj)
        {
            return obj._string[0];
        }
        public static implicit operator TaskEightSeven(int _int)
        {
            TaskEightSeven taskEightSeven = new TaskEightSeven("abwaw");
            string str = "";
            for(int i = 0; i < _int; i++)
            {
                str += (char)taskEightSeven;
            }
            TaskEightSeven taskEightSeven1 = new TaskEightSeven(str);
            return taskEightSeven1;
        }
    }

    class TaskEightEight
    {
        public int[] ints;
        public TaskEightEight(int[] ints)
        {
            this.ints = ints;
        }
        public static implicit operator string(TaskEightEight obj)
        {
            string str = "";
            for(int i = 0; i < obj.ints.Length; i++)
            {
                str += obj.ints[i];
            }
            return str;
        }
        public static implicit operator int(TaskEightEight obj)
        {
            int sum = 0;
            for(int i = 0; i < obj.ints.Length; i++)
            {
                sum += obj.ints[i];
            }
            return sum;
        }
        public static implicit operator TaskEightEight(int obj)
        {
            int[] ints = new int[obj];
            for(int i = 0; i < obj; i++)
            {
                ints[i] = 0;
            }
            TaskEightEight taskEightEight = new TaskEightEight(ints);
            return taskEightEight;
        }
    }

    class TaskEightNine
    {
        public int _int;
        public TaskEightNine(int @int)
        {
            _int = @int;
        }

        public static TaskEightNine operator -(TaskEightNine obj, int i)
        {
            obj._int = obj._int - i;
            return obj;
        }
        public static TaskEightNine operator +(TaskEightNine obj, int i)
        {
            obj._int = obj._int + i;
            return obj;
        }
        public static TaskEightNine operator *(TaskEightNine obj, int i)
        {
            obj._int = obj._int * i;
            return obj;
        }
    }

    class TaskEightTen
    {
        public char _char;
        public int i;
        public string str;
        public TaskEightTen(char @char)
        {
            _char = @char;
        }

        public static TaskEightTen operator -(TaskEightTen obj, char c)
        {
            obj.i = (int)obj._char - (int)c;
            return obj;
        }
        public static TaskEightTen operator +(TaskEightTen obj, char c)
        {
            obj.str = "" + obj._char + c;
            return obj;
        }
    }
    public class TopicEight
    {
        private string _res;
        public TopicEight()
        {
            _res = Interaction.InputBox("Выберите номер задания(1-10)", "Тема 8. Выбор задания");
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
            string txt = "Изначальное значение: 10";
            TaskEightOne taskEightOne = new TaskEightOne(10);
            txt += "\nОператор ++: " + taskEightOne++._int.ToString();
            TaskEightOne taskEightOne1 = new TaskEightOne(10);
            txt += "\nОператор ++: " + taskEightOne1++._int.ToString();
            TaskEightOne taskEightOne2 = new TaskEightOne(10);
            txt += "\nОператор -: " + (taskEightOne2 - 9)._int.ToString();
            TaskEightOne taskEightOne3 = new TaskEightOne(10);
            txt += "\nОператор +: " + (taskEightOne3 + 10)._int.ToString();
            MessageBox.Show(txt, "Тема 8. Задание 1");
        }
        private static void Two()
        {
            string txt = "Длина массива: 10";
            TaskEightTwo taskEightTwo = new TaskEightTwo(10);
            txt += "\nОператор --: ";
            taskEightTwo--;
            for (int i = 0; i < taskEightTwo._int.Length; i++)
            {
                txt += taskEightTwo._int[i].ToString() + " ";
            }
            TaskEightTwo taskEightTwo1 = new TaskEightTwo(10);
            txt += "\nОператор ++: ";
            taskEightTwo1++;
            for (int i = 0; i < taskEightTwo1._int.Length; i++)
            {
                txt += taskEightTwo1._int[i].ToString() + " ";
            }
            TaskEightTwo taskEightTwo2 = new TaskEightTwo(10);
            txt += "\nОператор ~: " + (~taskEightTwo2).ToString();
            TaskEightTwo taskEightTwo3 = new TaskEightTwo(10);
            txt += "\nОператор +: ";
            taskEightTwo3 = taskEightTwo3 + 10;
            for (int i = 0; i < taskEightTwo3._int.Length; i++)
            {
                txt += taskEightTwo3._int[i].ToString() + " ";
            }
            TaskEightTwo taskEightTwo4 = new TaskEightTwo(10);
            taskEightTwo4 = 10 + taskEightTwo4;
            txt += "\nОператор +: ";
            for (int i = 0; i < taskEightTwo4._int.Length; i++)
            {
                txt += taskEightTwo4._int[i].ToString() + " ";
            }
            TaskEightTwo taskEightTwo5 = new TaskEightTwo(10);
            txt += "\nОператор +: ";
            taskEightTwo5 = taskEightTwo5 + taskEightTwo;
            for (int i = 0; i < taskEightTwo5._int.Length; i++)
            {
                txt += taskEightTwo5._int[i].ToString() + " ";
            }
            MessageBox.Show(txt, "Тема 8. Задание 2");
        }
        private static void Three()
        {
            string txt = "";
            TaskEightThree taskEightThree = new TaskEightThree(1, 1);
            TaskEightThree taskEightThree1 = new TaskEightThree(3, 3);
            if(taskEightThree > taskEightThree1)
            {
                txt += "1 объект больше 2";
            }
            if(taskEightThree < taskEightThree1)
            {
                txt += "1 объект меньше 2";
            }
            MessageBox.Show(txt, "Тема 8. Задание 3");

        }
        private static void Four()
        {
            string txt = "";
            TaskEightFour taskEightFour = new TaskEightFour(1, "test1");
            TaskEightFour taskEightFour1 = new TaskEightFour(3, "test");
            if (taskEightFour > taskEightFour1)
            {
                txt += "1 > 2\n";
            }
            if (taskEightFour < taskEightFour1)
            {
                txt += "1 < 2\n";
            }
            if (taskEightFour >= taskEightFour1)
            {
                txt += "1 >= 2\n";
            }
            if (taskEightFour <= taskEightFour1)
            {
                txt += "1 <= 2\n";
            }
            if (taskEightFour == taskEightFour1)
            {
                txt += "1 == 2\n";
            }
            if (taskEightFour != taskEightFour1)
            {
                txt += "1 != 2\n";
            }
            MessageBox.Show(txt, "Тема 8. Задание 4");
        }
        private static void Five()
        {
            TaskEightFive taskEightFive = new TaskEightFive(61, 'A');
            if(taskEightFive)
            {
                MessageBox.Show("Разность меньше 10", "Тема 8. Задание 5");
            }
            else
            {
                MessageBox.Show("Разность больше 10", "Тема 8.Задание 5");
            }
        }
        private static void Six()
        {
            string txt = "";
            TaskEightSix taskEightSix = new TaskEightSix(3);
            if(taskEightSix)
            {
                txt += "true\n";
            }
            taskEightSix = new TaskEightSix(11);
            if(taskEightSix)
            {
                txt += "false\n";
            }
            TaskEightSix taskEightSix1 = new TaskEightSix(0);
            TaskEightSix taskEightSix2 = new TaskEightSix(1);
            txt += "0||1 = " + (taskEightSix1 || taskEightSix2)._int + "\n";
            txt += "0&&1 = " + (taskEightSix1 && taskEightSix2)._int;
            MessageBox.Show(txt, "Тема 8. Задание 6");

        }
        private static void Seven()
        {
            TaskEightSeven taskEightSeven = new TaskEightSeven("abwaw");
            string txt = "Строка = abwaw\n";

            txt += "Количество символов в строке: " + (int)taskEightSeven + "\n";
            txt += "Первый символ в строке:" + (char)taskEightSeven + "\n";
            txt +=  ((TaskEightSeven)10)._string + "\n";
            MessageBox.Show(txt, "Тема 8. Задание 7");
        }
        private static void Eight()
        {
            int[] ints = new int[4] { 1, 4, 2, 1 };
            int i = 5;
            TaskEightEight taskEightEight = new TaskEightEight(ints);
            string txt = "Изначальный массив: ";
            for(int j = 0; j < ints.Length; j++)
            {
                txt += ints[j] + " ";
            }
            txt += "\nПреобразование в строку: " + (string)taskEightEight + "\n";
            txt += "Преобразование в число: " + (int)taskEightEight + "\n";
            TaskEightEight taskEightEight1 = (TaskEightEight)i;
            txt += "Преобразование из числа в объект: ";
            for (int j = 0; j < taskEightEight1.ints.Length; j++)
            {
                txt += taskEightEight1.ints[j] + " ";
            }
            MessageBox.Show(txt, "Тема 8. Задание 8");
        }
        private static void Nine()
        {
            TaskEightNine task = new TaskEightNine(10);
            string txt = "Изначальное число: 10\n";
            task += 1;
            txt += "Сумма числа и объекта: " + task._int + "\n";
            task -= 10;
            txt += "Разность числа и объекта: " + task._int + "\n";
            task *= 100;
            txt += "Произведение числа и объекта: " + task._int + "\n";
            MessageBox.Show(txt, "Тема 8. Задание 9");
        }
        private static void Ten()
        {
            TaskEightTen task = new TaskEightTen('A');
            string txt = "Начальный символ: " + task._char + "\n";
            task += 'B';
            txt += "Сумма двух символов: " + task.str + "\n";
            task = new TaskEightTen('A');
            task -= 'B';
            txt += "Разность двух символов: " + task.i + "\n";
            MessageBox.Show(txt, "Тема 8. Задание 10");
        }
    }
}
