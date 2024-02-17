using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NFive.SDK.Server.Storage
{
	public class EntityValidationException : Exception
	{
		public IEnumerable<ValidationResult> ValidationErrors { get; set; }

		public EntityValidationException(string message, IEnumerable<ValidationResult> validationErrors) : base(message)
		{
			ValidationErrors = validationErrors;
		}
	}
}
