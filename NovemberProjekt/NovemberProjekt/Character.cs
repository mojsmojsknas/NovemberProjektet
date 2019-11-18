using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjekt
{
    class Character
    {

        public int hp = 0;

        //ett mellanting mellan en metod och en variabel
        public int Hp
        {
            //get gör basically att man när man anropar den här får ett värde
            //I det här fallet får man värdet på hp
            get
            {
                return hp;
            }
            //set gör typ att man kan utifrån ändra vad variablen har för värde
            //I det här fallet kan man ändra på hp 
            set
            {
                hp = value;
            }

        }



    }
}
