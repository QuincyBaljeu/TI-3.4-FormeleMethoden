using FormeleMethoden.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormeleMethoden.Finite_Automatons
{
    class DeterministicFiniteAutomaton
    {
        private List<Char> _alphabet;
        private List<DFAState> _states;

        public DeterministicFiniteAutomaton(List<Char> alphabet)
        {
            this._alphabet = alphabet;
        }

        public bool accept(string s)
        {
            if (checkAlphabet(s))
            {
                foreach (char c in s)
                {
                    Console.WriteLine(c);
                }
            }
       
            return false;
        }

        public bool checkAlphabet(string s)
        {
            foreach(char c in s)
            {
                if (!_alphabet.Contains(c))
                {
                    Console.WriteLine("Given string contains chars not in DFA's alphabet");
                    return false;
                }
                    
            }

            return true;
        }

        public void addState(DFAState state)
        {
            _states.Add(state);
        }

    }
}
