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
    /*2019-11-12
    Jag har mest läst på mer om det jag var osäker på och försökt samla mina tankar om 
    vad exakt det är jag ska göra för sorts projekt. Jag har kännt mig lite osäker på 
    klasser och speciellt arv och jag tror att jag kommer att kunna ha stor nytta av 
    just arv till projektet. Jag kommer nog vara tvungen att programera hemma :( eller
    göra ett mindre projekt än vad jag tänkt mig. Vi får se
    */
    //använd virtual override på lvl 
    /*2019-11-18
     Börjat slänga in alla de klasser jag vill ha och hur jag vill ha dom. Med andra
     ord vilka som är bas- och subklasser. 
    */
    
    class Program
    {
        static void Main(string[] args)
        {
            //så man kan avsluta spelet 
            bool quit = false;


            while (quit == false)
            {
                
                //skapar en enemy
                Enemy e = new Enemy();
                //hämtar get från Hp och skriver ut det 
                Console.WriteLine(e.Hp);
                Console.ReadKey();




                

            }


            Console.ReadKey();

        }
    }
}
