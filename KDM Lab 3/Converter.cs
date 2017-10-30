using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDM_Lab_3
{
    class Converter
    {
        public static List<TruthColumn> Evaluate(string formulaString)
        {
            List<TruthColumn> columns = new List<TruthColumn>();

            bool hasA = formulaString.Contains('A');
            bool hasB = formulaString.Contains('B');
            bool hasC = formulaString.Contains('C');

            int count = 0;
            count += hasA ? 1 : 0;
            count += hasB ? 1 : 0;
            count += hasC ? 1 : 0;

            TruthColumn aColumn = null;
            TruthColumn bColumn = null;
            TruthColumn cColumn = null;

            if (hasA)
            {
                aColumn = new TruthColumn(1, count, "A");
                columns.Add(aColumn);
            }
            if (hasB)
            {
                bColumn = new TruthColumn(hasA ? 2 : 1, count, "B");
                columns.Add(bColumn);
            }
            if (hasC)
            {
                int position = 1;
                position += hasA ? 1 : 0;
                position += hasB ? 1 : 0;
                cColumn = new TruthColumn(position, count, "C");
                columns.Add(cColumn);
            }

            Stack<TruthColumn> stack = new Stack<TruthColumn>();

            for(int i = 0; i < formulaString.Length; i++)
            {
                if (IsOperator(formulaString[i]))
                {
                    if (formulaString[i] == '!')
                    {
                        TruthColumn op1 = stack.Pop();
                        TruthColumn result = TruthColumn.Negate(op1);
                        stack.Push(result);
                        columns.Add(result);
                    } else
                    {
                        TruthColumn op2 = stack.Pop();
                        TruthColumn op1 = stack.Pop();
                        TruthColumn result = TruthColumn.Evaluate(op1, op2, formulaString[i]);
                        stack.Push(result);
                        columns.Add(result);
                    }
                } else if (IsOperand(formulaString[i]))
                {
                    switch (formulaString[i])
                    {
                        case 'A':
                            stack.Push(aColumn);
                            break;
                        case 'B':
                            stack.Push(bColumn);
                            break;
                        case 'C':
                            stack.Push(cColumn);
                            break;
                    }
                }
            }

            return columns;
        }
        public static String Convert(String input)
        {
            Stack<char> stack = new Stack<char>();
            String str = input.Replace(" ", string.Empty);
            StringBuilder formula = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char x = str[i];
                if (x == '(')
                    stack.Push(x);
                else if (x == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        formula.Append(stack.Pop());
                    stack.Pop();
                }
                else if (IsOperand(x))
                {
                    formula.Append(x);
                }
                else if (IsOperator(x))
                {
                    while (stack.Count > 0 && stack.Peek() != '(' && Priority(x) <= Priority(stack.Peek()))
                        formula.Append(stack.Pop());
                    stack.Push(x);
                }
                else
                {
                    char y = stack.Pop();
                    if (y != '(')
                        formula.Append(y);
                }
            }
            while (stack.Count > 0)
            {
                formula.Append(stack.Pop());
            }
            return formula.ToString();
        }

        static bool IsOperator(char c)
        {
            return (c == '!' || c == 'ν' || c == '^' || c == '~' || c == '→');
        }
        static bool IsOperand(char c)
        {
            return (c == 'A' || c == 'B' || c == 'C');
        }

        static int Priority(char c)
        {
            switch (c)
            {
                case '~':
                    return 1;
                case '→':
                    return 2;
                case 'ν':
                    return 3;
                case '^':
                    return 4;
                case '!':
                    return 5;
                default:
                    throw new ArgumentException("Wrong parameter");
            }
        }
    }
}
