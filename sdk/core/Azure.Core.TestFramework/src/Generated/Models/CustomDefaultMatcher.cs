// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Core.TestFramework.Models
{
    /// <summary> The CustomDefaultMatcher. </summary>
    public partial class CustomDefaultMatcher
    {
        /// <summary> Initializes a new instance of CustomDefaultMatcher. </summary>
        /// <param name="nonDefaultHeaderExclusions"></param>
        /// <param name="compareBodies"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="nonDefaultHeaderExclusions"/> is null. </exception>
        public CustomDefaultMatcher(string nonDefaultHeaderExclusions, bool compareBodies)
        {
            if (nonDefaultHeaderExclusions == null)
            {
                throw new ArgumentNullException(nameof(nonDefaultHeaderExclusions));
            }

            NonDefaultHeaderExclusions = nonDefaultHeaderExclusions;
            CompareBodies = compareBodies;
        }

        /// <summary> Gets the non default header exclusions. </summary>
        public string NonDefaultHeaderExclusions { get; }
        /// <summary> Gets the compare bodies. </summary>
        public bool CompareBodies { get; }
    }
}
