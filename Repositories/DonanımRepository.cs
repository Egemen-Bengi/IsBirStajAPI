using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsBirStajAPI.Data;
using IsBirStajAPI.DTOs;
using IsBirStajAPI.DTOs.Response;
using IsBirStajAPI.Interfaces;
using IsBirStajAPI.Mappers;
using Microsoft.EntityFrameworkCore;

namespace IsBirStajAPI.Repositories
{
    public class DonanımRepository: IDonanımRepositry
    {
        private readonly EnvanterContext _context;
        public DonanımRepository(EnvanterContext context)
        {
            _context = context;
        }

        public async Task<Response<DonanımDto?>> GetDonanımByENAsync(string enNo)
        {
            var cihaz = await _context.Donanimlar.FirstOrDefaultAsync(d => d.EN.Trim() == enNo.Trim());
            
            if(cihaz == null)
            {
                return Response<DonanımDto?>.Fail("Aranan cihaz bulunamadı");  
            } 

            var cihazData = cihaz.ToDonanımDto();
            return Response<DonanımDto?>.Successful(cihazData);
        }

        public async Task<Response<bool>> UpdateKullaniciVeyaDurumAsync(string enNo, DonanımUpdateDto updateDto)
        {
            var cihaz = await _context.Donanimlar.FirstOrDefaultAsync(d => d.EN.Trim() == enNo.Trim());
            
            if(cihaz == null)
            {
                return Response<bool>.Fail("Güncellenmek istenen cihaz bulunamadı");
            }

            if (string.IsNullOrWhiteSpace(updateDto.Kullanici))
            {
                cihaz.Kullanicisi = updateDto.Kullanici;
            }
            if (string.IsNullOrWhiteSpace(updateDto.Durum))
            {
                cihaz.Durumu = updateDto.Durum;
            }
            _context.Donanimlar.Update(cihaz);
            await _context.SaveChangesAsync();

            return Response<bool>.Successful("Cihaz bilgileri güncellendi");
        }
    }
}