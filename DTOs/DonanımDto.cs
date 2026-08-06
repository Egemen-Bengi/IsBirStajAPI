using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsBirStajAPI.DTOs
{
    public class DonanımDto
    {
        public string EN { get; set; } = string.Empty;
        public string? BilgisayarAdi { get; set; }
        public string? Cinsi { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? Durumu { get; set; }
        public string? Kullanicisi { get; set; }
    }
}