using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            juice orangeJuice = new juice("Orange Juice",false,"Made with California Oranges","Oranges");
            juice appleJuice = new juice();

            beer budweiser = new beer("Budweiser",5.0f,"American Classic",true);
            beer becks = new beer();

            soda pepsi = new soda("Pepsi Soda",true,"Live For Now");
            soda sprite = new soda();

            Beverage[] Drinks = new Beverage[6];

            appleJuice.name = "Apple Juice";
            appleJuice.fruit = "Apples";
            appleJuice.description = "Made With Organic Apples";
            appleJuice.carbonated = true;
            if (appleJuice.carbonated = true)
            { appleJuice.description = appleJuice.description + " - Carbonated"; }
            else
            { appleJuice.description = appleJuice.description + " - Non-Carbonated"; }
                       
            becks.name = "Becks Beer";
            becks.alcohol = 5.75f;
            becks.description = "German Favorite";
            becks.carbonated = true;
            if (becks.carbonated = true)
            { becks.description = becks.description + " - Carbonated " + "%" + becks.alcohol + " Alcohol"; }
            else
            { becks.description = becks.description + " - Non-Carbonated " + "%" + becks.alcohol + " Alcohol"; }

            sprite.name = "Sprite Soda";
            sprite.carbonated = true;
            sprite.description="Obey Your Thirst";
            if (sprite.carbonated == true)
            { sprite.description = sprite.description + " - Carbonated"; }
            else
            { sprite.description = sprite.description + " - Non-Carbonated"; }

            Drinks[0] = orangeJuice;
            Drinks[1] = appleJuice;
            Drinks[2] = budweiser;
            Drinks[3] = becks;
            Drinks[4] = pepsi;
            Drinks[5] = sprite;

            string msg = "";
            Console.WriteLine();
            Console.WriteLine("> SmartCop Beverage Menu <");
            for(int i=0; i < Drinks.Length; i++)
            {
                switch(Drinks[i].GetType().Name)
                {
                    case "juice":
                        msg = String.Format("  {0}\t..... {1}", Drinks[i].name,Drinks[i].description);
                        break;
                    case "beer":
                        msg = String.Format("  {0}\t..... {1}", Drinks[i].name, Drinks[i].description);
                        break;
                    case "soda":
                        msg = String.Format("  {0}\t..... {1}", Drinks[i].name, Drinks[i].description);
                        break;
                    default:
                        break;
                }
                Console.WriteLine(msg);
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        }
    }
    public class Beverage
    {
        public string name;
        public Boolean carbonated;
        public string description;
        public Beverage()
        {
            
        }
    }

    class juice : Beverage
    {
        public string fruit;
        public juice()
        {  carbonated = false; }
        public juice(string nm, Boolean cb,string desc,string src)
        {
            name = nm;
            fruit = src;
            if (cb == true)
            { description = desc + " - Carbonated";  }
            else
            { description = desc + " - Non-Carbonated";  }            
        } 
    }

    class beer : Beverage
    {
        public float alcohol;
        public beer()
        {  carbonated = false; }
        public beer(string nm, float ac, string desc,Boolean cb)
        {
            name = nm;
            alcohol = ac;
            carbonated = cb;
            if (cb == true)
            { description = desc + " - Carbonated " + "%" + ac + " Alcohol";}
            else
            { description = desc + " - Non-Carbonated " + "%" + ac + " Alcohol"; }
        }               
    }

    class soda : Beverage
    {
        public soda()
        { carbonated = false; }
        public soda(string nm, Boolean cb,string desc)
        {
            name = nm;
            carbonated = cb;
            if (cb == true)
            { description = desc + " - Carbonated"; }
            else
            { description = desc + " - Non-Carbonated"; }
        }
    }
}
