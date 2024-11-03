using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_One
{
    internal class Program
    {
        static void Main()
        {
            string Topic = "1. Знакомство с языком C#\n" + 
                "2. Базовые типы и операторы\n" + 
                "3. Управляющие инструкции\n" + 
                "4. Массивы\n" +
                "5. Статические методы\n" +
                "6. Знакомство с классами и объектами\n" +
                "7. Работа с текстом\n" +
                "8. Перегрузка операторов\n" +
                "9. Свойства и индексаты\n" +
                "10. Наследование";
            string res = Interaction.InputBox("Выберите номер темы, для просмотра заданий и решений:\n" + Topic, "Выбор темы");
            switch(res)
            {
                case "1":
                    TopicOne topicOne = new TopicOne();
                    break;
                case "2":
                    TopicTwo topicTwo = new TopicTwo();
                    break;
                case "3":
                    TopicThree topicThree = new TopicThree();
                    break;
                case "4":
                    TopicFour topicFour = new TopicFour();
                    break;
                case "5":
                    TopicFive topicFive = new TopicFive();
                    break;
                case "6":
                    TopicSix topicSix = new TopicSix();
                    break;
                case "7":
                    TopicSeven topicSeven = new TopicSeven();
                    break;
                case "8":
                    TopicEight topicEight = new TopicEight();
                    break;
                case "9":
                    TopicNine topicNine = new TopicNine();
                    break;
                case "10":
                    TopicTen topicTen = new TopicTen();
                    break;
                default:
                    break;
            }
        }
    }
}
