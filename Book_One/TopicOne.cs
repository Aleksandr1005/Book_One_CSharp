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
    public class TopicOne
    {
        private string _res;
        public TopicOne()
        {
            _res = Interaction.InputBox("Выберите номер задания(1-10)", "Тема 1. Выбор задания");
            switch(_res)
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
            string name = Interaction.InputBox("Введите свое имя", "Задание 1");
            MessageBox.Show("Ваше имя: " + name, "Задание 1");
        }
        private static void Two()
        {
            string two = Interaction.InputBox("Введите свое имя и возраст", "Задание 2");
            string[] txt = two.Split(' ');
            MessageBox.Show("Ваше имя: " + txt[0] + "\nВаш возраст: " + txt[1], "Задание 2");
        }
        private static void Three()
        {
            string three = Interaction.InputBox("Введите день недели, месяц, дату", "Задание 3");
            string[] txt = three.Split(' ');
            MessageBox.Show("День недели: " + txt[0] + "\nДата: " + txt[1] + "\nМесяц: " + txt[2], "Задание 3");
        }
        private static void Four()
        {
            string four = Interaction.InputBox("Введите количество дней в мясяце, месяц", "Задание 4");
            string[] txt = four.Split(' ');
            MessageBox.Show("Месяц: " + txt[0] + "\nДней в месяце: " + txt[1], "Задание 4");
        }
        private static void Five()
        {
            string born = Interaction.InputBox("Введите свой год рождения", "Задание 5");
            int year = 2024;
            int age = year - Int32.Parse(born);
            MessageBox.Show("Ваш возраст: " + age, "Задание 5");
        }
        private static void Six()
        {
            string name = Interaction.InputBox("Введите свое имя и год рождения", "Задание 6");
            string[] txt = name.Split(' ');
            int year = 2024;
            int age = year - Int32.Parse(txt[1]);
            MessageBox.Show("Ваше имя: " + txt[0] + "\nВаш возраст: " + age, "Задание 6");
        }
        private static void Seven()
        {
            string age = Interaction.InputBox("Введите свой возраст: ", "Задание 7");
            int year = 2024;
            int born = year - Int32.Parse(age);
            MessageBox.Show("Ваш год рождения: " + born, "Задание 7");
        }
        private static void Eight()
        {
            string numbers = Interaction.InputBox("Введите 2 числа ", "Задание 8");
            string[] txt = numbers.Split(' ');
            int sum = Int32.Parse(txt[0]) + Int32.Parse(txt[1]);
            MessageBox.Show("Сумма: " + sum, "Задание 8");
        }
        private static void Nine()
        {
            string number = Interaction.InputBox("Введите число: ", "Задание 9");
            MessageBox.Show("Последовательность чисел: " + (Int32.Parse(number) - 1) + " " + number + " " + (Int32.Parse(number) + 1), "Задание 9");
        }
        private static void Ten()
        {
            string number = Interaction.InputBox("Введите 2 числа: ", "Задание 10");
            string[] txt = number.Split(' ');
            int sum = Int32.Parse(txt[0]) + Int32.Parse(txt[1]);
            int minus = Int32.Parse(txt[0]) - Int32.Parse(txt[1]);
            MessageBox.Show("Сумма: " + sum + "\nРазность: " + minus, "Задание 10");
        }
    }
}
