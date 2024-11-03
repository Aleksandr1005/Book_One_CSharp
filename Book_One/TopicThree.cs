using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_One
{
    public class TopicThree
    {
        private string _res;
        public TopicThree()
        {
            _res = Interaction.InputBox("Выберите номер задания(1-10)", "Тема 3. Выбор задания");
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
            try
            {
                int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 1"));
                string txt = "Число " + (input % 3 == 0 && input % 7 == 0 ? "делится" : "не делится") + " на 3 и 7";
                MessageBox.Show(txt, "Задание 1");
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!", "Ошибка");
            }
        } 
        private static void Two()
        {
            try
            {
                string[] input = (Interaction.InputBox("Введите 2 числа", "Задание 2")).Split();
                string txt = "";
                if (Int32.Parse(input[0]) > Int32.Parse(input[1]))
                {
                    txt += "Число" + input[0] + " больше";
                }
                else if (Int32.Parse(input[0]) < Int32.Parse(input[1]))
                {
                    txt += "Число" + input[1] + " больше";
                }
                else
                {
                    txt += "Число" + input + " равно " + input[1];
                }
                MessageBox.Show(txt, "Задание 2");
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!", "Ошибка");
            }
        }
        private static void Three()
        {
            try
            {
                int input, sum = 0;
                do
                {
                    input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 3"));
                    sum += input;
                } while (input != 0);
                string txt = "Сумма чисел: " + sum;
                MessageBox.Show(txt, "Задание 3");
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!", "Ошибка");
            }
        }
        private static void Four()
        {
            try
            {
                int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 4"));
                string txt;
                switch (input)
                {
                    case 1:
                        txt = "Понедельник";
                        break;
                    case 2:
                        txt = "Вторник";
                        break;
                    case 3:
                        txt = "Среда";
                        break;
                    case 4:
                        txt = "Четверг";
                        break;
                    case 5:
                        txt = "Пятница";
                        break;
                    case 6:
                        txt = "Суббота";
                        break;
                    case 7:
                        txt = "Воскресенье";
                        break;
                    default:
                        txt = "Вы вышли за диапозон";
                        break;
                }
                MessageBox.Show(txt, "Задание 4");
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!", "Ошибка");
            }
        }
        private static void Five()
        {
            string input_s = Interaction.InputBox("Введите число", "Задание 5");
            switch (input_s)
            {
                case "Понедельник":
                    MessageBox.Show("1 день", "Задание 5");
                    break;
                case "Вторник":
                    MessageBox.Show("2 день", "Задание 5");
                    break;
                case "Среда":
                    MessageBox.Show("3 день", "Задание 5");
                    break;
                case "Четверг":
                    MessageBox.Show("4 день", "Задание 5");
                    break;
                case "Пятница":
                    MessageBox.Show("5 день", "Задание 5");
                    break;
                case "Суббота":
                    MessageBox.Show("6 день", "Задание 5");
                    break;
                case "Воскресенье":
                    MessageBox.Show("7 день", "Задание 5");
                    break;
                default:
                    MessageBox.Show("Такого дня нет", "Задание 5");
                    break;
            }
        }
        private static void Six()
        {
            try
            {
                int input = Int32.Parse(Interaction.InputBox("Введите n", "Задание 6"));
                int sum = 0;
                for (int i = 1; i <= input; i++)
                {
                    sum += i * 2;
                }
                if (sum == input * (input + 1))
                {
                    MessageBox.Show("Сумма четных чисел " + sum, "Задание 6");

                }
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!", "Ошибка");
            }
        }
        private static void Seven()
        {
            try
                {
                int input = Int32.Parse(Interaction.InputBox("Введите n", "Задание 7"));
                int sum = 0;
                for (int i = 1; i <= input; i++)
                {
                    sum += i ^ 2;
                }
                if (sum == input * (input + 1) * (2 * input + 1) / 6)
                {
                    MessageBox.Show("Сумма квадратов чисел " + sum, "Задание 7");

                }
            }
                catch
            {
                MessageBox.Show("Вы ввели не число!", "Ошибка");
            }
        }
        private static void Eight()
        {
            try
            {
                int input = Int32.Parse(Interaction.InputBox("Введите количество чисел фибоначи", "Задание 8"));
                int first = 1;
                int second = 1;
                string txt = "1 1 ";
                for (int i = 1; i < input - 1; i++)
                {
                    txt += first + second + " ";
                    int s = first + second;
                    first = second;
                    second = s;
                }
                MessageBox.Show(txt, "Задание 8");
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!", "Ошибка");
            }
        }
        private static void Nine()
        {
            try
            {
                int input = Int32.Parse(Interaction.InputBox("Введите 1 число", "Задание 9"));
                int input1 = Int32.Parse(Interaction.InputBox("Введите 2 число", "Задание 9"));
                string txt = "";
                for (int i = input; i <= input1; i++)
                {
                    txt += i + " ";
                }
                MessageBox.Show(txt, "Задание 9");
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!", "Ошибка");
            }
        }
        private static void Ten()
        {
            try
            {

                int input = Int32.Parse(Interaction.InputBox("Введите количество чисел", "Задание 19"));
                int sum = 0;
                string txt = "Числа: ";
                for (int i = 0; i < input; i++)
                {
                    int input_ch = Int32.Parse(Interaction.InputBox("Введите " + (i + 1) + " число из " + input, "Задание 10"));
                    if (input_ch % 5 == 2 || input_ch % 3 == 1)
                    {
                        sum += input_ch;
                        txt += input_ch + " ";
                    }
                }
                txt += "\nСумма чисел: " + sum;
                MessageBox.Show(txt, "Задание 10");
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!", "Ошибка");
            }
        }
    }
}
