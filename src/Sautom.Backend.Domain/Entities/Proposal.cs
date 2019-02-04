using System;
using System.Collections.Generic;

namespace Sautom.Backend.Domain.Entities
{
    public class Proposal : IEntity
    {
	    public Proposal()
        {
            AvailableIntensities = new HashSet<IntensityType>();
            AvailableHouseTypes = new HashSet<HousingType>();
        }

	    public virtual City City { get; set; }

	    public string SchoolName { get; set; }
	    public string CourseName { get; set; }

	    public virtual ICollection<IntensityType> AvailableIntensities { get; }
	    public virtual ICollection<HousingType> AvailableHouseTypes { get; }

	    public bool IsGroupType { get; set; }
	    public string CuratorName { get; set; }
	    public DateTime? StartDate { get; set; }
	    public DateTime? EndDate { get; set; }

	    public Guid Id { get; set; }
    }
}
