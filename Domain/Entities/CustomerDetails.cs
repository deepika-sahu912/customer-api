using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
	public class CustomerDetails
	{ 
		[Key]
		public int Id { get; set; }

		public string? Name { get; set; }

        public string? Address { get; set; }
    }
}

