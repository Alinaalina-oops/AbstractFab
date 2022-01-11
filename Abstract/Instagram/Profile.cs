using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Instagram
{
 
    public class Profile : BaseManagement.MainProfile
    {
        public Profile()
        {
            Console.WriteLine("Edit your profile");
        }


        public override void status()
        {
            Console.WriteLine("Choose your status");
        }


        public override void ProfPic()
        {
            Console.WriteLine("Choose your friends");
        }
    }
}
