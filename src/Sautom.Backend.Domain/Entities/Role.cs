﻿using System;

namespace Sautom.Backend.Domain.Entities
{
    public class Role : IEntity
    {
	    public string RoleName { get; set; }
	    public Guid Id { get; set; }
    }
}
