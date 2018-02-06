using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidak.Models
{
	public class MembershipTypes
	{
		public byte Id { get; set; }
		[Required]
		public string Name { get; set; }
		public short SignupFee { get; set; }
		public byte DurationInMonths { get; set; }
		public byte DiscountRate { get; set; }
	}
}