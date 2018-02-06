using System;
using System.ComponentModel.DataAnnotations;

namespace Vidak.Models
{
	public class Customer
	{
		public int Id { get; set; }
		[Required]
		[StringLength(255)]
		public string Name { get; set; }
		public bool IsSubscribedToNewsletter { get; set; }
		public MembershipTypes MembershipType { get; set; }
		public byte MemberShipTypeId { get; set; }
		public DateTime? Birthday { get; set; }
	}
}