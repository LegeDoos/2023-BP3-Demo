using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGithub
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // data access methods
        public void CreateData()
        {
            DAL dal = new DAL();
            dal.CreateCustomer(this);
        }
    }
}
