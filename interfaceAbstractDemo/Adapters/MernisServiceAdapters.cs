
using interfaceAbstractDemo.Abstract;
using interfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaceAbstractDemo.MernisServiceReference;

namespace interfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapters : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), 
            customer.LastName.ToUpper(),customer.DateofBirth.Year);

        }
    }
}
