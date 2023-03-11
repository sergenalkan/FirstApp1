using System;

namespace Gun5_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Interface newlenemez
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()

            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            //IPersonManager personManager = new CustomerManager1();
            //IPersonManager personManager1 = new EmployeeManager();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager1());
        }
        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }
        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer { Id = 1, FirstName = "Ediz", LastName = "Alkan", Address = "İstanbul" };
            Student student = new Student { Id = 1, FirstName = "Sercan", LastName = "Alkan", Deparmant = "Market" };
            manager.Add(student);
            manager.Add(customer);
        }
    }

    //implemented operation : içi doldurulmuş, implente edilmiş | Normal Class ve inherit
    //implemented operation : içi boş, her üyede imzam değişir

    interface IPersonManager
    {
        void Add();
        void Update();

    }

    class CustomerManager1 : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Deparmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Deparmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
