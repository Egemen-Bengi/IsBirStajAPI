using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsBirStajAPI.DTOs;
using IsBirStajAPI.Models;

namespace IsBirStajAPI.Mappers
{
    public static class DonanımMapper
    {
        public static DonanımDto ToDonanımDto(this DonanımCihazı cihaz)
        {
            return new DonanımDto
            {
                EN = cihaz.EN,
                BilgisayarAdi = cihaz.BilgisayarAdi,
                Cinsi = cihaz.Cinsi,
                Marka = cihaz.Marka,
                Model = cihaz.Model,
                Durumu = cihaz.Durumu,
                Kullanicisi = cihaz.Kullanicisi
            };
        }
    }
}