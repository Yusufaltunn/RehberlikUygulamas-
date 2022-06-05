using MvcPhoneNumber.Models.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RehberlikUygulaması.Models.Context
{
    public class RehberlikContext:DbContext
    {
        public RehberlikContext() : base("server=DESKTOP-KQQVASI;Database=RehberlikUygulamasıDB;Trusted_Connection=true")
        {
            
            
            }


        public DbSet<kisi> kisiler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }

    }
}

