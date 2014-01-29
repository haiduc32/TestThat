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
    /// TypeConstraint is the abstract base for constraints
    /// that take a Type as their expected value.
    /// </summary>
    public abstract class TypeConstraint : Constraint
    {
        /// <summary>
        /// The expected Type used by the constraint
        /// </summary>
        protected readonly Type expectedType;

        /// <summary>
        /// Construct a TypeConstraint for a given Type
        /// </summary>
        /// <param name="type"></param>
        protected TypeConstraint(Type type) : base(type)
        {
            this.expectedType = type;
        }

        /// <summary>
        /// Write the actual value for a failing constraint test to a
        /// MessageWriter. TypeConstraints override this method to write
        /// the name of the type.
        /// </summary>
        /// <param name="writer">The writer on which the actual value is displayed</param>
		public override void WriteActualValueTo(MessageWriter writer)
		{
			writer.WriteActualValue( actual == null ? null : actual.GetType() ); 
		}
	}
}
