//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace toyzshop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dataveriEntities3 : DbContext
    {
        public dataveriEntities3()
            : base("name=dataveriEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AlinanUrun> AlinanUrun { get; set; }
        public virtual DbSet<Duyuru> Duyuru { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciYntm> KullaniciYntm { get; set; }
        public virtual DbSet<SatilanUrun> SatilanUrun { get; set; }
    }
}
