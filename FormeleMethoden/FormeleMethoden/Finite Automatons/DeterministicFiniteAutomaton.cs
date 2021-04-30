using FormeleMethoden.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormeleMethoden.Finite_Automatons
{
    class DeterministicFiniteAutomaton
    {
        private List<Char> _alphabet;
        private List<State> _states;

        public DeterministicFiniteAutomaton(List<Char> alphabet, List<State> states)
        {
            this._alphabet = alphabet;
            this._states = states;
        }

        public bool accept(string s)
        {
            if (checkAlphabet(s))
            {
                foreach(State state in _states)
                {
                

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
