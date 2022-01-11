using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
          // Создаем классы-контроллеры, работающие с соответствующими фабриками
			Controller hcotn = new Controller(new VK.VkFact());
			Controller ocotn = new Controller(new Instagram.InstFact());

			Console.WriteLine("ВК:");
			hcotn.run();
            Console.WriteLine();
            Console.WriteLine("Инстаграм:");
			ocotn.run();

			Console.Read();
        }
    }
}
