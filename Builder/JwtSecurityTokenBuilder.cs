using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Builder
{
    public class JwtSecurityTokenBuilder : IJwtSecurityTokenBuilder
    {
        private IList<Claim> claims = new List<Claim>();

        public string Issuer { get; set; } = "SomeDefaultValueIfNeededOr";
        public string Audience { get; set; } = "IfItIsMandatoryForBuildingTheObject";
        public void AddClaims(Claim claim)
        {
            claims.Add(claim);
        }
        public DateTime? ActivationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public SigningCredentials SigningCredentials { get; set; }

        public JwtSecurityToken Build()
        {
            return new JwtSecurityToken(Issuer, Audience, claims, ActivationDate, ExpirationDate, SigningCredentials);
        }
    }
}
