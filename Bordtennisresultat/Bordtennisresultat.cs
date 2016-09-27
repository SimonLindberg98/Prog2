using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordtennisresultat
{
    class Bordtennisresultat
    {
        int poäng1;
        int poäng2;
        int set1;
        int set2;
        bool vinst1;
        bool vinst2;

        //Konstruktor
        public Bordtennisresultat()
        {
            poäng1 = 0;
            poäng2 = 0;
            set1 = 0;
            set2 = 0;
            vinst1 = false;
            vinst2 = false;
        }

        //Egenskaper 
        public int Poäng1
        {
            get
            {
                return poäng1;
            }
        }

        public int Poäng2
        {
            get
            {
                return poäng2;
            }
        }

        public int Set1
        {
            get
            {
                return set1;
            }
        }

        public int Set2
        {
            get
            {
                return set2;
            }
        }

        public bool Vinst1
        {
            get
            {
                return vinst1;
            }
        }

        public bool Vinst2
        {
            get
            {
                return vinst2;
            }
        }

        //Metoder
        public void GePoäng1()
        {
            poäng1++;
            if(poäng1 >= 11 && (poäng1 - poäng2) >= 2)
            {
                set1++;
                if(set1 == 4)
                {
                    //YOU WIN
                    vinst1 = true;
                    set1 = 0;
                    set2 = 0;
                }
                poäng1 = 0;
                poäng2 = 0;
                
            }
        }

        public void GePoäng2()
        {
            poäng2++;
            if (poäng2 >= 11 && (poäng2 - poäng1) >= 2)
            {
                set2++;
                if (set2 == 4)
                {
                    //YOU WIN
                    vinst2 = true;
                    set1 = 0;
                    set2 = 0;
                }
                poäng1 = 0;
                poäng2 = 0;
                
            }
        }


    }
}
