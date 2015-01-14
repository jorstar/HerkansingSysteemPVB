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
    public DbSet<Student> Student { get; set; }
    public DbSet<Toets> Toets { get; set; }
    public DbSet<Vak> Vak { get; set; }

    public virtual ObjectResult<GetAllSurveillance_Result> GetAllSurveillance()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllSurveillance_Result>("GetAllSurveillance");
    }

    public virtual ObjectResult<GetAllToets_Result> GetAllToets()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllToets_Result>("GetAllToets");
    }

    public virtual ObjectResult<GetAllVaks_Result> GetAllVaks()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllVaks_Result>("GetAllVaks");
    }

    public virtual ObjectResult<LoginBeheer_Result> LoginBeheer(string username, string password)
    {
        var usernameParameter = username != null ?
            new ObjectParameter("Username", username) :
            new ObjectParameter("Username", typeof(string));

        var passwordParameter = password != null ?
            new ObjectParameter("Password", password) :
            new ObjectParameter("Password", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoginBeheer_Result>("LoginBeheer", usernameParameter, passwordParameter);
    }

    public virtual ObjectResult<string> LoginDocent(string username, string password)
    {
        var usernameParameter = username != null ?
            new ObjectParameter("Username", username) :
            new ObjectParameter("Username", typeof(string));

        var passwordParameter = password != null ?
            new ObjectParameter("Password", password) :
            new ObjectParameter("Password", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LoginDocent", usernameParameter, passwordParameter);
    }

    public virtual ObjectResult<string> LoginStudent(string username, string password)
    {
        var usernameParameter = username != null ?
            new ObjectParameter("Username", username) :
            new ObjectParameter("Username", typeof(string));

        var passwordParameter = password != null ?
            new ObjectParameter("Password", password) :
            new ObjectParameter("Password", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LoginStudent", usernameParameter, passwordParameter);
    }

    public virtual ObjectResult<VerkrijgAlleHerkansingenStudent_Result> VerkrijgAlleHerkansingenStudent(Nullable<int> studentID)
    {
        var studentIDParameter = studentID.HasValue ?
            new ObjectParameter("studentID", studentID) :
            new ObjectParameter("studentID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerkrijgAlleHerkansingenStudent_Result>("VerkrijgAlleHerkansingenStudent", studentIDParameter);
    }

    public virtual ObjectResult<string> GetAllklassen()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetAllklassen");
    }

    public virtual ObjectResult<string> GetAllopleidingen()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetAllopleidingen");
    }

    public virtual ObjectResult<string> GetAllLokalen()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetAllLokalen");
    }

    public virtual ObjectResult<GetToetsInfo_Result> GetToetsInfo(Nullable<int> toetsID)
    {
        var toetsIDParameter = toetsID.HasValue ?
            new ObjectParameter("ToetsID", toetsID) :
            new ObjectParameter("ToetsID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetToetsInfo_Result>("GetToetsInfo", toetsIDParameter);
    }

    public virtual ObjectResult<VerkrijgBeschikbareHerkansingStudent_Result> VerkrijgBeschikbareHerkansingStudent(Nullable<int> studentID)
    {
        var studentIDParameter = studentID.HasValue ?
            new ObjectParameter("studentID", studentID) :
            new ObjectParameter("studentID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerkrijgBeschikbareHerkansingStudent_Result>("VerkrijgBeschikbareHerkansingStudent", studentIDParameter);
    }

    public virtual ObjectResult<VerkrijgHistorieHerkansingenStudent_Result> VerkrijgHistorieHerkansingenStudent(Nullable<int> studentID)
    {
        var studentIDParameter = studentID.HasValue ?
            new ObjectParameter("studentID", studentID) :
            new ObjectParameter("studentID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerkrijgHistorieHerkansingenStudent_Result>("VerkrijgHistorieHerkansingenStudent", studentIDParameter);
    }

    public virtual ObjectResult<GetHerkansingInfo_Result> GetHerkansingInfo(Nullable<int> herkansingsID)
    {
        var herkansingsIDParameter = herkansingsID.HasValue ?
            new ObjectParameter("HerkansingsID", herkansingsID) :
            new ObjectParameter("HerkansingsID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetHerkansingInfo_Result>("GetHerkansingInfo", herkansingsIDParameter);
    }

    public virtual ObjectResult<DisplayHerkansingen_Result> DisplayHerkansingen(Nullable<int> studentID)
    {
        var studentIDParameter = studentID.HasValue ?
            new ObjectParameter("studentID", studentID) :
            new ObjectParameter("studentID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DisplayHerkansingen_Result>("DisplayHerkansingen", studentIDParameter);
    }

    public virtual ObjectResult<GetAllAankomendeHerkansingenPlusInfo_Result> GetAllAankomendeHerkansingenPlusInfo()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllAankomendeHerkansingenPlusInfo_Result>("GetAllAankomendeHerkansingenPlusInfo");
    }
}
