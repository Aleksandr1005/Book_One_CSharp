using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_One
{
    public class TopicFive
    {
        static int dobleFact(int input)
        {
            int fact = 1;
            while (input >= 1)
            {
                fact *= input;
                input = input - 2;
            }
            return fact;
        }

        static int SumSqr(int input)
        {
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum += (int)Math.Pow(i, 2);
            }
            return sum;
        }

        static string newMas(int[] input, int input2)
        {
            int[] mas = new int[input2];
            string txt = "";
            for (int i = 0; i < input2; i++)
            {
                mas[i] = input[i];
                txt += input[i] + " ";
            }
            return txt;
        }

        static int[] codeSybs(char[] input)
        {
            int[] mas = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                mas[i] = (int)input[i];
            }
            return mas;
        }

        static int srNumMas(int[] input)
        {
            int sr = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sr += input[i];
            }
            sr /= input.Length;
            return sr;
        }

        static int maxElement(int[,] input, out int N, out int M)
        {
            N = input.GetLength(0);
            M = input.GetLength(1);
            int max = input[0, 0];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (max < input[i, j])
                    {
                        max = input[i, j];
                    }
                }
            }
            return max;
        }

        static char[] reverseChars(char[] input)
        {

            Array.Reverse(input);
            return input;
        }

        static int[] addMas(int s, int e)
        {
            int[] a = new int[e - s + 1];
            for (int i = 0; i < a.Length; i++)
            {
                if (s <= e)
                {
                    a[i] = s;
                    s++;
                }
            }
            return a;
        }

        static char[] addMas(char s, char e)
        {
            char[] a = new char[21];
            for (int i = 0; i < a.Length; i++)
            {
                if (s <= e)
                {
                    a[i] = s;
                    s++;
                }
            }
            return a;
        }

        static int max(params int[] input)
        {
            int maxEl = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > maxEl)
                {
                    maxEl = input[i];
                }
            }
            return maxEl;
        }

        static string newString(string input, params char[] input1)
        {
            foreach (char c in input1)
            {
                input += c;
            }
            return input;
        }
        private string _res;
        public TopicFive()
        {
            _res = Interaction.InputBox("Выберите номер задания(1-10)", "Тема 5. Выбор задания");
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
            int input = dobleFact(Int32.Parse(Interaction.InputBox("Введите число для 2 факториала", "Задание 1")));
            string txt = "Результат " + input;
            MessageBox.Show(txt, "Задание 1");
        }
        private static void Two()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 2"));
            int res = SumSqr(input);
            if (res == input * (input + 1) * (2 * input + 1) / 6)
            {
                string txt = "Результат " + res;
                MessageBox.Show(txt, "Задание 2");
            }
        }
        private static void Three()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 3"));
            int[] mas = new int[input * 2];
            for (int i = 0; i < input * 2; i++)
            {
                mas[i] = i;
            }
            string res = newMas(mas, input);
            string txt = "Результат: " + res;
            MessageBox.Show(txt, "Задание 3");
        }
        private static void Four()
        {
            char[] chars = { 'A', 'c', 'F', 'e', 'K' };
            int[] res = codeSybs(chars);
            string txt = "Результат: ";
            foreach (int i in res)
            {
                txt += i + " ";
            }
            MessageBox.Show(txt, "Задание 4");
        }
        private static void Five()
        {
            Random rnd = new Random();
            int[] mas = new int[10];
            string txt = "Массив: ";
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 100);
                txt += mas[i] + " ";
            }
            int res = srNumMas(mas);
            txt += "\nРезультат: " + res;
            MessageBox.Show(txt, "Задание 5");
        }
        private static void Six()
        {
            int N, M;
            int[,] mas = new int[5, 5];
            string txt = "";
            Random rnd = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                    txt += mas[i, j] + " ";
                }
                txt += "\n";
            }
            int res = maxElement(mas, out N, out M);
            txt += "Максимальное значение: " + res;
            MessageBox.Show(txt, "Задание 6");
        }
        private static void Seven()
        {
            char[] chars = new char[6] { 'a', 'b', 'c', 'd', 'f', 'g' };
            char[] res = reverseChars(chars);
            string txt = "Новый массив: ";
            for (int i = 0; i < chars.Length; i++)
            {
                txt += res[i] + " ";
            }
            MessageBox.Show(txt, "Задание 7");
        }
        private static void Eight()
        {
            int start = 4, end = 10;
            char start_c = 'f', end_c = 'z';
            int[] res = addMas(start, end);
            char[] res_1 = addMas(start_c, end_c);
            string txt = "Числовой массив: ";
            foreach (int i in res)
            {
                txt += i + " ";
            }
            txt += "\nСимвольный массив: ";
            foreach (char i in res_1)
            {
                txt += i + " ";
            }
            MessageBox.Show(txt, "Задание 8");
        }
        private static void Nine()
        {
            int res = max(1, 5, 6, 7, 4, 2, 2, 8, 4, 4, 10, 21, 2, 3, 4);
            string txt = "Максимальный элемент: " + res;
            MessageBox.Show(txt, "Задание 9");
        }
        private static void Ten()
        {
            string input = "Hello ";
            string res = newString(input, 'w', 'o', 'r', 'l', 'd', '!');
            string txt = "Новый текст: " + res;
            MessageBox.Show(txt, "Задание 10");
        }
    }
}
