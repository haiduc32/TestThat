// ****************************************************************
// License Info:
// Portions Copyright © 2002-2009 Charlie Poole or 
// Copyright © 2002-2004 James W. Newkirk, Michael C. Two,
// Alexei A. Vorontsov or Copyright © 2000-2002 Philip A. Craig 
// ****************************************************************

using System;

namespace MonkeyTest.TestThat
{
    /// <summary>
    /// The SpecialValue enum is used to represent TestCase arguments
    /// that cannot be used as arguments to an Attribute.
    /// </summary>
	public enum SpecialValue
	{
        /// <summary>
        /// Null represents a null value, which cannot be used as an 
        /// argument to an attribute under .NET 1.x
        /// </summary>
        Null
	}
}
