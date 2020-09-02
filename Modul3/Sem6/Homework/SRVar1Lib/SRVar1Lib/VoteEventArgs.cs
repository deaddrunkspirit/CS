using System;

namespace SRVar1Lib
{
    public class VoteEventArgs : EventArgs
    {
        public string Question { get; set; }

        public int VoteFor { get; set; }

        public int VoteAgainst { get; set; }

        public int VoteAbstained { get; set; }
    }
}