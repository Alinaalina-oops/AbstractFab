using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.BaseManagement
{
    public abstract class SocialNetFactory
    {
        public abstract Video CreateVideo();


        public abstract MainProfile CreateMainProfile();


        public abstract Message CreateMessage();
    }
}
