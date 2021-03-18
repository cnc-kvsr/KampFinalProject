using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Core.Extensions
{
    //Extension--> Bir class'ı genişletmek
    //Extension için class statik olmalı
    public static class ClaimExtensions
    {
        //ICollection türünde claim'i extend edicez
        public static void AddEmail(this ICollection<Claim> claims, string email)
        {
            //Operasyona yeni bir claim ekliyoruz(AddEmail)
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, email));
        }

        public static void AddName(this ICollection<Claim> claims, string name)
        {
            claims.Add(new Claim(ClaimTypes.Name, name));
        }

        public static void AddNameIdentifier(this ICollection<Claim> claims, string nameIdentifier)
        {
            claims.Add(new Claim(ClaimTypes.NameIdentifier, nameIdentifier));
        }

        public static void AddRoles(this ICollection<Claim> claims, string[] roles)
        {
            //Herbir rolü tek tek sisteme ekle.Bunun için foreach kull.
            roles.ToList().ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role)));
        }
    }
}
