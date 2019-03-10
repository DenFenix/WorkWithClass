using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernclass
{
    class Stack
    {
        //примеры 
        /*public string errMsg;
        private double bal;
        private bool isError(byte statys)
        {
        }*/
        //Сравнение доступа к открытым и закрытым членам класса
        /*  private int alpha; //явно задан спецификатор приват, чтобы не давать доступ непосредственно к переменной, ммоджно создать метод, который бы получал доступ к этой переменной
          int beta; //private по умолчанию
          public int gamma;//явно задан спецификатор public
                           //методы для получения доступа к alfa и beta

          public void SetAlpha(int a)//метол записи значения в приватную перменню
          {
              alpha = a;
          }

          public int GetAlpha()
          {
              return alpha;
          }
          */
        private char[] stak; //Массив для хранения стека
        int tos;//индекс вершины стека
        //создаём пустой класс Stack заданного размера
        public Stack(int size)
        {
            stak = new char[size];
            tos = 0;
        }
        //помешпем символы в стек
        public void push(char ch)
        {
            if (tos == stak.Length)
            {
                Console.WriteLine(" - Стэк заполен");
                return;
            }

            stak[tos] = ch;
            tos++;
        }
        //извлекаем символы из стека
        public char pop()
        {
            if (tos == 0)
            {
                Console.WriteLine(" - Стек пуст.");
                return (char)0;
            }
            tos--;
            return stak[tos];
        }
        //Метод возвращает значение true, если стек полон
        public bool full()
        {
            return tos == stak.Length;
        }
        public bool empty()
        {
            return tos == 0;
        }
        public int capacity()
        {
            return stak.Length;
        }
        public int getNum()
        {
            return tos;
        }

    }
}
