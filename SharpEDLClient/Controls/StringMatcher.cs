// Copyright © Serge Weinstock 2014.
//
// This library is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SergeUtils
{
    /// <summary>
    /// Possible ways of matching methods
    /// </summary>
    public enum StringMatchingMethod
    {
        NoWildcards,
        UseWildcards,
        UseRegexs,
    }

    /// <summary>
    /// Allows to decompose a strings against a pattern
    /// </summary>
    public class StringMatcher
    {
#region fields
        public delegate StringMatch MatchDelegate(string source);
        private readonly object m_pattern;
#endregion
        /// <summary>
        /// Match against a string
        /// </summary>
        public MatchDelegate Match { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public StringMatcher(StringMatchingMethod method, string pattern)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#region No wildcards
        /// <summary>
        /// Prepare the pattern for a "non wildcard" match
        /// </summary>
        private static object prepareNoWildcard(string pattern)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Compare the source against the pattern and if successfull returns a StringMatch
        /// 
        /// There is a match if source contains all the characters of pattern in the right order
        /// but not consecutively
        /// </summary>
        private StringMatch buildNoWildcard(string source)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Wildcards
        /// <summary>
        /// Prepare the pattern for a "wildcard" match
        /// </summary>
        private static object prepareWithWildcards(string pattern)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Add a chunk to list of segments
        /// </summary>
        static void addChunkToStringMatch(StringMatch res, string txt, bool isMatch)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Compare the source against the pattern and if successfull returns a StringMatch
        /// 
        /// There match is done against the source which can contain the wildcard '*'
        /// </summary>
        private StringMatch buildWithWildcards(string source)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Regexs
        /// <summary>
        /// Prepare the pattern for a "regex" match
        /// </summary>
        private static object prepareRegex(string pattern)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Compare the source against the pattern and if successfull returns a StringMatch
        /// 
        /// There is a match if source contains all the characters of pattern in the right order
        /// but not consecutively
        /// </summary>
        private StringMatch buildRegex(string source)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
#endregion
    }

    /// <summary>
    /// The result of a match
    /// There are the items we store in the suggestion listbox
    /// </summary>
    public class StringMatch
    {
        /// <summary>
        /// The original source
        /// </summary>
        public string Text { get; internal set; }
        /// <summary>
        /// The source decomposed on match/non matches against the pattern
        /// </summary>
        public List<string> Segments { get; internal set; }
        /// <summary>
        /// Is the first segment a match?
        /// </summary>
        public bool StartsOnMatch { get; internal set; }
    }
}