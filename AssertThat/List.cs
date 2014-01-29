// ****************************************************************
// License Info:
// Portions Copyright © 2002-2009 Charlie Poole or 
// Copyright © 2002-2004 James W. Newkirk, Michael C. Two,
// Alexei A. Vorontsov or Copyright © 2000-2002 Philip A. Craig 
// ****************************************************************

using System;
using System.Collections;
using MonkeyTest.TestThat.Constraints;

namespace MonkeyTest.TestThat
{
	/// <summary>
	/// The List class is a helper class with properties and methods
	/// that supply a number of constraints used with lists and collections.
	/// </summary>
	public class List
	{
		/// <summary>
		/// List.Map returns a ListMapper, which can be used to map
		/// the original collection to another collection.
		/// </summary>
		/// <param name="actual"></param>
		/// <returns></returns>
		public static ListMapper Map( ICollection actual )
		{
			return new ListMapper( actual );
		}
	}
}
