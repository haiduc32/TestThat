// ****************************************************************
// License Info:
// Portions Copyright © 2002-2009 Charlie Poole or 
// Copyright © 2002-2004 James W. Newkirk, Michael C. Two,
// Alexei A. Vorontsov or Copyright © 2000-2002 Philip A. Craig 
// ****************************************************************

using System;
using System.Collections;
using System.Reflection;

namespace MonkeyTest.TestThat
{
	/// <summary>
	/// ListMapper is used to transform a collection used as an actual argument
	/// producing another collection to be used in the assertion.
	/// </summary>
	public class ListMapper
	{
		ICollection original;

		/// <summary>
		/// Construct a ListMapper based on a collection
		/// </summary>
		/// <param name="original">The collection to be transformed</param>
 		public ListMapper( ICollection original )
		{
			this.original = original;
		}

		/// <summary>
		/// Produces a collection containing all the values of a property
		/// </summary>
		/// <param name="name">The collection of property values</param>
		/// <returns></returns>
		public ICollection Property( string name )
		{
			ArrayList propList = new ArrayList();
			foreach( object item in original )
			{
				PropertyInfo property = item.GetType().GetProperty( name, 
					BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance );
				if ( property == null )
					throw new ArgumentException( string.Format(
						"{0} does not have a {1} property", item, name ) );

				propList.Add( property.GetValue( item, null ) );
			}

			return propList;
		}
	}
}
