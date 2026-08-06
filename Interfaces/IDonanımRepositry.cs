using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsBirStajAPI.DTOs;
using IsBirStajAPI.DTOs.Response;

namespace IsBirStajAPI.Interfaces
{
    public interface IDonanımRepositry
    {
        Task<Response<DonanımDto?>> GetDonanımByENAsync(string enNo);
    }
}