using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Classes
{
    public class ReceiverClass
    {
        public ReceiverClass()
        {
            Messenger.Default.Register<NotificationMessage>(this, (message) =>
            {
                if (message.Notification == "MessageType1")
                    Method1();
            });

            Messenger.Default.Register<CustomMessageClass>(this, x => { Method2(x); });
        }

        public string Message { get; set; }
        public int Code { get; set; }

        public void Method1()
        {
            System.Windows.MessageBox.Show("MessageType1 has arrived from SenderClass");
        }

        public void Method2(CustomMessageClass customMessage)
        {
            Message = customMessage.Message;
            Code = customMessage.Code;
            System.Windows.MessageBox.Show($"Message: {Message}, Code: {Code} has arrived from SenderClass");
        }
    }
}