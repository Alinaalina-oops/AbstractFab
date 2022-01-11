using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Instagram
{
    public class reels : BaseManagement.Video
    {
        public reels()
        {
            Console.WriteLine("Reels are short videos on the instagram");
        }

      
        public override void CuteVideo()
        {
            Console.WriteLine("Little kitten playing with a ball");
        }

    
        public override void FunnyVideo()
        {
            Console.WriteLine("Our dog barks at his reflection");
        }


        public override void SportVideo()
        {
            Console.WriteLine("Abs+stretching at home");
        }
    }
}
