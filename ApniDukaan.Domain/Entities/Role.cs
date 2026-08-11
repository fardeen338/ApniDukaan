using System;
using System.Collections.Generic;
using System.Text;

namespace ApniDukaan.Domain.Entities
{
    public class Role
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
