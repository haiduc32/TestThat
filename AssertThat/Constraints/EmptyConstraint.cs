// ****************************************************************
// License Info:
// Portions Copyright � 2002-2009 Charlie Poole or 
// Copyright � 2002-2004 James W. Newkirk, Michael C. Two,
// Alexei A. Vorontsov or Copyright � 2000-2002 Philip A. Craig 
// ****************************************************************

using System;

namespace MonkeyTest.TestThat.Constraints
{
	/// <summary>
	/// EmptyConstraint tests a whether a string or collection is empty,
	/// postponing the decision about which test is applied until the
	/// type of the actual argument is known.
	/// </summary>
	public class EmptyConstraint : Constraint
	{
		private Constraint RealConstraint
		{
			get 
			{
                if (actual is string)
                    return new EmptyStringConstraint();
                else if (actual is System.IO.DirectoryInfo)
                    return new EmptyDirectoryConstraint();
                else
					return new EmptyCollectionConstraint();
			}
		}
		
		/// <summary>
        /// Test whether the constraint is satisfied by a given value
        /// </summary>
        /// <param name="actual">The value to be tested</param>
        /// <returns>True for success, false for failure</returns>
		public override bool Matches(object actual)
		{
			this.actual = actual;

            if (actual == null)
                throw new ArgumentException("The actual value must be a non-null string, IEnumerable or DirectoryInfo", "actual");

			return this.RealConstraint.Matches( actual );
		}

        /// <summary>
        /// Write the constraint description to a MessageWriter
        /// </summary>
        /// <param name="writer">The writer on which the description is displayed</param>
		public override void WriteDescriptionTo(MessageWriter writer)
		{
			this.RealConstraint.WriteDescriptionTo( writer );
		}
	}
}
