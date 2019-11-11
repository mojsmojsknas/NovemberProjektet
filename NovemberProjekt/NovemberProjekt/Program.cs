using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjekt
{
    //Jag tänker nog göra något form av gamestate spel
    //Jag har valt att försöka göra någon form av gamestate projekt fast med klasser. Men majoriteten av lektionen har gått åt till att kolla igenom mina tidigare arbeten och uppgiftsbeskrivningen för insperation

    /*2019-11-11 
    Jag har börjat exprimetera lite gran med properties och inkapsling då det värkar najs.
    Primärt i Enemy klassen
    */
    class Program
    {
        static void Main(string[] args)
        {
            
            bool quit = false;


            while (quit == false)
            {
                Enemy e = new Enemy();

                Console.WriteLine(e.Hp);
                Console.ReadKey();




                

            }


            Console.ReadKey();

        }
    }
}
