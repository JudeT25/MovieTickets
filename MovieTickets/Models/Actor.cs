﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MovieTickets.Models
{
	public class Actor
	{
		[Key]
		public int Id { get; set; }

		public string ProfilePictureURL { get; set; }
		public string FullName { get; set; }
		public string Bio { get; set; }

	}
}
