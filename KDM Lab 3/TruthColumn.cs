using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDM_Lab_3
{
    public class TruthColumn
    {

        public string stringDesc;

        bool[] _truthArray;
        public bool[] truthArray
        {
            get
            {
                return _truthArray;
            }
        }

        public TruthColumn(int position, int count, string letter)
        {

            switch (count)
            {
                case 1:
                    _truthArray = new bool[] { false, true };
                    break;
                case 2:
                    switch (position)
                    {
                        case 1:
                            _truthArray = new bool[] { false, false, true, true };
                            break;
                        case 2:
                            _truthArray = new bool[] { false, true, false, true };
                            break;
                    }
                    break;
                case 3:
                    switch (position)
                    {
                        case 1:
                            _truthArray = new bool[] { false, false, false, false, true, true, true, true };
                            break;
                        case 2:
                            _truthArray = new bool[] { false, false, true, true, false, false, true, true };
                            break;
                        case 3:
                            _truthArray = new bool[] { false, true, false, true, false, true, false, true };
                            break;
                    }
                    break;
            }
            stringDesc = letter;
        }

        public TruthColumn(bool[] truthArray, string desc)
        {
            _truthArray = truthArray;
            stringDesc = desc;
        }

        public static TruthColumn Negate(TruthColumn ts)
        {
            bool[] _truthArray = new bool[ts.truthArray.Length];
            string stringDesc = ts.stringDesc.Length == 1 ? "!" + ts.stringDesc : "!(" + ts.stringDesc + ")";

            for (int i = 0; i < ts.truthArray.Length; i++)
            {
                _truthArray[i] = !ts.truthArray[i];
            }

            return new TruthColumn(_truthArray, stringDesc);
        }
        public static TruthColumn Evaluate(TruthColumn left, TruthColumn right, char operation)
        {
            if (left.truthArray.Length == right.truthArray.Length)
            {
                bool[] _truthArray = new bool[left.truthArray.Length];
                string stringDesc = $"{left.stringDesc} {operation} {right.stringDesc}";

                for (int i = 0; i < left.truthArray.Length; i++)
                {
                    switch (operation)
                    {
                        case '^':
                            _truthArray[i] = left.truthArray[i] && right.truthArray[i];
                            break;
                        case 'ν':
                            _truthArray[i] = left.truthArray[i] || right.truthArray[i];
                            break;
                        case '~':
                            _truthArray[i] = (left.truthArray[i] && right.truthArray[i]) || (!left.truthArray[i] && !right.truthArray[i]);
                            break;
                        case '→':
                            _truthArray[i] = !left.truthArray[i] || right.truthArray[i];
                            break;
                    }
                }

                return new TruthColumn(_truthArray, stringDesc);

            } else
            {
                throw new Exception("Different truth array length.");
            }
        }
    }
}
