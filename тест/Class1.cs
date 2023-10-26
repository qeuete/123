
using System.Collections.Generic;

namespace mtest
{
    internal class Parametri
    {
        public List<FormaTorta> Items { get; set; }
        public string Name { get; get}
        public int Price { get; get }       
        public Parametri(string Name)
        {
            Nazvanie = Name;
            Price = new List<MenuItem>();
            SelectedIndex = 0;
        }



        internal class Razmer
    {
        public List<Razmer> Items { get; set; }
        public string Name;
        public int Price;
    }
    internal class Nachinka
    {
        public string Name;
        public int Price;
    }
    internal class Yarusi
    {
        public string Name;
        public int Price;
    }
    internal class Pokritie
    {
        public string Name;
        public int Price;
    }
    internal class Dekor
    {
        public string Name;
        public int Price;
    }
}
