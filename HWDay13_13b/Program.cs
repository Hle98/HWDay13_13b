using System;
using System.Collections.Generic;

namespace HWDay13_13b
{
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new List<string> { "H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne", "Na", "Mg", "Al", "Si", "P", "S", "Cl", "Ar", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Kr", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Tc", "Ru", "Rh", "Pd", "Ag", "Cd", "In", "Sn", "Sb", "Te", "I", "Xe", "Cs", "Ba", "La", "Ce", "Pr", "Nd", "Pm", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er", "Tm", "Yb", "Lu", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "TI", "Pb", "Bi", "Po", "At", "Rn", "Fr", "Ra", "Ac", "Th", "Pa", "U", "Np", "Pu", "Am", "Cm", "Bk", "Cf", "Es", "Fm", "Md", "No", "Lr", "Rf", "Db", "Sg", "Bh", "Hs", "Mt", "Ds", "Rg", "Cn", "Nh", "FI", "Mc", "Lv", "Ts", "Og"};
            Spelling(ls, "frenchfries");
        }
        static void Spelling(List<string> ls, string word)
        {
            var result = new Stack<string>();
            if (Spelling(ls, word, result))
            {
                Console.Write($"Yes, {word} can be spelled out using element symbols.");
            }
            else
            {
                Console.Write($"No, {word} can't be spelled out using element symbols.");
            }
        }
        static bool Spelling(List<string>ls, string word, Stack<string> result)
        {
            if (word.Length == 0)
            {
                return true;
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (i != 0)
                {
                    if (ls.Contains(UppercaseFirstLetter(word[i - 1].ToString()) + word[i]))
                    {
                        result.Push(word[i].ToString());
                        result.Push(word[i - 1].ToString());
                        if (Spelling(ls, word.Substring(i+1), result))
                        {
                            return true;
                        }
                        result.Pop();
                    }
                    return false;
                }
                else if (ls.Contains(UppercaseFirstLetter(word[i].ToString())))
                {
                    result.Push(word[i].ToString());
                    if (Spelling(ls, word.Substring(i + 1), result))
                    {
                        return true;
                    }
                    result.Pop();
                }
            }
            return false;
        }
        static string UppercaseFirstLetter(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
                    
                        
                
                
                
               
            
