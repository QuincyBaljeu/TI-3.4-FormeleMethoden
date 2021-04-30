using System;
using System.Collections.Generic;
using System.Text;

namespace FormeleMethoden.States
{
    class DFAState : State
    {
        private char _charToCheck;

        public DFAState(char charToCheck)
        {
            this._charToCheck = charToCheck;
        }

        public bool check(char incomingChar)
        {
            if (_charToCheck.Equals(incomingChar))
                return true;
            else
                return false;
        }
    }
}
