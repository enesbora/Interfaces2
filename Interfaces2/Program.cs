using System;

namespace Interfaces2
{
    class Program
    {
        //interface new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();

            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }

    //inherits - class  -------------- implments - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müsteri ekleme kodlari
            Console.WriteLine("Müsteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müsteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //calisan ekleme kodlari
            Console.WriteLine("Calisan eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Calisan güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

    }
}
