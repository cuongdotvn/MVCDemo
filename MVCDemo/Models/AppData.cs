using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class AppData : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Employees.Add(new Employee()
            {
                Name = "ABC",
                Designation = "Manager",
                Department = "Sales"
            });
            base.Seed(context);
        }
    }
}