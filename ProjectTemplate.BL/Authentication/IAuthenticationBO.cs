﻿using ProjectTemplate.Domain.DTO.Authentication;
using System.Threading.Tasks;

namespace ProjectTemplate.BL.Authentication
{
    public interface IAuthenticationBO
    {
        Task<ResultLoginDTO> Login(AuthenticationDTO login);
        Task<ResultLoginDTO> ChangePassword(string email);
        Task<ResultLoginDTO> VerifyLinkChangePassword(string hash);
        Task<bool> UpdatePassword(string hash, string password);
    }
}
