using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Classes
{
    public class SenderClass
    {
        public SenderClass()
        {
            
        }

        public CustomMessageClass CustomMessage { get; set; }

        public void SendTextMessage(string message)
        {
            Messenger.Default.Send(new NotificationMessage(message));
        }

        public void SendCustomMessage(int code, string message)
        {
            CustomMessage = new CustomMessageClass(code, message);
            Messenger.Default.Send(CustomMessage);
        }
    }
}