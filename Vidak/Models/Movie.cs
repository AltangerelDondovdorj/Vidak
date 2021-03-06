﻿using System;
using System.Security.AccessControl;

namespace Vidak.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public GenreTypes GenreTypes { get; set; }
		public byte GenreId { get; set; }
		public DateTime DateAdded { get; set; }
		public DateTime ReleaseDate { get; set; }
		public byte NumberInStock { get; set; }
	}
}