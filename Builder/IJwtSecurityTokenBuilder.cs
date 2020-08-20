using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Builder
{
    public interface IJwtSecurityTokenBuilder
    {
        JwtSecurityToken Build();
        string Issuer { get; set; }
        string Audience { get; set; }
        void AddClaims(Claim claim);
        DateTime? ActivationDate { get; set; }
        DateTime? ExpirationDate { get; set; }
        SigningCredentials SigningCredentials { get; set; }
    }
}
