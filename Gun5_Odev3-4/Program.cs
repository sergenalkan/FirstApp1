using System;

namespace Gun5_Odev3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //Abstract Sınıfların nesnesi oluşturalamaz, referans noktası alınabilir.
    //virtual(base)-override(derive)
    //kalıtım
    //poliformizim : her erkek insandır ama her insan erkek değildir

    //interfacelerde void(imzalarda) public, private, protected gibi erişim belirleyicileri olmaz
    //abstraclarda olur
    abstract class MyClass
    {
        //public void X() { }
        //public int MyProperty { get; set; }
        //private int myVar;

        //public int MyProperty2
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public abstract void X();
        abstract public int MyProperty { get; set; }
    }

    abstract class Ornek
    {
        abstract public void X();
        abstract public int Y { get; set; }
        public abstract bool Z();
        public void W() { }

    }

    class Calisma : Ornek
    {
        public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void X()
        {
            throw new NotImplementedException();
        }
        public override bool Z()
        {
            throw new NotImplementedException();
        }
    }
}
