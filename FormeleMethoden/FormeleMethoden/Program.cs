using FormeleMethoden.Finite_Automatons;
using System;
using System.Collections.Generic;

namespace FormeleMethoden
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                List<Char> alphabet = new List<char> { 'a', 'b' };

                DeterministicFiniteAutomaton dfa = new DeterministicFiniteAutomaton(alphabet);

                string s = Console.ReadLine();

                dfa.accept(s);
            }
        }
    }
}
