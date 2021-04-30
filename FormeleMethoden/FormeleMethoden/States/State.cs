using System;
using System.Collections.Generic;
using System.Text;

namespace FormeleMethoden.States
{
    abstract class State
    {
        public abstract bool check(char incomingChar);
    }
}
