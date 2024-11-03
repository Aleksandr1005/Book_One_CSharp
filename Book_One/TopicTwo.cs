using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_One
{
    
    public class TopicTwo
    {
        private string _res;
        public TopicTwo()
        {
            _res = Interaction.InputBox("Выберите номер задания(1-10)", "Тема 2. Выбор задания");
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
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 1"));
            string txt = "Число " + (input % 3 == 0 ? "делится" : "не делится") + " на 3";
            MessageBox.Show(txt, "Задание 1");
        }
        private static void Two()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 2"));
            string txt = "Число " + (input % 5 == 2 && input % 7 == 1 ? "подходит" : "не подходит") + " условию";
            MessageBox.Show(txt, "Задание 2");
        }
        private static void Three()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 3"));
            string txt = "Число " + (input % 4 == 0 && input >= 10 ? "подходит" : "не подходит") + " условию";
            MessageBox.Show(txt, "Задание 3");
        }
        private static void Four()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 4"));
            string txt = "Число " + (input >= 5 && input <= 10 ? "подходит" : "не подходит") + " условию";
            MessageBox.Show(txt, "Задание 4");
        }
        private static void Five()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 5")) / 1000;
            string txt = "В этом числе " + input + " тысяч";
            MessageBox.Show(txt, "Задание 5");
        }
        private static void Six()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 6"));
            string txt = "2 число справа: " + ((input & 56) >> 3);
            MessageBox.Show(txt, "Задание 6");
        }
        private static void Seven()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 7"));
            string txt = "3 число справа: " + ((input >> 2) % 2);
            MessageBox.Show(txt, "Задание 7");
        }
        private static void Eight()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 8"));
            string txt = "Новое число: " + (input |= 1 << 2);
            MessageBox.Show(txt, "Задание 8");
        }
        private static void Nine()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 9"));
            string txt = "Новое число: " + (input ^= 0 << 3);
            MessageBox.Show(txt, "Задание 9");
        }
        private static void Ten()
        {
            int input = Int32.Parse(Interaction.InputBox("Введите число", "Задание 10"));
            string txt = "Новое число: " + (input ^= 1 << 2);
            MessageBox.Show(txt, "Задание 10");
        }
    }
}
