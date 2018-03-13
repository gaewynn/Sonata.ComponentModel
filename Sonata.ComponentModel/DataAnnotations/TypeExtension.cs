#region Namespace Sonata.ComponentModel.DataAnnotations
//	TODO: comment
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace Sonata.ComponentModel.DataAnnotations
{
	/// <summary>
	///  Adds functionalities to the <see cref="Type"/> class.
	/// </summary>
	public static class TypeExtension
	{
		/// <summary>
		/// Gets all properties of the specified <see cref="Type"/> that do not have the <see cref="NotMappedAttribute"/>.
		/// </summary>
		/// <param name="instance">The <see cref="Type"/> in which looking for properties.</param>
		/// <returns>All properties of the specified <see cref="Type"/> that do not have the <see cref="NotMappedAttribute"/>.</returns>
		public static IEnumerable<PropertyInfo> GetMappedProperties(this Type instance)
		{
			if (instance == null)
				throw new ArgumentNullException(nameof(instance));

			return instance.GetProperties()
				.Where(p => p.GetCustomAttributes(typeof(NotMappedAttribute), false).FirstOrDefault() == null)
				.Select(p => p);
		}
	}
}
