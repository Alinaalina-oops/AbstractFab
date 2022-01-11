using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Instagram
{

    public class Direct : BaseManagement.Message
    {
        public Direct()
        {
            Console.WriteLine("Direct is an instagram messenger");
        }


        public override void SentMessage()
        {
            Console.WriteLine("Choose a recipient");
        }


        public override void CreateGroupChat()
        {
            Console.WriteLine("Choose your friends");
        }
    }
 }
