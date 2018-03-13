#region Namespace Sonata.ComponentModel.DataAnnotations
//	TODO: comment
#endregion

using System;
using System.ComponentModel.DataAnnotations;
using Sonata.Diagnostics.Logs;

namespace Sonata.ComponentModel.DataAnnotations
{
	public static class ValidationResultExtension
	{
		public static BusinessLog ToBusinessLog(this ValidationResult instance, Type source, LogLevels level = LogLevels.Error)
		{
			if (instance == null)
				throw new ArgumentNullException(nameof(instance));

			return new BusinessLog(source, level, instance.ErrorMessage);
		}

		public static TechnicalLog ToTechnicalLog(this ValidationResult instance, Type source, LogLevels level = LogLevels.Error)
		{
			if (instance == null)
				throw new ArgumentNullException(nameof(instance));

			return new TechnicalLog(source, level, instance.ErrorMessage);
		}
	}
}