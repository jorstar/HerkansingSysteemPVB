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

    public virtual ObjectResult<GetHerkansingInfo_Result> GetHerkansingInfo(Nullable<int> herkansingsID)
    {
        var herkansingsIDParameter = herkansingsID.HasValue ?
            new ObjectParameter("HerkansingsID", herkansingsID) :
            new ObjectParameter("HerkansingsID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetHerkansingInfo_Result>("GetHerkansingInfo", herkansingsIDParameter);
    }

    public virtual ObjectResult<GetAllAankomendeHerkansingenPlusInfo_Result> GetAllAankomendeHerkansingenPlusInfo()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllAankomendeHerkansingenPlusInfo_Result>("GetAllAankomendeHerkansingenPlusInfo");
    }

    public virtual ObjectResult<GetHerkansingInfoHerk_Result> GetHerkansingInfoHerk(Nullable<int> herkansingID)
    {
        var herkansingIDParameter = herkansingID.HasValue ?
            new ObjectParameter("HerkansingID", herkansingID) :
            new ObjectParameter("HerkansingID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetHerkansingInfoHerk_Result>("GetHerkansingInfoHerk", herkansingIDParameter);
    }

    public virtual ObjectResult<DisplayHerkansingen_Result> DisplayHerkansingen(Nullable<int> studentID)
    {
        var studentIDParameter = studentID.HasValue ?
            new ObjectParameter("studentID", studentID) :
            new ObjectParameter("studentID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DisplayHerkansingen_Result>("DisplayHerkansingen", studentIDParameter);
    }

    public virtual ObjectResult<VerkrijgAlleHerkansingenStudent_Result> VerkrijgAlleHerkansingenStudent(Nullable<int> studentID)
    {
        var studentIDParameter = studentID.HasValue ?
            new ObjectParameter("studentID", studentID) :
            new ObjectParameter("studentID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerkrijgAlleHerkansingenStudent_Result>("VerkrijgAlleHerkansingenStudent", studentIDParameter);
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

    public virtual ObjectResult<string> GetDocentEmail(string docentID)
    {
        var docentIDParameter = docentID != null ?
            new ObjectParameter("DocentID", docentID) :
            new ObjectParameter("DocentID", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetDocentEmail", docentIDParameter);
    }

    public virtual ObjectResult<string> GetSurveillantEmail(string surveillantID)
    {
        var surveillantIDParameter = surveillantID != null ?
            new ObjectParameter("SurveillantID", surveillantID) :
            new ObjectParameter("SurveillantID", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetSurveillantEmail", surveillantIDParameter);
    }

    public virtual ObjectResult<GetAllStudentenHerk_Result1> GetAllStudentenHerk(Nullable<int> herkansingID)
    {
        var herkansingIDParameter = herkansingID.HasValue ?
            new ObjectParameter("HerkansingID", herkansingID) :
            new ObjectParameter("HerkansingID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllStudentenHerk_Result1>("GetAllStudentenHerk", herkansingIDParameter);
    }

    public virtual int UpdateHerkansing(Nullable<int> herkansingID, string lokaal, Nullable<System.DateTime> datum, string surveillant, Nullable<int> toets, Nullable<int> tijdsduur, Nullable<int> plaatsen, Nullable<bool> actief, Nullable<bool> isHetEenKlas, string klasIDofOpleidingsID, string beginTijd)
    {
        var herkansingIDParameter = herkansingID.HasValue ?
            new ObjectParameter("HerkansingID", herkansingID) :
            new ObjectParameter("HerkansingID", typeof(int));

        var lokaalParameter = lokaal != null ?
            new ObjectParameter("Lokaal", lokaal) :
            new ObjectParameter("Lokaal", typeof(string));

        var datumParameter = datum.HasValue ?
            new ObjectParameter("Datum", datum) :
            new ObjectParameter("Datum", typeof(System.DateTime));

        var surveillantParameter = surveillant != null ?
            new ObjectParameter("Surveillant", surveillant) :
            new ObjectParameter("Surveillant", typeof(string));

        var toetsParameter = toets.HasValue ?
            new ObjectParameter("Toets", toets) :
            new ObjectParameter("Toets", typeof(int));

        var tijdsduurParameter = tijdsduur.HasValue ?
            new ObjectParameter("Tijdsduur", tijdsduur) :
            new ObjectParameter("Tijdsduur", typeof(int));

        var plaatsenParameter = plaatsen.HasValue ?
            new ObjectParameter("Plaatsen", plaatsen) :
            new ObjectParameter("Plaatsen", typeof(int));

        var actiefParameter = actief.HasValue ?
            new ObjectParameter("Actief", actief) :
            new ObjectParameter("Actief", typeof(bool));

        var isHetEenKlasParameter = isHetEenKlas.HasValue ?
            new ObjectParameter("IsHetEenKlas", isHetEenKlas) :
            new ObjectParameter("IsHetEenKlas", typeof(bool));

        var klasIDofOpleidingsIDParameter = klasIDofOpleidingsID != null ?
            new ObjectParameter("KlasIDofOpleidingsID", klasIDofOpleidingsID) :
            new ObjectParameter("KlasIDofOpleidingsID", typeof(string));

        var beginTijdParameter = beginTijd != null ?
            new ObjectParameter("BeginTijd", beginTijd) :
            new ObjectParameter("BeginTijd", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateHerkansing", herkansingIDParameter, lokaalParameter, datumParameter, surveillantParameter, toetsParameter, tijdsduurParameter, plaatsenParameter, actiefParameter, isHetEenKlasParameter, klasIDofOpleidingsIDParameter, beginTijdParameter);
    }

    public virtual ObjectResult<VerkrijgAlleHerkansingenDocent_Result> VerkrijgAlleHerkansingenDocent()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerkrijgAlleHerkansingenDocent_Result>("VerkrijgAlleHerkansingenDocent");
    }

    public virtual ObjectResult<VerkrijgBeschikbareHerkansingDocent_Result> VerkrijgBeschikbareHerkansingDocent()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerkrijgBeschikbareHerkansingDocent_Result>("VerkrijgBeschikbareHerkansingDocent");
    }

    public virtual ObjectResult<VerkrijgHistorieHerkansingenDocent_Result> VerkrijgHistorieHerkansingenDocent()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerkrijgHistorieHerkansingenDocent_Result>("VerkrijgHistorieHerkansingenDocent");
    }

    public virtual ObjectResult<DisplayHerkansingenDocent_Result> DisplayHerkansingenDocent()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DisplayHerkansingenDocent_Result>("DisplayHerkansingenDocent");
    }
}
