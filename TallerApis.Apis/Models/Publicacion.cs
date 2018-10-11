using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerApis.Apis.Models
{
    public class Publicacion : DbContext
    {
       public Publicacion() : base("PublicacionConnection")
        {

        }
        public DbSet<tblpublicacion> Publicaciones { get; set; }
    }
}