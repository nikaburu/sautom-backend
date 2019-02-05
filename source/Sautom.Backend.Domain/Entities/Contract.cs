using System;

namespace Sautom.Backend.Domain.Entities
{
    public class Contract : IEntity
    {
	    #region Consulting
	    public string ConsultingNumber { get; set; }
	    public DateTime? ConsultingDate { get; set; }
	    public float ConsultingHours { get; set; }
	    public float ConsultingSum { get; set; }
	    public DateTime? ConsultingActDate { get; set; }
	    public virtual Rate ConsultingRate { get; set; }
		#endregion

	    #region Workshop
	    public string WorkshopNumber { get; set; }
	    public DateTime? WorkshopDate { get; set; }
	    public float WorkshopHours { get; set; }
	    public float WorkshopSum { get; set; }
	    public DateTime? WorkshopActDate { get; set; }
	    public virtual Rate WorkshopRate { get; set; }
		#endregion

	    #region Invoice
	    public DateTime? InvoiceDate { get; set; }
	    public int InvoiceSum { get; set; }
		#endregion

	    public virtual Order Order { get; set; }
	    public Guid Id { get; set; }
    }
}
