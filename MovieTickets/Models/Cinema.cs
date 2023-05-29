using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MovieTickets.Models
{
	public class Cinema
	{
		[Key]
		public int Id { get; set; }

		public string Logo { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}

