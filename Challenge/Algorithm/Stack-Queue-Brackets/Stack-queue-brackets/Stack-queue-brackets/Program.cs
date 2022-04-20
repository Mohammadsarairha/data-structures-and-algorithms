using System;
using System.Collections.Generic;

namespace Stack_queue_brackets
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool ValidateBrackets(string str)
        {
            Stack<char> bracketStack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                {
                    bracketStack.Push(str[i]);
                    continue;
                }else if(str[i] == ')' || str[i] == ']' || str[i] == '}')
                {
                    if (bracketStack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if (str[i] == ')' && bracketStack.Peek() == '(')
                        {
                            bracketStack.Pop();
                            continue;
                        }
                        else if (str[i] == ']' && bracketStack.Peek() == '[')
                        {
                            bracketStack.Pop();
                            continue;
                        }
                        else if (str[i] == '}' && bracketStack.Peek() == '{')
                        {
                            bracketStack.Pop();
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            //Check if Stack not empty or string empty
            if (bracketStack.Count > 0 || str == "")
            {
                return false;
            }else
                return true;
        }
    }
}
