using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Common.Web.Extensions
{
    public static class UserExtensions
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            return user?.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
        }

        public static string GetName(this ClaimsPrincipal user)
        {
            return user?.Claims.FirstOrDefault(c => c.Type == "name")?.Value;
        }

        public static string GetFirstName(this ClaimsPrincipal user)
        {
            return user?.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname")?.Value;
        }

        public static string GetLastName(this ClaimsPrincipal user)
        {
            return user?.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname")?.Value;
        }

        public static string GetEmail(this ClaimsPrincipal user)
        {
            return user?.FindFirst("emails")?.Value;
        }

        public static string GetGivenName(this ClaimsPrincipal user)
        {
            return user?.Claims.Where(c => c.Type == System.Security.Claims.ClaimTypes.GivenName).SingleOrDefault().Value;
        }

        public static string GetNameOrEmail(this ClaimsPrincipal user)
        {
            if (user == null)
                return "unknown";

            var name = GetName(user);
            if (!string.IsNullOrWhiteSpace(name))
                return name;

            var email = GetEmail(user);
            if (!string.IsNullOrWhiteSpace(email))
                return email;

            var id = GetUserId(user);
            if (!string.IsNullOrWhiteSpace(id))
                return id;

            return "unknown";
        }
    }
}
