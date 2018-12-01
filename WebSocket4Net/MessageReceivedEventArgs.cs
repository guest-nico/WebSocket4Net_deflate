using System;
using System.Collections.Generic;
using System.Text;

namespace WebSocket4Net
{
    public class MessageReceivedEventArgs : EventArgs
    {
    	public MessageReceivedEventArgs(string message, byte[] data)
        {
            Message = message;
            Data = data;
        }

        public string Message { get; private set; }
        public byte[] Data { get; private set; }
    }
}
