using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.VK
{
    public class Messenger : BaseManagement.Message
    {
        public Messenger()
        {
            Console.WriteLine("Вк мессенджер-удобное средство для общения с друзьями");
        }


        public override void SentMessage()
        {
            Console.WriteLine("Выберите получателя");
        }


        public override void CreateGroupChat()
        {
            Console.WriteLine("Выберите друзей");
        }
    }
}
