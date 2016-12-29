using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFCodeFirst
{
    public class CustomerContext : DbContext
    {
        // 建立MVC專案
        // NuGet檢查是否有Entity Framework套件
        // 在Models建立Class(Table)
        // 在Models建立Context(DbSet)
        // 在Controllers新增一筆Log

        public DbSet<Customer> ClientBasics { get; set; }
    }
}
