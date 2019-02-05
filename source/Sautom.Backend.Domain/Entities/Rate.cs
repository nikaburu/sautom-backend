using System;

namespace Sautom.Backend.Domain.Entities
{
    public class Rate : IEntity
    {
	    public DateTime Date { get; set; }
	    public float RateValue { get; set; }
	    public Guid Id { get; set; }
    }
}
