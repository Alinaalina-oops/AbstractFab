using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.VK
{
    public class Account : BaseManagement.MainProfile
    {
        public Account()
        {
            Console.WriteLine("Изменить аккаунт");
        }


        public override void status()
        {
            Console.WriteLine("Выберите статус");
        }


        public override void ProfPic()
        {
            Console.WriteLine("Выберите аватарку");
        }
    }
}
