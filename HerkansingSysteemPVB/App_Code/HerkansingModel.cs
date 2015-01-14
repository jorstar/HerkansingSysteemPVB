﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Beheerder
{
    public string Gebruikersnaam { get; set; }
    public string Roepnaam { get; set; }
    public string Tussenvoegsel { get; set; }
    public string Achternaam { get; set; }
    public string Wachtwoord { get; set; }
}

public partial class Docent
{
    public Docent()
    {
        this.Herkansing = new HashSet<Herkansing>();
        this.Herkansing1 = new HashSet<Herkansing>();
    }

    public string DocentID { get; set; }
    public string Roepnaam { get; set; }
    public string Tussenvoegsel { get; set; }
    public string Achternaam { get; set; }
    public string Email { get; set; }
    public string Wachtwoord { get; set; }

    public virtual ICollection<Herkansing> Herkansing { get; set; }
    public virtual ICollection<Herkansing> Herkansing1 { get; set; }
}

public partial class Herkansing
{
    public Herkansing()
    {
        this.Inschrijving = new HashSet<Inschrijving>();
    }

    public int HerkansingID { get; set; }
    public string Lokaal { get; set; }
    public string Docent { get; set; }
    public System.DateTime Datum { get; set; }
    public string Surveillant { get; set; }
    public int Toets { get; set; }
    public int Tijdsduur { get; set; }
    public int Plaatsen { get; set; }
    public bool Actief { get; set; }
    public bool IsHetEenKlas { get; set; }
    public string KlasIDofOpleidingsID { get; set; }
    public string BeginTijd { get; set; }

    public virtual Docent Docent1 { get; set; }
    public virtual Docent Docent2 { get; set; }
    public virtual Lokaal Lokaal1 { get; set; }
    public virtual Toets Toets1 { get; set; }
    public virtual ICollection<Inschrijving> Inschrijving { get; set; }
}

public partial class Inschrijving
{
    public string StudentID { get; set; }
    public int HerkansingID { get; set; }
    public string BevestigingsID { get; set; }
    public bool Bevestigd { get; set; }

    public virtual Herkansing Herkansing { get; set; }
    public virtual Student Student { get; set; }
}

public partial class Lokaal
{
    public Lokaal()
    {
        this.Herkansing = new HashSet<Herkansing>();
    }

    public string LokaalNr { get; set; }
    public int AantalPlaatsen { get; set; }

    public virtual ICollection<Herkansing> Herkansing { get; set; }
}

public partial class Student
{
    public Student()
    {
        this.Inschrijving = new HashSet<Inschrijving>();
    }

    public string LRL_NR { get; set; }
    public string KLAS { get; set; }
    public string ROEPNAAM { get; set; }
    public string TUSSENV { get; set; }
    public string ACHTERNAM { get; set; }
    public string OPLEIDING { get; set; }
    public string EMAIL { get; set; }
    public System.DateTime GEBOORTEDATUM { get; set; }
    public string WACHTWOORD { get; set; }

    public virtual ICollection<Inschrijving> Inschrijving { get; set; }
}

public partial class Toets
{
    public Toets()
    {
        this.Herkansing = new HashSet<Herkansing>();
    }

    public int ToetsID { get; set; }
    public string ToetsNaam { get; set; }
    public string ToetsDescriptie { get; set; }
    public int Vak { get; set; }

    public virtual ICollection<Herkansing> Herkansing { get; set; }
    public virtual Vak Vak1 { get; set; }
}

public partial class Vak
{
    public Vak()
    {
        this.Toets = new HashSet<Toets>();
    }

    public int VakID { get; set; }
    public string VakNaam { get; set; }
    public string VakDescriptie { get; set; }

    public virtual ICollection<Toets> Toets { get; set; }
}

public partial class DisplayHerkansingen_Result
{
    public Nullable<int> HerkansingID { get; set; }
    public string Vak { get; set; }
    public string Toets { get; set; }
    public string Datum { get; set; }
}

