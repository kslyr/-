using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_2_
{
    public class MessagePub
    {
        public delegate void MessageHand(string message);

        public event MessageHand OnMessageSent;

        public void Send(string message)
        {
            OnMessageSent?.Invoke(message);
        }
    }
}
