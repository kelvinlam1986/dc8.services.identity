﻿using Dc8.Services.Identity.Application.DTO;
using System;
using System.Threading.Tasks;

namespace Dc8.Services.Identity.Application.Services
{
    public interface IRefreshTokenService
    {
        Task<string> CreateAsync(Guid userId);
        Task RevokeAsync(string refreshToken);
        Task<AuthDto> UseAsync(string refreshToken);
    }
}
