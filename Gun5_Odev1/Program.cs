using System;

namespace Gun5_Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class GetSetLearn
        {
            public string _Ad;//bu bir fielddir
            public int Id { get; set; }
            public string _Name;
            public string Name // get okur, set değer atar
            { 
                get { return _Name; } 
                set { _Name = value; } 
            }
        } 
    }
}
