using System;
using System.Collections.Generic;

namespace Sautom.Backend.Domain.Entities
{
    public class Authorization : IEntity
    {
        public Authorization()
        {
            Roles = new HashSet<Role>();
        }

	    public string Password { get; set; }

	    public virtual ICollection<Role> Roles { get; }
	    public virtual Manager Manager { get; set; }
	    public Guid Id { get; set; }
    }
}
