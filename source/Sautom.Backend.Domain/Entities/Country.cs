using System;
using System.Collections.Generic;

namespace Sautom.Backend.Domain.Entities
{
    public class Country : IEntity
    {
	    public Country()
        {
            Cities = new HashSet<City>();
            EmbassyDocuments = new HashSet<EmbassyDocument>();
        }

	    public string CountryName { get; set; }

	    public virtual ICollection<City> Cities { get; }
	    public virtual ICollection<EmbassyDocument> EmbassyDocuments { get; }

	    public Guid Id { get; set; }
    }
}
