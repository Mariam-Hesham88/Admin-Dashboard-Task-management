﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entites
{
	public class Admin
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MinLength(3)]
		public string UserName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[MinLength(6)]
		public string Password { get; set; }
	}
}
