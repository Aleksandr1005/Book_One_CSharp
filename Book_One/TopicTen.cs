using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_One
{
    class TopicTenOneBase
    {
        private string txt;
        public TopicTenOneBase(string str)
        {
            txt = str;
        }
        public override string ToString()
        {
            return "TopicTenOneBase" + " " + txt;
        }
    }
    class TopicTenOne : TopicTenOneBase
    {
        private string txt;
        public TopicTenOne(string str, string str2) : base(str)
        {
            txt = str2;
        }
        public TopicTenOne(string str) : base(str) { }
        public override string ToString()
        {
            return "TopicTenOne" + " " + txt;
        }
    }
    
    class TopicTenTwoBase
    {
        private string txt;
        public virtual string Query()
        {
            txt = "Базовый. Без аргументов";
            return txt;
        }
        public virtual string Query2(string str)
        {
            txt = "Базовый. С аргументом" + str;
            return txt;
        }
        public TopicTenTwoBase(string str)
        {
            txt = str;
        }
        public int lenght
        {
            get
            {
                return txt.Length;
            }
        }
        public int this[int  index]
        {
            get
            {
                return txt[index];
            }
        }
    }
    class TopicTenTwo : TopicTenTwoBase
    {
        public int _int;
        public TopicTenTwo(int a, string str) : base(str)
        {
            _int = a;
        }
        public override string Query()
        {
            return "Произвольный. Без аргументов";
        }
        public override string Query2(string str)
        {
            return "Произвольный. С аргументом" + str;
 
        }
        public string Qurey3(int a)
        {
            _int = a;
            return "Произвольный. Число: " + _int;
        }
        public string Query4(int a, string str)
        {
            _int = a;
            return "Произвольный. Число:" + _int + " Строка: " + str;
        }
        
    }

    class TopicTenThreeBase
    {
        public int[] mas;
        public TopicTenThreeBase(int[] ints)
        {
            mas = ints;
        }
        public override string ToString()
        {
            string txt = "Базовый. Массив: \n";
            for (int i = 0; i < mas.Length; i++)
            {
                txt += mas[i] + " ";
            }
            return txt;
        }
    }
    class TopicTenThree : TopicTenThreeBase
    {
        public char[] ch;
        public TopicTenThree(char[] cha, int[] ints) : base(ints)
        {
            ch = cha;
        }
        public override string ToString()
        {
            string txt = "Произвольный. Массив:\n";
            for(int i = 0; i < ch.Length; i++)
            {
                txt += ch[i] + " ";
            }
            return txt + "\n" + base.ToString();
        }
    }

    class TopicTenFourBase
    {
        public int _int;
        public TopicTenFourBase(int @int)
        {
            _int = @int;
        }
        public string Query(int i)
        {
            _int = i;
            return "Базовый. Метод: " + _int + "\n";
        }
        public override string ToString()
        {
            return Query(1);
        }
    }
    class TopicTenFourOne : TopicTenFourBase
    {
        public char _ch;
        public TopicTenFourOne(char @ch, int a) : base(a) 
        {
            _ch = @ch;
        }
        public string Query(char @char, int a)
        {
            string txt = "Произвольный от базового\n";
            _ch = @char;
            _int = a;
            txt += "Символ: " + _ch + " Число:" + _int + "\n";
            return txt;
        }
        public override string ToString()
        {
            return base.ToString() + Query('c',1);
        }
    }
    class TopicTenFourTwo : TopicTenFourOne
    {
        public string txt;
        public TopicTenFourTwo(string str, char ch, int a) : base(ch, a)
        {
            txt = str;
        }
        public string Query(string @str, char @ch, int @a)
        {
            string txt1 = "Произвольный от произвольного\n";
            txt = @str;
            _int = @a;
            _ch = @ch;
            txt1 += "Строка: " + txt + " Символ: " + _ch + " Число: " + _int + "\n";
            return txt1;
        }
        public override string ToString()
        {
            return base.ToString() + Query("Привет",'c', 1);
        }
    }
    
    class TopicTenFiveBase
    {
        public char ch;
        public TopicTenFiveBase(char ch)
        {
            this.ch = ch;
        }
        public TopicTenFiveBase(TopicTenFiveBase topicTenFiveBase) {
            ch = topicTenFiveBase.ch;
        }
    }
    class TopicTenFiveOne : TopicTenFiveBase
    {
        public string str;
        public TopicTenFiveOne(string str, char c) : base(c)
        {
            this.str = str;
        }
        public TopicTenFiveOne(TopicTenFiveOne topicTenFiveOne) : base(topicTenFiveOne.ch)
        {
            str = topicTenFiveOne.str;
        }
    }
    class TopicTenFiveTwo : TopicTenFiveOne
    {
        public int a;
        public TopicTenFiveTwo(int a, string str, char c) : base(str, c)
        {
            this.a = a;
        }
        public TopicTenFiveTwo(TopicTenFiveTwo topicTenFiveTwo): base(topicTenFiveTwo.str, topicTenFiveTwo.ch)
        {
            a = topicTenFiveTwo.a;
        }
    }

    class TopicTenSixBase
    {
        protected string str;
        public TopicTenSixBase(string str)
        {
            this.str = str;
        }
        public string nameClass(TopicTenSixBase topicTenSixBase)
        {
            string _str = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + ": " + topicTenSixBase.str;
            return _str;
        }
    }
    class TopicTenSixOne : TopicTenSixBase
    {
        protected int _int;
        public TopicTenSixOne(int @int, string str) : base(str)
        {
            _int = @int;
        }
        public string nameClass(TopicTenSixOne topicTenSixOne)
        {
            string _str = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + ": " + topicTenSixOne.str + ", " + topicTenSixOne._int;
            return _str;
        }
    }
    class TopicTenSixTwo : TopicTenSixBase
    {
        protected char _char;
        public TopicTenSixTwo(char @char, string str) : base(str)
        {
            _char = @char;
        }
        public string nameClass(TopicTenSixTwo topicTenSixTwo)
        {
            string _str = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + ": " + topicTenSixTwo.str + ", " + topicTenSixTwo._char;
            return _str;
        }
    }
    public class TopicTenSevenBase
    {
        public string str;
        public TopicTenSevenBase(string str)
        {
            this.str = str;
        }
        public virtual string result(TopicTenSevenBase topicTenSevenBase)
        {
            return topicTenSevenBase.str;
        }
    }
    public class TopicTenSevenOne : TopicTenSevenBase
    {
        public char _char;
        public TopicTenSevenOne(char @char, string str) : base(str)
        {
            _char = @char;
        }
        public override string result(TopicTenSevenBase topicTenSevenBase)
        {
            return base.result(topicTenSevenBase);
        }
    }

    public class TopicTenEightBase
    {
        public int _int;


        public virtual int this[int index]
        {
            get
            {
                int t = _int;
                int k = 0, l = 0;
                while (k < index)
                {
                    k++;
                    l = t % 10;
                    t = t / 10;
                }
                return l;
            }
        }
    }
    public class TopicTenEight : TopicTenEightBase
    {
        public int _index;
        public int this[int ch, int k]
        {
            get
            {
                int t;
                if (ch == 0) t = base._int;
                else t = _index;
                int kl = 0, c = 0;
                while(kl < k)
                {
                    kl++;
                    c  = t % 10;
                    t = t / 10;
                }
                return c;
            }
        }
        public override int this[int index]
        {
            get
            {
                int t = base._int + _index;
                int kl = 0, ch = 0;
                while(kl < index)
                {
                    kl++;
                    ch = t % 10;
                    t = t / 10;
                }
                return ch;
            }
        }
    }

    public class TopicTenNineBase
    {
        protected string str;
        public virtual string vStr
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }
        }
        public override string ToString()
        {
            return "TopicTenNineBase: " + str;
        }
    }
    public class TopicTenNine : TopicTenNineBase
    {
        protected string _str;
        public override string vStr
        {
            get
            {
                return _str + ' ' + base.vStr;
            }
            set
            {
                string strOne = "", strTwo = "";
                bool flag = false;
                for(int i = 0; i < value.Length; i++)
                {
                    if(value[i] == ' ')
                    {
                        flag = true;
                        i++;
                    }
                    if (!flag)
                    {
                        strOne += value[i];
                    }
                    else
                    {
                        strTwo += value[i];
                    }
                }
                _str = strOne;
                base.str = strTwo;
            }
        }
        public override string ToString()
        {
            string txt = "TopicTenNineBase: " + base.str + "\n";
            txt += "TopicTenNine: " + _str;
            return txt;
        }
    }

    public class TopicTenTenbase
    {
        protected int[] ints = new int[5];
        public int[] mas
        {
            get
            {
                return ints;
            }
            set
            {
                for(int i = 0 ; i < value.Length ; i++)
                    ints[i] = value[i];
            }
        }
        public virtual string razmer()
        {
            return "Размер ц.м:" + ints.Length + "\n";
        }
    }
    public class TopicTenTen : TopicTenTenbase
    {
        protected char[] chars = new char[5];
        public char[] mas_ch
        {
            get
            {
                return chars;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                    chars[i] = value[i];
            }
        }
        public override string razmer()
        {
            return base.razmer() + 
                "Размер ч.м: " + chars.Length;
        }
    }

    public class TopicTen
    {
        private string _res;
        public TopicTen()
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
            TopicTenOneBase A = new TopicTenOneBase("Привет");
            TopicTenOne B = new TopicTenOne("Hello");
            TopicTenOne C = new TopicTenOne("Hello", "world");
            MessageBox.Show(A.ToString() + "\n" + B.ToString() + "\n" + C.ToString(), "Задание 1");
        }
        private static void Two()
        {
            string txt = "Базовый\n";
            TopicTenTwoBase A = new TopicTenTwoBase("Привет");
            txt += A.Query() + "\n";
            txt += A.Query2("Хай") + "\n";
            txt += "Длина = " + A.lenght;
            txt += "Символ c 4 индексом = " + A[4] + "\n";
            TopicTenTwo B = new TopicTenTwo(7,"Hello");
            txt += "Произвольный\n";
            txt += B.Query() + "\n";
            txt += B.Query2("Хай") + "\n";
            txt += B.Qurey3(4) + "\n";
            txt += B.Query4(5, "Здарова") + "\n";
            MessageBox.Show(txt, "Задание 2");
        }
        private static void Three()
        {
            int[] ints = { 1, 2, 3 };
            char[] ch = { 'a', 'b', 'c' };
            TopicTenThree B = new TopicTenThree(ch, ints);
            MessageBox.Show(B.ToString(), "Задание 3");
        }
        private static void Four()
        {
            TopicTenFourTwo A = new TopicTenFourTwo("Привет", 'c', 1);
            MessageBox.Show(A.ToString(), "Задание 4");
        }
        private static void Five()
        {
            TopicTenFiveTwo A = new TopicTenFiveTwo(1, "Число", 'c');
            string str = "Число: " + A.a + "\n";
            str += "Строка: " + A.str + "\n";
            str += "Символ: " + A.ch + "\n";
            TopicTenFiveTwo B = new TopicTenFiveTwo(A);
            str += "\n\nКопия:\n";
            str += "Число: " + B.a + "\n";
            str += "Строка: " + B.str + "\n";
            str += "Символ: " + B.ch + "\n";
            MessageBox.Show(str, "Задание 5");
        }
        private static void Six()
        {
            TopicTenSixTwo topicTenSixTwo = new TopicTenSixTwo('a', "Строка");
            TopicTenSixOne topicTenSixOne = new TopicTenSixOne(1, "Строка 2");
            TopicTenSixBase topicTenSixBase = new TopicTenSixBase("Строка 3");
            string str = "Базовый метод:\n" + topicTenSixBase.nameClass(topicTenSixBase);
            str += "\nПервый произвольный класс:\n" + topicTenSixOne.nameClass(topicTenSixOne);
            str += "\nВторой произвольный класс:\n" + topicTenSixTwo.nameClass(topicTenSixTwo);
            MessageBox.Show(str, "Задание 6");
        }
        private static void Seven()
        {
            TopicTenSevenBase topicTenSevenBase = new TopicTenSevenBase("Привет");
            TopicTenSevenOne topicTenSeven = new TopicTenSevenOne('1', "Пока");
            string str = "Базовый метод:\n";
            str += topicTenSevenBase.result(topicTenSevenBase);
            str += "\nПроизводный класс:\n";
            str += topicTenSeven.result(topicTenSeven);
            MessageBox.Show(str, "Задание 7");
        }
        private static void Eight()
        {
            TopicTenEightBase topic = new TopicTenEightBase();
            topic._int = 12345;
            string txt = "Базовый класс:\n";
            txt += "topic._int = " + topic._int;
            txt += "\ntopic[3] = " + topic[3];
            TopicTenEight topicTenEight = new TopicTenEight();
            topicTenEight._int = 434343;
            topicTenEight._index = 544343;
            txt += "\nПроизвольный класс:\n";
            txt += "topicTenEight._int = " + topicTenEight._int;
            txt += "\ntopicTenEight._index = " + topicTenEight._index;
            txt += "\ntopicTenEight[1, 4] = " + topicTenEight[1, 4];
            txt += "\ntopicTenEight[2, 3] = " + topicTenEight[2, 3];
            MessageBox.Show(txt, "Задание 8");
        }
        private static void Nine()
        {
            TopicTenNineBase topic = new TopicTenNineBase();
            topic.vStr = "Привет";
            string txt = "Базовый класс:\ntopic.str = " + topic.vStr;
            txt += "\nToString" + topic.ToString();
            TopicTenNine topicTenNine = new TopicTenNine();
            topicTenNine.vStr = "Пока всем";
            txt += "\nПроизводный класс:\n";
            txt += topicTenNine.ToString();
            MessageBox.Show(txt, "Задание 9");
        }
        private static void Ten()
        {
            TopicTenTenbase topicTenTenbase = new TopicTenTenbase();
            TopicTenTen topicTenTen = new TopicTenTen();
            int[] ints = new int[5] {1,2,3,4,5};
            char[] charArr = new char[5] {'a','b','c','d','e'};
            topicTenTenbase.mas = ints;
            topicTenTen.mas_ch = charArr;
            string txt = "Базовый класс:\n";
            txt += topicTenTenbase.mas + "\n";
            txt += topicTenTenbase.razmer() + "\n";
            txt += "Производный класс:\n";
            txt += topicTenTen.mas + "\n";
            txt += topicTenTen.razmer() + "\n";
            MessageBox.Show(txt, "Задание 10");
        }
    }
}
