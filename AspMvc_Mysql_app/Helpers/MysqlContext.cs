using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AspMvc_Mysql_app.Models;

namespace AspMvc_Mysql_app.Helpers
{
    public class MysqlContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}
