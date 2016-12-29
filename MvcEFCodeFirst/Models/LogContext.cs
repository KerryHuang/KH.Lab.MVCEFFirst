using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcEFCodeFirst.Models
{
    public class LogContext : DbContext
    {
        public LogContext()
            : base("name=DefaultConnection") //連線字串
        {
            // 建立MVC專案
            // NuGet檢查是否有Entity Framework套件
            // 在Models建立Class(Table)
            // 在Models建立Context(DbSet)
            // 在Controllers新增一筆Log
        }
        public DbSet<LogModels> LogModels { get; set; }
    }
}