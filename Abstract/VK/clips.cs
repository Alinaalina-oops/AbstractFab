using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.VK
{

    public class clips : BaseManagement.Video
    {
        public clips()
        {
            Console.WriteLine("Клипы в вк- это короткие видео");
        }


        public override void CuteVideo()
        {
            Console.WriteLine("Котёнок играет с хозяином");
        }


        public override void FunnyVideo()
        {
            Console.WriteLine("Попугай танцует");
        }


        public override void SportVideo()
        {
            Console.WriteLine("Домашняя растяжка");
        }
    }
}
