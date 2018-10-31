using System;
using System.Collections.Generic;
/*Reverse a stack and put the reversed value back in the same stack. 
         * You can use only one other stack and a temp variable.*/
namespace Stack3
{
    class Program
    {
        static Stack<string> Reverse(Stack<string> stack)
        {
            if (stack.Count == 0)
                return stack;

            string temp = stack.Pop();
            Reverse(stack);
            BottomInsert(stack, temp);
            return stack;
        }

        static void BottomInsert(Stack<string> stack, string x)
        {
            if (stack.Count == 0)
            {
                stack.Push(x);
                return;
            }
            else
            {
                string temp = stack.Pop();
                BottomInsert(stack, x);
                stack.Push(temp);
            }
        }

        //static Stack<string> ReverseStack2(Stack<string> stack)
        //{
        //  это просто копирует в новый стэк и потом его возвращает в основную функцию вызова
        //    var stack2 = new Stack<string>();
        //    while (stack.Count > 0)
        //    {
        //        stack2.Push(stack.Pop());
        //    }
        //    return stack2;
        //}

        //too much time, not good
        //static Stack<string> ReverseStack(Stack<string> stack)
        //{
        //    if (stack.Count <= 1)
        //        return stack;
        //    var stack2 = new Stack<string>();
        //    string temp = null;
        //    int cou = 0;
        //    for (int i = 0; i < stack.Count-1; i++)
        //    {
        //        temp = stack.Pop();
        //        while (stack.Count > cou)
        //        {
        //            stack2.Push(stack.Pop());
        //        }
        //        stack.Push(temp);
        //        while (stack2.Count > 0)
        //        {
        //            stack.Push(stack2.Pop());
        //        }
        //        cou = cou + 1;
        //    }
        //    return stack;
        //}


        static void Main()
        {
            var stack1 = new Stack<string>();
            stack1.Push("40");
            stack1.Push("41");
            stack1.Push("42");
            stack1.Push("43");
            stack1.Push("44");
            stack1.Push("45");
            foreach (string s in stack1)
            {
                Console.WriteLine(s);
            }
            //stack1 = ReverseStack2(stack1);
            //Console.WriteLine("After reverse 2");
            //foreach (string s in stack1)
            //{
            //    Console.WriteLine(s);
            //}

            stack1 = Reverse(stack1);
            foreach (string s in stack1)
            {
                Console.WriteLine(s);
            }
        }
    }
}
