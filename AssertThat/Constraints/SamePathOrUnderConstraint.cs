﻿// ****************************************************************
// License Info:
// Portions Copyright © 2002-2009 Charlie Poole or 
// Copyright © 2002-2004 James W. Newkirk, Michael C. Two,
// Alexei A. Vorontsov or Copyright © 2000-2002 Philip A. Craig 
// ****************************************************************

namespace MonkeyTest.TestThat.Constraints
{
    /// <summary>
    /// SamePathOrUnderConstraint tests that one path is under another
    /// </summary>
    public class SamePathOrUnderConstraint : PathConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SamePathOrUnderConstraint"/> class.
        /// </summary>
        /// <param name="expected">The expected path</param>
        public SamePathOrUnderConstraint(string expected) : base(expected) { }

        /// <summary>
        /// Test whether the constraint is satisfied by a given value
        /// </summary>
        /// <param name="expectedPath">The expected path</param>
        /// <param name="actualPath">The actual path</param>
        /// <returns>True for success, false for failure</returns>
        protected override bool IsMatch(string expectedPath, string actualPath)
        {
            string path1 = Canonicalize(expectedPath);
            string path2 = Canonicalize(actualPath);
            return string.Compare(path1, path2, caseInsensitive) == 0 || IsSubPath(path1, path2, caseInsensitive);
        }

        /// <summary>
        /// Write the constraint description to a MessageWriter
        /// </summary>
        /// <param name="writer">The writer on which the description is displayed</param>
        public override void WriteDescriptionTo(MessageWriter writer)
        {
            writer.WritePredicate("Path under or matching");
            writer.WriteExpectedValue(expectedPath);
        }
    }
}
