using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsBirStajAPI.Models
{
    public class DonanımCihazı
    {
        public int Id { get; set; } 
        public string EN { get; set; } = string.Empty; 
        public string? BilgisayarAdi { get; set; }
        public string? Cinsi { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? SeriNo { get; set; }
        public string? Aciklama { get; set; }
        public string? SaticiFirma { get; set; }
        public string? FaturaTarihi { get; set; }
        public string? FaturaNo { get; set; }
        public string? GarantiSuresiYil { get; set; }
        public string? GarantiBitisTarihi { get; set; }
        public string? Durumu { get; set; }
        public string? EnvanterdenCikmaTarihi { get; set; }
        public string? Kullanicisi { get; set; }
        public string? Sorumlu { get; set; }
    }
}