using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class Program
    {
        static int Main(string[] args)
        {
            //управление доступом осуществляется  public, private, protected, internal
            //public  разрешает доступ разрешает доступ к члену откуда угодно
            //private разрешает доступ к члену только для методов внури этого класса
            //первый пример set, ger к приватной переменной

            /* MyClass firsttime = new MyClass();
             //не видит переменнойальфа
             firsttime.SetAlpha(6);
             Console.WriteLine(firsttime.GetAlpha());
             Console.ReadKey();*/

            //Создание стека
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);
            char ch; int i;
            for (i = 0; !stk1.full(); i++)
            {
                stk1.push((char)('A'+i));
            }
            if (stk1.full())
                Console.WriteLine("Стек stk1 полон.");
            Console.Write("Содержимое стека stk1");
            while (!stk1.empty())
            {
                ch = stk1.pop();
                Console.Write(ch);
            }
            Console.WriteLine();
            if (stk1.empty()) Console.WriteLine("Стек stk1 пуст.\n");


            //использование переменного количества аргументов

            Min ob = new Min();
            int min;
            int a = 10, b = 20;
            min = ob.minVal(a, b);
            Console.WriteLine("Минимум равен "+ min);

            min = ob.minVal(a, b, -1);
            Console.WriteLine("Минимум равен " + min);

            //можно так е передать int массив
            int[] mass = {1,2,3,4,5 };
            min = ob.minVal(mass);
            Console.WriteLine("Минимум равен " + min);

            //возвращение методами объектов
            Rect r1 = new Rect(4,5);
            Console.Write("Размеры прямоугольника r1: ");
            r1.show();
            //прямоугольник, который в 2ое больше прямоугольника r1
            Rect r2 = r1.enlarge(2); //заместо new Rect(width * factor, height * factor)
            Console.Write("Размеры прямоугольника r2:");
            r2.show();
            Console.WriteLine("Площадь прямоугольника r2:" + r2.area());

            /*В фабриках класса применяются классовые типы значений*/
            /*Фабрик класса  - метод который используется для построения заданного класса */

            MyClass ob2 = new MyClass();
            int ii, jj;
            //генерируем объекты с помощью фабрики класса
            for (ii = 0, jj = 10; ii < 10; ii++, jj++)
            {
               MyClass anotherOb =  ob2.factory(ii, jj); //создаём объект
                anotherOb.show();
            }
            Console.WriteLine();

            //12.03.2019
            //Вызов перегруженного конструктора с помощью ссылки this

            /*имя_конструктора (список_параметров1): this(список параметров2)
             //тело конструтора, которое может ыть пустым*/
            XYCoord t1 = new XYCoord();
            XYCoord t2  = new XYCoord(8,9);
            XYCoord t3 = new XYCoord(t2);
            Console.WriteLine("t1.x, t1.y: " + t1.x + ", " + t1.y);
            Console.WriteLine("t2.x, t2.y: " + t2.x + ", " + t2.y);
            Console.WriteLine("t3.x, t3.y: " + t3.x + ", " + t3.y);

            //Возвращение значений из main
            //Main(): public static int Main();
            /*Для работы с аргументами командной строки
             Main(): public static void Main(string[] args)  public static int Main(string[] args) */

            //пирмер
            //string[] args2 = new string[2];
            //string[] args2 = { "закодировать", "зако", "зако"};
            /*args2[0] = "закодировать";
            args2[1] = "зако";
            args2[2] = "зако";*/


            //перегрузка логических операторов
            ThreeD tre0 = new ThreeD();
            ThreeD tre1 = new ThreeD(1, 1, 1);
            ThreeD tre2 = new ThreeD(2,2,2);
            Console.WriteLine(tre0 | tre1);
            Console.WriteLine(tre0 | tre0);
            Console.WriteLine(tre0 & tre1);
            Console.WriteLine(!tre0);

            //Чтобы сделать учечённные нужно
            /*
             * 1. Класс доджен перегружать операторы & и |. 
             * 2.  &- и |-методы должны возвращать объект класса
             * 3. каждый параметр должен представлять собой ссылку на объект класса
             * 4. класс должен перегружать операторы true и false
             */
            Console.WriteLine(tre0 && tre1);
            Console.WriteLine(tre0 ||tre1);
            if (tre0 && tre1)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("Ложь");
            if (tre0 || tre1)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("Ложь");

            //Операторы преобразований
            /*
             * две формы операторов преобразования явная и неявная
             * public static explicit operator тип_результата(исходный_тип v) [return значение;]
             * public static implict operator тип_результата (исходный_тип v) [return значение;]
             * тип_результата тип в который нужно выполнить преобразование
             * исходный тип - объекто подлежащий преобразованию
             * элемент v значение класса после преобразования
             * если impluict - автомтоматически
             * если explict - выполняется при использовании операторов приведения типов
             */
            //неявное
            //int i3i = new ThreeD(10, 10, 10);

            //явное
            int i3i = (int)(new ThreeD(10, 10, 10));
            Console.WriteLine(i3i);

            int per1, per2;
            per1 = 9;
            per2 = 9;
            FailSoftArray2D ma2 = new FailSoftArray2D(per1,per2);
            for (int z = 7, x = 7; z < 10; z++, x++)
            {
                ma2[z, x] = z * x;
                if (ma2.svError)
                    Console.WriteLine("fs[" + z + ", " + x + "] вне границ");
               
            }
            for (int z = 7, x = 7; z < 10; z++, x++)
            {
                Console.WriteLine(ma2[z,x]);
                if (ma2.svError)
                    Console.WriteLine("fs[" + z + ", " + x + "] вне границ");

            }
            //свойства - поле и методы доступа к полю
            //свойства похожи на инексаторы имя и get set
            /*
             * тип имя
             * {
             *  get
             *  {
             *      //код аксессора чтения поля
             *  }
             *  set
             *  {
             *      //код аксессора записи поля тут есть value
             *  }
             * }
             * тип - это тип свойства  int, double  и т.д
             * имя - его имя
             * замето них можно использовать методы
             */

            SimpProp obj = new SimpProp();
            Console.WriteLine("Исходное значение ob.myprop: " + obj.mypop);
            obj.mypop = 10;
            Console.WriteLine("Присвоенно значение ob.myprop: " + obj.mypop);
            obj.mypop = -1;
            Console.WriteLine("-1 ob.myprop: " + obj.mypop);


            //наследование
            /*
             class имя_производного_класса : имя_базового_класса {  // тело класса  }
             */
            Triangle tr = new Triangle();
            tr.Height = 10;
            tr.Width = 10;
            tr.Style = "ravnostoron";

            tr.showStype();
            
            tr.showDim();
            Console.WriteLine(tr.area());

            Rectangle kw = new Rectangle(1,2);
            /*kw.Height = 1;
            kw.Width = 2;*/
            Console.WriteLine("Площадь квадрата " + kw.area());


            Console.WriteLine("Виртуальные методы и их определение");
            Base baseob = new Base();
            Derived1 dOb1 = new Derived1();
            Derived2 dOb2 = new Derived2();
            Derived3 dOb3 = new Derived3();
            Base baseref; //ссылка на базовый подкласс
            baseref = baseob;
            baseref.who(); //взависимости от типа объекта выполняется своя версия
            baseref = dOb1;
            baseref.who();
            baseref = dOb2;
            baseref.who();
            baseref = dOb3;
            baseref.who(); //первый переопределеннный метод при просмотре иерархии сверху вниз
            //свойства можно можфицировать с помощью виртуал и оверрайд

            

            //Класс обжект
            Console.WriteLine(baseref.Equals(dOb1)); //определяет является ли вызвывающий объект таким же, как  объект, адрисуемый ссылкой ob
            Console.WriteLine(Equals(baseref, dOb1)); //Определяет является ли объект 1 таким же как и объект 2
            Console.WriteLine(baseref.GetHashCode()); //Возвращает хэш-код
            Console.WriteLine(baseref.GetType()); //получает тип оъекта во время выполнения программы
            Console.WriteLine(ReferenceEquals(dOb1, dOb2)); //определяет, ссылются ли 1 и 2 на один и тот же объект    
            Console.WriteLine(dOb1.ToString()); //возращает строку, которая описывает объект

            Console.WriteLine(new MyClass().ToString()); //Возвращение пререопределенного метода из класса object


            //Приведение к объектному типу и восстановление значения
            int xt;
            object obje;
            xt = 10;
            obje = xt;// Превращаем xt в объект
            Console.WriteLine(obje.ToString());
            int yt = (int)obje; //обратное превращение
            Console.WriteLine(yt);

            //Другой пример
            //приведение  значений к объектному типу возможно при передаче значений методами
            int xt2;
            xt2 = 10;
            Console.WriteLine("Значение x =" +xt2);
            //переменная xt2 автоматически приводится к объектому типу при передаче в sqr
            xt2 = Program.sqr(xt2);
            Console.WriteLine("Значение ч в квадрате рано" + xt2);

            //ещё пример
            Console.WriteLine(10.ToString()); //10 представляется как объект и выводится его строковое представдение 10


            object[] p1 = new object[9];
            //сохраняем int значения
            for(int i3 = 0; i3<3;i3++)
            {
                p1[i3] = i3;
            }
            //сохраняем double значениия
            for(int j3=3;j3<6;j3++ )
            {
                p1[j3] = (double)j3;
            }
            //сохраняем bool, string и char значения
            p1[6] = true;
            p1[7] = 'x';
            p1[8] = "asf";


            for (int bb = 0; bb<p1.Length;bb++)
            {
                Console.WriteLine(p1[bb]);
            }

            //Интерфейсы
            /*interface имя
             {
             тип_возрата имя метода 1(сиксок параметров);
             тип_возрата имя метода 2(сиксок параметров);
             }*/
            /*интерфейс который генерирует ряд чисел
             public interface ISeries
             {
             int getNext(); //Возвращает следующее число ряда
             void reset(); //Выполняет перезапуск
             void setStat(int x); //устанавливает начальные значения
             }
             */
            /*класс который реализует интерефейс
             class имя_класса : имя_интерфейса
             {
             //тело класса
             }
           */
            ByTwos o1b1 = new ByTwos();
            for(int i3 = 0; i3<5;i3++)
            {
                Console.WriteLine("Следующее значение равно " + o1b1.getNext());
            }
            Console.WriteLine("\nПереход в исходное состояние.");
            o1b1.reset();
            for (int i3 = 0; i3 < 5; i3++)
            {
                Console.WriteLine("Следующее значение равно " + o1b1.getNext());
            }
            Console.WriteLine("\nНачинаем с числа 100.");
            o1b1.setStart(100);
            for (int i3 = 0; i3 < 5; i3++)
            {
                Console.WriteLine("Следующее значение равно " + o1b1.getNext());
            }

            Console.ReadKey();
            //рабочий вариант вызов черехз
            /*
             * cd C:\Users\Denis\source\repos\Lernclass\Lernclass\bin\Debug
             * Lernclass.exe
             */
            if (args.Length < 2)
            {
                Console.WriteLine("Использование+ "  +"слово1: <<закодировать>>/<<раскодировать>> " + "[слово2... словоN]");
                return 1; //возврат значения признака неверного выполнения
            }

            if (args[0] != "закодировать" & args[0] != "раскодирвоать")
            {
                Console.WriteLine("Первым аргументом должно быть слово " + "\"закодировать\" или \"раскодировать\".");
                return 1; // Возврат признака неверного выполнения. 
            }
            //Кодируем и декодируем сообщение
            for (int n = 1; n < args.Length; n++)
            {
                for (int i2 = 0; i2 < args[n].Length; i2++)
                {
                    if (args[0] == "закодировать")
                    {
                        Console.Write((char)(args[n][i2] + 1)); ///берём n слово i2 символ
                    }
                    else
                        Console.Write((char)(args[n][i2] - 1));
                }
                Console.Write(" ");
            }
            Console.WriteLine();
            
            return 0;

            
        }
        static int sqr(object o)
        {
            return (int)o * (int)o; //возвращается уже int
        }
    }
}
