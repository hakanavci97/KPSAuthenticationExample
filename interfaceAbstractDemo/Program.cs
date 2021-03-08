using interfaceAbstractDemo.Abstract;
using interfaceAbstractDemo.Adapters;
using interfaceAbstractDemo.Concrete;
using interfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapters());
            customerManager.Save(new Customer {DateofBirth=new DateTime(1997,3,21),FirstName="Hakan",LastName="Avci",NationalityId="11111111111" });
            Console.ReadLine();
        }
    }
}
