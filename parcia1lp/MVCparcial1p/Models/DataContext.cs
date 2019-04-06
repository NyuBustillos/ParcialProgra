using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCparcial1p.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
        public System.Data.Entity.DbSet<MVCparcial1p.Models.AdrianaBustillosFriend> AdrianaBustillosFriendss { get; set; }
    }

}