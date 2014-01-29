// ****************************************************************
// License Info:
// Portions Copyright © 2002-2009 Charlie Poole or 
// Copyright © 2002-2004 James W. Newkirk, Michael C. Two,
// Alexei A. Vorontsov or Copyright © 2000-2002 Philip A. Craig 
// ****************************************************************

namespace MonkeyTest.TestThat
{
    /// <summary>
    /// The TestStatus enum indicates the result of running a test
    /// </summary>
    public enum TestStatus
    {
        /// <summary>
        /// The test was inconclusive
        /// </summary>
        Inconclusive = 0,

        /// <summary>
        /// The test has skipped 
        /// </summary>
        Skipped = 1,

        /// <summary>
        /// The test succeeded
        /// </summary>
        Passed = 2,

        /// <summary>
        /// The test failed
        /// </summary>
        Failed = 3
    }
}
