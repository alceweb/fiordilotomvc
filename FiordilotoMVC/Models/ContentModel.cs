using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FiordilotoMVC.Models
{
    public class ContentModel
    {
    }

    public class Eventi
    {
        [Key]
        public int Evento_Id { get; set; }
        [Display(Name ="Vendita")]
        public bool Vendita { get; set; }
        [Display(Name ="Didattica")]
        public bool Didattica { get; set; }
        [Display(Name ="Corso")]
        public bool Corso { get; set; }
        [Display(Name ="Titolo")]
        public string Titolo { get; set; }
        [Display(Name ="Descrizione breve")]
        public string DescrizioneB { get; set; }
        [Display(Name ="Descrizione")]
        public string Descrizione { get; set; }
        [Display(Name ="Regia")]
        public string Regia { get; set; }
        [Display(Name ="In evidenza")]
        public bool Evidenza { get; set; }
        [Display(Name = "Counseling")]
        public bool Counseling { get; set; }
        [Display(Name ="Credits")]
        public bool Credits { get; set; }
        [Display(Name ="Scritti&Opinioni")]
        public bool Casa { get; set; }
        [Display(Name = "Data evento")]
        [DataType(DataType.Date)]
        [DefaultValue("01/01/2000")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Data { get; set; }
        [Display(Name ="Partecipazioni")]
        public string Partecipazioni { get; set; }
        [Display(Name ="Archivio")]
        public bool Archivio { get; set; }
        [Display(Name = "Posizione")]
        public int Posizione { get; set; }
        [Display(Name ="Città")]
        public string Città { get; set; }
    }

}