﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;

public partial class herkansingDBEntities : DbContext
{
    public herkansingDBEntities()
        : base("name=herkansingDBEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public DbSet<Beheerder> Beheerder { get; set; }
    public DbSet<Docent> Docent { get; set; }
    public DbSet<Herkansing> Herkansing { get; set; }
    public DbSet<Inschrijving> Inschrijving { get; set; }
    public DbSet<Lokaal> Lokaal { get; set; }
    public DbSet<Toets> Toets { get; set; }
    public DbSet<Vak> Vak { get; set; }
    public DbSet<Student> Student { get; set; }

    public virtual ObjectResult<GetAllVaks_Result> GetAllVaks()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllVaks_Result>("GetAllVaks");
    }

    public virtual ObjectResult<VerkrijgAlleHerkansingenStudent_Result> VerkrijgAlleHerkansingenStudent(Nullable<int> studentID)
    {
        var studentIDParameter = studentID.HasValue ?
            new ObjectParameter("studentID", studentID) :
            new ObjectParameter("studentID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerkrijgAlleHerkansingenStudent_Result>("VerkrijgAlleHerkansingenStudent", studentIDParameter);
    }
}
