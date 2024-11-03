using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_One
{
    public class TopicFour
    {
        private string _res;
        public TopicFour()
        {
            _res = Interaction.InputBox("Выберите номер задания(1-10)", "Тема 4. Выбор задания");
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
                int input = Int32.Parse(Interaction.InputBox("Введите размер массива", "Задание 1"));
                int[] mas = new int[input];
                int flag = 0;
                int check = 0;
                while (flag < mas.Length)
                {
                    check++;
                    if (check % 5 == 2)
                    {
                        mas[flag] = check;
                        flag = flag + 1;
                    }
                }
                string txt = "";
                foreach (int i in mas)
                {
                    txt = txt + i + " ";
                }
                MessageBox.Show(txt, "Задание 1");
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!", "Ошибка");
            }
        }
        private static void Two()
        {
            int[] masiv = new int[11];
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = (int)Math.Pow(2, i);
            }
            string txt1 = "";
            foreach (int i in masiv)
            {
                txt1 = txt1 + i + " ";
            }
            MessageBox.Show(txt1, "Задание 2");
        }
        private static void Three()
        {
            char[] chars = new char[10];
            char one = 'a';
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = one;
                one = (char)(one + 2);
            }
            string txt = "";
            foreach (char i in chars)
            {
                txt = txt + i + " ";
            }
            MessageBox.Show(txt, "Задание 3");

        }
        private static void Four()
        {
            char[] chars1 = new char[19];
            char[] sybs = { 'A', 'E', 'Y', 'U', 'O', 'I', 'J' };
            char one = 'A';
            bool flag1 = false;
            int k = 0;
            for (int i = 0; i < chars1.Length; i++)
            {
                one = (char)(one + 1);
                foreach (char j in sybs)
                {
                    if (j == one) { flag1 = true; }
                }
                if (flag1 == false)
                {
                    chars1[k] = one;
                    k++;

                }
                flag1 = false;
            }
            string txt = "";
            foreach (char i in chars1)
            {
                txt = txt + i + " ";
            }
            MessageBox.Show(txt, "Задание 4");

        }
        private static void Five()
        {
            int[] mas1 = new int[10];
            Random rnd = new Random();
            int index = 0, max = 0;
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = rnd.Next(1, 50);
                if (max < mas1[i])
                {
                    max = mas1[i];
                    index = i;
                }
            }
            string txt = "Массив: ";
            foreach (int i in mas1)
            {
                txt = txt + i + " ";
            }
            txt += "\nМаксимальное значение: " + max + "\nИндекс максимального значения: " + index;
            MessageBox.Show(txt, "Задание 5");
        }
        private static void Six()
        {
            int[] mas = new int[10];
            Random rnd = new Random();
            int s;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 50);
            }
            for (int i = 1; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - i; j++)
                {
                    if (mas[j] < mas[j + 1])
                    {
                        s = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = s;
                    }
                }
            }
            string txt = "Массив: ";
            foreach (int i in mas)
            {
                txt = txt + i + " ";
            }
            MessageBox.Show(txt, "Задание 6");
        }
        private static void Seven()
        {
            char[] chars = new char[10];
            string txt = "Массив: ";
            Random rnd = new Random();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)rnd.Next('A', 'Z' + 1);
                txt = txt + chars[i] + " ";
            }
            Array.Reverse(chars);
            txt += "Обратный массив: ";
            foreach (char i in chars)
            {
                txt = txt + i + " ";
            }
            MessageBox.Show(txt, "Задание 7");
        }
        private static void Eight()
        {
            int[,] mas = new int[5, 5];
            int[,] rev_mas = new int[5, 5];
            int[] sv = new int[5];
            Random rnd = new Random();
            string txt1 = "Массив:\n";
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 50);
                    txt1 += mas[i, j] + " ";
                }
                txt1 += "\n";
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    rev_mas[i, j] = mas[j, i];
                }
            }
            txt1 += "Измененный массив: \n";
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {

                    txt1 += rev_mas[i, j] + " ";
                }
                txt1 += "\n";
            }
            MessageBox.Show(txt1, "Задание 8");
        }
        private static void Nine()
        {
            int[,] mas = new int[5, 5];
            int[,] del_mas3 = new int[4, 4];
            Random rnd = new Random();
            string txt = "Массив:\n";
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 50);
                    txt += mas[i, j] + " ";
                }
                txt += "\n";
            }
            int number = rnd.Next(0, mas.GetLength(0));
            int number1 = rnd.Next(0, mas.GetLength(1));
            int n = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int m = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (j != number1)
                    {
                        del_mas3[n, m] = mas[i, j];
                        m++;
                    }
                }
                if (i != number)
                {
                    n++;
                }
            }
            txt += "Измененный массив: \n";
            for (int i = 0; i < del_mas3.GetLength(0); i++)
            {
                for (int j = 0; j < del_mas3.GetLength(1); j++)
                {

                    txt += del_mas3[i, j] + " ";
                }
                txt += "\n";
            }
            MessageBox.Show(txt, "Задание 9");
        }
        private static void Ten()
        {
            int N = 5;
            int M = 5;
            int[,] mas3 = new int[5, 5];
            string txt = "Массив:\n";
            int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;

            int f = 1;
            int y = 0;
            int u = 0;

            while (f <= N * M)
            {
                mas3[y, u] = f;
                if (y == Ibeg && u < M - Jfin - 1)
                    ++u;
                else if (u == M - Jfin - 1 && y < N - Ifin - 1)
                    ++y;
                else if (y == N - Ifin - 1 && u > Jbeg)
                    --u;
                else
                    --y;

                if ((y == Ibeg + 1) && (u == Jbeg) && (Jbeg != M - Jfin - 1))
                {
                    ++Ibeg;
                    ++Ifin;
                    ++Jbeg;
                    ++Jfin;
                }
                ++f;
            }

            for (int i = 0; i < mas3.GetLength(0); i++)
            {
                for (int j = 0; j < mas3.GetLength(1); j++)
                {
                    txt += mas3[i, j] + " ";
                }
                txt += "\n";
            }
            MessageBox.Show(txt, "Задание 10");
        }
    }
}