public partial class GetAllAankomendeHerkansingenPlusInfo_Result
{
    public Nullable<int> HerkansingID { get; set; }
    public Nullable<int> ToetsID { get; set; }
    public Nullable<System.DateTime> Datum { get; set; }
    public string BeginTijd { get; set; }
    public Nullable<int> Tijdsduur { get; set; }
    public string Surveillant { get; set; }
    public Nullable<bool> IsHetEenKlas { get; set; }
    public string KlasIDofOpleidingsID { get; set; }
    public Nullable<int> Plaatsen { get; set; }
    public string Lokaal { get; set; }
}

public partial class GetAllStudentenHerk_Result
{
    public string Studentcode { get; set; }
    public string Naam { get; set; }
    public string KLAS { get; set; }
    public string OPLEIDING { get; set; }
}

public partial class GetAllSurveillance_Result
{
    public string DocentID { get; set; }
    public string DocentInfo { get; set; }
}

public partial class GetAllToets_Result
{
    public int toetsID { get; set; }
    public string toetsNaam { get; set; }
}

public partial class GetAllVaks_Result
{
    public int VakID { get; set; }
    public string VakNaam { get; set; }
}

public partial class GetHerkansingInfo_Result
{
    public int HerkansingID { get; set; }
    public string Lokaal { get; set; }
    public string Docent { get; set; }
    public System.DateTime Datum { get; set; }
    public string Surveillant { get; set; }
    public int Toets { get; set; }
    public int Tijdsduur { get; set; }
    public int Plaatsen { get; set; }
    public bool Actief { get; set; }
    public bool IsHetEenKlas { get; set; }
    public string KlasIDofOpleidingsID { get; set; }
    public string BeginTijd { get; set; }
}

public partial class GetHerkansingInfoHerk_Result
{
    public string Toetsnaam { get; set; }
    public int ToetsID { get; set; }
    public string VakNaam { get; set; }
    public string ToetsDescriptie { get; set; }
    public string Datum { get; set; }
    public string BeginTijd { get; set; }
    public int Tijdsduur { get; set; }
    public string KlasIDofOpleidingsID { get; set; }
    public string Lokaal { get; set; }
    public string Surveillant { get; set; }
}

public partial class GetToetsInfo_Result
{
    public Nullable<int> ToetsID { get; set; }
    public string ToetsNaam { get; set; }
    public string ToetsDescriptie { get; set; }
    public string VakNaam { get; set; }
}

public partial class LoginBeheer_Result
{
    public string Gebruikersnaam { get; set; }
    public string Roepnaam { get; set; }
    public string Tussenvoegsel { get; set; }
    public string Achternaam { get; set; }
    public string Wachtwoord { get; set; }
}

public partial class VerkrijgAlleHerkansingenStudent_Result
{
    public Nullable<int> HerkansingID { get; set; }
    public string Datum { get; set; }
    public string Lokaal { get; set; }
    public Nullable<int> toetsId { get; set; }
    public Nullable<int> Lengte_van_toets { get; set; }
    public string Starttijd { get; set; }
    public string Vak { get; set; }
    public string Toets { get; set; }
}

public partial class VerkrijgBeschikbareHerkansingStudent_Result
{
    public Nullable<int> HerkansingID { get; set; }
    public string Datum { get; set; }
    public string Lokaal { get; set; }
    public Nullable<int> Toets { get; set; }
    public Nullable<int> Tijdsduur { get; set; }
    public string VakNaam { get; set; }
    public string ToetsNaam { get; set; }
}

public partial class VerkrijgHistorieHerkansingenStudent_Result
{
    public Nullable<int> HerkansingID { get; set; }
    public string Datum { get; set; }
    public string Lokaal { get; set; }
    public Nullable<int> Toets { get; set; }
    public Nullable<int> Lengte_van_toets { get; set; }
    public string Starttijd { get; set; }
    public string Vak { get; set; }
    public string Toets1 { get; set; }
}
