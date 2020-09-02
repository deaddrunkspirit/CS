using System;
using System.Collections.Generic;
using System.Text;

namespace SRVar1Lib
{
    public class ElectoralComission
    {
        public event EventHandler<VoteEventArgs> OnVote;

        public VoteEventArgs Vote(string Question)
        {
        }
    }
}