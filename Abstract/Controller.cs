using System;
using System.Collections.Generic;
using System.Text;
using Abstract.BaseManagement;


namespace Abstract
{
   public class Controller
    {
        SocialNetFactory SocialNet; 
        public Controller(SocialNetFactory SocialNet)
        {
            this.SocialNet = SocialNet;
        }
       
        public void run()
        {            
            Video video = SocialNet.CreateVideo();
            MainProfile mainProfile = SocialNet.CreateMainProfile();
            Message message = SocialNet.CreateMessage();

             // Отдаем им какие-либо команды. 
            video.CuteVideo();
            video.FunnyVideo();
            video.SportVideo();
            mainProfile.status();
            message.SentMessage();
        }
    }
}
