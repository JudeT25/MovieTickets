using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using MovieTickets.Data;

namespace MovieTickets.Models
{
	public class Movie
	{
		[Key]
		public int id { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string CinemaName { get; set; }
		public string MovieActors { get; set; }
		public MovieCategory MovieCategory { get; set; }
		public string MovieProducer { get; set; }
		public string MovieImageUrl { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }



	}
}

