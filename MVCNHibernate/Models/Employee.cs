using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCNHibernate.Models
{
    public class Employee
    {
        public virtual int? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Designation { get; set; }
        public virtual string Role { get; set; }
        public virtual string Gender { get; set; }
        public virtual double Salary { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }
        public virtual string Address { get; set; }
    }
}