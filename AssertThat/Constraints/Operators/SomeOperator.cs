﻿// ****************************************************************
// License Info:
// Portions Copyright © 2002-2009 Charlie Poole or 
// Copyright © 2002-2004 James W. Newkirk, Michael C. Two,
// Alexei A. Vorontsov or Copyright © 2000-2002 Philip A. Craig 
// ****************************************************************

namespace MonkeyTest.TestThat.Constraints.Operators
{
    /// <summary>
    /// Represents a constraint that succeeds if any of the 
    /// members of a collection match a base constraint.
    /// </summary>
    public class SomeOperator : CollectionOperator
    {
        /// <summary>
        /// Returns a constraint that will apply the argument
        /// to the members of a collection, succeeding if
        /// any of them succeed.
        /// </summary>
        public override Constraint ApplyPrefix(Constraint constraint)
        {
            return new SomeItemsConstraint(constraint);
        }
    }
}
