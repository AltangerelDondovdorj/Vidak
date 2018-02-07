using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidak.Models
{
	public class GenreTypes
	{
		public byte Id { get; set; }
		[MaxLength(255)]
		public string Name { get; set; }
	}
}