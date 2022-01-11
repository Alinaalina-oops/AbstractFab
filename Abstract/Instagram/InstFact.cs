using System;
using System.Collections.Generic;
using System.Text;
using Abstract.BaseManagement;

namespace Abstract.Instagram
{
     public class InstFact : SocialNetFactory
    {
  
        public override Video CreateVideo()
        {
            return new reels();
        }

        public override MainProfile CreateMainProfile()
        {
            return new Profile();
        }

     
        public override Message CreateMessage()
        {
            return new Direct();
        }
    }
}
