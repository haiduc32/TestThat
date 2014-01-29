// ****************************************************************
// License Info:
// Portions Copyright © 2002-2009 Charlie Poole or 
// Copyright © 2002-2004 James W. Newkirk, Michael C. Two,
// Alexei A. Vorontsov or Copyright © 2000-2002 Philip A. Craig 
// ****************************************************************

namespace MonkeyTest.TestThat.Constraints.Operators
{
    /// <summary>
    /// Abstract base for operators that indicate how to
    /// apply a constraint to items in a collection.
    /// </summary>
    public abstract class CollectionOperator : PrefixOperator
    {
        /// <summary>
        /// Constructs a CollectionOperator
        /// </summary>
        protected CollectionOperator()
        {
            // Collection Operators stack on everything
            // and allow all other ops to stack on them
            this.left_precedence = 1;
            this.right_precedence = 10;
        }
    }
}
