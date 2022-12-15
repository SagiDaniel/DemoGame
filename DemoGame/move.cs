using System;
using System.Data;
using System.Xml.XPath;
using DemoGame;
namespace DemoGame
{
    public class move
    {
        public string harc = "_X___I_";
        public void moving()
        {
            
            string mozgastipus;
            Console.WriteLine(harc);
            Console.WriteLine("A pálya");
            Console.WriteLine("Te vagy az X, az ellenfél az I");
            do
            {
                Console.WriteLine("Adja meg mit szeretne csinalni(lépés, támadás, gyógyítás):");
                mozgastipus= Console.ReadLine().ToLower();
                
            } while (true);

        }
    }
}