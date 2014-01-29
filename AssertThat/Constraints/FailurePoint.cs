// ****************************************************************
// License Info:
// Portions Copyright © 2002-2009 Charlie Poole or 
// Copyright © 2002-2004 James W. Newkirk, Michael C. Two,
// Alexei A. Vorontsov or Copyright © 2000-2002 Philip A. Craig 
// ****************************************************************

using System;
using System.Text;

namespace MonkeyTest.TestThat.Constraints
{
    /// <summary>
    /// FailurePoint class represents one point of failure
    /// in an equality test.
    /// </summary>
    public class FailurePoint
    {
        /// <summary>
        /// The location of the failure
        /// </summary>
        public int Position;

        /// <summary>
        /// The expected value
        /// </summary>
        public object ExpectedValue;

        /// <summary>
        /// The actual value
        /// </summary>
        public object ActualValue;

        /// <summary>
        /// Indicates whether the expected value is valid
        /// </summary>
        public bool ExpectedHasData;

        /// <summary>
        /// Indicates whether the actual value is valid
        /// </summary>
        public bool ActualHasData;
    }

    /// <summary>
    /// FailurePointList represents a set of FailurePoints
    /// in a cross-platform way.
    /// </summary>
#if CLR_2_0 || CLR_4_0
    class FailurePointList : System.Collections.Generic.List<FailurePoint> { }
#else
    class FailurePointList : System.Collections.ArrayList { }
#endif

}
