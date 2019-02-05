using System;

namespace Sautom.Backend.Domain.Entities
{
    public class HousingType : IEntity
    {
	    public string HousingName { get; set; }
	    public Guid Id { get; set; }
    }
}
