using System;
using System.Collections.Generic;
using System.Text;
using Abstract.BaseManagement;

namespace Abstract.VK
{
        public class VkFact : SocialNetFactory
        {

            public override Video CreateVideo()
            {
                return new clips();
            }

            public override MainProfile CreateMainProfile()
            {
                return new Account();
            }


            public override Message CreateMessage()
            {
                return new Messenger();
            }
       
    }
}
