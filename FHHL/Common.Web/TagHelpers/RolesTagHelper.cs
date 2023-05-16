using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Web.TagHelpers
{
    public class RolesTagHelper
    {
        [HtmlTargetElement(Attributes = "roles")]
        public class RoleTagHelper : TagHelper
        {
            private string _Roles = "";
            public string Roles
            {
                get
                {
                    return _Roles;
                }
                set
                {
                    _Roles = value;
                    roleList = _Roles.Split(',').Select(r => r.Trim()).ToList();
                }
            }

            private List<string> roleList;

            private IHttpContextAccessor httpContextAccessor;

            public RoleTagHelper(IHttpContextAccessor httpContextAccessor)
            {
                this.httpContextAccessor = httpContextAccessor;
                roleList = new List<string>();
            }

            public override void Process(TagHelperContext context, TagHelperOutput output)
            {
                var user = httpContextAccessor.HttpContext.User;
                foreach (var s in roleList)
                {
                    if (user.IsInRole(s))
                    {
                        return;
                    }
                }
                output.SuppressOutput();
            }

        }
    }
}
