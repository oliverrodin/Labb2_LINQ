using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Data.Handlers
{
    public class AppHandler : IAppHandler
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Hello World");

            Console.ReadLine();
        }

        private void Menu()
        {

        }
    }
}
