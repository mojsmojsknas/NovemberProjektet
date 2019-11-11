using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjekt
{
    
    class Enemy
    {
        public int hp = 0;

        //ett mellanting mellan en metod och en variabel
        public int Hp
        {
            //get set gör att man kan lägga till mer logik och ger en mer redigerings möjligheter
            
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }

        }





    }
}
