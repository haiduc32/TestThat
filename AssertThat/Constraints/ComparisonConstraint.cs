// ****************************************************************
// License Info:
// Portions Copyright � 2002-2009 Charlie Poole or 
// Copyright � 2002-2004 James W. Newkirk, Michael C. Two,
// Alexei A. Vorontsov or Copyright � 2000-2002 Philip A. Craig 
// ****************************************************************

using System;
using System.Collections;
#if CLR_2_0 || CLR_4_0
using System.Collections.Generic;
#endif

namespace MonkeyTest.TestThat.Constraints
{
    /// <summary>
    /// Abstract base class for constraints that compare values to
    /// determine if one is greater than, equal to or less than
    /// the other. This class supplies the Using modifiers.
    /// </summary>
    public abstract class ComparisonConstraint : Constraint
    {
        /// <summary>
        /// ComparisonAdapter to be used in making the comparison
        /// </summary>
        protected ComparisonAdapter comparer = ComparisonAdapter.Default;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ComparisonConstraint"/> class.
        /// </summary>
        public ComparisonConstraint(object arg) : base(arg) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ComparisonConstraint"/> class.
        /// </summary>
        public ComparisonConstraint(object arg1, object arg2) : base(arg1, arg2) { }

        /// <summary>
        /// Modifies the constraint to use an IComparer and returns self
        /// </summary>
        public ComparisonConstraint Using(IComparer comparer)
        {
            this.comparer = ComparisonAdapter.For(comparer);
            return this;
        }

#if CLR_2_0 || CLR_4_0
        /// <summary>
        /// Modifies the constraint to use an IComparer&lt;T&gt; and returns self
        /// </summary>
        public ComparisonConstraint Using<T>(IComparer<T> comparer)
        {
            this.comparer = ComparisonAdapter.For(comparer);
            return this;
        }

        /// <summary>
        /// Modifies the constraint to use a Comparison&lt;T&gt; and returns self
        /// </summary>
        public ComparisonConstraint Using<T>(Comparison<T> comparer)
        {
            this.comparer = ComparisonAdapter.For(comparer);
            return this;
        }
#endif
    }
}
