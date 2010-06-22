﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Ncqrs
{
    internal static class InternalExtensions
    {
        public static bool Empty(this IEnumerable target)
        {
            return (target.Cast<object>().Count() == 0);
        }

        public static bool Empty<TSource>(this IEnumerable<TSource> target)
        {
            return (target.Count() == 0);
        }

        public static bool IsNullOrEmpty(this string target)
        {
            return String.IsNullOrEmpty(target);
        }
    }
}
