//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WirelessMediaZadatak.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Proizvod")]
    public partial class Proizvod
    {
        public int ProizvodId { get; set; }
        public int KategorijaId { get; set; }
        public int ProizvodjacId { get; set; }
        public int DobavljacId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cena { get; set; }
    
        public virtual Dobavljac Dobavljac { get; set; }
        public virtual Kategorija Kategorija { get; set; }
        public virtual Proizvodjac Proizvodjac { get; set; }
    }
}