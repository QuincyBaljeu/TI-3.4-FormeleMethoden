using FormeleMethoden.Finite_Automatons;
using FormeleMethoden.States;
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

                List<State> states = new List<State> { new DFAState('b'), new DFAState('a'), new DFAState('b') };

                DeterministicFiniteAutomaton dfa = new DeterministicFiniteAutomaton(alphabet, states);

                string s = Console.ReadLine();


                dfa.accept(s);
            }
        }
    }
}
