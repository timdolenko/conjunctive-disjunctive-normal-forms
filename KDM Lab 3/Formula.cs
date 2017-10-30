using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDM_Lab_3
{
    public class Formula
    {
        //Negation !
        //disjunction ||
        //conjunction &&
        //equals =
        //->
        //! ν ^ = →

        List<TruthColumn> _truthTable;

        public List<TruthColumn> truthTable
        {
            get
            {
                return _truthTable;
            }
        }

        public string formulaString;
        public string reversePolishNotationFormulaString;

        public Formula(string formulaString)
        {
            this.formulaString = formulaString;
            this.reversePolishNotationFormulaString = Converter.Convert(formulaString);
            _truthTable = Converter.Evaluate(reversePolishNotationFormulaString);
        }

        public string principalDisjunctiveNormalForm
        {
            get
            {
                string str = "";
                for(int i = 0; i < truthTable.Last().truthArray.Length; i++)
                {
                    if (truthTable.Last().truthArray[i])
                    {
                        string subStr = "";
                        for(int j = 0; j < 3; j++)
                        {
                            if (truthTable[j].stringDesc.Length == 1)
                            {
                                subStr += truthTable[j].truthArray[i] ? truthTable[j].stringDesc : "!" + truthTable[j].stringDesc;
                            }
                        }
                        str += str.Length == 0 ? subStr : "ν" + subStr;
                    }
                }
                return str;
            }
        }

        public string principalConjunctiveNormalForm
        {
            get
            {
                string str = "";
                for (int i = 0; i < truthTable.Last().truthArray.Length; i++)
                {
                    if (!truthTable.Last().truthArray[i])
                    {
                        string subStr = "(";
                        for (int j = 0; j < 3; j++)
                        {
                            if (truthTable[j].stringDesc.Length == 1)
                            {
                                subStr += subStr.Length == 1 ? "" : "ν";
                                subStr += !truthTable[j].truthArray[i] ? truthTable[j].stringDesc : "!" + truthTable[j].stringDesc;
                            }
                        }
                        subStr += ")";
                        str += subStr;
                    }
                }
                return str;
            }
        }
    }
}
